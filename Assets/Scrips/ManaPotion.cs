using System;

public class ManaPotion : CatchableObject
{
    public int manaAmount = 100;

    protected override void ExecuteBehaviour(PlayerCharacteristics player)
    {
        const double tolerance = 1;
        if (Math.Abs(player.CurrentMana - player.totalMana) > tolerance)
        {
            player.AddMana(manaAmount);
            Destroy(gameObject);
        }
    }
}
