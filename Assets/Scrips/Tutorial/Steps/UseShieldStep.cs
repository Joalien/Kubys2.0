using System;
using UnityEngine;

public class UseShieldStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \n" + _spellLetter + "\n" +
                                      "pour vous défendre avec un bouclier magique\n" +
                                      "Attention toutefois, garder votre bouclier actif trop longtemps vous coûtera du mana";
    private string _spellLetter = "b";
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
