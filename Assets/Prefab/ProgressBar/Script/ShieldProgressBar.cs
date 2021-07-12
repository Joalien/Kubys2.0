using UnityEngine;

[ExecuteInEditMode]
public class ShieldProgressBar : ProgressBar
{
    private void Start()
    {
        Maximum = playerCharacteristics.totalShield;
        playerCharacteristics.shieldUpdate.AddListener(Call);
        playerCharacteristics.shieldUpdate.Invoke();
    }

    protected override void Call()
    {
        Current = playerCharacteristics.CurrentShield;
    }

    protected override Color GetBarColor()
    {
        return Color.black;
    }

    protected override string GetTitle()
    {
        return "Shield";
    }
}
