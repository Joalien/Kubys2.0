using System;
using UnityEngine;

public class DropElementStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \n" + _spellLetter + "\npour lacher votre élément principal.\n Vous pourrez ensuite le récupérer en marchant dessus";
    private string _spellLetter = "x";
    private PlayerElements _playerElements;


    public override void ActivateStep()
    {
        _playerElements = GameObject.Find("MyPlayer").GetComponent<PlayerElements>();
    }

    public override bool IsStepDone()
    {
        return _playerElements.secondaryElement == _playerElements.defaultEmptyElement;
    }
}
