using UnityEngine;

public class CrouchStep : TutorialStep
{
    public override string Message => "Appuyez sur la touche \nCtrl\npour vous accroupir";

    public override bool IsStepDone()
    {
        return Input.GetKey("w") && Input.GetKey(KeyCode.LeftControl);
    }
}
