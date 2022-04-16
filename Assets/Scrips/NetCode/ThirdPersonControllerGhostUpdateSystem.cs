using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Networking.Transport.Utilities;
using Unity.NetCode;
using Unity.Entities;
using Unity.Transforms;

[UpdateInGroup(typeof(GhostUpdateSystemGroup))]
public class ThirdPersonControllerGhostUpdateSystem : JobComponentSystem
{
    [BurstCompile]
    struct UpdateInterpolatedJob : IJobChunk
    {
        [ReadOnly] public NativeHashMap<int, GhostEntity> GhostMap;
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        [NativeDisableContainerSafetyRestriction] public NativeArray<uint> minMaxSnapshotTick;
#pragma warning disable 649
        [NativeSetThreadIndex]
        public int ThreadIndex;
#pragma warning restore 649
#endif
        [ReadOnly] public ArchetypeChunkBufferType<ThirdPersonControllerSnapshotData> ghostSnapshotDataType;
        [ReadOnly] public ArchetypeChunkEntityType ghostEntityType;
        public ArchetypeChunkComponentType<MovablePlayer> ghostMovablePlayerType;
        [ReadOnly] public ArchetypeChunkBufferType<LinkedEntityGroup> ghostLinkedEntityGroupType;
        [NativeDisableParallelForRestriction] public ComponentDataFromEntity<Rotation> ghostRotationFromEntity;
        [NativeDisableParallelForRestriction] public ComponentDataFromEntity<Translation> ghostTranslationFromEntity;

