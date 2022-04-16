using Unity.Entities;
using Unity.NetCode;

[GenerateAuthoringComponent]
public struct MovablePlayer : IComponentData
{
    [GhostDefaultField]
    public int PlayerId;
}
