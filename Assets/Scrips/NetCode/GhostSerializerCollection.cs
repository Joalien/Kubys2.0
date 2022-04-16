using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Networking.Transport;
using Unity.NetCode;

public struct PlayerGhostSerializerCollection : IGhostSerializerCollection
{
#if UNITY_EDITOR || DEVELOPMENT_BUILD
    public string[] CreateSerializerNameList()
    {
        var arr = new string[]
        {
            "ThirdPersonControllerGhostSerializer",
        };
        return arr;
    }

    public int Length => 1;
#endif
    public static int FindGhostType<T>()
        where T : struct, ISnapshotData<T>
    {
        if (typeof(T) == typeof(ThirdPersonControllerSnapshotData))
            return 0;
        return -1;
    }

    public void BeginSerialize(ComponentSystemBase system)
    {
        m_ThirdPersonControllerGhostSerializer.BeginSerialize(system);
    }

    public int CalculateImportance(int serializer, ArchetypeChunk chunk)
    {
        switch (serializer)
        {
            case 0:
                return m_ThirdPersonControllerGhostSerializer.CalculateImportance(chunk);
        }

        throw new ArgumentException("Invalid serializer type");
    }

    public int GetSnapshotSize(int serializer)
    {
        switch (serializer)
        {
            case 0:
                return m_ThirdPersonControllerGhostSerializer.SnapshotSize;
        }

        throw new ArgumentException("Invalid serializer type");
    }

    public int Serialize(ref DataStreamWriter dataStream, SerializeData data)
    {
        switch (data.ghostType)
        {
            case 0:
            {
                return GhostSendSystem<PlayerGhostSerializerCollection>.InvokeSerialize<ThirdPersonControllerGhostSerializer, ThirdPersonControllerSnapshotData>(m_ThirdPersonControllerGhostSerializer, ref dataStream, data);
            }
            default:
                throw new ArgumentException("Invalid serializer type");
        }
    }
    private ThirdPersonControllerGhostSerializer m_ThirdPersonControllerGhostSerializer;
}

public struct EnablePlayerGhostSendSystemComponent : IComponentData
{}
public class PlayerGhostSendSystem : GhostSendSystem<PlayerGhostSerializerCollection>
{
    protected override void OnCreate()
    {
        base.OnCreate();
        RequireSingletonForUpdate<EnablePlayerGhostSendSystemComponent>();
    }

    public override bool IsEnabled()
    {
        return HasSingleton<EnablePlayerGhostSendSystemComponent>();
    }
}
