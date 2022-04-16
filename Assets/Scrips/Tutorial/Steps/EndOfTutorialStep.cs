using UnityEngine;

public class EndOfTutorialStep : TutorialStep
{
    private float _nextStepTimer;
    public float timeBeforeNextStep = 5;

    public override void ActivateStep()
    {
        _nextStepTimer = Time.time + timeBeforeNextStep;
    }

    public override string Message => "Bravo !\nvous êtes arrivé à la fin de ce tutoriel\nvous êtes libre désormais";

    public override bool IsStepDone()
    {
        return Time.time > _nextStepTimer;
    }
}
