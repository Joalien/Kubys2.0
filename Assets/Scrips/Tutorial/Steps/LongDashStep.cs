using UnityEngine;

public class LongDashStep : TutorialStep
{
    public override string Message => "Restez appuyé sur la touche \n" + _spellLetter + "\npour bondir encore plus loin";
    private GameObject _ePanel;
    private string _spellLetter = "e";


    public override void ActivateStep()
    {
        // _spellLetter = GameObject.Find("MyPlayer").GetComponent<CastSpell>().spellLetter;
        _ePanel = GameObject.Find("EPanel");
    }

    public override bool IsStepDone()
    {
        return Input.GetKeyUp(_spellLetter)
               && _ePanel.GetComponent<CastSpell>().GetCurrentMultiplier() == 2;
    }
}
