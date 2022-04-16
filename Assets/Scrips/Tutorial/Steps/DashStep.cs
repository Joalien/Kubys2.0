using System;
using UnityEngine;

public class DashStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \n" + _spellLetter + "\npour bondir dans une direction";
    private string _spellLetter = "e";


    public override void ActivateStep()
    {
        // _spellLetter = GameObject.Find("MyPlayer").GetComponent<CastSpell>().spellLetter;
    }

    public override bool IsStepDone()
    {
        return Input.GetKeyUp(_spellLetter);
    }
}
