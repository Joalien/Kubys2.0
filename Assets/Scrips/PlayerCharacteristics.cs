using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCharacteristics : MonoBehaviour
{
    public new string name;
    public int totalHealth;
    public int totalMana;
    public int totalShield;

    public float healthRegen = 1.1f;
    public float manaRegen = 2.2f;
    public float shieldRegen = 5f;

    [HideInInspector] public UnityEvent healthUpdate;
    [HideInInspector] public UnityEvent manaUpdate;
    [HideInInspector] public UnityEvent shieldUpdate;

    [HideInInspector] public UnityEvent kdaUpdate;

    [HideInInspector] public UnityEvent deathOfPlayer;

    [HideInInspector]
    public Vector3 startingPosition = new Vector3(-75, 11, -40);

    private void Awake()
    {
        kdaUpdate = new UnityEvent();
        healthUpdate = new UnityEvent();
        shieldUpdate = new UnityEvent();
        manaUpdate = new UnityEvent();
        deathOfPlayer = new UnityEvent();
    }

    public int Kill
    {
        get => _kill;
        set
        {
            _kill = value;
            kdaUpdate.Invoke();
        }
    }

    public int Death
    {
        get => _death;
        set
        {
            _death = value;
            kdaUpdate.Invoke();
        }
    }

    public int Assist
    {
        get => _assist;
        set
        {
            _assist = value;
            kdaUpdate.Invoke();
        }
    }

    private int _kill, _death, _assist;

    public float CurrentHealth
    {
        get => currentHealth;
        set
        {
            currentHealth = value;
            healthUpdate.Invoke();
        }
    }

    public float CurrentMana {
        get => currentMana;
        set
        {
            currentMana = value;
            manaUpdate.Invoke();
        }}

    public float CurrentShield {
        get => currentShield;
        set
        {
            currentShield = value;
            shieldUpdate.Invoke();
        }}

    [SerializeField] private float currentHealth, currentMana, currentShield;
    private MonoBehaviour[] _monoBehaviours;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _monoBehaviours = gameObject.GetComponents<MonoBehaviour>();
        AddHealth(totalHealth);
        AddMana(totalMana);
        AddShield(totalShield);

        startingPosition = transform.position;

        InvokeRepeating(nameof(NaturalRegen), 1f, 1f);
    }

    public void DecreaseMana(float amount)
    {
        AddMana(-amount);
    }

    public void AddMana(float amount)
    {
        CurrentMana = Mathf.Clamp(CurrentMana + amount, 0, totalMana);
        manaUpdate.Invoke();
    }

    public void DecreaseShield(float amount)
    {
        AddShield(-amount);
    }

    public void AddShield(float amount)
    {
        CurrentShield = Mathf.Clamp(CurrentShield + amount, 0, totalShield);
        shieldUpdate.Invoke();
    }

    public void DecreaseHealth(float amount)
    {
        AddHealth(-amount);
    }

    public void AddHealth(float amount)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, totalHealth);
        healthUpdate.Invoke();

        if (CurrentHealth <= 0)
        {
           StartCoroutine(KillPlayer());
        }
    }

    private IEnumerator KillPlayer()
    {
        deathOfPlayer.Invoke();
        _monoBehaviours.ToList().ForEach(behaviour =>  behaviour.enabled = false);
        _rigidbody.isKinematic = true;
        _rigidbody.velocity = Vector3.zero;
        Death++;
        
        yield return new WaitForSeconds(5);
        
        gameObject.transform.position = startingPosition;
        _monoBehaviours.ToList().ForEach(behaviour =>  behaviour.enabled = true);
        _rigidbody.isKinematic = false;
        AddHealth(totalHealth);
        AddMana(totalMana);
        AddShield(totalShield);
    }

    private void NaturalRegen()
    {
        AddMana(manaRegen);
        AddShield(shieldRegen);
        AddHealth(healthRegen);
    }
}
