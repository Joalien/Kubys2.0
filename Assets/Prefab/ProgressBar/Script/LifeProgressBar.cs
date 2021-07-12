using UnityEngine;

[ExecuteInEditMode]
public class LifeProgressBar : ProgressBar
{
    private void Start()
    {
        Maximum = playerCharacteristics.totalHealth;
        playerCharacteristics.healthUpdate.AddListener(Call);
        playerCharacteristics.healthUpdate.Invoke();
    }

    protected override void Call()
    {
        Current = playerCharacteristics.CurrentHealth;
    }

    protected override Color GetBarColor()
    {
        return Color.red;
    }

    protected override string GetTitle()
    {
        return "Life";
    }
}
