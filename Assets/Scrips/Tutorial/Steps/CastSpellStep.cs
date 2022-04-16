using System;
using UnityEngine;

public class CastSpellStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \n" + _spellLetter + "\npour lancer une puissante attaque";
    private string _spellLetter = "r";
    private GameObject _spellIcon; // TODO highlight me

    public override void ActivateStep()
    {
        // _spellLetter = GameObject.Find("MyPlayer").GetComponent<CastSpell>().spellLetter;
    }

    public override bool IsStepDone()
    {
        return Input.GetKey(_spellLetter);
    }
}
