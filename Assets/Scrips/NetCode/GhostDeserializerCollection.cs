using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Networking.Transport;
using Unity.NetCode;

public struct PlayerGhostDeserializerCollection : IGhostDeserializerCollection
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
    public void Initialize(World world)
    {
        var curThirdPersonControllerGhostSpawnSystem = world.GetOrCreateSystem<ThirdPersonControllerGhostSpawnSystem>();
        m_ThirdPersonControllerSnapshotDataNewGhostIds = curThirdPersonControllerGhostSpawnSystem.NewGhostIds;
        m_ThirdPersonControllerSnapshotDataNewGhosts = curThirdPersonControllerGhostSpawnSystem.NewGhosts;
        curThirdPersonControllerGhostSpawnSystem.GhostType = 0;
    }

    public void BeginDeserialize(JobComponentSystem system)
    {
        m_ThirdPersonControllerSnapshotDataFromEntity = system.GetBufferFromEntity<ThirdPersonControllerSnapshotData>();
    }
    public bool Deserialize(int serializer, Entity entity, uint snapshot, uint baseline, uint baseline2, uint baseline3,
        ref DataStreamReader reader, NetworkCompressionModel compressionModel)
    {
        switch (serializer)
        {
            case 0:
                return GhostReceiveSystem<PlayerGhostDeserializerCollection>.InvokeDeserialize(m_ThirdPersonControllerSnapshotDataFromEntity, entity, snapshot, baseline, baseline2,
                baseline3, ref reader, compressionModel);
            default:
                throw new ArgumentException("Invalid serializer type");
        }
    }
    public void Spawn(int serializer, int ghostId, uint snapshot, ref DataStreamReader reader,
        NetworkCompressionModel compressionModel)
    {
        switch (serializer)
        {
            case 0:
                m_ThirdPersonControllerSnapshotDataNewGhostIds.Add(ghostId);
                m_ThirdPersonControllerSnapshotDataNewGhosts.Add(GhostReceiveSystem<PlayerGhostDeserializerCollection>.InvokeSpawn<ThirdPersonControllerSnapshotData>(snapshot, ref reader, compressionModel));
                break;
            default:
                throw new ArgumentException("Invalid serializer type");
        }
    }

    private BufferFromEntity<ThirdPersonControllerSnapshotData> m_ThirdPersonControllerSnapshotDataFromEntity;
    private NativeList<int> m_ThirdPersonControllerSnapshotDataNewGhostIds;
    private NativeList<ThirdPersonControllerSnapshotData> m_ThirdPersonControllerSnapshotDataNewGhosts;
}
public struct EnablePlayerGhostReceiveSystemComponent : IComponentData
{}
public class PlayerGhostReceiveSystem : GhostReceiveSystem<PlayerGhostDeserializerCollection>
{
    protected override void OnCreate()
    {
        base.OnCreate();
        RequireSingletonForUpdate<EnablePlayerGhostReceiveSystemComponent>();
    }
}
