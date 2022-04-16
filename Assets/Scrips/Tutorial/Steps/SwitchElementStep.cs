using System;
using UnityEngine;

public class SwitchElementStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \n" + _spellLetter + "\npour intervertir l'élément principal et le secondaire";
    private string _spellLetter = "c";
    private PlayerElements _playerElements;
    private Element _mainElement;
    private Element _secondaryElement;


    public override void ActivateStep()
    {
        _playerElements = GameObject.Find("MyPlayer").GetComponent<PlayerElements>();
        _mainElement = _playerElements.mainElement;
        _secondaryElement = _playerElements.secondaryElement;
    }

    public override bool IsStepDone()
    {
        return _playerElements.mainElement == _secondaryElement && _playerElements.secondaryElement == _mainElement;
    }
}
