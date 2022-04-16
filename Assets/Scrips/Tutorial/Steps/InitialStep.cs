using UnityEngine;

public class InitialStep : TutorialStep
{
    public override string Message => "Utilisez les touches\nZ/Q/S/D\npour vous déplacer";

    public override bool IsStepDone()
    {
        return Input.GetKey("z")
               || Input.GetKey("q")
               || Input.GetKey("s")
               || Input.GetKey("d");
    }
}
