public class ElementScript : CatchableObject
{
    public Element element;

    protected override void ExecuteBehaviour(PlayerCharacteristics player)
    {
        if (player.GetComponent<PlayerElements>().AddElement(element))
        {
            Destroy(gameObject);
        }
    }
}