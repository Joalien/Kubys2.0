using UnityEngine;

public class CongratulationStep : TutorialStep
{
    private float _nextStepTimer;
    public float timeBeforeNextStep = 3;

    public override void ActivateStep()
    {
        _nextStepTimer = Time.time + timeBeforeNextStep;
    }

    public override string Message => "Bravo !\nVous maitrisez les mouvements de base \nNous allons pouvoir passer aux sorts";

    public override bool IsStepDone()
    {
        return Time.time > _nextStepTimer;
    }
}