        public uint targetTick;
        public float targetTickFraction;
        public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
        {
            var deserializerState = new GhostDeserializerState
            {
                GhostMap = GhostMap
            };
            var ghostEntityArray = chunk.GetNativeArray(ghostEntityType);
            var ghostSnapshotDataArray = chunk.GetBufferAccessor(ghostSnapshotDataType);
            var ghostMovablePlayerArray = chunk.GetNativeArray(ghostMovablePlayerType);
            var ghostLinkedEntityGroupArray = chunk.GetBufferAccessor(ghostLinkedEntityGroupType);
#if UNITY_EDITOR || DEVELOPMENT_BUILD
            var minMaxOffset = ThreadIndex * (JobsUtility.CacheLineSize/4);
#endif
            for (int entityIndex = 0; entityIndex < ghostEntityArray.Length; ++entityIndex)
            {
                var snapshot = ghostSnapshotDataArray[entityIndex];
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                var latestTick = snapshot.GetLatestTick();
                if (latestTick != 0)
                {
                    if (minMaxSnapshotTick[minMaxOffset] == 0 || SequenceHelpers.IsNewer(minMaxSnapshotTick[minMaxOffset], latestTick))
                        minMaxSnapshotTick[minMaxOffset] = latestTick;
                    if (minMaxSnapshotTick[minMaxOffset + 1] == 0 || SequenceHelpers.IsNewer(latestTick, minMaxSnapshotTick[minMaxOffset + 1]))
                        minMaxSnapshotTick[minMaxOffset + 1] = latestTick;
                }
#endif
                // If there is no data found don't apply anything (would be default state), required for prespawned ghosts
                ThirdPersonControllerSnapshotData snapshotData;
                if (!snapshot.GetDataAtTick(targetTick, targetTickFraction, out snapshotData))
                    return;

                var ghostMovablePlayer = ghostMovablePlayerArray[entityIndex];
                var ghostRotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value];
                var ghostTranslation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value];
                var ghostChild0Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value];
                var ghostChild0Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value];
                var ghostChild1Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value];
                var ghostChild1Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value];
                var ghostChild2Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value];
                var ghostChild2Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value];
                var ghostChild3Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value];
                var ghostChild3Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value];
                var ghostChild4Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value];
                var ghostChild4Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value];
                var ghostChild5Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value];
                var ghostChild5Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value];
                var ghostChild6Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value];
                var ghostChild6Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value];
                var ghostChild7Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value];
                var ghostChild7Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value];
                var ghostChild8Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value];
                var ghostChild8Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value];
                var ghostChild9Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value];
                var ghostChild9Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value];
                var ghostChild10Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value];
                var ghostChild10Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value];
                var ghostChild11Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value];
                var ghostChild11Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value];
                var ghostChild12Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value];
                var ghostChild12Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value];
                var ghostChild13Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value];
                var ghostChild13Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value];
                var ghostChild14Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value];
                var ghostChild14Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value];
                var ghostChild15Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value];
                var ghostChild15Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value];
                var ghostChild16Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value];
                var ghostChild16Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value];
                var ghostChild17Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value];
                var ghostChild17Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value];
                var ghostChild18Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value];
                var ghostChild18Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value];
                var ghostChild19Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value];
                var ghostChild19Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value];
                var ghostChild20Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value];
                var ghostChild20Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value];
                var ghostChild21Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value];
                var ghostChild21Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value];
                var ghostChild22Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value];
                var ghostChild22Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value];
                var ghostChild23Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value];
                var ghostChild23Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value];
                var ghostChild24Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value];
                var ghostChild24Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value];
                var ghostChild25Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value];
                var ghostChild25Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value];
                var ghostChild26Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value];
                var ghostChild26Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value];
                var ghostChild27Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value];
                var ghostChild27Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value];
                var ghostChild28Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value];
                var ghostChild28Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value];
                var ghostChild29Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value];
                var ghostChild29Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value];
                var ghostChild30Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value];
                var ghostChild30Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value];
                var ghostChild31Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value];
                var ghostChild31Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value];
                var ghostChild32Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value];
                var ghostChild32Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value];
                var ghostChild33Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value];
                var ghostChild33Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value];
                var ghostChild34Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value];
                var ghostChild34Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value];
                var ghostChild35Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value];
                var ghostChild35Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value];
                var ghostChild36Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value];
                var ghostChild36Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value];
                var ghostChild37Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value];
                var ghostChild37Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value];
                var ghostChild38Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value];
                var ghostChild38Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value];
                var ghostChild39Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value];
                var ghostChild39Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value];
                var ghostChild40Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value];
                var ghostChild40Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value];
                var ghostChild41Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value];
                var ghostChild41Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value];
                var ghostChild42Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value];
                var ghostChild42Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value];
                var ghostChild43Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value];
                var ghostChild43Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value];
                var ghostChild44Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value];
                var ghostChild44Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value];
                var ghostChild45Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value];
                var ghostChild45Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value];
                var ghostChild46Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value];
                var ghostChild46Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value];
                var ghostChild47Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value];
                var ghostChild47Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value];
                var ghostChild48Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value];
                var ghostChild48Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value];
                var ghostChild49Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value];
                var ghostChild49Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value];
                var ghostChild50Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value];
                var ghostChild50Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value];
                var ghostChild51Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value];
                var ghostChild51Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value];
                var ghostChild52Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value];
                var ghostChild52Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value];
                var ghostChild53Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value];
                var ghostChild53Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value];
                var ghostChild54Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value];
                var ghostChild54Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value];
                var ghostChild55Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value];
                var ghostChild55Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value];
                var ghostChild56Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value];
                var ghostChild56Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value];
                var ghostChild57Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value];
                var ghostChild57Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value];
                var ghostChild58Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value];
                var ghostChild58Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value];
                var ghostChild59Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value];
                var ghostChild59Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value];
                var ghostChild60Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value];
                var ghostChild60Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value];
                var ghostChild61Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value];
                var ghostChild61Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value];
                var ghostChild62Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value];
                var ghostChild62Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value];
                var ghostChild63Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value];
                var ghostChild63Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value];
                var ghostChild64Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value];
                var ghostChild64Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value];
                var ghostChild65Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value];
                var ghostChild65Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value];
                var ghostChild66Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value];
                var ghostChild66Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value];
                var ghostChild67Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value];
                var ghostChild67Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value];
                var ghostChild68Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value];
                var ghostChild68Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value];
                var ghostChild69Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value];
                var ghostChild69Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value];
                var ghostChild70Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value];
                var ghostChild70Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value];
                var ghostChild71Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value];
                var ghostChild71Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value];
                var ghostChild72Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value];
                var ghostChild72Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value];
                var ghostChild73Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value];
                var ghostChild73Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value];
                var ghostChild74Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value];
                var ghostChild74Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value];
                var ghostChild75Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value];
                var ghostChild75Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value];
                var ghostChild76Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value];
                var ghostChild76Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value];
                var ghostChild77Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value];
                var ghostChild77Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value];
                var ghostChild78Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value];
                var ghostChild78Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value];
                var ghostChild79Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value];
                var ghostChild79Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value];
                var ghostChild80Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value];
                var ghostChild80Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value];
                var ghostChild81Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value];
                var ghostChild81Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value];
                var ghostChild82Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value];
                var ghostChild82Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value];
                var ghostChild83Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value];
                var ghostChild83Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value];
                var ghostChild84Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value];
                var ghostChild84Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value];
                var ghostChild85Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value];
                var ghostChild85Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value];
                var ghostChild86Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value];
                var ghostChild86Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value];
                ghostMovablePlayer.PlayerId = snapshotData.GetMovablePlayerPlayerId(deserializerState);
                ghostRotation.Value = snapshotData.GetRotationValue(deserializerState);
                ghostTranslation.Value = snapshotData.GetTranslationValue(deserializerState);
                ghostChild0Rotation.Value = snapshotData.GetChild0RotationValue(deserializerState);
                ghostChild0Translation.Value = snapshotData.GetChild0TranslationValue(deserializerState);
                ghostChild1Rotation.Value = snapshotData.GetChild1RotationValue(deserializerState);
                ghostChild1Translation.Value = snapshotData.GetChild1TranslationValue(deserializerState);
                ghostChild2Rotation.Value = snapshotData.GetChild2RotationValue(deserializerState);
                ghostChild2Translation.Value = snapshotData.GetChild2TranslationValue(deserializerState);
                ghostChild3Rotation.Value = snapshotData.GetChild3RotationValue(deserializerState);
                ghostChild3Translation.Value = snapshotData.GetChild3TranslationValue(deserializerState);
                ghostChild4Rotation.Value = snapshotData.GetChild4RotationValue(deserializerState);
                ghostChild4Translation.Value = snapshotData.GetChild4TranslationValue(deserializerState);
                ghostChild5Rotation.Value = snapshotData.GetChild5RotationValue(deserializerState);
                ghostChild5Translation.Value = snapshotData.GetChild5TranslationValue(deserializerState);
                ghostChild6Rotation.Value = snapshotData.GetChild6RotationValue(deserializerState);
                ghostChild6Translation.Value = snapshotData.GetChild6TranslationValue(deserializerState);
                ghostChild7Rotation.Value = snapshotData.GetChild7RotationValue(deserializerState);
                ghostChild7Translation.Value = snapshotData.GetChild7TranslationValue(deserializerState);
                ghostChild8Rotation.Value = snapshotData.GetChild8RotationValue(deserializerState);
                ghostChild8Translation.Value = snapshotData.GetChild8TranslationValue(deserializerState);
                ghostChild9Rotation.Value = snapshotData.GetChild9RotationValue(deserializerState);
                ghostChild9Translation.Value = snapshotData.GetChild9TranslationValue(deserializerState);
                ghostChild10Rotation.Value = snapshotData.GetChild10RotationValue(deserializerState);
                ghostChild10Translation.Value = snapshotData.GetChild10TranslationValue(deserializerState);
                ghostChild11Rotation.Value = snapshotData.GetChild11RotationValue(deserializerState);
                ghostChild11Translation.Value = snapshotData.GetChild11TranslationValue(deserializerState);
                ghostChild12Rotation.Value = snapshotData.GetChild12RotationValue(deserializerState);
                ghostChild12Translation.Value = snapshotData.GetChild12TranslationValue(deserializerState);
                ghostChild13Rotation.Value = snapshotData.GetChild13RotationValue(deserializerState);
                ghostChild13Translation.Value = snapshotData.GetChild13TranslationValue(deserializerState);
                ghostChild14Rotation.Value = snapshotData.GetChild14RotationValue(deserializerState);
                ghostChild14Translation.Value = snapshotData.GetChild14TranslationValue(deserializerState);
                ghostChild15Rotation.Value = snapshotData.GetChild15RotationValue(deserializerState);
                ghostChild15Translation.Value = snapshotData.GetChild15TranslationValue(deserializerState);
                ghostChild16Rotation.Value = snapshotData.GetChild16RotationValue(deserializerState);
                ghostChild16Translation.Value = snapshotData.GetChild16TranslationValue(deserializerState);
                ghostChild17Rotation.Value = snapshotData.GetChild17RotationValue(deserializerState);
                ghostChild17Translation.Value = snapshotData.GetChild17TranslationValue(deserializerState);
                ghostChild18Rotation.Value = snapshotData.GetChild18RotationValue(deserializerState);
                ghostChild18Translation.Value = snapshotData.GetChild18TranslationValue(deserializerState);
                ghostChild19Rotation.Value = snapshotData.GetChild19RotationValue(deserializerState);
                ghostChild19Translation.Value = snapshotData.GetChild19TranslationValue(deserializerState);
                ghostChild20Rotation.Value = snapshotData.GetChild20RotationValue(deserializerState);
                ghostChild20Translation.Value = snapshotData.GetChild20TranslationValue(deserializerState);
                ghostChild21Rotation.Value = snapshotData.GetChild21RotationValue(deserializerState);
                ghostChild21Translation.Value = snapshotData.GetChild21TranslationValue(deserializerState);
                ghostChild22Rotation.Value = snapshotData.GetChild22RotationValue(deserializerState);
                ghostChild22Translation.Value = snapshotData.GetChild22TranslationValue(deserializerState);
                ghostChild23Rotation.Value = snapshotData.GetChild23RotationValue(deserializerState);
                ghostChild23Translation.Value = snapshotData.GetChild23TranslationValue(deserializerState);
                ghostChild24Rotation.Value = snapshotData.GetChild24RotationValue(deserializerState);
                ghostChild24Translation.Value = snapshotData.GetChild24TranslationValue(deserializerState);
                ghostChild25Rotation.Value = snapshotData.GetChild25RotationValue(deserializerState);
                ghostChild25Translation.Value = snapshotData.GetChild25TranslationValue(deserializerState);
                ghostChild26Rotation.Value = snapshotData.GetChild26RotationValue(deserializerState);
                ghostChild26Translation.Value = snapshotData.GetChild26TranslationValue(deserializerState);
                ghostChild27Rotation.Value = snapshotData.GetChild27RotationValue(deserializerState);
                ghostChild27Translation.Value = snapshotData.GetChild27TranslationValue(deserializerState);
                ghostChild28Rotation.Value = snapshotData.GetChild28RotationValue(deserializerState);
                ghostChild28Translation.Value = snapshotData.GetChild28TranslationValue(deserializerState);
                ghostChild29Rotation.Value = snapshotData.GetChild29RotationValue(deserializerState);
                ghostChild29Translation.Value = snapshotData.GetChild29TranslationValue(deserializerState);
                ghostChild30Rotation.Value = snapshotData.GetChild30RotationValue(deserializerState);
                ghostChild30Translation.Value = snapshotData.GetChild30TranslationValue(deserializerState);
                ghostChild31Rotation.Value = snapshotData.GetChild31RotationValue(deserializerState);
                ghostChild31Translation.Value = snapshotData.GetChild31TranslationValue(deserializerState);
                ghostChild32Rotation.Value = snapshotData.GetChild32RotationValue(deserializerState);
                ghostChild32Translation.Value = snapshotData.GetChild32TranslationValue(deserializerState);
                ghostChild33Rotation.Value = snapshotData.GetChild33RotationValue(deserializerState);
                ghostChild33Translation.Value = snapshotData.GetChild33TranslationValue(deserializerState);
                ghostChild34Rotation.Value = snapshotData.GetChild34RotationValue(deserializerState);
                ghostChild34Translation.Value = snapshotData.GetChild34TranslationValue(deserializerState);
                ghostChild35Rotation.Value = snapshotData.GetChild35RotationValue(deserializerState);
                ghostChild35Translation.Value = snapshotData.GetChild35TranslationValue(deserializerState);
                ghostChild36Rotation.Value = snapshotData.GetChild36RotationValue(deserializerState);
                ghostChild36Translation.Value = snapshotData.GetChild36TranslationValue(deserializerState);
                ghostChild37Rotation.Value = snapshotData.GetChild37RotationValue(deserializerState);
                ghostChild37Translation.Value = snapshotData.GetChild37TranslationValue(deserializerState);
                ghostChild38Rotation.Value = snapshotData.GetChild38RotationValue(deserializerState);
                ghostChild38Translation.Value = snapshotData.GetChild38TranslationValue(deserializerState);
                ghostChild39Rotation.Value = snapshotData.GetChild39RotationValue(deserializerState);
                ghostChild39Translation.Value = snapshotData.GetChild39TranslationValue(deserializerState);
                ghostChild40Rotation.Value = snapshotData.GetChild40RotationValue(deserializerState);
                ghostChild40Translation.Value = snapshotData.GetChild40TranslationValue(deserializerState);
                ghostChild41Rotation.Value = snapshotData.GetChild41RotationValue(deserializerState);
                ghostChild41Translation.Value = snapshotData.GetChild41TranslationValue(deserializerState);
                ghostChild42Rotation.Value = snapshotData.GetChild42RotationValue(deserializerState);
                ghostChild42Translation.Value = snapshotData.GetChild42TranslationValue(deserializerState);
                ghostChild43Rotation.Value = snapshotData.GetChild43RotationValue(deserializerState);
                ghostChild43Translation.Value = snapshotData.GetChild43TranslationValue(deserializerState);
                ghostChild44Rotation.Value = snapshotData.GetChild44RotationValue(deserializerState);
                ghostChild44Translation.Value = snapshotData.GetChild44TranslationValue(deserializerState);
                ghostChild45Rotation.Value = snapshotData.GetChild45RotationValue(deserializerState);
                ghostChild45Translation.Value = snapshotData.GetChild45TranslationValue(deserializerState);
                ghostChild46Rotation.Value = snapshotData.GetChild46RotationValue(deserializerState);
                ghostChild46Translation.Value = snapshotData.GetChild46TranslationValue(deserializerState);
                ghostChild47Rotation.Value = snapshotData.GetChild47RotationValue(deserializerState);
                ghostChild47Translation.Value = snapshotData.GetChild47TranslationValue(deserializerState);
                ghostChild48Rotation.Value = snapshotData.GetChild48RotationValue(deserializerState);
                ghostChild48Translation.Value = snapshotData.GetChild48TranslationValue(deserializerState);
                ghostChild49Rotation.Value = snapshotData.GetChild49RotationValue(deserializerState);
                ghostChild49Translation.Value = snapshotData.GetChild49TranslationValue(deserializerState);
                ghostChild50Rotation.Value = snapshotData.GetChild50RotationValue(deserializerState);
                ghostChild50Translation.Value = snapshotData.GetChild50TranslationValue(deserializerState);
                ghostChild51Rotation.Value = snapshotData.GetChild51RotationValue(deserializerState);
                ghostChild51Translation.Value = snapshotData.GetChild51TranslationValue(deserializerState);
                ghostChild52Rotation.Value = snapshotData.GetChild52RotationValue(deserializerState);
                ghostChild52Translation.Value = snapshotData.GetChild52TranslationValue(deserializerState);
                ghostChild53Rotation.Value = snapshotData.GetChild53RotationValue(deserializerState);
                ghostChild53Translation.Value = snapshotData.GetChild53TranslationValue(deserializerState);
                ghostChild54Rotation.Value = snapshotData.GetChild54RotationValue(deserializerState);
                ghostChild54Translation.Value = snapshotData.GetChild54TranslationValue(deserializerState);
                ghostChild55Rotation.Value = snapshotData.GetChild55RotationValue(deserializerState);
                ghostChild55Translation.Value = snapshotData.GetChild55TranslationValue(deserializerState);
                ghostChild56Rotation.Value = snapshotData.GetChild56RotationValue(deserializerState);
                ghostChild56Translation.Value = snapshotData.GetChild56TranslationValue(deserializerState);
                ghostChild57Rotation.Value = snapshotData.GetChild57RotationValue(deserializerState);
                ghostChild57Translation.Value = snapshotData.GetChild57TranslationValue(deserializerState);
                ghostChild58Rotation.Value = snapshotData.GetChild58RotationValue(deserializerState);
                ghostChild58Translation.Value = snapshotData.GetChild58TranslationValue(deserializerState);
                ghostChild59Rotation.Value = snapshotData.GetChild59RotationValue(deserializerState);
                ghostChild59Translation.Value = snapshotData.GetChild59TranslationValue(deserializerState);
                ghostChild60Rotation.Value = snapshotData.GetChild60RotationValue(deserializerState);
                ghostChild60Translation.Value = snapshotData.GetChild60TranslationValue(deserializerState);
                ghostChild61Rotation.Value = snapshotData.GetChild61RotationValue(deserializerState);
                ghostChild61Translation.Value = snapshotData.GetChild61TranslationValue(deserializerState);
                ghostChild62Rotation.Value = snapshotData.GetChild62RotationValue(deserializerState);
                ghostChild62Translation.Value = snapshotData.GetChild62TranslationValue(deserializerState);
                ghostChild63Rotation.Value = snapshotData.GetChild63RotationValue(deserializerState);
                ghostChild63Translation.Value = snapshotData.GetChild63TranslationValue(deserializerState);
                ghostChild64Rotation.Value = snapshotData.GetChild64RotationValue(deserializerState);
                ghostChild64Translation.Value = snapshotData.GetChild64TranslationValue(deserializerState);
                ghostChild65Rotation.Value = snapshotData.GetChild65RotationValue(deserializerState);
                ghostChild65Translation.Value = snapshotData.GetChild65TranslationValue(deserializerState);
                ghostChild66Rotation.Value = snapshotData.GetChild66RotationValue(deserializerState);
                ghostChild66Translation.Value = snapshotData.GetChild66TranslationValue(deserializerState);
                ghostChild67Rotation.Value = snapshotData.GetChild67RotationValue(deserializerState);
                ghostChild67Translation.Value = snapshotData.GetChild67TranslationValue(deserializerState);
                ghostChild68Rotation.Value = snapshotData.GetChild68RotationValue(deserializerState);
                ghostChild68Translation.Value = snapshotData.GetChild68TranslationValue(deserializerState);
                ghostChild69Rotation.Value = snapshotData.GetChild69RotationValue(deserializerState);
                ghostChild69Translation.Value = snapshotData.GetChild69TranslationValue(deserializerState);
                ghostChild70Rotation.Value = snapshotData.GetChild70RotationValue(deserializerState);
                ghostChild70Translation.Value = snapshotData.GetChild70TranslationValue(deserializerState);
                ghostChild71Rotation.Value = snapshotData.GetChild71RotationValue(deserializerState);
                ghostChild71Translation.Value = snapshotData.GetChild71TranslationValue(deserializerState);
                ghostChild72Rotation.Value = snapshotData.GetChild72RotationValue(deserializerState);
                ghostChild72Translation.Value = snapshotData.GetChild72TranslationValue(deserializerState);
                ghostChild73Rotation.Value = snapshotData.GetChild73RotationValue(deserializerState);
                ghostChild73Translation.Value = snapshotData.GetChild73TranslationValue(deserializerState);
                ghostChild74Rotation.Value = snapshotData.GetChild74RotationValue(deserializerState);
                ghostChild74Translation.Value = snapshotData.GetChild74TranslationValue(deserializerState);
                ghostChild75Rotation.Value = snapshotData.GetChild75RotationValue(deserializerState);
                ghostChild75Translation.Value = snapshotData.GetChild75TranslationValue(deserializerState);
                ghostChild76Rotation.Value = snapshotData.GetChild76RotationValue(deserializerState);
                ghostChild76Translation.Value = snapshotData.GetChild76TranslationValue(deserializerState);
                ghostChild77Rotation.Value = snapshotData.GetChild77RotationValue(deserializerState);
                ghostChild77Translation.Value = snapshotData.GetChild77TranslationValue(deserializerState);
                ghostChild78Rotation.Value = snapshotData.GetChild78RotationValue(deserializerState);
                ghostChild78Translation.Value = snapshotData.GetChild78TranslationValue(deserializerState);
                ghostChild79Rotation.Value = snapshotData.GetChild79RotationValue(deserializerState);
                ghostChild79Translation.Value = snapshotData.GetChild79TranslationValue(deserializerState);
                ghostChild80Rotation.Value = snapshotData.GetChild80RotationValue(deserializerState);
                ghostChild80Translation.Value = snapshotData.GetChild80TranslationValue(deserializerState);
                ghostChild81Rotation.Value = snapshotData.GetChild81RotationValue(deserializerState);
                ghostChild81Translation.Value = snapshotData.GetChild81TranslationValue(deserializerState);
                ghostChild82Rotation.Value = snapshotData.GetChild82RotationValue(deserializerState);
                ghostChild82Translation.Value = snapshotData.GetChild82TranslationValue(deserializerState);
                ghostChild83Rotation.Value = snapshotData.GetChild83RotationValue(deserializerState);
                ghostChild83Translation.Value = snapshotData.GetChild83TranslationValue(deserializerState);
                ghostChild84Rotation.Value = snapshotData.GetChild84RotationValue(deserializerState);
                ghostChild84Translation.Value = snapshotData.GetChild84TranslationValue(deserializerState);
                ghostChild85Rotation.Value = snapshotData.GetChild85RotationValue(deserializerState);
                ghostChild85Translation.Value = snapshotData.GetChild85TranslationValue(deserializerState);
                ghostChild86Rotation.Value = snapshotData.GetChild86RotationValue(deserializerState);
                ghostChild86Translation.Value = snapshotData.GetChild86TranslationValue(deserializerState);
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value] = ghostRotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value] = ghostTranslation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value] = ghostChild0Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value] = ghostChild0Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value] = ghostChild1Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value] = ghostChild1Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value] = ghostChild2Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value] = ghostChild2Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value] = ghostChild3Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value] = ghostChild3Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value] = ghostChild4Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value] = ghostChild4Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value] = ghostChild5Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value] = ghostChild5Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value] = ghostChild6Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value] = ghostChild6Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value] = ghostChild7Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value] = ghostChild7Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value] = ghostChild8Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value] = ghostChild8Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value] = ghostChild9Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value] = ghostChild9Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value] = ghostChild10Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value] = ghostChild10Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value] = ghostChild11Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value] = ghostChild11Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value] = ghostChild12Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value] = ghostChild12Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value] = ghostChild13Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value] = ghostChild13Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value] = ghostChild14Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value] = ghostChild14Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value] = ghostChild15Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value] = ghostChild15Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value] = ghostChild16Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value] = ghostChild16Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value] = ghostChild17Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value] = ghostChild17Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value] = ghostChild18Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value] = ghostChild18Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value] = ghostChild19Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value] = ghostChild19Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value] = ghostChild20Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value] = ghostChild20Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value] = ghostChild21Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value] = ghostChild21Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value] = ghostChild22Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value] = ghostChild22Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value] = ghostChild23Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value] = ghostChild23Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value] = ghostChild24Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value] = ghostChild24Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value] = ghostChild25Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value] = ghostChild25Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value] = ghostChild26Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value] = ghostChild26Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value] = ghostChild27Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value] = ghostChild27Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value] = ghostChild28Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value] = ghostChild28Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value] = ghostChild29Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value] = ghostChild29Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value] = ghostChild30Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value] = ghostChild30Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value] = ghostChild31Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value] = ghostChild31Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value] = ghostChild32Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value] = ghostChild32Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value] = ghostChild33Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value] = ghostChild33Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value] = ghostChild34Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value] = ghostChild34Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value] = ghostChild35Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value] = ghostChild35Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value] = ghostChild36Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value] = ghostChild36Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value] = ghostChild37Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value] = ghostChild37Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value] = ghostChild38Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value] = ghostChild38Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value] = ghostChild39Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value] = ghostChild39Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value] = ghostChild40Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value] = ghostChild40Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value] = ghostChild41Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value] = ghostChild41Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value] = ghostChild42Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value] = ghostChild42Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value] = ghostChild43Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value] = ghostChild43Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value] = ghostChild44Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value] = ghostChild44Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value] = ghostChild45Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value] = ghostChild45Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value] = ghostChild46Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value] = ghostChild46Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value] = ghostChild47Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value] = ghostChild47Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value] = ghostChild48Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value] = ghostChild48Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value] = ghostChild49Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value] = ghostChild49Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value] = ghostChild50Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value] = ghostChild50Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value] = ghostChild51Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value] = ghostChild51Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value] = ghostChild52Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value] = ghostChild52Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value] = ghostChild53Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value] = ghostChild53Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value] = ghostChild54Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value] = ghostChild54Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value] = ghostChild55Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value] = ghostChild55Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value] = ghostChild56Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value] = ghostChild56Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value] = ghostChild57Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value] = ghostChild57Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value] = ghostChild58Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value] = ghostChild58Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value] = ghostChild59Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value] = ghostChild59Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value] = ghostChild60Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value] = ghostChild60Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value] = ghostChild61Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value] = ghostChild61Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value] = ghostChild62Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value] = ghostChild62Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value] = ghostChild63Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value] = ghostChild63Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value] = ghostChild64Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value] = ghostChild64Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value] = ghostChild65Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value] = ghostChild65Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value] = ghostChild66Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value] = ghostChild66Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value] = ghostChild67Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value] = ghostChild67Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value] = ghostChild68Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value] = ghostChild68Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value] = ghostChild69Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value] = ghostChild69Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value] = ghostChild70Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value] = ghostChild70Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value] = ghostChild71Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value] = ghostChild71Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value] = ghostChild72Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value] = ghostChild72Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value] = ghostChild73Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value] = ghostChild73Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value] = ghostChild74Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value] = ghostChild74Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value] = ghostChild75Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value] = ghostChild75Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value] = ghostChild76Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value] = ghostChild76Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value] = ghostChild77Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value] = ghostChild77Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value] = ghostChild78Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value] = ghostChild78Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value] = ghostChild79Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value] = ghostChild79Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value] = ghostChild80Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value] = ghostChild80Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value] = ghostChild81Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value] = ghostChild81Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value] = ghostChild82Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value] = ghostChild82Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value] = ghostChild83Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value] = ghostChild83Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value] = ghostChild84Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value] = ghostChild84Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value] = ghostChild85Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value] = ghostChild85Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value] = ghostChild86Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value] = ghostChild86Translation;
                ghostMovablePlayerArray[entityIndex] = ghostMovablePlayer;
            }
        }
    }
    [BurstCompile]
    struct UpdatePredictedJob : IJobChunk
    {
        [ReadOnly] public NativeHashMap<int, GhostEntity> GhostMap;
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        [NativeDisableContainerSafetyRestriction] public NativeArray<uint> minMaxSnapshotTick;
#endif
#pragma warning disable 649
        [NativeSetThreadIndex]
        public int ThreadIndex;
#pragma warning restore 649
        [NativeDisableParallelForRestriction] public NativeArray<uint> minPredictedTick;
        [ReadOnly] public ArchetypeChunkBufferType<ThirdPersonControllerSnapshotData> ghostSnapshotDataType;
        [ReadOnly] public ArchetypeChunkEntityType ghostEntityType;
        public ArchetypeChunkComponentType<PredictedGhostComponent> predictedGhostComponentType;
        public ArchetypeChunkComponentType<MovablePlayer> ghostMovablePlayerType;
        [ReadOnly] public ArchetypeChunkBufferType<LinkedEntityGroup> ghostLinkedEntityGroupType;
        [NativeDisableParallelForRestriction] public ComponentDataFromEntity<Rotation> ghostRotationFromEntity;
        [NativeDisableParallelForRestriction] public ComponentDataFromEntity<Translation> ghostTranslationFromEntity;
        public uint targetTick;
        public uint lastPredictedTick;
        public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
        {
            var deserializerState = new GhostDeserializerState
            {
                GhostMap = GhostMap
            };
            var ghostEntityArray = chunk.GetNativeArray(ghostEntityType);
            var ghostSnapshotDataArray = chunk.GetBufferAccessor(ghostSnapshotDataType);
            var predictedGhostComponentArray = chunk.GetNativeArray(predictedGhostComponentType);
            var ghostMovablePlayerArray = chunk.GetNativeArray(ghostMovablePlayerType);
            var ghostLinkedEntityGroupArray = chunk.GetBufferAccessor(ghostLinkedEntityGroupType);
#if UNITY_EDITOR || DEVELOPMENT_BUILD
            var minMaxOffset = ThreadIndex * (JobsUtility.CacheLineSize/4);
#endif
            for (int entityIndex = 0; entityIndex < ghostEntityArray.Length; ++entityIndex)
            {
                var snapshot = ghostSnapshotDataArray[entityIndex];
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                var latestTick = snapshot.GetLatestTick();
                if (latestTick != 0)
                {
                    if (minMaxSnapshotTick[minMaxOffset] == 0 || SequenceHelpers.IsNewer(minMaxSnapshotTick[minMaxOffset], latestTick))
                        minMaxSnapshotTick[minMaxOffset] = latestTick;
                    if (minMaxSnapshotTick[minMaxOffset + 1] == 0 || SequenceHelpers.IsNewer(latestTick, minMaxSnapshotTick[minMaxOffset + 1]))
                        minMaxSnapshotTick[minMaxOffset + 1] = latestTick;
                }
#endif
                ThirdPersonControllerSnapshotData snapshotData;
                snapshot.GetDataAtTick(targetTick, out snapshotData);

                var predictedData = predictedGhostComponentArray[entityIndex];
                var lastPredictedTickInst = lastPredictedTick;
                if (lastPredictedTickInst == 0 || predictedData.AppliedTick != snapshotData.Tick)
                    lastPredictedTickInst = snapshotData.Tick;
                else if (!SequenceHelpers.IsNewer(lastPredictedTickInst, snapshotData.Tick))
                    lastPredictedTickInst = snapshotData.Tick;
                if (minPredictedTick[ThreadIndex] == 0 || SequenceHelpers.IsNewer(minPredictedTick[ThreadIndex], lastPredictedTickInst))
                    minPredictedTick[ThreadIndex] = lastPredictedTickInst;
                predictedGhostComponentArray[entityIndex] = new PredictedGhostComponent{AppliedTick = snapshotData.Tick, PredictionStartTick = lastPredictedTickInst};
                if (lastPredictedTickInst != snapshotData.Tick)
                    continue;

                var ghostMovablePlayer = ghostMovablePlayerArray[entityIndex];
                var ghostRotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value];
                var ghostTranslation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value];
                var ghostChild0Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value];
                var ghostChild0Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value];
                var ghostChild1Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value];
                var ghostChild1Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value];
                var ghostChild2Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value];
                var ghostChild2Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value];
                var ghostChild3Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value];
                var ghostChild3Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value];
                var ghostChild4Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value];
                var ghostChild4Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value];
                var ghostChild5Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value];
                var ghostChild5Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value];
                var ghostChild6Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value];
                var ghostChild6Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value];
                var ghostChild7Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value];
                var ghostChild7Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value];
                var ghostChild8Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value];
                var ghostChild8Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value];
                var ghostChild9Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value];
                var ghostChild9Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value];
                var ghostChild10Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value];
                var ghostChild10Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value];
                var ghostChild11Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value];
                var ghostChild11Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value];
                var ghostChild12Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value];
                var ghostChild12Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value];
                var ghostChild13Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value];
                var ghostChild13Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value];
                var ghostChild14Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value];
                var ghostChild14Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value];
                var ghostChild15Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value];
                var ghostChild15Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value];
                var ghostChild16Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value];
                var ghostChild16Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value];
                var ghostChild17Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value];
                var ghostChild17Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value];
                var ghostChild18Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value];
                var ghostChild18Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value];
                var ghostChild19Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value];
                var ghostChild19Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value];
                var ghostChild20Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value];
                var ghostChild20Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value];
                var ghostChild21Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value];
                var ghostChild21Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value];
                var ghostChild22Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value];
                var ghostChild22Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value];
                var ghostChild23Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value];
                var ghostChild23Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value];
                var ghostChild24Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value];
                var ghostChild24Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value];
                var ghostChild25Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value];
                var ghostChild25Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value];
                var ghostChild26Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value];
                var ghostChild26Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value];
                var ghostChild27Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value];
                var ghostChild27Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value];
                var ghostChild28Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value];
                var ghostChild28Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value];
                var ghostChild29Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value];
                var ghostChild29Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value];
                var ghostChild30Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value];
                var ghostChild30Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value];
                var ghostChild31Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value];
                var ghostChild31Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value];
                var ghostChild32Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value];
                var ghostChild32Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value];
                var ghostChild33Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value];
                var ghostChild33Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value];
                var ghostChild34Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value];
                var ghostChild34Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value];
                var ghostChild35Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value];
                var ghostChild35Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value];
                var ghostChild36Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value];
                var ghostChild36Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value];
                var ghostChild37Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value];
                var ghostChild37Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value];
                var ghostChild38Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value];
                var ghostChild38Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value];
                var ghostChild39Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value];
                var ghostChild39Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value];
                var ghostChild40Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value];
                var ghostChild40Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value];
                var ghostChild41Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value];
                var ghostChild41Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value];
                var ghostChild42Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value];
                var ghostChild42Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value];
                var ghostChild43Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value];
                var ghostChild43Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value];
                var ghostChild44Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value];
                var ghostChild44Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value];
                var ghostChild45Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value];
                var ghostChild45Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value];
                var ghostChild46Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value];
                var ghostChild46Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value];
                var ghostChild47Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value];
                var ghostChild47Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value];
                var ghostChild48Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value];
                var ghostChild48Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value];
                var ghostChild49Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value];
                var ghostChild49Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value];
                var ghostChild50Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value];
                var ghostChild50Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value];
                var ghostChild51Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value];
                var ghostChild51Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value];
                var ghostChild52Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value];
                var ghostChild52Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value];
                var ghostChild53Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value];
                var ghostChild53Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value];
                var ghostChild54Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value];
                var ghostChild54Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value];
                var ghostChild55Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value];
                var ghostChild55Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value];
                var ghostChild56Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value];
                var ghostChild56Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value];
                var ghostChild57Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value];
                var ghostChild57Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value];
                var ghostChild58Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value];
                var ghostChild58Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value];
                var ghostChild59Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value];
                var ghostChild59Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value];
                var ghostChild60Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value];
                var ghostChild60Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value];
                var ghostChild61Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value];
                var ghostChild61Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value];
                var ghostChild62Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value];
                var ghostChild62Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value];
                var ghostChild63Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value];
                var ghostChild63Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value];
                var ghostChild64Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value];
                var ghostChild64Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value];
                var ghostChild65Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value];
                var ghostChild65Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value];
                var ghostChild66Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value];
                var ghostChild66Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value];
                var ghostChild67Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value];
                var ghostChild67Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value];
                var ghostChild68Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value];
                var ghostChild68Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value];
                var ghostChild69Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value];
                var ghostChild69Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value];
                var ghostChild70Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value];
                var ghostChild70Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value];
                var ghostChild71Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value];
                var ghostChild71Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value];
                var ghostChild72Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value];
                var ghostChild72Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value];
                var ghostChild73Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value];
                var ghostChild73Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value];
                var ghostChild74Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value];
                var ghostChild74Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value];
                var ghostChild75Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value];
                var ghostChild75Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value];
                var ghostChild76Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value];
                var ghostChild76Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value];
                var ghostChild77Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value];
                var ghostChild77Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value];
                var ghostChild78Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value];
                var ghostChild78Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value];
                var ghostChild79Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value];
                var ghostChild79Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value];
                var ghostChild80Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value];
                var ghostChild80Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value];
                var ghostChild81Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value];
                var ghostChild81Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value];
                var ghostChild82Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value];
                var ghostChild82Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value];
                var ghostChild83Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value];
                var ghostChild83Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value];
                var ghostChild84Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value];
                var ghostChild84Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value];
                var ghostChild85Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value];
                var ghostChild85Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value];
                var ghostChild86Rotation = ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value];
                var ghostChild86Translation = ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value];
                ghostMovablePlayer.PlayerId = snapshotData.GetMovablePlayerPlayerId(deserializerState);
                ghostRotation.Value = snapshotData.GetRotationValue(deserializerState);
                ghostTranslation.Value = snapshotData.GetTranslationValue(deserializerState);
                ghostChild0Rotation.Value = snapshotData.GetChild0RotationValue(deserializerState);
                ghostChild0Translation.Value = snapshotData.GetChild0TranslationValue(deserializerState);
                ghostChild1Rotation.Value = snapshotData.GetChild1RotationValue(deserializerState);
                ghostChild1Translation.Value = snapshotData.GetChild1TranslationValue(deserializerState);
                ghostChild2Rotation.Value = snapshotData.GetChild2RotationValue(deserializerState);
                ghostChild2Translation.Value = snapshotData.GetChild2TranslationValue(deserializerState);
                ghostChild3Rotation.Value = snapshotData.GetChild3RotationValue(deserializerState);
                ghostChild3Translation.Value = snapshotData.GetChild3TranslationValue(deserializerState);
                ghostChild4Rotation.Value = snapshotData.GetChild4RotationValue(deserializerState);
                ghostChild4Translation.Value = snapshotData.GetChild4TranslationValue(deserializerState);
                ghostChild5Rotation.Value = snapshotData.GetChild5RotationValue(deserializerState);
                ghostChild5Translation.Value = snapshotData.GetChild5TranslationValue(deserializerState);
                ghostChild6Rotation.Value = snapshotData.GetChild6RotationValue(deserializerState);
                ghostChild6Translation.Value = snapshotData.GetChild6TranslationValue(deserializerState);
                ghostChild7Rotation.Value = snapshotData.GetChild7RotationValue(deserializerState);
                ghostChild7Translation.Value = snapshotData.GetChild7TranslationValue(deserializerState);
                ghostChild8Rotation.Value = snapshotData.GetChild8RotationValue(deserializerState);
                ghostChild8Translation.Value = snapshotData.GetChild8TranslationValue(deserializerState);
                ghostChild9Rotation.Value = snapshotData.GetChild9RotationValue(deserializerState);
                ghostChild9Translation.Value = snapshotData.GetChild9TranslationValue(deserializerState);
                ghostChild10Rotation.Value = snapshotData.GetChild10RotationValue(deserializerState);
                ghostChild10Translation.Value = snapshotData.GetChild10TranslationValue(deserializerState);
                ghostChild11Rotation.Value = snapshotData.GetChild11RotationValue(deserializerState);
                ghostChild11Translation.Value = snapshotData.GetChild11TranslationValue(deserializerState);
                ghostChild12Rotation.Value = snapshotData.GetChild12RotationValue(deserializerState);
                ghostChild12Translation.Value = snapshotData.GetChild12TranslationValue(deserializerState);
                ghostChild13Rotation.Value = snapshotData.GetChild13RotationValue(deserializerState);
                ghostChild13Translation.Value = snapshotData.GetChild13TranslationValue(deserializerState);
                ghostChild14Rotation.Value = snapshotData.GetChild14RotationValue(deserializerState);
                ghostChild14Translation.Value = snapshotData.GetChild14TranslationValue(deserializerState);
                ghostChild15Rotation.Value = snapshotData.GetChild15RotationValue(deserializerState);
                ghostChild15Translation.Value = snapshotData.GetChild15TranslationValue(deserializerState);
                ghostChild16Rotation.Value = snapshotData.GetChild16RotationValue(deserializerState);
                ghostChild16Translation.Value = snapshotData.GetChild16TranslationValue(deserializerState);
                ghostChild17Rotation.Value = snapshotData.GetChild17RotationValue(deserializerState);
                ghostChild17Translation.Value = snapshotData.GetChild17TranslationValue(deserializerState);
                ghostChild18Rotation.Value = snapshotData.GetChild18RotationValue(deserializerState);
                ghostChild18Translation.Value = snapshotData.GetChild18TranslationValue(deserializerState);
                ghostChild19Rotation.Value = snapshotData.GetChild19RotationValue(deserializerState);
                ghostChild19Translation.Value = snapshotData.GetChild19TranslationValue(deserializerState);
                ghostChild20Rotation.Value = snapshotData.GetChild20RotationValue(deserializerState);
                ghostChild20Translation.Value = snapshotData.GetChild20TranslationValue(deserializerState);
                ghostChild21Rotation.Value = snapshotData.GetChild21RotationValue(deserializerState);
                ghostChild21Translation.Value = snapshotData.GetChild21TranslationValue(deserializerState);
                ghostChild22Rotation.Value = snapshotData.GetChild22RotationValue(deserializerState);
                ghostChild22Translation.Value = snapshotData.GetChild22TranslationValue(deserializerState);
                ghostChild23Rotation.Value = snapshotData.GetChild23RotationValue(deserializerState);
                ghostChild23Translation.Value = snapshotData.GetChild23TranslationValue(deserializerState);
                ghostChild24Rotation.Value = snapshotData.GetChild24RotationValue(deserializerState);
                ghostChild24Translation.Value = snapshotData.GetChild24TranslationValue(deserializerState);
                ghostChild25Rotation.Value = snapshotData.GetChild25RotationValue(deserializerState);
                ghostChild25Translation.Value = snapshotData.GetChild25TranslationValue(deserializerState);
                ghostChild26Rotation.Value = snapshotData.GetChild26RotationValue(deserializerState);
                ghostChild26Translation.Value = snapshotData.GetChild26TranslationValue(deserializerState);
                ghostChild27Rotation.Value = snapshotData.GetChild27RotationValue(deserializerState);
                ghostChild27Translation.Value = snapshotData.GetChild27TranslationValue(deserializerState);
                ghostChild28Rotation.Value = snapshotData.GetChild28RotationValue(deserializerState);
                ghostChild28Translation.Value = snapshotData.GetChild28TranslationValue(deserializerState);
                ghostChild29Rotation.Value = snapshotData.GetChild29RotationValue(deserializerState);
                ghostChild29Translation.Value = snapshotData.GetChild29TranslationValue(deserializerState);
                ghostChild30Rotation.Value = snapshotData.GetChild30RotationValue(deserializerState);
                ghostChild30Translation.Value = snapshotData.GetChild30TranslationValue(deserializerState);
                ghostChild31Rotation.Value = snapshotData.GetChild31RotationValue(deserializerState);
                ghostChild31Translation.Value = snapshotData.GetChild31TranslationValue(deserializerState);
                ghostChild32Rotation.Value = snapshotData.GetChild32RotationValue(deserializerState);
                ghostChild32Translation.Value = snapshotData.GetChild32TranslationValue(deserializerState);
                ghostChild33Rotation.Value = snapshotData.GetChild33RotationValue(deserializerState);
                ghostChild33Translation.Value = snapshotData.GetChild33TranslationValue(deserializerState);
                ghostChild34Rotation.Value = snapshotData.GetChild34RotationValue(deserializerState);
                ghostChild34Translation.Value = snapshotData.GetChild34TranslationValue(deserializerState);
                ghostChild35Rotation.Value = snapshotData.GetChild35RotationValue(deserializerState);
                ghostChild35Translation.Value = snapshotData.GetChild35TranslationValue(deserializerState);
                ghostChild36Rotation.Value = snapshotData.GetChild36RotationValue(deserializerState);
                ghostChild36Translation.Value = snapshotData.GetChild36TranslationValue(deserializerState);
                ghostChild37Rotation.Value = snapshotData.GetChild37RotationValue(deserializerState);
                ghostChild37Translation.Value = snapshotData.GetChild37TranslationValue(deserializerState);
                ghostChild38Rotation.Value = snapshotData.GetChild38RotationValue(deserializerState);
                ghostChild38Translation.Value = snapshotData.GetChild38TranslationValue(deserializerState);
                ghostChild39Rotation.Value = snapshotData.GetChild39RotationValue(deserializerState);
                ghostChild39Translation.Value = snapshotData.GetChild39TranslationValue(deserializerState);
                ghostChild40Rotation.Value = snapshotData.GetChild40RotationValue(deserializerState);
                ghostChild40Translation.Value = snapshotData.GetChild40TranslationValue(deserializerState);
                ghostChild41Rotation.Value = snapshotData.GetChild41RotationValue(deserializerState);
                ghostChild41Translation.Value = snapshotData.GetChild41TranslationValue(deserializerState);
                ghostChild42Rotation.Value = snapshotData.GetChild42RotationValue(deserializerState);
                ghostChild42Translation.Value = snapshotData.GetChild42TranslationValue(deserializerState);
                ghostChild43Rotation.Value = snapshotData.GetChild43RotationValue(deserializerState);
                ghostChild43Translation.Value = snapshotData.GetChild43TranslationValue(deserializerState);
                ghostChild44Rotation.Value = snapshotData.GetChild44RotationValue(deserializerState);
                ghostChild44Translation.Value = snapshotData.GetChild44TranslationValue(deserializerState);
                ghostChild45Rotation.Value = snapshotData.GetChild45RotationValue(deserializerState);
                ghostChild45Translation.Value = snapshotData.GetChild45TranslationValue(deserializerState);
                ghostChild46Rotation.Value = snapshotData.GetChild46RotationValue(deserializerState);
                ghostChild46Translation.Value = snapshotData.GetChild46TranslationValue(deserializerState);
                ghostChild47Rotation.Value = snapshotData.GetChild47RotationValue(deserializerState);
                ghostChild47Translation.Value = snapshotData.GetChild47TranslationValue(deserializerState);
                ghostChild48Rotation.Value = snapshotData.GetChild48RotationValue(deserializerState);
                ghostChild48Translation.Value = snapshotData.GetChild48TranslationValue(deserializerState);
                ghostChild49Rotation.Value = snapshotData.GetChild49RotationValue(deserializerState);
                ghostChild49Translation.Value = snapshotData.GetChild49TranslationValue(deserializerState);
                ghostChild50Rotation.Value = snapshotData.GetChild50RotationValue(deserializerState);
                ghostChild50Translation.Value = snapshotData.GetChild50TranslationValue(deserializerState);
                ghostChild51Rotation.Value = snapshotData.GetChild51RotationValue(deserializerState);
                ghostChild51Translation.Value = snapshotData.GetChild51TranslationValue(deserializerState);
                ghostChild52Rotation.Value = snapshotData.GetChild52RotationValue(deserializerState);
                ghostChild52Translation.Value = snapshotData.GetChild52TranslationValue(deserializerState);
                ghostChild53Rotation.Value = snapshotData.GetChild53RotationValue(deserializerState);
                ghostChild53Translation.Value = snapshotData.GetChild53TranslationValue(deserializerState);
                ghostChild54Rotation.Value = snapshotData.GetChild54RotationValue(deserializerState);
                ghostChild54Translation.Value = snapshotData.GetChild54TranslationValue(deserializerState);
                ghostChild55Rotation.Value = snapshotData.GetChild55RotationValue(deserializerState);
                ghostChild55Translation.Value = snapshotData.GetChild55TranslationValue(deserializerState);
                ghostChild56Rotation.Value = snapshotData.GetChild56RotationValue(deserializerState);
                ghostChild56Translation.Value = snapshotData.GetChild56TranslationValue(deserializerState);
                ghostChild57Rotation.Value = snapshotData.GetChild57RotationValue(deserializerState);
                ghostChild57Translation.Value = snapshotData.GetChild57TranslationValue(deserializerState);
                ghostChild58Rotation.Value = snapshotData.GetChild58RotationValue(deserializerState);
                ghostChild58Translation.Value = snapshotData.GetChild58TranslationValue(deserializerState);
                ghostChild59Rotation.Value = snapshotData.GetChild59RotationValue(deserializerState);
                ghostChild59Translation.Value = snapshotData.GetChild59TranslationValue(deserializerState);
                ghostChild60Rotation.Value = snapshotData.GetChild60RotationValue(deserializerState);
                ghostChild60Translation.Value = snapshotData.GetChild60TranslationValue(deserializerState);
                ghostChild61Rotation.Value = snapshotData.GetChild61RotationValue(deserializerState);
                ghostChild61Translation.Value = snapshotData.GetChild61TranslationValue(deserializerState);
                ghostChild62Rotation.Value = snapshotData.GetChild62RotationValue(deserializerState);
                ghostChild62Translation.Value = snapshotData.GetChild62TranslationValue(deserializerState);
                ghostChild63Rotation.Value = snapshotData.GetChild63RotationValue(deserializerState);
                ghostChild63Translation.Value = snapshotData.GetChild63TranslationValue(deserializerState);
                ghostChild64Rotation.Value = snapshotData.GetChild64RotationValue(deserializerState);
                ghostChild64Translation.Value = snapshotData.GetChild64TranslationValue(deserializerState);
                ghostChild65Rotation.Value = snapshotData.GetChild65RotationValue(deserializerState);
                ghostChild65Translation.Value = snapshotData.GetChild65TranslationValue(deserializerState);
                ghostChild66Rotation.Value = snapshotData.GetChild66RotationValue(deserializerState);
                ghostChild66Translation.Value = snapshotData.GetChild66TranslationValue(deserializerState);
                ghostChild67Rotation.Value = snapshotData.GetChild67RotationValue(deserializerState);
                ghostChild67Translation.Value = snapshotData.GetChild67TranslationValue(deserializerState);
                ghostChild68Rotation.Value = snapshotData.GetChild68RotationValue(deserializerState);
                ghostChild68Translation.Value = snapshotData.GetChild68TranslationValue(deserializerState);
                ghostChild69Rotation.Value = snapshotData.GetChild69RotationValue(deserializerState);
                ghostChild69Translation.Value = snapshotData.GetChild69TranslationValue(deserializerState);
                ghostChild70Rotation.Value = snapshotData.GetChild70RotationValue(deserializerState);
                ghostChild70Translation.Value = snapshotData.GetChild70TranslationValue(deserializerState);
                ghostChild71Rotation.Value = snapshotData.GetChild71RotationValue(deserializerState);
                ghostChild71Translation.Value = snapshotData.GetChild71TranslationValue(deserializerState);
                ghostChild72Rotation.Value = snapshotData.GetChild72RotationValue(deserializerState);
                ghostChild72Translation.Value = snapshotData.GetChild72TranslationValue(deserializerState);
                ghostChild73Rotation.Value = snapshotData.GetChild73RotationValue(deserializerState);
                ghostChild73Translation.Value = snapshotData.GetChild73TranslationValue(deserializerState);
                ghostChild74Rotation.Value = snapshotData.GetChild74RotationValue(deserializerState);
                ghostChild74Translation.Value = snapshotData.GetChild74TranslationValue(deserializerState);
                ghostChild75Rotation.Value = snapshotData.GetChild75RotationValue(deserializerState);
                ghostChild75Translation.Value = snapshotData.GetChild75TranslationValue(deserializerState);
                ghostChild76Rotation.Value = snapshotData.GetChild76RotationValue(deserializerState);
                ghostChild76Translation.Value = snapshotData.GetChild76TranslationValue(deserializerState);
                ghostChild77Rotation.Value = snapshotData.GetChild77RotationValue(deserializerState);
                ghostChild77Translation.Value = snapshotData.GetChild77TranslationValue(deserializerState);
                ghostChild78Rotation.Value = snapshotData.GetChild78RotationValue(deserializerState);
                ghostChild78Translation.Value = snapshotData.GetChild78TranslationValue(deserializerState);
                ghostChild79Rotation.Value = snapshotData.GetChild79RotationValue(deserializerState);
                ghostChild79Translation.Value = snapshotData.GetChild79TranslationValue(deserializerState);
                ghostChild80Rotation.Value = snapshotData.GetChild80RotationValue(deserializerState);
                ghostChild80Translation.Value = snapshotData.GetChild80TranslationValue(deserializerState);
                ghostChild81Rotation.Value = snapshotData.GetChild81RotationValue(deserializerState);
                ghostChild81Translation.Value = snapshotData.GetChild81TranslationValue(deserializerState);
                ghostChild82Rotation.Value = snapshotData.GetChild82RotationValue(deserializerState);
                ghostChild82Translation.Value = snapshotData.GetChild82TranslationValue(deserializerState);
                ghostChild83Rotation.Value = snapshotData.GetChild83RotationValue(deserializerState);
                ghostChild83Translation.Value = snapshotData.GetChild83TranslationValue(deserializerState);
                ghostChild84Rotation.Value = snapshotData.GetChild84RotationValue(deserializerState);
                ghostChild84Translation.Value = snapshotData.GetChild84TranslationValue(deserializerState);
                ghostChild85Rotation.Value = snapshotData.GetChild85RotationValue(deserializerState);
                ghostChild85Translation.Value = snapshotData.GetChild85TranslationValue(deserializerState);
                ghostChild86Rotation.Value = snapshotData.GetChild86RotationValue(deserializerState);
                ghostChild86Translation.Value = snapshotData.GetChild86TranslationValue(deserializerState);
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value] = ghostRotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][0].Value] = ghostTranslation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value] = ghostChild0Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][1].Value] = ghostChild0Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value] = ghostChild1Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][2].Value] = ghostChild1Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value] = ghostChild2Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][3].Value] = ghostChild2Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value] = ghostChild3Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][4].Value] = ghostChild3Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value] = ghostChild4Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][5].Value] = ghostChild4Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value] = ghostChild5Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][6].Value] = ghostChild5Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value] = ghostChild6Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][7].Value] = ghostChild6Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value] = ghostChild7Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][8].Value] = ghostChild7Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value] = ghostChild8Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][9].Value] = ghostChild8Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value] = ghostChild9Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][10].Value] = ghostChild9Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value] = ghostChild10Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][11].Value] = ghostChild10Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value] = ghostChild11Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][12].Value] = ghostChild11Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value] = ghostChild12Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][13].Value] = ghostChild12Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value] = ghostChild13Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][14].Value] = ghostChild13Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value] = ghostChild14Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][15].Value] = ghostChild14Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value] = ghostChild15Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][16].Value] = ghostChild15Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value] = ghostChild16Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][17].Value] = ghostChild16Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value] = ghostChild17Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][18].Value] = ghostChild17Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value] = ghostChild18Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][19].Value] = ghostChild18Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value] = ghostChild19Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][20].Value] = ghostChild19Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value] = ghostChild20Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][21].Value] = ghostChild20Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value] = ghostChild21Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][22].Value] = ghostChild21Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value] = ghostChild22Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][23].Value] = ghostChild22Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value] = ghostChild23Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][24].Value] = ghostChild23Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value] = ghostChild24Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][25].Value] = ghostChild24Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value] = ghostChild25Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][26].Value] = ghostChild25Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value] = ghostChild26Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][27].Value] = ghostChild26Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value] = ghostChild27Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][28].Value] = ghostChild27Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value] = ghostChild28Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][29].Value] = ghostChild28Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value] = ghostChild29Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][30].Value] = ghostChild29Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value] = ghostChild30Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][31].Value] = ghostChild30Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value] = ghostChild31Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][32].Value] = ghostChild31Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value] = ghostChild32Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][33].Value] = ghostChild32Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value] = ghostChild33Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][34].Value] = ghostChild33Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value] = ghostChild34Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][35].Value] = ghostChild34Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value] = ghostChild35Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][36].Value] = ghostChild35Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value] = ghostChild36Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][37].Value] = ghostChild36Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value] = ghostChild37Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][38].Value] = ghostChild37Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value] = ghostChild38Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][39].Value] = ghostChild38Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value] = ghostChild39Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][40].Value] = ghostChild39Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value] = ghostChild40Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][41].Value] = ghostChild40Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value] = ghostChild41Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][42].Value] = ghostChild41Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value] = ghostChild42Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][43].Value] = ghostChild42Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value] = ghostChild43Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][44].Value] = ghostChild43Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value] = ghostChild44Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][45].Value] = ghostChild44Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value] = ghostChild45Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][46].Value] = ghostChild45Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value] = ghostChild46Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][47].Value] = ghostChild46Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value] = ghostChild47Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][48].Value] = ghostChild47Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value] = ghostChild48Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][49].Value] = ghostChild48Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value] = ghostChild49Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][50].Value] = ghostChild49Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value] = ghostChild50Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][51].Value] = ghostChild50Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value] = ghostChild51Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][52].Value] = ghostChild51Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value] = ghostChild52Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][53].Value] = ghostChild52Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value] = ghostChild53Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][54].Value] = ghostChild53Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value] = ghostChild54Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][55].Value] = ghostChild54Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value] = ghostChild55Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][56].Value] = ghostChild55Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value] = ghostChild56Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][57].Value] = ghostChild56Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value] = ghostChild57Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][58].Value] = ghostChild57Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value] = ghostChild58Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][59].Value] = ghostChild58Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value] = ghostChild59Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][60].Value] = ghostChild59Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value] = ghostChild60Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][61].Value] = ghostChild60Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value] = ghostChild61Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][62].Value] = ghostChild61Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value] = ghostChild62Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][63].Value] = ghostChild62Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value] = ghostChild63Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][64].Value] = ghostChild63Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value] = ghostChild64Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][65].Value] = ghostChild64Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value] = ghostChild65Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][66].Value] = ghostChild65Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value] = ghostChild66Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][67].Value] = ghostChild66Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value] = ghostChild67Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][68].Value] = ghostChild67Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value] = ghostChild68Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][69].Value] = ghostChild68Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value] = ghostChild69Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][70].Value] = ghostChild69Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value] = ghostChild70Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][71].Value] = ghostChild70Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value] = ghostChild71Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][72].Value] = ghostChild71Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value] = ghostChild72Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][73].Value] = ghostChild72Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value] = ghostChild73Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][74].Value] = ghostChild73Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value] = ghostChild74Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][75].Value] = ghostChild74Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value] = ghostChild75Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][76].Value] = ghostChild75Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value] = ghostChild76Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][77].Value] = ghostChild76Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value] = ghostChild77Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][78].Value] = ghostChild77Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value] = ghostChild78Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][79].Value] = ghostChild78Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value] = ghostChild79Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][80].Value] = ghostChild79Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value] = ghostChild80Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][81].Value] = ghostChild80Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value] = ghostChild81Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][82].Value] = ghostChild81Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value] = ghostChild82Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][83].Value] = ghostChild82Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value] = ghostChild83Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][84].Value] = ghostChild83Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value] = ghostChild84Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][85].Value] = ghostChild84Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value] = ghostChild85Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][86].Value] = ghostChild85Translation;
                ghostRotationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value] = ghostChild86Rotation;
                ghostTranslationFromEntity[ghostLinkedEntityGroupArray[entityIndex][87].Value] = ghostChild86Translation;
                ghostMovablePlayerArray[entityIndex] = ghostMovablePlayer;
            }
        }
    }
    private ClientSimulationSystemGroup m_ClientSimulationSystemGroup;
    private GhostPredictionSystemGroup m_GhostPredictionSystemGroup;
    private EntityQuery m_interpolatedQuery;
    private EntityQuery m_predictedQuery;
    private GhostUpdateSystemGroup m_GhostUpdateSystemGroup;
    private uint m_LastPredictedTick;
    protected override void OnCreate()
    {
        m_GhostUpdateSystemGroup = World.GetOrCreateSystem<GhostUpdateSystemGroup>();
        m_ClientSimulationSystemGroup = World.GetOrCreateSystem<ClientSimulationSystemGroup>();
        m_GhostPredictionSystemGroup = World.GetOrCreateSystem<GhostPredictionSystemGroup>();
        m_interpolatedQuery = GetEntityQuery(new EntityQueryDesc
        {
            All = new []{
                ComponentType.ReadWrite<ThirdPersonControllerSnapshotData>(),
                ComponentType.ReadOnly<GhostComponent>(),
                ComponentType.ReadWrite<MovablePlayer>(),
                ComponentType.ReadOnly<LinkedEntityGroup>(),
            },
            None = new []{ComponentType.ReadWrite<PredictedGhostComponent>()}
        });
        m_predictedQuery = GetEntityQuery(new EntityQueryDesc
        {
            All = new []{
                ComponentType.ReadOnly<ThirdPersonControllerSnapshotData>(),
                ComponentType.ReadOnly<GhostComponent>(),
                ComponentType.ReadOnly<PredictedGhostComponent>(),
                ComponentType.ReadWrite<MovablePlayer>(),
                ComponentType.ReadOnly<LinkedEntityGroup>(),
            }
        });
        RequireForUpdate(GetEntityQuery(ComponentType.ReadWrite<ThirdPersonControllerSnapshotData>(),
            ComponentType.ReadOnly<GhostComponent>()));
    }
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var ghostEntityMap = m_GhostUpdateSystemGroup.GhostEntityMap;
#if UNITY_EDITOR || DEVELOPMENT_BUILD
        var ghostMinMaxSnapshotTick = m_GhostUpdateSystemGroup.GhostSnapshotTickMinMax;
