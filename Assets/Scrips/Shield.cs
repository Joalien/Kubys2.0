using UnityEngine;

public class Shield : MonoBehaviour
{
    public string shieldLetter = "b";
    public int shieldCost = 50;
    private PlayerCharacteristics _playerCharacteristics;
    private GameObject _shield;

    private void Start()
    {
        _playerCharacteristics = GetComponent<PlayerCharacteristics>();
    }

    // Update is called once per frame
    private void Update()
    {
        var currentShieldCost = Time.deltaTime * shieldCost;
        if (Input.GetKey(shieldLetter) && _playerCharacteristics.CurrentShield > currentShieldCost)
        {
            if (_shield == null) _shield = Instantiate(GetComponent<PlayerElements>().mainElement.shield);
            _shield.transform.position = transform.position;
            _playerCharacteristics.DecreaseShield(currentShieldCost);
        } else if (_shield != null)
        {
            Destroy(_shield);
        }

        if (Input.GetKeyUp(shieldLetter)) Destroy(_shield);
    }

    public bool IsProtected()
    {
        return _shield != null;
    }
}
