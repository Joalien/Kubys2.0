using UnityEngine;

[ExecuteInEditMode]
public class ManaProgressBar : ProgressBar
{
    private void Start()
    {
        Maximum = playerCharacteristics.totalMana;
        playerCharacteristics.manaUpdate.AddListener(Call);
        playerCharacteristics.manaUpdate.Invoke();
    }

    protected override void Call()
    {
        Current = playerCharacteristics.CurrentMana;
    }

    protected override Color GetBarColor()
    {
        return Color.blue;
    }

    protected override string GetTitle()
    {
        return "Mana";
    }
}
