using System;

public class HealthPotion : CatchableObject
{
    public int healthAmount = 200;
    
    protected override void ExecuteBehaviour(PlayerCharacteristics player)
    {
        const double tolerance = 1;
        if (Math.Abs(player.CurrentHealth - player.totalHealth) > tolerance)
        {
            player.AddHealth(healthAmount);
            Destroy(gameObject);
        }
    }
}
