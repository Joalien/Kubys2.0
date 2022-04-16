using UnityEngine;

public class TakeTheHealStep : TutorialStep
{
    private GameObject _player;
    private GameObject _lifeCross;

    public override string Message => "Pour retrouver la totalité de votre vie, \navancer jusqu'à la croix";

    public override void ActivateStep()
    {
        _player = GameObject.Find("MyPlayer");

        PlayerCharacteristics playerCharacteristics = _player.GetComponent<PlayerCharacteristics>();
        playerCharacteristics.CurrentHealth = (float) (playerCharacteristics.totalHealth * 0.8);
        if (_lifeCross != null) Destroy(_lifeCross);
        _lifeCross = Instantiate(Resources.Load<GameObject>("Life Cross"), new Vector3(56, 2, -74), Quaternion.identity);
    }

    public override bool IsStepDone()
    {
        return _lifeCross == null;
    }
}
