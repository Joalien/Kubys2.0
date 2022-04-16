using UnityEngine;
using UnityEngine.UI;

public class ProcessElements : MonoBehaviour
{
    public string switchElementLetter = "c";
    public string dropElementLetter = "x";

    private GameObject _player;
    private PlayerElements _playerElements;

    private RawImage _mainElementImage;
    private RawImage _secondaryElementImage;
 
    private void Awake()
    {
        _player = GameObject.Find("MyPlayer");
        _playerElements = _player.GetComponent<PlayerElements>();
        
        _mainElementImage = transform.Find("MainElementImage").GetComponent<RawImage>();
        _secondaryElementImage = transform.Find("SecondaryElementImage").GetComponent<RawImage>();
    }

    private void Start()
    {
        _player.GetComponent<PlayerElements>().updateMainElement.AddListener(AssignMainElement);
        _player.GetComponent<PlayerElements>().updateSecondaryElement.AddListener(AssignSecondaryElement);
    }

    private void Update()
    {
        if (Input.GetKeyDown(switchElementLetter))
        {
            _playerElements.SwitchElement();
        }
        
        if (Input.GetKeyDown(dropElementLetter))
        {
            _playerElements.DropMainElement();
        }
    }


    private void AssignMainElement()
    {
        _mainElementImage.texture = _playerElements.mainElement.icon;
    }
    
    private void AssignSecondaryElement()
    {
        _secondaryElementImage.texture = _playerElements.secondaryElement.icon;
    }
}