#endif
        if (!m_predictedQuery.IsEmptyIgnoreFilter)
        {
            var updatePredictedJob = new UpdatePredictedJob
            {
                GhostMap = ghostEntityMap,
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                minMaxSnapshotTick = ghostMinMaxSnapshotTick,
#endif
                minPredictedTick = m_GhostPredictionSystemGroup.OldestPredictedTick,
                ghostSnapshotDataType = GetArchetypeChunkBufferType<ThirdPersonControllerSnapshotData>(true),
                ghostEntityType = GetArchetypeChunkEntityType(),
                predictedGhostComponentType = GetArchetypeChunkComponentType<PredictedGhostComponent>(),
                ghostMovablePlayerType = GetArchetypeChunkComponentType<MovablePlayer>(),
                ghostLinkedEntityGroupType = GetArchetypeChunkBufferType<LinkedEntityGroup>(true),
                ghostRotationFromEntity = GetComponentDataFromEntity<Rotation>(),
                ghostTranslationFromEntity = GetComponentDataFromEntity<Translation>(),

                targetTick = m_ClientSimulationSystemGroup.ServerTick,
                lastPredictedTick = m_LastPredictedTick
            };
            m_LastPredictedTick = m_ClientSimulationSystemGroup.ServerTick;
            if (m_ClientSimulationSystemGroup.ServerTickFraction < 1)
                m_LastPredictedTick = 0;
            inputDeps = updatePredictedJob.Schedule(m_predictedQuery, JobHandle.CombineDependencies(inputDeps, m_GhostUpdateSystemGroup.LastGhostMapWriter));
            m_GhostPredictionSystemGroup.AddPredictedTickWriter(inputDeps);
        }
        if (!m_interpolatedQuery.IsEmptyIgnoreFilter)
        {
            var updateInterpolatedJob = new UpdateInterpolatedJob
            {
                GhostMap = ghostEntityMap,
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                minMaxSnapshotTick = ghostMinMaxSnapshotTick,
#endif
                ghostSnapshotDataType = GetArchetypeChunkBufferType<ThirdPersonControllerSnapshotData>(true),
                ghostEntityType = GetArchetypeChunkEntityType(),
                ghostMovablePlayerType = GetArchetypeChunkComponentType<MovablePlayer>(),
                ghostLinkedEntityGroupType = GetArchetypeChunkBufferType<LinkedEntityGroup>(true),
                ghostRotationFromEntity = GetComponentDataFromEntity<Rotation>(),
                ghostTranslationFromEntity = GetComponentDataFromEntity<Translation>(),
                targetTick = m_ClientSimulationSystemGroup.InterpolationTick,
                targetTickFraction = m_ClientSimulationSystemGroup.InterpolationTickFraction
            };
            inputDeps = updateInterpolatedJob.Schedule(m_interpolatedQuery, JobHandle.CombineDependencies(inputDeps, m_GhostUpdateSystemGroup.LastGhostMapWriter));
        }
        return inputDeps;
    }
}
public partial class ThirdPersonControllerGhostSpawnSystem : DefaultGhostSpawnSystem<ThirdPersonControllerSnapshotData>
{
    struct SetPredictedDefault : IJobParallelFor
    {
        [ReadOnly] public NativeArray<ThirdPersonControllerSnapshotData> snapshots;
        public NativeArray<int> predictionMask;
        [ReadOnly][DeallocateOnJobCompletion] public NativeArray<NetworkIdComponent> localPlayerId;
        public void Execute(int index)
        {
            if (localPlayerId.Length == 1 && snapshots[index].GetMovablePlayerPlayerId() == localPlayerId[0].Value)
                predictionMask[index] = 1;
        }
    }
    protected override JobHandle SetPredictedGhostDefaults(NativeArray<ThirdPersonControllerSnapshotData> snapshots, NativeArray<int> predictionMask, JobHandle inputDeps)
    {
        JobHandle playerHandle;
        var job = new SetPredictedDefault
        {
            snapshots = snapshots,
            predictionMask = predictionMask,
            localPlayerId = m_PlayerGroup.ToComponentDataArrayAsync<NetworkIdComponent>(Allocator.TempJob, out playerHandle),
        };
        return job.Schedule(predictionMask.Length, 8, JobHandle.CombineDependencies(playerHandle, inputDeps));
    }
}
