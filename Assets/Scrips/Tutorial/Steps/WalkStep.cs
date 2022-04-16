using UnityEngine;

public class WalkStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \nMAJ\npour marcher";

    public override bool IsStepDone()
    {
        return Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift);
    }
}
