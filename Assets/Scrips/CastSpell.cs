using System;
using System.Collections;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.Characters.ThirdPerson;

public class CastSpell : MonoBehaviour
{
    // TODO Stop using a static Spell, get one from API
    public Spell spell;
    public string spellLetter;

    private PlayerCharacteristics _playerCharacteristics;
    private float _nextFire = 0;
    private ThirdPersonCharacter _mCharacter; // A reference to the ThirdPersonCharacter on the object
    private Vector3 _castPosition;
    private Camera _mainCamera;
    private ProgressBarCircle _cooldownProgressBar;
    private ProgressBarCircle _chargeProgressBar;

    private GameObject _myPlayer;
    private GameObject _spellPrevizualizationEnd;
    private GameObject _spellPrevizualizationBeam;
    private GameObject _spellPrevizualizationStart;
    private LineRenderer _line;
    private GameObject _spellAnimation;
    private ThirdPersonCharacter _thirdPersonCharacter;
    private float _currentMultiplier;
    private UnityEvent _resetDefaultCursor;

    private void Start()
    {
        _myPlayer = GameObject.Find("MyPlayer");
        _thirdPersonCharacter = _myPlayer.GetComponent<ThirdPersonCharacter>();
        _mCharacter = _myPlayer.GetComponent<ThirdPersonCharacter>();
        _playerCharacteristics = _myPlayer.GetComponent<PlayerCharacteristics>();
        spell.previsualizationShape.transform.localScale = Vector3.one * spell.areaOfEffect;
        _mainCamera = Camera.main;
        try
        {
            _cooldownProgressBar = GetComponentsInChildren<ProgressBarCircle>()[0];
            _chargeProgressBar = GetComponentsInChildren<ProgressBarCircle>()[1];
            _chargeProgressBar.BarValue = 100;
        }
        catch (IndexOutOfRangeException)
        {
        }

        _resetDefaultCursor = FindObjectOfType<CursorScript>().resetCursor;
    }

    void Update()
    {
        if (Time.time < _nextFire)
        {
            _cooldownProgressBar.BarValue = 100 * (Time.time - (_nextFire - spell.cooldown)) / spell.cooldown;
            return;
        }

        if (_cooldownProgressBar.BarValue < 100)
        {
            _cooldownProgressBar.BarValue = 100;
        }

        if (spell.manaCost > _playerCharacteristics.CurrentMana) return;

        if (Input.GetKey(spellLetter))
        {
            // Cursor.SetCursor(spell.cursorShape, Vector2.zero, CursorMode.Auto);
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = _mainCamera.ScreenPointToRay(mouse);

            if (_spellPrevizualizationEnd == null)
            {
                _spellPrevizualizationEnd = Instantiate(_myPlayer.GetComponent<PlayerElements>().mainElement.shield);
                _spellPrevizualizationBeam = Instantiate(_myPlayer.GetComponent<PlayerElements>().mainElement.beam);
                _spellPrevizualizationStart = Instantiate(_myPlayer.GetComponent<PlayerElements>().mainElement.beamStart);
                _line = _spellPrevizualizationBeam.GetComponent<LineRenderer>();
            }

            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit))
            {
                _castPosition = hit.point;
                _spellPrevizualizationEnd.GetComponent<Renderer>().sharedMaterial.SetFloat("_FresnelWidth", 10);
            }
            else
            {
                _castPosition = castPoint.GetPoint(spell.range);
                _spellPrevizualizationEnd.GetComponent<Renderer>().sharedMaterial.SetFloat("_FresnelWidth", 1);
            }

            if (spell.hasCharge)
            {
                _chargeProgressBar.BarValue -= 100 * Time.deltaTime / spell.chargeTime;
            }

            _spellPrevizualizationEnd.transform.position = _castPosition;
            Vector3 playerPos = _mCharacter.transform.position;
            playerPos.y += 1;

            _line.useWorldSpace = true;
            _line.SetPosition(0, playerPos);
            _line.SetPosition(1, _castPosition);

            _spellPrevizualizationStart.transform.position = playerPos;
            _spellPrevizualizationStart.transform.LookAt(_castPosition);

            float distance = Vector3.Distance(playerPos, _castPosition);
            // _line.material.mainTextureScale = new Vector2(distance/3f, 1); //This sets the scale of the texture so it doesn't look stretched
            _line.material.mainTextureOffset -= new Vector2(Time.deltaTime * 1f, 0); //This scrolls the texture along the beam if not set to 0

        }

        if (Input.GetKeyUp(spellLetter))
        {
            _resetDefaultCursor.Invoke();
            _currentMultiplier = GetCurrentMultiplier(); // [0; 1]
            if (_chargeProgressBar != null) _chargeProgressBar.BarValue = 100;
            Vector3 playerPos = _mCharacter.transform.position;
            playerPos.y += 1;

            Destroy(_spellPrevizualizationEnd);
            Destroy(_spellPrevizualizationBeam);
            Destroy(_spellPrevizualizationStart);
            _nextFire = Time.time + spell.cooldown;

            Run(_playerCharacteristics, playerPos, _castPosition);

            _playerCharacteristics.DecreaseMana(spell.manaCost);
        }
    }

    private void Run (PlayerCharacteristics playerCharacteristics, Vector3 from, Vector3 to)
    {
        // spell.caster = playerCharacteristics;

        if (spell.hasMovement)
        {
            Rigidbody rb = _myPlayer.GetComponent<Rigidbody>();
            Vector3 currentVelocity = rb.velocity;
            rb.AddForce(Quaternion.LookRotation(to - from, Vector3.up) * Vector3.forward * (spell.dashForce * _currentMultiplier), ForceMode.Impulse);
            _thirdPersonCharacter.isDashing = true;
            StartCoroutine(RestoreVelocityAfterTime(spell.dashTime, rb, currentVelocity));
        }

        if (spell.hasAnimation)
        {
            GameObject missile =
                Instantiate(playerCharacteristics.GetComponent<PlayerElements>().mainElement.missile);
            try
            {
                missile.GetComponent<MagicProjectileScript>().caster = playerCharacteristics;
                Debug.Log("Player " + playerCharacteristics.name + " fires !");
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
            missile.transform.rotation = Quaternion.LookRotation(to - from, Vector3.up);
            missile.transform.position = from + missile.transform.forward * 2;
            missile.GetComponent<Rigidbody>()
                .AddForce(missile.transform.forward * (spell.initialForce * _currentMultiplier));
            Destroy(missile, spell.timeBeforeDestroy);
        }
    }

    private IEnumerator RestoreVelocityAfterTime(float seconds, Rigidbody rb, Vector3 oldVelocity)
    {
        yield return new WaitForSeconds(seconds);
        rb.velocity = oldVelocity;
        _thirdPersonCharacter.isDashing = false;
    }

    public float GetCurrentMultiplier()
    {
        return _chargeProgressBar != null ? 1 + (100 - _chargeProgressBar.BarValue) / 100 * spell.overhead : 1; // [0; 1]
    }
}
