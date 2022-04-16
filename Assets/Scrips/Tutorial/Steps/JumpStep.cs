using UnityEngine;

public class JumpStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \nESPACE\npour sauter";

    public override bool IsStepDone()
    {
        return Input.GetKey(KeyCode.Space);
    }
}
