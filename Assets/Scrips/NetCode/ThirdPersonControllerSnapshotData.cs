using Unity.Networking.Transport;
using Unity.NetCode;
using Unity.Mathematics;

public struct ThirdPersonControllerSnapshotData : ISnapshotData<ThirdPersonControllerSnapshotData>
{
    public uint tick;
    private int MovablePlayerPlayerId;
    private int RotationValueX;
    private int RotationValueY;
    private int RotationValueZ;
    private int RotationValueW;
    private int TranslationValueX;
    private int TranslationValueY;
    private int TranslationValueZ;
    private int Child0RotationValueX;
    private int Child0RotationValueY;
    private int Child0RotationValueZ;
    private int Child0RotationValueW;
    private int Child0TranslationValueX;
    private int Child0TranslationValueY;
    private int Child0TranslationValueZ;
    private int Child1RotationValueX;
    private int Child1RotationValueY;
    private int Child1RotationValueZ;
    private int Child1RotationValueW;
    private int Child1TranslationValueX;
    private int Child1TranslationValueY;
    private int Child1TranslationValueZ;
    private int Child2RotationValueX;
    private int Child2RotationValueY;
    private int Child2RotationValueZ;
    private int Child2RotationValueW;
    private int Child2TranslationValueX;
    private int Child2TranslationValueY;
    private int Child2TranslationValueZ;
    private int Child3RotationValueX;
    private int Child3RotationValueY;
    private int Child3RotationValueZ;
    private int Child3RotationValueW;
    private int Child3TranslationValueX;
    private int Child3TranslationValueY;
    private int Child3TranslationValueZ;
    private int Child4RotationValueX;
    private int Child4RotationValueY;
    private int Child4RotationValueZ;
    private int Child4RotationValueW;
    private int Child4TranslationValueX;
    private int Child4TranslationValueY;
    private int Child4TranslationValueZ;
    private int Child5RotationValueX;
    private int Child5RotationValueY;
    private int Child5RotationValueZ;
    private int Child5RotationValueW;
    private int Child5TranslationValueX;
    private int Child5TranslationValueY;
    private int Child5TranslationValueZ;
    private int Child6RotationValueX;
    private int Child6RotationValueY;
    private int Child6RotationValueZ;
    private int Child6RotationValueW;
    private int Child6TranslationValueX;
    private int Child6TranslationValueY;
    private int Child6TranslationValueZ;
    private int Child7RotationValueX;
    private int Child7RotationValueY;
    private int Child7RotationValueZ;
    private int Child7RotationValueW;
    private int Child7TranslationValueX;
    private int Child7TranslationValueY;
    private int Child7TranslationValueZ;
    private int Child8RotationValueX;
    private int Child8RotationValueY;
    private int Child8RotationValueZ;
    private int Child8RotationValueW;
    private int Child8TranslationValueX;
    private int Child8TranslationValueY;
    private int Child8TranslationValueZ;
    private int Child9RotationValueX;
    private int Child9RotationValueY;
    private int Child9RotationValueZ;
    private int Child9RotationValueW;
    private int Child9TranslationValueX;
    private int Child9TranslationValueY;
    private int Child9TranslationValueZ;
    private int Child10RotationValueX;
    private int Child10RotationValueY;
    private int Child10RotationValueZ;
    private int Child10RotationValueW;
    private int Child10TranslationValueX;
    private int Child10TranslationValueY;
    private int Child10TranslationValueZ;
    private int Child11RotationValueX;
    private int Child11RotationValueY;
    private int Child11RotationValueZ;
    private int Child11RotationValueW;
    private int Child11TranslationValueX;
    private int Child11TranslationValueY;
    private int Child11TranslationValueZ;
    private int Child12RotationValueX;
    private int Child12RotationValueY;
    private int Child12RotationValueZ;
    private int Child12RotationValueW;
    private int Child12TranslationValueX;
    private int Child12TranslationValueY;
    private int Child12TranslationValueZ;
    private int Child13RotationValueX;
    private int Child13RotationValueY;
    private int Child13RotationValueZ;
    private int Child13RotationValueW;
    private int Child13TranslationValueX;
    private int Child13TranslationValueY;
    private int Child13TranslationValueZ;
    private int Child14RotationValueX;
    private int Child14RotationValueY;
    private int Child14RotationValueZ;
    private int Child14RotationValueW;
    private int Child14TranslationValueX;
    private int Child14TranslationValueY;
    private int Child14TranslationValueZ;
    private int Child15RotationValueX;
    private int Child15RotationValueY;
    private int Child15RotationValueZ;
    private int Child15RotationValueW;
    private int Child15TranslationValueX;
    private int Child15TranslationValueY;
    private int Child15TranslationValueZ;
    private int Child16RotationValueX;
    private int Child16RotationValueY;
    private int Child16RotationValueZ;
    private int Child16RotationValueW;
    private int Child16TranslationValueX;
    private int Child16TranslationValueY;
    private int Child16TranslationValueZ;
    private int Child17RotationValueX;
    private int Child17RotationValueY;
    private int Child17RotationValueZ;
    private int Child17RotationValueW;
    private int Child17TranslationValueX;
    private int Child17TranslationValueY;
    private int Child17TranslationValueZ;
    private int Child18RotationValueX;
    private int Child18RotationValueY;
    private int Child18RotationValueZ;
    private int Child18RotationValueW;
    private int Child18TranslationValueX;
    private int Child18TranslationValueY;
    private int Child18TranslationValueZ;
    private int Child19RotationValueX;
    private int Child19RotationValueY;
    private int Child19RotationValueZ;
    private int Child19RotationValueW;
    private int Child19TranslationValueX;
    private int Child19TranslationValueY;
    private int Child19TranslationValueZ;
    private int Child20RotationValueX;
    private int Child20RotationValueY;
    private int Child20RotationValueZ;
    private int Child20RotationValueW;
    private int Child20TranslationValueX;
    private int Child20TranslationValueY;
    private int Child20TranslationValueZ;
    private int Child21RotationValueX;
    private int Child21RotationValueY;
    private int Child21RotationValueZ;
    private int Child21RotationValueW;
    private int Child21TranslationValueX;
    private int Child21TranslationValueY;
    private int Child21TranslationValueZ;
    private int Child22RotationValueX;
    private int Child22RotationValueY;
    private int Child22RotationValueZ;
    private int Child22RotationValueW;
    private int Child22TranslationValueX;
    private int Child22TranslationValueY;
    private int Child22TranslationValueZ;
    private int Child23RotationValueX;
    private int Child23RotationValueY;
    private int Child23RotationValueZ;
    private int Child23RotationValueW;
    private int Child23TranslationValueX;
    private int Child23TranslationValueY;
    private int Child23TranslationValueZ;
    private int Child24RotationValueX;
    private int Child24RotationValueY;
    private int Child24RotationValueZ;
    private int Child24RotationValueW;
    private int Child24TranslationValueX;
    private int Child24TranslationValueY;
    private int Child24TranslationValueZ;
    private int Child25RotationValueX;
    private int Child25RotationValueY;
    private int Child25RotationValueZ;
    private int Child25RotationValueW;
    private int Child25TranslationValueX;
    private int Child25TranslationValueY;
    private int Child25TranslationValueZ;
    private int Child26RotationValueX;
    private int Child26RotationValueY;
    private int Child26RotationValueZ;
    private int Child26RotationValueW;
    private int Child26TranslationValueX;
    private int Child26TranslationValueY;
    private int Child26TranslationValueZ;
    private int Child27RotationValueX;
    private int Child27RotationValueY;
    private int Child27RotationValueZ;
    private int Child27RotationValueW;
    private int Child27TranslationValueX;
    private int Child27TranslationValueY;
    private int Child27TranslationValueZ;
    private int Child28RotationValueX;
    private int Child28RotationValueY;
    private int Child28RotationValueZ;
    private int Child28RotationValueW;
    private int Child28TranslationValueX;
    private int Child28TranslationValueY;
    private int Child28TranslationValueZ;
    private int Child29RotationValueX;
    private int Child29RotationValueY;
    private int Child29RotationValueZ;
    private int Child29RotationValueW;
    private int Child29TranslationValueX;
    private int Child29TranslationValueY;
    private int Child29TranslationValueZ;
    private int Child30RotationValueX;
    private int Child30RotationValueY;
    private int Child30RotationValueZ;
    private int Child30RotationValueW;
    private int Child30TranslationValueX;
    private int Child30TranslationValueY;
    private int Child30TranslationValueZ;
    private int Child31RotationValueX;
    private int Child31RotationValueY;
    private int Child31RotationValueZ;
    private int Child31RotationValueW;
    private int Child31TranslationValueX;
    private int Child31TranslationValueY;
    private int Child31TranslationValueZ;
    private int Child32RotationValueX;
    private int Child32RotationValueY;
    private int Child32RotationValueZ;
    private int Child32RotationValueW;
    private int Child32TranslationValueX;
    private int Child32TranslationValueY;
    private int Child32TranslationValueZ;
    private int Child33RotationValueX;
    private int Child33RotationValueY;
    private int Child33RotationValueZ;
    private int Child33RotationValueW;
    private int Child33TranslationValueX;
    private int Child33TranslationValueY;
    private int Child33TranslationValueZ;
    private int Child34RotationValueX;
    private int Child34RotationValueY;
    private int Child34RotationValueZ;
    private int Child34RotationValueW;
    private int Child34TranslationValueX;
    private int Child34TranslationValueY;
    private int Child34TranslationValueZ;
    private int Child35RotationValueX;
    private int Child35RotationValueY;
    private int Child35RotationValueZ;
    private int Child35RotationValueW;
    private int Child35TranslationValueX;
    private int Child35TranslationValueY;
    private int Child35TranslationValueZ;
    private int Child36RotationValueX;
    private int Child36RotationValueY;
    private int Child36RotationValueZ;
    private int Child36RotationValueW;
    private int Child36TranslationValueX;
    private int Child36TranslationValueY;
    private int Child36TranslationValueZ;
    private int Child37RotationValueX;
    private int Child37RotationValueY;
    private int Child37RotationValueZ;
    private int Child37RotationValueW;
    private int Child37TranslationValueX;
    private int Child37TranslationValueY;
    private int Child37TranslationValueZ;
    private int Child38RotationValueX;
    private int Child38RotationValueY;
    private int Child38RotationValueZ;
    private int Child38RotationValueW;
    private int Child38TranslationValueX;
    private int Child38TranslationValueY;
    private int Child38TranslationValueZ;
    private int Child39RotationValueX;
    private int Child39RotationValueY;
    private int Child39RotationValueZ;
    private int Child39RotationValueW;
    private int Child39TranslationValueX;
    private int Child39TranslationValueY;
    private int Child39TranslationValueZ;
    private int Child40RotationValueX;
    private int Child40RotationValueY;
    private int Child40RotationValueZ;
    private int Child40RotationValueW;
    private int Child40TranslationValueX;
    private int Child40TranslationValueY;
    private int Child40TranslationValueZ;
    private int Child41RotationValueX;
    private int Child41RotationValueY;
    private int Child41RotationValueZ;
    private int Child41RotationValueW;
    private int Child41TranslationValueX;
    private int Child41TranslationValueY;
    private int Child41TranslationValueZ;
    private int Child42RotationValueX;
    private int Child42RotationValueY;
    private int Child42RotationValueZ;
    private int Child42RotationValueW;
    private int Child42TranslationValueX;
    private int Child42TranslationValueY;
    private int Child42TranslationValueZ;
    private int Child43RotationValueX;
    private int Child43RotationValueY;
    private int Child43RotationValueZ;
    private int Child43RotationValueW;
    private int Child43TranslationValueX;
    private int Child43TranslationValueY;
    private int Child43TranslationValueZ;
    private int Child44RotationValueX;
    private int Child44RotationValueY;
    private int Child44RotationValueZ;
    private int Child44RotationValueW;
    private int Child44TranslationValueX;
    private int Child44TranslationValueY;
    private int Child44TranslationValueZ;
    private int Child45RotationValueX;
    private int Child45RotationValueY;
    private int Child45RotationValueZ;
    private int Child45RotationValueW;
    private int Child45TranslationValueX;
    private int Child45TranslationValueY;
    private int Child45TranslationValueZ;
    private int Child46RotationValueX;
    private int Child46RotationValueY;
    private int Child46RotationValueZ;
    private int Child46RotationValueW;
    private int Child46TranslationValueX;
    private int Child46TranslationValueY;
    private int Child46TranslationValueZ;
    private int Child47RotationValueX;
    private int Child47RotationValueY;
    private int Child47RotationValueZ;
    private int Child47RotationValueW;
    private int Child47TranslationValueX;
    private int Child47TranslationValueY;
    private int Child47TranslationValueZ;
    private int Child48RotationValueX;
    private int Child48RotationValueY;
    private int Child48RotationValueZ;
    private int Child48RotationValueW;
    private int Child48TranslationValueX;
    private int Child48TranslationValueY;
    private int Child48TranslationValueZ;
    private int Child49RotationValueX;
    private int Child49RotationValueY;
    private int Child49RotationValueZ;
    private int Child49RotationValueW;
    private int Child49TranslationValueX;
    private int Child49TranslationValueY;
    private int Child49TranslationValueZ;
    private int Child50RotationValueX;
    private int Child50RotationValueY;
    private int Child50RotationValueZ;
    private int Child50RotationValueW;
    private int Child50TranslationValueX;
    private int Child50TranslationValueY;
    private int Child50TranslationValueZ;
    private int Child51RotationValueX;
    private int Child51RotationValueY;
    private int Child51RotationValueZ;
    private int Child51RotationValueW;
    private int Child51TranslationValueX;
    private int Child51TranslationValueY;
    private int Child51TranslationValueZ;
    private int Child52RotationValueX;
    private int Child52RotationValueY;
    private int Child52RotationValueZ;
    private int Child52RotationValueW;
    private int Child52TranslationValueX;
    private int Child52TranslationValueY;
    private int Child52TranslationValueZ;
    private int Child53RotationValueX;
    private int Child53RotationValueY;
    private int Child53RotationValueZ;
    private int Child53RotationValueW;
    private int Child53TranslationValueX;
    private int Child53TranslationValueY;
    private int Child53TranslationValueZ;
    private int Child54RotationValueX;
    private int Child54RotationValueY;
    private int Child54RotationValueZ;
    private int Child54RotationValueW;
    private int Child54TranslationValueX;
    private int Child54TranslationValueY;
    private int Child54TranslationValueZ;
    private int Child55RotationValueX;
    private int Child55RotationValueY;
    private int Child55RotationValueZ;
    private int Child55RotationValueW;
    private int Child55TranslationValueX;
    private int Child55TranslationValueY;
    private int Child55TranslationValueZ;
    private int Child56RotationValueX;
    private int Child56RotationValueY;
    private int Child56RotationValueZ;
    private int Child56RotationValueW;
    private int Child56TranslationValueX;
    private int Child56TranslationValueY;
    private int Child56TranslationValueZ;
    private int Child57RotationValueX;
    private int Child57RotationValueY;
    private int Child57RotationValueZ;
    private int Child57RotationValueW;
    private int Child57TranslationValueX;
    private int Child57TranslationValueY;
    private int Child57TranslationValueZ;
    private int Child58RotationValueX;
    private int Child58RotationValueY;
    private int Child58RotationValueZ;
    private int Child58RotationValueW;
    private int Child58TranslationValueX;
    private int Child58TranslationValueY;
    private int Child58TranslationValueZ;
    private int Child59RotationValueX;
    private int Child59RotationValueY;
    private int Child59RotationValueZ;
    private int Child59RotationValueW;
    private int Child59TranslationValueX;
    private int Child59TranslationValueY;
    private int Child59TranslationValueZ;
    private int Child60RotationValueX;
    private int Child60RotationValueY;
    private int Child60RotationValueZ;
    private int Child60RotationValueW;
    private int Child60TranslationValueX;
    private int Child60TranslationValueY;
    private int Child60TranslationValueZ;
    private int Child61RotationValueX;
    private int Child61RotationValueY;
    private int Child61RotationValueZ;
    private int Child61RotationValueW;
    private int Child61TranslationValueX;
    private int Child61TranslationValueY;
    private int Child61TranslationValueZ;
    private int Child62RotationValueX;
    private int Child62RotationValueY;
    private int Child62RotationValueZ;
    private int Child62RotationValueW;
    private int Child62TranslationValueX;
    private int Child62TranslationValueY;
    private int Child62TranslationValueZ;
    private int Child63RotationValueX;
    private int Child63RotationValueY;
    private int Child63RotationValueZ;
    private int Child63RotationValueW;
    private int Child63TranslationValueX;
    private int Child63TranslationValueY;
    private int Child63TranslationValueZ;
    private int Child64RotationValueX;
    private int Child64RotationValueY;
    private int Child64RotationValueZ;
    private int Child64RotationValueW;
    private int Child64TranslationValueX;
    private int Child64TranslationValueY;
    private int Child64TranslationValueZ;
    private int Child65RotationValueX;
    private int Child65RotationValueY;
    private int Child65RotationValueZ;
    private int Child65RotationValueW;
    private int Child65TranslationValueX;
    private int Child65TranslationValueY;
    private int Child65TranslationValueZ;
    private int Child66RotationValueX;
    private int Child66RotationValueY;
    private int Child66RotationValueZ;
    private int Child66RotationValueW;
    private int Child66TranslationValueX;
    private int Child66TranslationValueY;
    private int Child66TranslationValueZ;
    private int Child67RotationValueX;
    private int Child67RotationValueY;
    private int Child67RotationValueZ;
    private int Child67RotationValueW;
    private int Child67TranslationValueX;
    private int Child67TranslationValueY;
    private int Child67TranslationValueZ;
    private int Child68RotationValueX;
    private int Child68RotationValueY;
    private int Child68RotationValueZ;
    private int Child68RotationValueW;
    private int Child68TranslationValueX;
    private int Child68TranslationValueY;
    private int Child68TranslationValueZ;
    private int Child69RotationValueX;
    private int Child69RotationValueY;
    private int Child69RotationValueZ;
    private int Child69RotationValueW;
    private int Child69TranslationValueX;
    private int Child69TranslationValueY;
    private int Child69TranslationValueZ;
    private int Child70RotationValueX;
    private int Child70RotationValueY;
    private int Child70RotationValueZ;
    private int Child70RotationValueW;
    private int Child70TranslationValueX;
    private int Child70TranslationValueY;
    private int Child70TranslationValueZ;
    private int Child71RotationValueX;
    private int Child71RotationValueY;
    private int Child71RotationValueZ;
    private int Child71RotationValueW;
    private int Child71TranslationValueX;
    private int Child71TranslationValueY;
    private int Child71TranslationValueZ;
    private int Child72RotationValueX;
    private int Child72RotationValueY;
    private int Child72RotationValueZ;
    private int Child72RotationValueW;
    private int Child72TranslationValueX;
    private int Child72TranslationValueY;
    private int Child72TranslationValueZ;
    private int Child73RotationValueX;
    private int Child73RotationValueY;
    private int Child73RotationValueZ;
    private int Child73RotationValueW;
    private int Child73TranslationValueX;
    private int Child73TranslationValueY;
    private int Child73TranslationValueZ;
    private int Child74RotationValueX;
    private int Child74RotationValueY;
    private int Child74RotationValueZ;
    private int Child74RotationValueW;
    private int Child74TranslationValueX;
    private int Child74TranslationValueY;
    private int Child74TranslationValueZ;
    private int Child75RotationValueX;
    private int Child75RotationValueY;
    private int Child75RotationValueZ;
    private int Child75RotationValueW;
    private int Child75TranslationValueX;
    private int Child75TranslationValueY;
    private int Child75TranslationValueZ;
    private int Child76RotationValueX;
    private int Child76RotationValueY;
    private int Child76RotationValueZ;
    private int Child76RotationValueW;
    private int Child76TranslationValueX;
    private int Child76TranslationValueY;
    private int Child76TranslationValueZ;
    private int Child77RotationValueX;
    private int Child77RotationValueY;
    private int Child77RotationValueZ;
    private int Child77RotationValueW;
    private int Child77TranslationValueX;
    private int Child77TranslationValueY;
    private int Child77TranslationValueZ;
    private int Child78RotationValueX;
    private int Child78RotationValueY;
    private int Child78RotationValueZ;
    private int Child78RotationValueW;
    private int Child78TranslationValueX;
    private int Child78TranslationValueY;
    private int Child78TranslationValueZ;
    private int Child79RotationValueX;
    private int Child79RotationValueY;
    private int Child79RotationValueZ;
    private int Child79RotationValueW;
    private int Child79TranslationValueX;
    private int Child79TranslationValueY;
    private int Child79TranslationValueZ;
    private int Child80RotationValueX;
    private int Child80RotationValueY;
    private int Child80RotationValueZ;
    private int Child80RotationValueW;
    private int Child80TranslationValueX;
    private int Child80TranslationValueY;
    private int Child80TranslationValueZ;
    private int Child81RotationValueX;
    private int Child81RotationValueY;
    private int Child81RotationValueZ;
    private int Child81RotationValueW;
    private int Child81TranslationValueX;
    private int Child81TranslationValueY;
    private int Child81TranslationValueZ;
    private int Child82RotationValueX;
    private int Child82RotationValueY;
    private int Child82RotationValueZ;
    private int Child82RotationValueW;
    private int Child82TranslationValueX;
    private int Child82TranslationValueY;
    private int Child82TranslationValueZ;
    private int Child83RotationValueX;
    private int Child83RotationValueY;
    private int Child83RotationValueZ;
    private int Child83RotationValueW;
    private int Child83TranslationValueX;
    private int Child83TranslationValueY;
    private int Child83TranslationValueZ;
    private int Child84RotationValueX;
    private int Child84RotationValueY;
    private int Child84RotationValueZ;
    private int Child84RotationValueW;
    private int Child84TranslationValueX;
    private int Child84TranslationValueY;
    private int Child84TranslationValueZ;
    private int Child85RotationValueX;
    private int Child85RotationValueY;
    private int Child85RotationValueZ;
    private int Child85RotationValueW;
    private int Child85TranslationValueX;
    private int Child85TranslationValueY;
    private int Child85TranslationValueZ;
    private int Child86RotationValueX;
    private int Child86RotationValueY;
    private int Child86RotationValueZ;
    private int Child86RotationValueW;
    private int Child86TranslationValueX;
    private int Child86TranslationValueY;
    private int Child86TranslationValueZ;
    uint changeMask0;
    uint changeMask1;
    uint changeMask2;
    uint changeMask3;
    uint changeMask4;
    uint changeMask5;

    public uint Tick => tick;
    public int GetMovablePlayerPlayerId(GhostDeserializerState deserializerState)
    {
        return (int)MovablePlayerPlayerId;
    }
    public int GetMovablePlayerPlayerId()
    {
        return (int)MovablePlayerPlayerId;
    }
    public void SetMovablePlayerPlayerId(int val, GhostSerializerState serializerState)
    {
        MovablePlayerPlayerId = (int)val;
    }
    public void SetMovablePlayerPlayerId(int val)
    {
        MovablePlayerPlayerId = (int)val;
    }
    public quaternion GetRotationValue(GhostDeserializerState deserializerState)
    {
        return GetRotationValue();
    }
    public quaternion GetRotationValue()
    {
        return new quaternion(RotationValueX * 0.001f, RotationValueY * 0.001f, RotationValueZ * 0.001f, RotationValueW * 0.001f);
    }
    public void SetRotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetRotationValue(q);
    }
    public void SetRotationValue(quaternion q)
    {
        RotationValueX = (int)(q.value.x * 1000);
        RotationValueY = (int)(q.value.y * 1000);
        RotationValueZ = (int)(q.value.z * 1000);
        RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetTranslationValue(GhostDeserializerState deserializerState)
    {
        return GetTranslationValue();
    }
    public float3 GetTranslationValue()
    {
        return new float3(TranslationValueX * 0.01f, TranslationValueY * 0.01f, TranslationValueZ * 0.01f);
    }
    public void SetTranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetTranslationValue(val);
    }
    public void SetTranslationValue(float3 val)
    {
        TranslationValueX = (int)(val.x * 100);
        TranslationValueY = (int)(val.y * 100);
        TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild0RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild0RotationValue();
    }
    public quaternion GetChild0RotationValue()
    {
        return new quaternion(Child0RotationValueX * 0.001f, Child0RotationValueY * 0.001f, Child0RotationValueZ * 0.001f, Child0RotationValueW * 0.001f);
    }
    public void SetChild0RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild0RotationValue(q);
    }
    public void SetChild0RotationValue(quaternion q)
    {
        Child0RotationValueX = (int)(q.value.x * 1000);
        Child0RotationValueY = (int)(q.value.y * 1000);
        Child0RotationValueZ = (int)(q.value.z * 1000);
        Child0RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild0TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild0TranslationValue();
    }
    public float3 GetChild0TranslationValue()
    {
        return new float3(Child0TranslationValueX * 0.01f, Child0TranslationValueY * 0.01f, Child0TranslationValueZ * 0.01f);
    }
    public void SetChild0TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild0TranslationValue(val);
    }
    public void SetChild0TranslationValue(float3 val)
    {
        Child0TranslationValueX = (int)(val.x * 100);
        Child0TranslationValueY = (int)(val.y * 100);
        Child0TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild1RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild1RotationValue();
    }
    public quaternion GetChild1RotationValue()
    {
        return new quaternion(Child1RotationValueX * 0.001f, Child1RotationValueY * 0.001f, Child1RotationValueZ * 0.001f, Child1RotationValueW * 0.001f);
    }
    public void SetChild1RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild1RotationValue(q);
    }
    public void SetChild1RotationValue(quaternion q)
    {
        Child1RotationValueX = (int)(q.value.x * 1000);
        Child1RotationValueY = (int)(q.value.y * 1000);
        Child1RotationValueZ = (int)(q.value.z * 1000);
        Child1RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild1TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild1TranslationValue();
    }
    public float3 GetChild1TranslationValue()
    {
        return new float3(Child1TranslationValueX * 0.01f, Child1TranslationValueY * 0.01f, Child1TranslationValueZ * 0.01f);
    }
    public void SetChild1TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild1TranslationValue(val);
    }
    public void SetChild1TranslationValue(float3 val)
    {
        Child1TranslationValueX = (int)(val.x * 100);
        Child1TranslationValueY = (int)(val.y * 100);
        Child1TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild2RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild2RotationValue();
    }
    public quaternion GetChild2RotationValue()
    {
        return new quaternion(Child2RotationValueX * 0.001f, Child2RotationValueY * 0.001f, Child2RotationValueZ * 0.001f, Child2RotationValueW * 0.001f);
    }
    public void SetChild2RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild2RotationValue(q);
    }
    public void SetChild2RotationValue(quaternion q)
    {
        Child2RotationValueX = (int)(q.value.x * 1000);
        Child2RotationValueY = (int)(q.value.y * 1000);
        Child2RotationValueZ = (int)(q.value.z * 1000);
        Child2RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild2TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild2TranslationValue();
    }
    public float3 GetChild2TranslationValue()
    {
        return new float3(Child2TranslationValueX * 0.01f, Child2TranslationValueY * 0.01f, Child2TranslationValueZ * 0.01f);
    }
    public void SetChild2TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild2TranslationValue(val);
    }
    public void SetChild2TranslationValue(float3 val)
    {
        Child2TranslationValueX = (int)(val.x * 100);
        Child2TranslationValueY = (int)(val.y * 100);
        Child2TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild3RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild3RotationValue();
    }
    public quaternion GetChild3RotationValue()
    {
        return new quaternion(Child3RotationValueX * 0.001f, Child3RotationValueY * 0.001f, Child3RotationValueZ * 0.001f, Child3RotationValueW * 0.001f);
    }
    public void SetChild3RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild3RotationValue(q);
    }
    public void SetChild3RotationValue(quaternion q)
    {
        Child3RotationValueX = (int)(q.value.x * 1000);
        Child3RotationValueY = (int)(q.value.y * 1000);
        Child3RotationValueZ = (int)(q.value.z * 1000);
        Child3RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild3TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild3TranslationValue();
    }
    public float3 GetChild3TranslationValue()
    {
        return new float3(Child3TranslationValueX * 0.01f, Child3TranslationValueY * 0.01f, Child3TranslationValueZ * 0.01f);
    }
    public void SetChild3TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild3TranslationValue(val);
    }
    public void SetChild3TranslationValue(float3 val)
    {
        Child3TranslationValueX = (int)(val.x * 100);
        Child3TranslationValueY = (int)(val.y * 100);
        Child3TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild4RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild4RotationValue();
    }
    public quaternion GetChild4RotationValue()
    {
        return new quaternion(Child4RotationValueX * 0.001f, Child4RotationValueY * 0.001f, Child4RotationValueZ * 0.001f, Child4RotationValueW * 0.001f);
    }
    public void SetChild4RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild4RotationValue(q);
    }
    public void SetChild4RotationValue(quaternion q)
    {
        Child4RotationValueX = (int)(q.value.x * 1000);
        Child4RotationValueY = (int)(q.value.y * 1000);
        Child4RotationValueZ = (int)(q.value.z * 1000);
        Child4RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild4TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild4TranslationValue();
    }
    public float3 GetChild4TranslationValue()
    {
        return new float3(Child4TranslationValueX * 0.01f, Child4TranslationValueY * 0.01f, Child4TranslationValueZ * 0.01f);
    }
    public void SetChild4TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild4TranslationValue(val);
    }
    public void SetChild4TranslationValue(float3 val)
    {
        Child4TranslationValueX = (int)(val.x * 100);
        Child4TranslationValueY = (int)(val.y * 100);
        Child4TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild5RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild5RotationValue();
    }
    public quaternion GetChild5RotationValue()
    {
        return new quaternion(Child5RotationValueX * 0.001f, Child5RotationValueY * 0.001f, Child5RotationValueZ * 0.001f, Child5RotationValueW * 0.001f);
    }
    public void SetChild5RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild5RotationValue(q);
    }
    public void SetChild5RotationValue(quaternion q)
    {
        Child5RotationValueX = (int)(q.value.x * 1000);
        Child5RotationValueY = (int)(q.value.y * 1000);
        Child5RotationValueZ = (int)(q.value.z * 1000);
        Child5RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild5TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild5TranslationValue();
    }
    public float3 GetChild5TranslationValue()
    {
        return new float3(Child5TranslationValueX * 0.01f, Child5TranslationValueY * 0.01f, Child5TranslationValueZ * 0.01f);
    }
    public void SetChild5TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild5TranslationValue(val);
    }
    public void SetChild5TranslationValue(float3 val)
    {
        Child5TranslationValueX = (int)(val.x * 100);
        Child5TranslationValueY = (int)(val.y * 100);
        Child5TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild6RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild6RotationValue();
    }
    public quaternion GetChild6RotationValue()
    {
        return new quaternion(Child6RotationValueX * 0.001f, Child6RotationValueY * 0.001f, Child6RotationValueZ * 0.001f, Child6RotationValueW * 0.001f);
    }
    public void SetChild6RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild6RotationValue(q);
    }
    public void SetChild6RotationValue(quaternion q)
    {
        Child6RotationValueX = (int)(q.value.x * 1000);
        Child6RotationValueY = (int)(q.value.y * 1000);
        Child6RotationValueZ = (int)(q.value.z * 1000);
        Child6RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild6TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild6TranslationValue();
    }
    public float3 GetChild6TranslationValue()
    {
        return new float3(Child6TranslationValueX * 0.01f, Child6TranslationValueY * 0.01f, Child6TranslationValueZ * 0.01f);
    }
    public void SetChild6TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild6TranslationValue(val);
    }
    public void SetChild6TranslationValue(float3 val)
    {
        Child6TranslationValueX = (int)(val.x * 100);
        Child6TranslationValueY = (int)(val.y * 100);
        Child6TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild7RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild7RotationValue();
    }
    public quaternion GetChild7RotationValue()
    {
        return new quaternion(Child7RotationValueX * 0.001f, Child7RotationValueY * 0.001f, Child7RotationValueZ * 0.001f, Child7RotationValueW * 0.001f);
    }
    public void SetChild7RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild7RotationValue(q);
    }
    public void SetChild7RotationValue(quaternion q)
    {
        Child7RotationValueX = (int)(q.value.x * 1000);
        Child7RotationValueY = (int)(q.value.y * 1000);
        Child7RotationValueZ = (int)(q.value.z * 1000);
        Child7RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild7TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild7TranslationValue();
    }
    public float3 GetChild7TranslationValue()
    {
        return new float3(Child7TranslationValueX * 0.01f, Child7TranslationValueY * 0.01f, Child7TranslationValueZ * 0.01f);
    }
    public void SetChild7TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild7TranslationValue(val);
    }
    public void SetChild7TranslationValue(float3 val)
    {
        Child7TranslationValueX = (int)(val.x * 100);
        Child7TranslationValueY = (int)(val.y * 100);
        Child7TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild8RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild8RotationValue();
    }
    public quaternion GetChild8RotationValue()
    {
        return new quaternion(Child8RotationValueX * 0.001f, Child8RotationValueY * 0.001f, Child8RotationValueZ * 0.001f, Child8RotationValueW * 0.001f);
    }
    public void SetChild8RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild8RotationValue(q);
    }
    public void SetChild8RotationValue(quaternion q)
    {
        Child8RotationValueX = (int)(q.value.x * 1000);
        Child8RotationValueY = (int)(q.value.y * 1000);
        Child8RotationValueZ = (int)(q.value.z * 1000);
        Child8RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild8TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild8TranslationValue();
    }
    public float3 GetChild8TranslationValue()
    {
        return new float3(Child8TranslationValueX * 0.01f, Child8TranslationValueY * 0.01f, Child8TranslationValueZ * 0.01f);
    }
    public void SetChild8TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild8TranslationValue(val);
    }
    public void SetChild8TranslationValue(float3 val)
    {
        Child8TranslationValueX = (int)(val.x * 100);
        Child8TranslationValueY = (int)(val.y * 100);
        Child8TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild9RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild9RotationValue();
    }
    public quaternion GetChild9RotationValue()
    {
        return new quaternion(Child9RotationValueX * 0.001f, Child9RotationValueY * 0.001f, Child9RotationValueZ * 0.001f, Child9RotationValueW * 0.001f);
    }
    public void SetChild9RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild9RotationValue(q);
    }
    public void SetChild9RotationValue(quaternion q)
    {
        Child9RotationValueX = (int)(q.value.x * 1000);
        Child9RotationValueY = (int)(q.value.y * 1000);
        Child9RotationValueZ = (int)(q.value.z * 1000);
        Child9RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild9TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild9TranslationValue();
    }
    public float3 GetChild9TranslationValue()
    {
        return new float3(Child9TranslationValueX * 0.01f, Child9TranslationValueY * 0.01f, Child9TranslationValueZ * 0.01f);
    }
    public void SetChild9TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild9TranslationValue(val);
    }
    public void SetChild9TranslationValue(float3 val)
    {
        Child9TranslationValueX = (int)(val.x * 100);
        Child9TranslationValueY = (int)(val.y * 100);
        Child9TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild10RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild10RotationValue();
    }
    public quaternion GetChild10RotationValue()
    {
        return new quaternion(Child10RotationValueX * 0.001f, Child10RotationValueY * 0.001f, Child10RotationValueZ * 0.001f, Child10RotationValueW * 0.001f);
    }
    public void SetChild10RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild10RotationValue(q);
    }
    public void SetChild10RotationValue(quaternion q)
    {
        Child10RotationValueX = (int)(q.value.x * 1000);
        Child10RotationValueY = (int)(q.value.y * 1000);
        Child10RotationValueZ = (int)(q.value.z * 1000);
        Child10RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild10TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild10TranslationValue();
    }
    public float3 GetChild10TranslationValue()
    {
        return new float3(Child10TranslationValueX * 0.01f, Child10TranslationValueY * 0.01f, Child10TranslationValueZ * 0.01f);
    }
    public void SetChild10TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild10TranslationValue(val);
    }
    public void SetChild10TranslationValue(float3 val)
    {
        Child10TranslationValueX = (int)(val.x * 100);
        Child10TranslationValueY = (int)(val.y * 100);
        Child10TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild11RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild11RotationValue();
    }
    public quaternion GetChild11RotationValue()
    {
        return new quaternion(Child11RotationValueX * 0.001f, Child11RotationValueY * 0.001f, Child11RotationValueZ * 0.001f, Child11RotationValueW * 0.001f);
    }
    public void SetChild11RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild11RotationValue(q);
    }
    public void SetChild11RotationValue(quaternion q)
    {
        Child11RotationValueX = (int)(q.value.x * 1000);
        Child11RotationValueY = (int)(q.value.y * 1000);
        Child11RotationValueZ = (int)(q.value.z * 1000);
        Child11RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild11TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild11TranslationValue();
    }
    public float3 GetChild11TranslationValue()
    {
        return new float3(Child11TranslationValueX * 0.01f, Child11TranslationValueY * 0.01f, Child11TranslationValueZ * 0.01f);
    }
    public void SetChild11TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild11TranslationValue(val);
    }
    public void SetChild11TranslationValue(float3 val)
    {
        Child11TranslationValueX = (int)(val.x * 100);
        Child11TranslationValueY = (int)(val.y * 100);
        Child11TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild12RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild12RotationValue();
    }
    public quaternion GetChild12RotationValue()
    {
        return new quaternion(Child12RotationValueX * 0.001f, Child12RotationValueY * 0.001f, Child12RotationValueZ * 0.001f, Child12RotationValueW * 0.001f);
    }
    public void SetChild12RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild12RotationValue(q);
    }
    public void SetChild12RotationValue(quaternion q)
    {
        Child12RotationValueX = (int)(q.value.x * 1000);
        Child12RotationValueY = (int)(q.value.y * 1000);
        Child12RotationValueZ = (int)(q.value.z * 1000);
        Child12RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild12TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild12TranslationValue();
    }
    public float3 GetChild12TranslationValue()
    {
        return new float3(Child12TranslationValueX * 0.01f, Child12TranslationValueY * 0.01f, Child12TranslationValueZ * 0.01f);
    }
    public void SetChild12TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild12TranslationValue(val);
    }
    public void SetChild12TranslationValue(float3 val)
    {
        Child12TranslationValueX = (int)(val.x * 100);
        Child12TranslationValueY = (int)(val.y * 100);
        Child12TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild13RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild13RotationValue();
    }
    public quaternion GetChild13RotationValue()
    {
        return new quaternion(Child13RotationValueX * 0.001f, Child13RotationValueY * 0.001f, Child13RotationValueZ * 0.001f, Child13RotationValueW * 0.001f);
    }
    public void SetChild13RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild13RotationValue(q);
    }
    public void SetChild13RotationValue(quaternion q)
    {
        Child13RotationValueX = (int)(q.value.x * 1000);
        Child13RotationValueY = (int)(q.value.y * 1000);
        Child13RotationValueZ = (int)(q.value.z * 1000);
        Child13RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild13TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild13TranslationValue();
    }
    public float3 GetChild13TranslationValue()
    {
        return new float3(Child13TranslationValueX * 0.01f, Child13TranslationValueY * 0.01f, Child13TranslationValueZ * 0.01f);
    }
    public void SetChild13TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild13TranslationValue(val);
    }
    public void SetChild13TranslationValue(float3 val)
    {
        Child13TranslationValueX = (int)(val.x * 100);
        Child13TranslationValueY = (int)(val.y * 100);
        Child13TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild14RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild14RotationValue();
    }
    public quaternion GetChild14RotationValue()
    {
        return new quaternion(Child14RotationValueX * 0.001f, Child14RotationValueY * 0.001f, Child14RotationValueZ * 0.001f, Child14RotationValueW * 0.001f);
    }
    public void SetChild14RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild14RotationValue(q);
    }
    public void SetChild14RotationValue(quaternion q)
    {
        Child14RotationValueX = (int)(q.value.x * 1000);
        Child14RotationValueY = (int)(q.value.y * 1000);
        Child14RotationValueZ = (int)(q.value.z * 1000);
        Child14RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild14TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild14TranslationValue();
    }
    public float3 GetChild14TranslationValue()
    {
        return new float3(Child14TranslationValueX * 0.01f, Child14TranslationValueY * 0.01f, Child14TranslationValueZ * 0.01f);
    }
    public void SetChild14TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild14TranslationValue(val);
    }
    public void SetChild14TranslationValue(float3 val)
    {
        Child14TranslationValueX = (int)(val.x * 100);
        Child14TranslationValueY = (int)(val.y * 100);
        Child14TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild15RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild15RotationValue();
    }
    public quaternion GetChild15RotationValue()
    {
        return new quaternion(Child15RotationValueX * 0.001f, Child15RotationValueY * 0.001f, Child15RotationValueZ * 0.001f, Child15RotationValueW * 0.001f);
    }
    public void SetChild15RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild15RotationValue(q);
    }
    public void SetChild15RotationValue(quaternion q)
    {
        Child15RotationValueX = (int)(q.value.x * 1000);
        Child15RotationValueY = (int)(q.value.y * 1000);
        Child15RotationValueZ = (int)(q.value.z * 1000);
        Child15RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild15TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild15TranslationValue();
    }
    public float3 GetChild15TranslationValue()
    {
        return new float3(Child15TranslationValueX * 0.01f, Child15TranslationValueY * 0.01f, Child15TranslationValueZ * 0.01f);
    }
    public void SetChild15TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild15TranslationValue(val);
    }
    public void SetChild15TranslationValue(float3 val)
    {
        Child15TranslationValueX = (int)(val.x * 100);
        Child15TranslationValueY = (int)(val.y * 100);
        Child15TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild16RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild16RotationValue();
    }
    public quaternion GetChild16RotationValue()
    {
        return new quaternion(Child16RotationValueX * 0.001f, Child16RotationValueY * 0.001f, Child16RotationValueZ * 0.001f, Child16RotationValueW * 0.001f);
    }
    public void SetChild16RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild16RotationValue(q);
    }
    public void SetChild16RotationValue(quaternion q)
    {
        Child16RotationValueX = (int)(q.value.x * 1000);
        Child16RotationValueY = (int)(q.value.y * 1000);
        Child16RotationValueZ = (int)(q.value.z * 1000);
        Child16RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild16TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild16TranslationValue();
    }
    public float3 GetChild16TranslationValue()
    {
        return new float3(Child16TranslationValueX * 0.01f, Child16TranslationValueY * 0.01f, Child16TranslationValueZ * 0.01f);
    }
    public void SetChild16TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild16TranslationValue(val);
    }
    public void SetChild16TranslationValue(float3 val)
    {
        Child16TranslationValueX = (int)(val.x * 100);
        Child16TranslationValueY = (int)(val.y * 100);
        Child16TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild17RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild17RotationValue();
    }
    public quaternion GetChild17RotationValue()
    {
        return new quaternion(Child17RotationValueX * 0.001f, Child17RotationValueY * 0.001f, Child17RotationValueZ * 0.001f, Child17RotationValueW * 0.001f);
    }
    public void SetChild17RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild17RotationValue(q);
    }
    public void SetChild17RotationValue(quaternion q)
    {
        Child17RotationValueX = (int)(q.value.x * 1000);
        Child17RotationValueY = (int)(q.value.y * 1000);
        Child17RotationValueZ = (int)(q.value.z * 1000);
        Child17RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild17TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild17TranslationValue();
    }
    public float3 GetChild17TranslationValue()
    {
        return new float3(Child17TranslationValueX * 0.01f, Child17TranslationValueY * 0.01f, Child17TranslationValueZ * 0.01f);
    }
    public void SetChild17TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild17TranslationValue(val);
    }
    public void SetChild17TranslationValue(float3 val)
    {
        Child17TranslationValueX = (int)(val.x * 100);
        Child17TranslationValueY = (int)(val.y * 100);
        Child17TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild18RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild18RotationValue();
    }
    public quaternion GetChild18RotationValue()
    {
        return new quaternion(Child18RotationValueX * 0.001f, Child18RotationValueY * 0.001f, Child18RotationValueZ * 0.001f, Child18RotationValueW * 0.001f);
    }
    public void SetChild18RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild18RotationValue(q);
    }
    public void SetChild18RotationValue(quaternion q)
    {
        Child18RotationValueX = (int)(q.value.x * 1000);
        Child18RotationValueY = (int)(q.value.y * 1000);
        Child18RotationValueZ = (int)(q.value.z * 1000);
        Child18RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild18TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild18TranslationValue();
    }
    public float3 GetChild18TranslationValue()
    {
        return new float3(Child18TranslationValueX * 0.01f, Child18TranslationValueY * 0.01f, Child18TranslationValueZ * 0.01f);
    }
    public void SetChild18TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild18TranslationValue(val);
    }
    public void SetChild18TranslationValue(float3 val)
    {
        Child18TranslationValueX = (int)(val.x * 100);
        Child18TranslationValueY = (int)(val.y * 100);
        Child18TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild19RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild19RotationValue();
    }
    public quaternion GetChild19RotationValue()
    {
        return new quaternion(Child19RotationValueX * 0.001f, Child19RotationValueY * 0.001f, Child19RotationValueZ * 0.001f, Child19RotationValueW * 0.001f);
    }
    public void SetChild19RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild19RotationValue(q);
    }
    public void SetChild19RotationValue(quaternion q)
    {
        Child19RotationValueX = (int)(q.value.x * 1000);
        Child19RotationValueY = (int)(q.value.y * 1000);
        Child19RotationValueZ = (int)(q.value.z * 1000);
        Child19RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild19TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild19TranslationValue();
    }
    public float3 GetChild19TranslationValue()
    {
        return new float3(Child19TranslationValueX * 0.01f, Child19TranslationValueY * 0.01f, Child19TranslationValueZ * 0.01f);
    }
    public void SetChild19TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild19TranslationValue(val);
    }
    public void SetChild19TranslationValue(float3 val)
    {
        Child19TranslationValueX = (int)(val.x * 100);
        Child19TranslationValueY = (int)(val.y * 100);
        Child19TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild20RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild20RotationValue();
    }
    public quaternion GetChild20RotationValue()
    {
        return new quaternion(Child20RotationValueX * 0.001f, Child20RotationValueY * 0.001f, Child20RotationValueZ * 0.001f, Child20RotationValueW * 0.001f);
    }
    public void SetChild20RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild20RotationValue(q);
    }
    public void SetChild20RotationValue(quaternion q)
    {
        Child20RotationValueX = (int)(q.value.x * 1000);
        Child20RotationValueY = (int)(q.value.y * 1000);
        Child20RotationValueZ = (int)(q.value.z * 1000);
        Child20RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild20TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild20TranslationValue();
    }
    public float3 GetChild20TranslationValue()
    {
        return new float3(Child20TranslationValueX * 0.01f, Child20TranslationValueY * 0.01f, Child20TranslationValueZ * 0.01f);
    }
    public void SetChild20TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild20TranslationValue(val);
    }
    public void SetChild20TranslationValue(float3 val)
    {
        Child20TranslationValueX = (int)(val.x * 100);
        Child20TranslationValueY = (int)(val.y * 100);
        Child20TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild21RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild21RotationValue();
    }
    public quaternion GetChild21RotationValue()
    {
        return new quaternion(Child21RotationValueX * 0.001f, Child21RotationValueY * 0.001f, Child21RotationValueZ * 0.001f, Child21RotationValueW * 0.001f);
    }
    public void SetChild21RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild21RotationValue(q);
    }
    public void SetChild21RotationValue(quaternion q)
    {
        Child21RotationValueX = (int)(q.value.x * 1000);
        Child21RotationValueY = (int)(q.value.y * 1000);
        Child21RotationValueZ = (int)(q.value.z * 1000);
        Child21RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild21TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild21TranslationValue();
    }
    public float3 GetChild21TranslationValue()
    {
        return new float3(Child21TranslationValueX * 0.01f, Child21TranslationValueY * 0.01f, Child21TranslationValueZ * 0.01f);
    }
    public void SetChild21TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild21TranslationValue(val);
    }
    public void SetChild21TranslationValue(float3 val)
    {
        Child21TranslationValueX = (int)(val.x * 100);
        Child21TranslationValueY = (int)(val.y * 100);
        Child21TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild22RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild22RotationValue();
    }
    public quaternion GetChild22RotationValue()
    {
        return new quaternion(Child22RotationValueX * 0.001f, Child22RotationValueY * 0.001f, Child22RotationValueZ * 0.001f, Child22RotationValueW * 0.001f);
    }
    public void SetChild22RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild22RotationValue(q);
    }
    public void SetChild22RotationValue(quaternion q)
    {
        Child22RotationValueX = (int)(q.value.x * 1000);
        Child22RotationValueY = (int)(q.value.y * 1000);
        Child22RotationValueZ = (int)(q.value.z * 1000);
        Child22RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild22TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild22TranslationValue();
    }
    public float3 GetChild22TranslationValue()
    {
        return new float3(Child22TranslationValueX * 0.01f, Child22TranslationValueY * 0.01f, Child22TranslationValueZ * 0.01f);
    }
    public void SetChild22TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild22TranslationValue(val);
    }
    public void SetChild22TranslationValue(float3 val)
    {
        Child22TranslationValueX = (int)(val.x * 100);
        Child22TranslationValueY = (int)(val.y * 100);
        Child22TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild23RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild23RotationValue();
    }
    public quaternion GetChild23RotationValue()
    {
        return new quaternion(Child23RotationValueX * 0.001f, Child23RotationValueY * 0.001f, Child23RotationValueZ * 0.001f, Child23RotationValueW * 0.001f);
    }
    public void SetChild23RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild23RotationValue(q);
    }
    public void SetChild23RotationValue(quaternion q)
    {
        Child23RotationValueX = (int)(q.value.x * 1000);
        Child23RotationValueY = (int)(q.value.y * 1000);
        Child23RotationValueZ = (int)(q.value.z * 1000);
        Child23RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild23TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild23TranslationValue();
    }
    public float3 GetChild23TranslationValue()
    {
        return new float3(Child23TranslationValueX * 0.01f, Child23TranslationValueY * 0.01f, Child23TranslationValueZ * 0.01f);
    }
    public void SetChild23TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild23TranslationValue(val);
    }
    public void SetChild23TranslationValue(float3 val)
    {
        Child23TranslationValueX = (int)(val.x * 100);
        Child23TranslationValueY = (int)(val.y * 100);
        Child23TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild24RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild24RotationValue();
    }
    public quaternion GetChild24RotationValue()
    {
        return new quaternion(Child24RotationValueX * 0.001f, Child24RotationValueY * 0.001f, Child24RotationValueZ * 0.001f, Child24RotationValueW * 0.001f);
    }
    public void SetChild24RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild24RotationValue(q);
    }
    public void SetChild24RotationValue(quaternion q)
    {
        Child24RotationValueX = (int)(q.value.x * 1000);
        Child24RotationValueY = (int)(q.value.y * 1000);
        Child24RotationValueZ = (int)(q.value.z * 1000);
        Child24RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild24TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild24TranslationValue();
    }
    public float3 GetChild24TranslationValue()
    {
        return new float3(Child24TranslationValueX * 0.01f, Child24TranslationValueY * 0.01f, Child24TranslationValueZ * 0.01f);
    }
    public void SetChild24TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild24TranslationValue(val);
    }
    public void SetChild24TranslationValue(float3 val)
    {
        Child24TranslationValueX = (int)(val.x * 100);
        Child24TranslationValueY = (int)(val.y * 100);
        Child24TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild25RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild25RotationValue();
    }
    public quaternion GetChild25RotationValue()
    {
        return new quaternion(Child25RotationValueX * 0.001f, Child25RotationValueY * 0.001f, Child25RotationValueZ * 0.001f, Child25RotationValueW * 0.001f);
    }
    public void SetChild25RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild25RotationValue(q);
    }
    public void SetChild25RotationValue(quaternion q)
    {
        Child25RotationValueX = (int)(q.value.x * 1000);
        Child25RotationValueY = (int)(q.value.y * 1000);
        Child25RotationValueZ = (int)(q.value.z * 1000);
        Child25RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild25TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild25TranslationValue();
    }
    public float3 GetChild25TranslationValue()
    {
        return new float3(Child25TranslationValueX * 0.01f, Child25TranslationValueY * 0.01f, Child25TranslationValueZ * 0.01f);
    }
    public void SetChild25TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild25TranslationValue(val);
    }
    public void SetChild25TranslationValue(float3 val)
    {
        Child25TranslationValueX = (int)(val.x * 100);
        Child25TranslationValueY = (int)(val.y * 100);
        Child25TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild26RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild26RotationValue();
    }
    public quaternion GetChild26RotationValue()
    {
        return new quaternion(Child26RotationValueX * 0.001f, Child26RotationValueY * 0.001f, Child26RotationValueZ * 0.001f, Child26RotationValueW * 0.001f);
    }
    public void SetChild26RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild26RotationValue(q);
    }
    public void SetChild26RotationValue(quaternion q)
    {
        Child26RotationValueX = (int)(q.value.x * 1000);
        Child26RotationValueY = (int)(q.value.y * 1000);
        Child26RotationValueZ = (int)(q.value.z * 1000);
        Child26RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild26TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild26TranslationValue();
    }
    public float3 GetChild26TranslationValue()
    {
        return new float3(Child26TranslationValueX * 0.01f, Child26TranslationValueY * 0.01f, Child26TranslationValueZ * 0.01f);
    }
    public void SetChild26TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild26TranslationValue(val);
    }
    public void SetChild26TranslationValue(float3 val)
    {
        Child26TranslationValueX = (int)(val.x * 100);
        Child26TranslationValueY = (int)(val.y * 100);
        Child26TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild27RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild27RotationValue();
    }
    public quaternion GetChild27RotationValue()
    {
        return new quaternion(Child27RotationValueX * 0.001f, Child27RotationValueY * 0.001f, Child27RotationValueZ * 0.001f, Child27RotationValueW * 0.001f);
    }
    public void SetChild27RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild27RotationValue(q);
    }
    public void SetChild27RotationValue(quaternion q)
    {
        Child27RotationValueX = (int)(q.value.x * 1000);
        Child27RotationValueY = (int)(q.value.y * 1000);
        Child27RotationValueZ = (int)(q.value.z * 1000);
        Child27RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild27TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild27TranslationValue();
    }
    public float3 GetChild27TranslationValue()
    {
        return new float3(Child27TranslationValueX * 0.01f, Child27TranslationValueY * 0.01f, Child27TranslationValueZ * 0.01f);
    }
    public void SetChild27TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild27TranslationValue(val);
    }
    public void SetChild27TranslationValue(float3 val)
    {
        Child27TranslationValueX = (int)(val.x * 100);
        Child27TranslationValueY = (int)(val.y * 100);
        Child27TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild28RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild28RotationValue();
    }
    public quaternion GetChild28RotationValue()
    {
        return new quaternion(Child28RotationValueX * 0.001f, Child28RotationValueY * 0.001f, Child28RotationValueZ * 0.001f, Child28RotationValueW * 0.001f);
    }
    public void SetChild28RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild28RotationValue(q);
    }
    public void SetChild28RotationValue(quaternion q)
    {
        Child28RotationValueX = (int)(q.value.x * 1000);
        Child28RotationValueY = (int)(q.value.y * 1000);
        Child28RotationValueZ = (int)(q.value.z * 1000);
        Child28RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild28TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild28TranslationValue();
    }
    public float3 GetChild28TranslationValue()
    {
        return new float3(Child28TranslationValueX * 0.01f, Child28TranslationValueY * 0.01f, Child28TranslationValueZ * 0.01f);
    }
    public void SetChild28TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild28TranslationValue(val);
    }
    public void SetChild28TranslationValue(float3 val)
    {
        Child28TranslationValueX = (int)(val.x * 100);
        Child28TranslationValueY = (int)(val.y * 100);
        Child28TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild29RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild29RotationValue();
    }
    public quaternion GetChild29RotationValue()
    {
        return new quaternion(Child29RotationValueX * 0.001f, Child29RotationValueY * 0.001f, Child29RotationValueZ * 0.001f, Child29RotationValueW * 0.001f);
    }
    public void SetChild29RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild29RotationValue(q);
    }
    public void SetChild29RotationValue(quaternion q)
    {
        Child29RotationValueX = (int)(q.value.x * 1000);
        Child29RotationValueY = (int)(q.value.y * 1000);
        Child29RotationValueZ = (int)(q.value.z * 1000);
        Child29RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild29TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild29TranslationValue();
    }
    public float3 GetChild29TranslationValue()
    {
        return new float3(Child29TranslationValueX * 0.01f, Child29TranslationValueY * 0.01f, Child29TranslationValueZ * 0.01f);
    }
    public void SetChild29TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild29TranslationValue(val);
    }
    public void SetChild29TranslationValue(float3 val)
    {
        Child29TranslationValueX = (int)(val.x * 100);
        Child29TranslationValueY = (int)(val.y * 100);
        Child29TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild30RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild30RotationValue();
    }
    public quaternion GetChild30RotationValue()
    {
        return new quaternion(Child30RotationValueX * 0.001f, Child30RotationValueY * 0.001f, Child30RotationValueZ * 0.001f, Child30RotationValueW * 0.001f);
    }
    public void SetChild30RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild30RotationValue(q);
    }
    public void SetChild30RotationValue(quaternion q)
    {
        Child30RotationValueX = (int)(q.value.x * 1000);
        Child30RotationValueY = (int)(q.value.y * 1000);
        Child30RotationValueZ = (int)(q.value.z * 1000);
        Child30RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild30TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild30TranslationValue();
    }
    public float3 GetChild30TranslationValue()
    {
        return new float3(Child30TranslationValueX * 0.01f, Child30TranslationValueY * 0.01f, Child30TranslationValueZ * 0.01f);
    }
    public void SetChild30TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild30TranslationValue(val);
    }
    public void SetChild30TranslationValue(float3 val)
    {
        Child30TranslationValueX = (int)(val.x * 100);
        Child30TranslationValueY = (int)(val.y * 100);
        Child30TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild31RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild31RotationValue();
    }
    public quaternion GetChild31RotationValue()
    {
        return new quaternion(Child31RotationValueX * 0.001f, Child31RotationValueY * 0.001f, Child31RotationValueZ * 0.001f, Child31RotationValueW * 0.001f);
    }
    public void SetChild31RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild31RotationValue(q);
    }
    public void SetChild31RotationValue(quaternion q)
    {
        Child31RotationValueX = (int)(q.value.x * 1000);
        Child31RotationValueY = (int)(q.value.y * 1000);
        Child31RotationValueZ = (int)(q.value.z * 1000);
        Child31RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild31TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild31TranslationValue();
    }
    public float3 GetChild31TranslationValue()
    {
        return new float3(Child31TranslationValueX * 0.01f, Child31TranslationValueY * 0.01f, Child31TranslationValueZ * 0.01f);
    }
    public void SetChild31TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild31TranslationValue(val);
    }
    public void SetChild31TranslationValue(float3 val)
    {
        Child31TranslationValueX = (int)(val.x * 100);
        Child31TranslationValueY = (int)(val.y * 100);
        Child31TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild32RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild32RotationValue();
    }
    public quaternion GetChild32RotationValue()
    {
        return new quaternion(Child32RotationValueX * 0.001f, Child32RotationValueY * 0.001f, Child32RotationValueZ * 0.001f, Child32RotationValueW * 0.001f);
    }
    public void SetChild32RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild32RotationValue(q);
    }
    public void SetChild32RotationValue(quaternion q)
    {
        Child32RotationValueX = (int)(q.value.x * 1000);
        Child32RotationValueY = (int)(q.value.y * 1000);
        Child32RotationValueZ = (int)(q.value.z * 1000);
        Child32RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild32TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild32TranslationValue();
    }
    public float3 GetChild32TranslationValue()
    {
        return new float3(Child32TranslationValueX * 0.01f, Child32TranslationValueY * 0.01f, Child32TranslationValueZ * 0.01f);
    }
    public void SetChild32TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild32TranslationValue(val);
    }
    public void SetChild32TranslationValue(float3 val)
    {
        Child32TranslationValueX = (int)(val.x * 100);
        Child32TranslationValueY = (int)(val.y * 100);
        Child32TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild33RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild33RotationValue();
    }
    public quaternion GetChild33RotationValue()
    {
        return new quaternion(Child33RotationValueX * 0.001f, Child33RotationValueY * 0.001f, Child33RotationValueZ * 0.001f, Child33RotationValueW * 0.001f);
    }
    public void SetChild33RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild33RotationValue(q);
    }
    public void SetChild33RotationValue(quaternion q)
    {
        Child33RotationValueX = (int)(q.value.x * 1000);
        Child33RotationValueY = (int)(q.value.y * 1000);
        Child33RotationValueZ = (int)(q.value.z * 1000);
        Child33RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild33TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild33TranslationValue();
    }
    public float3 GetChild33TranslationValue()
    {
        return new float3(Child33TranslationValueX * 0.01f, Child33TranslationValueY * 0.01f, Child33TranslationValueZ * 0.01f);
    }
    public void SetChild33TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild33TranslationValue(val);
    }
    public void SetChild33TranslationValue(float3 val)
    {
        Child33TranslationValueX = (int)(val.x * 100);
        Child33TranslationValueY = (int)(val.y * 100);
        Child33TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild34RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild34RotationValue();
    }
    public quaternion GetChild34RotationValue()
    {
        return new quaternion(Child34RotationValueX * 0.001f, Child34RotationValueY * 0.001f, Child34RotationValueZ * 0.001f, Child34RotationValueW * 0.001f);
    }
    public void SetChild34RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild34RotationValue(q);
    }
    public void SetChild34RotationValue(quaternion q)
    {
        Child34RotationValueX = (int)(q.value.x * 1000);
        Child34RotationValueY = (int)(q.value.y * 1000);
        Child34RotationValueZ = (int)(q.value.z * 1000);
        Child34RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild34TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild34TranslationValue();
    }
    public float3 GetChild34TranslationValue()
    {
        return new float3(Child34TranslationValueX * 0.01f, Child34TranslationValueY * 0.01f, Child34TranslationValueZ * 0.01f);
    }
    public void SetChild34TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild34TranslationValue(val);
    }
    public void SetChild34TranslationValue(float3 val)
    {
        Child34TranslationValueX = (int)(val.x * 100);
        Child34TranslationValueY = (int)(val.y * 100);
        Child34TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild35RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild35RotationValue();
    }
    public quaternion GetChild35RotationValue()
    {
        return new quaternion(Child35RotationValueX * 0.001f, Child35RotationValueY * 0.001f, Child35RotationValueZ * 0.001f, Child35RotationValueW * 0.001f);
    }
    public void SetChild35RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild35RotationValue(q);
    }
    public void SetChild35RotationValue(quaternion q)
    {
        Child35RotationValueX = (int)(q.value.x * 1000);
        Child35RotationValueY = (int)(q.value.y * 1000);
        Child35RotationValueZ = (int)(q.value.z * 1000);
        Child35RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild35TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild35TranslationValue();
    }
    public float3 GetChild35TranslationValue()
    {
        return new float3(Child35TranslationValueX * 0.01f, Child35TranslationValueY * 0.01f, Child35TranslationValueZ * 0.01f);
    }
    public void SetChild35TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild35TranslationValue(val);
    }
    public void SetChild35TranslationValue(float3 val)
    {
        Child35TranslationValueX = (int)(val.x * 100);
        Child35TranslationValueY = (int)(val.y * 100);
        Child35TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild36RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild36RotationValue();
    }
    public quaternion GetChild36RotationValue()
    {
        return new quaternion(Child36RotationValueX * 0.001f, Child36RotationValueY * 0.001f, Child36RotationValueZ * 0.001f, Child36RotationValueW * 0.001f);
    }
    public void SetChild36RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild36RotationValue(q);
    }
    public void SetChild36RotationValue(quaternion q)
    {
        Child36RotationValueX = (int)(q.value.x * 1000);
        Child36RotationValueY = (int)(q.value.y * 1000);
        Child36RotationValueZ = (int)(q.value.z * 1000);
        Child36RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild36TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild36TranslationValue();
    }
    public float3 GetChild36TranslationValue()
    {
        return new float3(Child36TranslationValueX * 0.01f, Child36TranslationValueY * 0.01f, Child36TranslationValueZ * 0.01f);
    }
    public void SetChild36TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild36TranslationValue(val);
    }
    public void SetChild36TranslationValue(float3 val)
    {
        Child36TranslationValueX = (int)(val.x * 100);
        Child36TranslationValueY = (int)(val.y * 100);
        Child36TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild37RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild37RotationValue();
    }
    public quaternion GetChild37RotationValue()
    {
        return new quaternion(Child37RotationValueX * 0.001f, Child37RotationValueY * 0.001f, Child37RotationValueZ * 0.001f, Child37RotationValueW * 0.001f);
    }
    public void SetChild37RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild37RotationValue(q);
    }
    public void SetChild37RotationValue(quaternion q)
    {
        Child37RotationValueX = (int)(q.value.x * 1000);
        Child37RotationValueY = (int)(q.value.y * 1000);
        Child37RotationValueZ = (int)(q.value.z * 1000);
        Child37RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild37TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild37TranslationValue();
    }
    public float3 GetChild37TranslationValue()
    {
        return new float3(Child37TranslationValueX * 0.01f, Child37TranslationValueY * 0.01f, Child37TranslationValueZ * 0.01f);
    }
    public void SetChild37TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild37TranslationValue(val);
    }
    public void SetChild37TranslationValue(float3 val)
    {
        Child37TranslationValueX = (int)(val.x * 100);
        Child37TranslationValueY = (int)(val.y * 100);
        Child37TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild38RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild38RotationValue();
    }
    public quaternion GetChild38RotationValue()
    {
        return new quaternion(Child38RotationValueX * 0.001f, Child38RotationValueY * 0.001f, Child38RotationValueZ * 0.001f, Child38RotationValueW * 0.001f);
    }
    public void SetChild38RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild38RotationValue(q);
    }
    public void SetChild38RotationValue(quaternion q)
    {
        Child38RotationValueX = (int)(q.value.x * 1000);
        Child38RotationValueY = (int)(q.value.y * 1000);
        Child38RotationValueZ = (int)(q.value.z * 1000);
        Child38RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild38TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild38TranslationValue();
    }
    public float3 GetChild38TranslationValue()
    {
        return new float3(Child38TranslationValueX * 0.01f, Child38TranslationValueY * 0.01f, Child38TranslationValueZ * 0.01f);
    }
    public void SetChild38TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild38TranslationValue(val);
    }
    public void SetChild38TranslationValue(float3 val)
    {
        Child38TranslationValueX = (int)(val.x * 100);
        Child38TranslationValueY = (int)(val.y * 100);
        Child38TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild39RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild39RotationValue();
    }
    public quaternion GetChild39RotationValue()
    {
        return new quaternion(Child39RotationValueX * 0.001f, Child39RotationValueY * 0.001f, Child39RotationValueZ * 0.001f, Child39RotationValueW * 0.001f);
    }
    public void SetChild39RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild39RotationValue(q);
    }
    public void SetChild39RotationValue(quaternion q)
    {
        Child39RotationValueX = (int)(q.value.x * 1000);
        Child39RotationValueY = (int)(q.value.y * 1000);
        Child39RotationValueZ = (int)(q.value.z * 1000);
        Child39RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild39TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild39TranslationValue();
    }
    public float3 GetChild39TranslationValue()
    {
        return new float3(Child39TranslationValueX * 0.01f, Child39TranslationValueY * 0.01f, Child39TranslationValueZ * 0.01f);
    }
    public void SetChild39TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild39TranslationValue(val);
    }
    public void SetChild39TranslationValue(float3 val)
    {
        Child39TranslationValueX = (int)(val.x * 100);
        Child39TranslationValueY = (int)(val.y * 100);
        Child39TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild40RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild40RotationValue();
    }
    public quaternion GetChild40RotationValue()
    {
        return new quaternion(Child40RotationValueX * 0.001f, Child40RotationValueY * 0.001f, Child40RotationValueZ * 0.001f, Child40RotationValueW * 0.001f);
    }
    public void SetChild40RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild40RotationValue(q);
    }
    public void SetChild40RotationValue(quaternion q)
    {
        Child40RotationValueX = (int)(q.value.x * 1000);
        Child40RotationValueY = (int)(q.value.y * 1000);
        Child40RotationValueZ = (int)(q.value.z * 1000);
        Child40RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild40TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild40TranslationValue();
    }
    public float3 GetChild40TranslationValue()
    {
        return new float3(Child40TranslationValueX * 0.01f, Child40TranslationValueY * 0.01f, Child40TranslationValueZ * 0.01f);
    }
    public void SetChild40TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild40TranslationValue(val);
    }
    public void SetChild40TranslationValue(float3 val)
    {
        Child40TranslationValueX = (int)(val.x * 100);
        Child40TranslationValueY = (int)(val.y * 100);
        Child40TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild41RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild41RotationValue();
    }
    public quaternion GetChild41RotationValue()
    {
        return new quaternion(Child41RotationValueX * 0.001f, Child41RotationValueY * 0.001f, Child41RotationValueZ * 0.001f, Child41RotationValueW * 0.001f);
    }
    public void SetChild41RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild41RotationValue(q);
    }
    public void SetChild41RotationValue(quaternion q)
    {
        Child41RotationValueX = (int)(q.value.x * 1000);
        Child41RotationValueY = (int)(q.value.y * 1000);
        Child41RotationValueZ = (int)(q.value.z * 1000);
        Child41RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild41TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild41TranslationValue();
    }
    public float3 GetChild41TranslationValue()
    {
        return new float3(Child41TranslationValueX * 0.01f, Child41TranslationValueY * 0.01f, Child41TranslationValueZ * 0.01f);
    }
    public void SetChild41TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild41TranslationValue(val);
    }
    public void SetChild41TranslationValue(float3 val)
    {
        Child41TranslationValueX = (int)(val.x * 100);
        Child41TranslationValueY = (int)(val.y * 100);
        Child41TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild42RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild42RotationValue();
    }
    public quaternion GetChild42RotationValue()
    {
        return new quaternion(Child42RotationValueX * 0.001f, Child42RotationValueY * 0.001f, Child42RotationValueZ * 0.001f, Child42RotationValueW * 0.001f);
    }
    public void SetChild42RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild42RotationValue(q);
    }
    public void SetChild42RotationValue(quaternion q)
    {
        Child42RotationValueX = (int)(q.value.x * 1000);
        Child42RotationValueY = (int)(q.value.y * 1000);
        Child42RotationValueZ = (int)(q.value.z * 1000);
        Child42RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild42TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild42TranslationValue();
    }
    public float3 GetChild42TranslationValue()
    {
        return new float3(Child42TranslationValueX * 0.01f, Child42TranslationValueY * 0.01f, Child42TranslationValueZ * 0.01f);
    }
    public void SetChild42TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild42TranslationValue(val);
    }
    public void SetChild42TranslationValue(float3 val)
    {
        Child42TranslationValueX = (int)(val.x * 100);
        Child42TranslationValueY = (int)(val.y * 100);
        Child42TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild43RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild43RotationValue();
    }
    public quaternion GetChild43RotationValue()
    {
        return new quaternion(Child43RotationValueX * 0.001f, Child43RotationValueY * 0.001f, Child43RotationValueZ * 0.001f, Child43RotationValueW * 0.001f);
    }
    public void SetChild43RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild43RotationValue(q);
    }
    public void SetChild43RotationValue(quaternion q)
    {
        Child43RotationValueX = (int)(q.value.x * 1000);
        Child43RotationValueY = (int)(q.value.y * 1000);
        Child43RotationValueZ = (int)(q.value.z * 1000);
        Child43RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild43TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild43TranslationValue();
    }
    public float3 GetChild43TranslationValue()
    {
        return new float3(Child43TranslationValueX * 0.01f, Child43TranslationValueY * 0.01f, Child43TranslationValueZ * 0.01f);
    }
    public void SetChild43TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild43TranslationValue(val);
    }
    public void SetChild43TranslationValue(float3 val)
    {
        Child43TranslationValueX = (int)(val.x * 100);
        Child43TranslationValueY = (int)(val.y * 100);
        Child43TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild44RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild44RotationValue();
    }
    public quaternion GetChild44RotationValue()
    {
        return new quaternion(Child44RotationValueX * 0.001f, Child44RotationValueY * 0.001f, Child44RotationValueZ * 0.001f, Child44RotationValueW * 0.001f);
    }
    public void SetChild44RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild44RotationValue(q);
    }
    public void SetChild44RotationValue(quaternion q)
    {
        Child44RotationValueX = (int)(q.value.x * 1000);
        Child44RotationValueY = (int)(q.value.y * 1000);
        Child44RotationValueZ = (int)(q.value.z * 1000);
        Child44RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild44TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild44TranslationValue();
    }
    public float3 GetChild44TranslationValue()
    {
        return new float3(Child44TranslationValueX * 0.01f, Child44TranslationValueY * 0.01f, Child44TranslationValueZ * 0.01f);
    }
    public void SetChild44TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild44TranslationValue(val);
    }
    public void SetChild44TranslationValue(float3 val)
    {
        Child44TranslationValueX = (int)(val.x * 100);
        Child44TranslationValueY = (int)(val.y * 100);
        Child44TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild45RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild45RotationValue();
    }
    public quaternion GetChild45RotationValue()
    {
        return new quaternion(Child45RotationValueX * 0.001f, Child45RotationValueY * 0.001f, Child45RotationValueZ * 0.001f, Child45RotationValueW * 0.001f);
    }
    public void SetChild45RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild45RotationValue(q);
    }
    public void SetChild45RotationValue(quaternion q)
    {
        Child45RotationValueX = (int)(q.value.x * 1000);
        Child45RotationValueY = (int)(q.value.y * 1000);
        Child45RotationValueZ = (int)(q.value.z * 1000);
        Child45RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild45TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild45TranslationValue();
    }
    public float3 GetChild45TranslationValue()
    {
        return new float3(Child45TranslationValueX * 0.01f, Child45TranslationValueY * 0.01f, Child45TranslationValueZ * 0.01f);
    }
    public void SetChild45TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild45TranslationValue(val);
    }
    public void SetChild45TranslationValue(float3 val)
    {
        Child45TranslationValueX = (int)(val.x * 100);
        Child45TranslationValueY = (int)(val.y * 100);
        Child45TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild46RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild46RotationValue();
    }
    public quaternion GetChild46RotationValue()
    {
        return new quaternion(Child46RotationValueX * 0.001f, Child46RotationValueY * 0.001f, Child46RotationValueZ * 0.001f, Child46RotationValueW * 0.001f);
    }
    public void SetChild46RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild46RotationValue(q);
    }
    public void SetChild46RotationValue(quaternion q)
    {
        Child46RotationValueX = (int)(q.value.x * 1000);
        Child46RotationValueY = (int)(q.value.y * 1000);
        Child46RotationValueZ = (int)(q.value.z * 1000);
        Child46RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild46TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild46TranslationValue();
    }
    public float3 GetChild46TranslationValue()
    {
        return new float3(Child46TranslationValueX * 0.01f, Child46TranslationValueY * 0.01f, Child46TranslationValueZ * 0.01f);
    }
    public void SetChild46TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild46TranslationValue(val);
    }
    public void SetChild46TranslationValue(float3 val)
    {
        Child46TranslationValueX = (int)(val.x * 100);
        Child46TranslationValueY = (int)(val.y * 100);
        Child46TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild47RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild47RotationValue();
    }
    public quaternion GetChild47RotationValue()
    {
        return new quaternion(Child47RotationValueX * 0.001f, Child47RotationValueY * 0.001f, Child47RotationValueZ * 0.001f, Child47RotationValueW * 0.001f);
    }
    public void SetChild47RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild47RotationValue(q);
    }
    public void SetChild47RotationValue(quaternion q)
    {
        Child47RotationValueX = (int)(q.value.x * 1000);
        Child47RotationValueY = (int)(q.value.y * 1000);
        Child47RotationValueZ = (int)(q.value.z * 1000);
        Child47RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild47TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild47TranslationValue();
    }
    public float3 GetChild47TranslationValue()
    {
        return new float3(Child47TranslationValueX * 0.01f, Child47TranslationValueY * 0.01f, Child47TranslationValueZ * 0.01f);
    }
    public void SetChild47TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild47TranslationValue(val);
    }
    public void SetChild47TranslationValue(float3 val)
    {
        Child47TranslationValueX = (int)(val.x * 100);
        Child47TranslationValueY = (int)(val.y * 100);
        Child47TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild48RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild48RotationValue();
    }
    public quaternion GetChild48RotationValue()
    {
        return new quaternion(Child48RotationValueX * 0.001f, Child48RotationValueY * 0.001f, Child48RotationValueZ * 0.001f, Child48RotationValueW * 0.001f);
    }
    public void SetChild48RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild48RotationValue(q);
    }
    public void SetChild48RotationValue(quaternion q)
    {
        Child48RotationValueX = (int)(q.value.x * 1000);
        Child48RotationValueY = (int)(q.value.y * 1000);
        Child48RotationValueZ = (int)(q.value.z * 1000);
        Child48RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild48TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild48TranslationValue();
    }
    public float3 GetChild48TranslationValue()
    {
        return new float3(Child48TranslationValueX * 0.01f, Child48TranslationValueY * 0.01f, Child48TranslationValueZ * 0.01f);
    }
    public void SetChild48TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild48TranslationValue(val);
    }
    public void SetChild48TranslationValue(float3 val)
    {
        Child48TranslationValueX = (int)(val.x * 100);
        Child48TranslationValueY = (int)(val.y * 100);
        Child48TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild49RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild49RotationValue();
    }
    public quaternion GetChild49RotationValue()
    {
        return new quaternion(Child49RotationValueX * 0.001f, Child49RotationValueY * 0.001f, Child49RotationValueZ * 0.001f, Child49RotationValueW * 0.001f);
    }
    public void SetChild49RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild49RotationValue(q);
    }
    public void SetChild49RotationValue(quaternion q)
    {
        Child49RotationValueX = (int)(q.value.x * 1000);
        Child49RotationValueY = (int)(q.value.y * 1000);
        Child49RotationValueZ = (int)(q.value.z * 1000);
        Child49RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild49TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild49TranslationValue();
    }
    public float3 GetChild49TranslationValue()
    {
        return new float3(Child49TranslationValueX * 0.01f, Child49TranslationValueY * 0.01f, Child49TranslationValueZ * 0.01f);
    }
    public void SetChild49TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild49TranslationValue(val);
    }
    public void SetChild49TranslationValue(float3 val)
    {
        Child49TranslationValueX = (int)(val.x * 100);
        Child49TranslationValueY = (int)(val.y * 100);
        Child49TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild50RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild50RotationValue();
    }
    public quaternion GetChild50RotationValue()
    {
        return new quaternion(Child50RotationValueX * 0.001f, Child50RotationValueY * 0.001f, Child50RotationValueZ * 0.001f, Child50RotationValueW * 0.001f);
    }
    public void SetChild50RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild50RotationValue(q);
    }
    public void SetChild50RotationValue(quaternion q)
    {
        Child50RotationValueX = (int)(q.value.x * 1000);
        Child50RotationValueY = (int)(q.value.y * 1000);
        Child50RotationValueZ = (int)(q.value.z * 1000);
        Child50RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild50TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild50TranslationValue();
    }
    public float3 GetChild50TranslationValue()
    {
        return new float3(Child50TranslationValueX * 0.01f, Child50TranslationValueY * 0.01f, Child50TranslationValueZ * 0.01f);
    }
    public void SetChild50TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild50TranslationValue(val);
    }
    public void SetChild50TranslationValue(float3 val)
    {
        Child50TranslationValueX = (int)(val.x * 100);
        Child50TranslationValueY = (int)(val.y * 100);
        Child50TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild51RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild51RotationValue();
    }
    public quaternion GetChild51RotationValue()
    {
        return new quaternion(Child51RotationValueX * 0.001f, Child51RotationValueY * 0.001f, Child51RotationValueZ * 0.001f, Child51RotationValueW * 0.001f);
    }
    public void SetChild51RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild51RotationValue(q);
    }
    public void SetChild51RotationValue(quaternion q)
    {
        Child51RotationValueX = (int)(q.value.x * 1000);
        Child51RotationValueY = (int)(q.value.y * 1000);
        Child51RotationValueZ = (int)(q.value.z * 1000);
        Child51RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild51TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild51TranslationValue();
    }
    public float3 GetChild51TranslationValue()
    {
        return new float3(Child51TranslationValueX * 0.01f, Child51TranslationValueY * 0.01f, Child51TranslationValueZ * 0.01f);
    }
    public void SetChild51TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild51TranslationValue(val);
    }
    public void SetChild51TranslationValue(float3 val)
    {
        Child51TranslationValueX = (int)(val.x * 100);
        Child51TranslationValueY = (int)(val.y * 100);
        Child51TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild52RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild52RotationValue();
    }
    public quaternion GetChild52RotationValue()
    {
        return new quaternion(Child52RotationValueX * 0.001f, Child52RotationValueY * 0.001f, Child52RotationValueZ * 0.001f, Child52RotationValueW * 0.001f);
    }
    public void SetChild52RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild52RotationValue(q);
    }
    public void SetChild52RotationValue(quaternion q)
    {
        Child52RotationValueX = (int)(q.value.x * 1000);
        Child52RotationValueY = (int)(q.value.y * 1000);
        Child52RotationValueZ = (int)(q.value.z * 1000);
        Child52RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild52TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild52TranslationValue();
    }
    public float3 GetChild52TranslationValue()
    {
        return new float3(Child52TranslationValueX * 0.01f, Child52TranslationValueY * 0.01f, Child52TranslationValueZ * 0.01f);
    }
    public void SetChild52TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild52TranslationValue(val);
    }
    public void SetChild52TranslationValue(float3 val)
    {
        Child52TranslationValueX = (int)(val.x * 100);
        Child52TranslationValueY = (int)(val.y * 100);
        Child52TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild53RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild53RotationValue();
    }
    public quaternion GetChild53RotationValue()
    {
        return new quaternion(Child53RotationValueX * 0.001f, Child53RotationValueY * 0.001f, Child53RotationValueZ * 0.001f, Child53RotationValueW * 0.001f);
    }
    public void SetChild53RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild53RotationValue(q);
    }
    public void SetChild53RotationValue(quaternion q)
    {
        Child53RotationValueX = (int)(q.value.x * 1000);
        Child53RotationValueY = (int)(q.value.y * 1000);
        Child53RotationValueZ = (int)(q.value.z * 1000);
        Child53RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild53TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild53TranslationValue();
    }
    public float3 GetChild53TranslationValue()
    {
        return new float3(Child53TranslationValueX * 0.01f, Child53TranslationValueY * 0.01f, Child53TranslationValueZ * 0.01f);
    }
    public void SetChild53TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild53TranslationValue(val);
    }
    public void SetChild53TranslationValue(float3 val)
    {
        Child53TranslationValueX = (int)(val.x * 100);
        Child53TranslationValueY = (int)(val.y * 100);
        Child53TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild54RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild54RotationValue();
    }
    public quaternion GetChild54RotationValue()
    {
        return new quaternion(Child54RotationValueX * 0.001f, Child54RotationValueY * 0.001f, Child54RotationValueZ * 0.001f, Child54RotationValueW * 0.001f);
    }
    public void SetChild54RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild54RotationValue(q);
    }
    public void SetChild54RotationValue(quaternion q)
    {
        Child54RotationValueX = (int)(q.value.x * 1000);
        Child54RotationValueY = (int)(q.value.y * 1000);
        Child54RotationValueZ = (int)(q.value.z * 1000);
        Child54RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild54TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild54TranslationValue();
    }
    public float3 GetChild54TranslationValue()
    {
        return new float3(Child54TranslationValueX * 0.01f, Child54TranslationValueY * 0.01f, Child54TranslationValueZ * 0.01f);
    }
    public void SetChild54TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild54TranslationValue(val);
    }
    public void SetChild54TranslationValue(float3 val)
    {
        Child54TranslationValueX = (int)(val.x * 100);
        Child54TranslationValueY = (int)(val.y * 100);
        Child54TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild55RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild55RotationValue();
    }
    public quaternion GetChild55RotationValue()
    {
        return new quaternion(Child55RotationValueX * 0.001f, Child55RotationValueY * 0.001f, Child55RotationValueZ * 0.001f, Child55RotationValueW * 0.001f);
    }
    public void SetChild55RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild55RotationValue(q);
    }
    public void SetChild55RotationValue(quaternion q)
    {
        Child55RotationValueX = (int)(q.value.x * 1000);
        Child55RotationValueY = (int)(q.value.y * 1000);
        Child55RotationValueZ = (int)(q.value.z * 1000);
        Child55RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild55TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild55TranslationValue();
    }
    public float3 GetChild55TranslationValue()
    {
        return new float3(Child55TranslationValueX * 0.01f, Child55TranslationValueY * 0.01f, Child55TranslationValueZ * 0.01f);
    }
    public void SetChild55TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild55TranslationValue(val);
    }
    public void SetChild55TranslationValue(float3 val)
    {
        Child55TranslationValueX = (int)(val.x * 100);
        Child55TranslationValueY = (int)(val.y * 100);
        Child55TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild56RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild56RotationValue();
    }
    public quaternion GetChild56RotationValue()
    {
        return new quaternion(Child56RotationValueX * 0.001f, Child56RotationValueY * 0.001f, Child56RotationValueZ * 0.001f, Child56RotationValueW * 0.001f);
    }
    public void SetChild56RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild56RotationValue(q);
    }
    public void SetChild56RotationValue(quaternion q)
    {
        Child56RotationValueX = (int)(q.value.x * 1000);
        Child56RotationValueY = (int)(q.value.y * 1000);
        Child56RotationValueZ = (int)(q.value.z * 1000);
        Child56RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild56TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild56TranslationValue();
    }
    public float3 GetChild56TranslationValue()
    {
        return new float3(Child56TranslationValueX * 0.01f, Child56TranslationValueY * 0.01f, Child56TranslationValueZ * 0.01f);
    }
    public void SetChild56TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild56TranslationValue(val);
    }
    public void SetChild56TranslationValue(float3 val)
    {
        Child56TranslationValueX = (int)(val.x * 100);
        Child56TranslationValueY = (int)(val.y * 100);
        Child56TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild57RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild57RotationValue();
    }
    public quaternion GetChild57RotationValue()
    {
        return new quaternion(Child57RotationValueX * 0.001f, Child57RotationValueY * 0.001f, Child57RotationValueZ * 0.001f, Child57RotationValueW * 0.001f);
    }
    public void SetChild57RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild57RotationValue(q);
    }
    public void SetChild57RotationValue(quaternion q)
    {
        Child57RotationValueX = (int)(q.value.x * 1000);
        Child57RotationValueY = (int)(q.value.y * 1000);
        Child57RotationValueZ = (int)(q.value.z * 1000);
        Child57RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild57TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild57TranslationValue();
    }
    public float3 GetChild57TranslationValue()
    {
        return new float3(Child57TranslationValueX * 0.01f, Child57TranslationValueY * 0.01f, Child57TranslationValueZ * 0.01f);
    }
    public void SetChild57TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild57TranslationValue(val);
    }
    public void SetChild57TranslationValue(float3 val)
    {
        Child57TranslationValueX = (int)(val.x * 100);
        Child57TranslationValueY = (int)(val.y * 100);
        Child57TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild58RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild58RotationValue();
    }
    public quaternion GetChild58RotationValue()
    {
        return new quaternion(Child58RotationValueX * 0.001f, Child58RotationValueY * 0.001f, Child58RotationValueZ * 0.001f, Child58RotationValueW * 0.001f);
    }
    public void SetChild58RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild58RotationValue(q);
    }
    public void SetChild58RotationValue(quaternion q)
    {
        Child58RotationValueX = (int)(q.value.x * 1000);
        Child58RotationValueY = (int)(q.value.y * 1000);
        Child58RotationValueZ = (int)(q.value.z * 1000);
        Child58RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild58TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild58TranslationValue();
    }
    public float3 GetChild58TranslationValue()
    {
        return new float3(Child58TranslationValueX * 0.01f, Child58TranslationValueY * 0.01f, Child58TranslationValueZ * 0.01f);
    }
    public void SetChild58TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild58TranslationValue(val);
    }
    public void SetChild58TranslationValue(float3 val)
    {
        Child58TranslationValueX = (int)(val.x * 100);
        Child58TranslationValueY = (int)(val.y * 100);
        Child58TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild59RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild59RotationValue();
    }
    public quaternion GetChild59RotationValue()
    {
        return new quaternion(Child59RotationValueX * 0.001f, Child59RotationValueY * 0.001f, Child59RotationValueZ * 0.001f, Child59RotationValueW * 0.001f);
    }
    public void SetChild59RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild59RotationValue(q);
    }
    public void SetChild59RotationValue(quaternion q)
    {
        Child59RotationValueX = (int)(q.value.x * 1000);
        Child59RotationValueY = (int)(q.value.y * 1000);
        Child59RotationValueZ = (int)(q.value.z * 1000);
        Child59RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild59TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild59TranslationValue();
    }
    public float3 GetChild59TranslationValue()
    {
        return new float3(Child59TranslationValueX * 0.01f, Child59TranslationValueY * 0.01f, Child59TranslationValueZ * 0.01f);
    }
    public void SetChild59TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild59TranslationValue(val);
    }
    public void SetChild59TranslationValue(float3 val)
    {
        Child59TranslationValueX = (int)(val.x * 100);
        Child59TranslationValueY = (int)(val.y * 100);
        Child59TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild60RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild60RotationValue();
    }
    public quaternion GetChild60RotationValue()
    {
        return new quaternion(Child60RotationValueX * 0.001f, Child60RotationValueY * 0.001f, Child60RotationValueZ * 0.001f, Child60RotationValueW * 0.001f);
    }
    public void SetChild60RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild60RotationValue(q);
    }
    public void SetChild60RotationValue(quaternion q)
    {
        Child60RotationValueX = (int)(q.value.x * 1000);
        Child60RotationValueY = (int)(q.value.y * 1000);
        Child60RotationValueZ = (int)(q.value.z * 1000);
        Child60RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild60TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild60TranslationValue();
    }
    public float3 GetChild60TranslationValue()
    {
        return new float3(Child60TranslationValueX * 0.01f, Child60TranslationValueY * 0.01f, Child60TranslationValueZ * 0.01f);
    }
    public void SetChild60TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild60TranslationValue(val);
    }
    public void SetChild60TranslationValue(float3 val)
    {
        Child60TranslationValueX = (int)(val.x * 100);
        Child60TranslationValueY = (int)(val.y * 100);
        Child60TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild61RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild61RotationValue();
    }
    public quaternion GetChild61RotationValue()
    {
        return new quaternion(Child61RotationValueX * 0.001f, Child61RotationValueY * 0.001f, Child61RotationValueZ * 0.001f, Child61RotationValueW * 0.001f);
    }
    public void SetChild61RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild61RotationValue(q);
    }
    public void SetChild61RotationValue(quaternion q)
    {
        Child61RotationValueX = (int)(q.value.x * 1000);
        Child61RotationValueY = (int)(q.value.y * 1000);
        Child61RotationValueZ = (int)(q.value.z * 1000);
        Child61RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild61TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild61TranslationValue();
    }
    public float3 GetChild61TranslationValue()
    {
        return new float3(Child61TranslationValueX * 0.01f, Child61TranslationValueY * 0.01f, Child61TranslationValueZ * 0.01f);
    }
    public void SetChild61TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild61TranslationValue(val);
    }
    public void SetChild61TranslationValue(float3 val)
    {
        Child61TranslationValueX = (int)(val.x * 100);
        Child61TranslationValueY = (int)(val.y * 100);
        Child61TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild62RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild62RotationValue();
    }
    public quaternion GetChild62RotationValue()
    {
        return new quaternion(Child62RotationValueX * 0.001f, Child62RotationValueY * 0.001f, Child62RotationValueZ * 0.001f, Child62RotationValueW * 0.001f);
    }
    public void SetChild62RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild62RotationValue(q);
    }
    public void SetChild62RotationValue(quaternion q)
    {
        Child62RotationValueX = (int)(q.value.x * 1000);
        Child62RotationValueY = (int)(q.value.y * 1000);
        Child62RotationValueZ = (int)(q.value.z * 1000);
        Child62RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild62TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild62TranslationValue();
    }
    public float3 GetChild62TranslationValue()
    {
        return new float3(Child62TranslationValueX * 0.01f, Child62TranslationValueY * 0.01f, Child62TranslationValueZ * 0.01f);
    }
    public void SetChild62TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild62TranslationValue(val);
    }
    public void SetChild62TranslationValue(float3 val)
    {
        Child62TranslationValueX = (int)(val.x * 100);
        Child62TranslationValueY = (int)(val.y * 100);
        Child62TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild63RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild63RotationValue();
    }
    public quaternion GetChild63RotationValue()
    {
        return new quaternion(Child63RotationValueX * 0.001f, Child63RotationValueY * 0.001f, Child63RotationValueZ * 0.001f, Child63RotationValueW * 0.001f);
    }
    public void SetChild63RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild63RotationValue(q);
    }
    public void SetChild63RotationValue(quaternion q)
    {
        Child63RotationValueX = (int)(q.value.x * 1000);
        Child63RotationValueY = (int)(q.value.y * 1000);
        Child63RotationValueZ = (int)(q.value.z * 1000);
        Child63RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild63TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild63TranslationValue();
    }
    public float3 GetChild63TranslationValue()
    {
        return new float3(Child63TranslationValueX * 0.01f, Child63TranslationValueY * 0.01f, Child63TranslationValueZ * 0.01f);
    }
    public void SetChild63TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild63TranslationValue(val);
    }
    public void SetChild63TranslationValue(float3 val)
    {
        Child63TranslationValueX = (int)(val.x * 100);
        Child63TranslationValueY = (int)(val.y * 100);
        Child63TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild64RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild64RotationValue();
    }
    public quaternion GetChild64RotationValue()
    {
        return new quaternion(Child64RotationValueX * 0.001f, Child64RotationValueY * 0.001f, Child64RotationValueZ * 0.001f, Child64RotationValueW * 0.001f);
    }
    public void SetChild64RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild64RotationValue(q);
    }
    public void SetChild64RotationValue(quaternion q)
    {
        Child64RotationValueX = (int)(q.value.x * 1000);
        Child64RotationValueY = (int)(q.value.y * 1000);
        Child64RotationValueZ = (int)(q.value.z * 1000);
        Child64RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild64TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild64TranslationValue();
    }
    public float3 GetChild64TranslationValue()
    {
        return new float3(Child64TranslationValueX * 0.01f, Child64TranslationValueY * 0.01f, Child64TranslationValueZ * 0.01f);
    }
    public void SetChild64TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild64TranslationValue(val);
    }
    public void SetChild64TranslationValue(float3 val)
    {
        Child64TranslationValueX = (int)(val.x * 100);
        Child64TranslationValueY = (int)(val.y * 100);
        Child64TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild65RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild65RotationValue();
    }
    public quaternion GetChild65RotationValue()
    {
        return new quaternion(Child65RotationValueX * 0.001f, Child65RotationValueY * 0.001f, Child65RotationValueZ * 0.001f, Child65RotationValueW * 0.001f);
    }
    public void SetChild65RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild65RotationValue(q);
    }
    public void SetChild65RotationValue(quaternion q)
    {
        Child65RotationValueX = (int)(q.value.x * 1000);
        Child65RotationValueY = (int)(q.value.y * 1000);
        Child65RotationValueZ = (int)(q.value.z * 1000);
        Child65RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild65TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild65TranslationValue();
    }
    public float3 GetChild65TranslationValue()
    {
        return new float3(Child65TranslationValueX * 0.01f, Child65TranslationValueY * 0.01f, Child65TranslationValueZ * 0.01f);
    }
    public void SetChild65TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild65TranslationValue(val);
    }
    public void SetChild65TranslationValue(float3 val)
    {
        Child65TranslationValueX = (int)(val.x * 100);
        Child65TranslationValueY = (int)(val.y * 100);
        Child65TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild66RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild66RotationValue();
    }
    public quaternion GetChild66RotationValue()
    {
        return new quaternion(Child66RotationValueX * 0.001f, Child66RotationValueY * 0.001f, Child66RotationValueZ * 0.001f, Child66RotationValueW * 0.001f);
    }
    public void SetChild66RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild66RotationValue(q);
    }
    public void SetChild66RotationValue(quaternion q)
    {
        Child66RotationValueX = (int)(q.value.x * 1000);
        Child66RotationValueY = (int)(q.value.y * 1000);
        Child66RotationValueZ = (int)(q.value.z * 1000);
        Child66RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild66TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild66TranslationValue();
    }
    public float3 GetChild66TranslationValue()
    {
        return new float3(Child66TranslationValueX * 0.01f, Child66TranslationValueY * 0.01f, Child66TranslationValueZ * 0.01f);
    }
    public void SetChild66TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild66TranslationValue(val);
    }
    public void SetChild66TranslationValue(float3 val)
    {
        Child66TranslationValueX = (int)(val.x * 100);
        Child66TranslationValueY = (int)(val.y * 100);
        Child66TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild67RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild67RotationValue();
    }
    public quaternion GetChild67RotationValue()
    {
        return new quaternion(Child67RotationValueX * 0.001f, Child67RotationValueY * 0.001f, Child67RotationValueZ * 0.001f, Child67RotationValueW * 0.001f);
    }
    public void SetChild67RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild67RotationValue(q);
    }
    public void SetChild67RotationValue(quaternion q)
    {
        Child67RotationValueX = (int)(q.value.x * 1000);
        Child67RotationValueY = (int)(q.value.y * 1000);
        Child67RotationValueZ = (int)(q.value.z * 1000);
        Child67RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild67TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild67TranslationValue();
    }
    public float3 GetChild67TranslationValue()
    {
        return new float3(Child67TranslationValueX * 0.01f, Child67TranslationValueY * 0.01f, Child67TranslationValueZ * 0.01f);
    }
    public void SetChild67TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild67TranslationValue(val);
    }
    public void SetChild67TranslationValue(float3 val)
    {
        Child67TranslationValueX = (int)(val.x * 100);
        Child67TranslationValueY = (int)(val.y * 100);
        Child67TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild68RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild68RotationValue();
    }
    public quaternion GetChild68RotationValue()
    {
        return new quaternion(Child68RotationValueX * 0.001f, Child68RotationValueY * 0.001f, Child68RotationValueZ * 0.001f, Child68RotationValueW * 0.001f);
    }
    public void SetChild68RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild68RotationValue(q);
    }
    public void SetChild68RotationValue(quaternion q)
    {
        Child68RotationValueX = (int)(q.value.x * 1000);
        Child68RotationValueY = (int)(q.value.y * 1000);
        Child68RotationValueZ = (int)(q.value.z * 1000);
        Child68RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild68TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild68TranslationValue();
    }
    public float3 GetChild68TranslationValue()
    {
        return new float3(Child68TranslationValueX * 0.01f, Child68TranslationValueY * 0.01f, Child68TranslationValueZ * 0.01f);
    }
    public void SetChild68TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild68TranslationValue(val);
    }
    public void SetChild68TranslationValue(float3 val)
    {
        Child68TranslationValueX = (int)(val.x * 100);
        Child68TranslationValueY = (int)(val.y * 100);
        Child68TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild69RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild69RotationValue();
    }
    public quaternion GetChild69RotationValue()
    {
        return new quaternion(Child69RotationValueX * 0.001f, Child69RotationValueY * 0.001f, Child69RotationValueZ * 0.001f, Child69RotationValueW * 0.001f);
    }
    public void SetChild69RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild69RotationValue(q);
    }
    public void SetChild69RotationValue(quaternion q)
    {
        Child69RotationValueX = (int)(q.value.x * 1000);
        Child69RotationValueY = (int)(q.value.y * 1000);
        Child69RotationValueZ = (int)(q.value.z * 1000);
        Child69RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild69TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild69TranslationValue();
    }
    public float3 GetChild69TranslationValue()
    {
        return new float3(Child69TranslationValueX * 0.01f, Child69TranslationValueY * 0.01f, Child69TranslationValueZ * 0.01f);
    }
    public void SetChild69TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild69TranslationValue(val);
    }
    public void SetChild69TranslationValue(float3 val)
    {
        Child69TranslationValueX = (int)(val.x * 100);
        Child69TranslationValueY = (int)(val.y * 100);
        Child69TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild70RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild70RotationValue();
    }
    public quaternion GetChild70RotationValue()
    {
        return new quaternion(Child70RotationValueX * 0.001f, Child70RotationValueY * 0.001f, Child70RotationValueZ * 0.001f, Child70RotationValueW * 0.001f);
    }
    public void SetChild70RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild70RotationValue(q);
    }
    public void SetChild70RotationValue(quaternion q)
    {
        Child70RotationValueX = (int)(q.value.x * 1000);
        Child70RotationValueY = (int)(q.value.y * 1000);
        Child70RotationValueZ = (int)(q.value.z * 1000);
        Child70RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild70TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild70TranslationValue();
    }
    public float3 GetChild70TranslationValue()
    {
        return new float3(Child70TranslationValueX * 0.01f, Child70TranslationValueY * 0.01f, Child70TranslationValueZ * 0.01f);
    }
    public void SetChild70TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild70TranslationValue(val);
    }
    public void SetChild70TranslationValue(float3 val)
    {
        Child70TranslationValueX = (int)(val.x * 100);
        Child70TranslationValueY = (int)(val.y * 100);
        Child70TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild71RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild71RotationValue();
    }
    public quaternion GetChild71RotationValue()
    {
        return new quaternion(Child71RotationValueX * 0.001f, Child71RotationValueY * 0.001f, Child71RotationValueZ * 0.001f, Child71RotationValueW * 0.001f);
    }
    public void SetChild71RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild71RotationValue(q);
    }
    public void SetChild71RotationValue(quaternion q)
    {
        Child71RotationValueX = (int)(q.value.x * 1000);
        Child71RotationValueY = (int)(q.value.y * 1000);
        Child71RotationValueZ = (int)(q.value.z * 1000);
        Child71RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild71TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild71TranslationValue();
    }
    public float3 GetChild71TranslationValue()
    {
        return new float3(Child71TranslationValueX * 0.01f, Child71TranslationValueY * 0.01f, Child71TranslationValueZ * 0.01f);
    }
    public void SetChild71TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild71TranslationValue(val);
    }
    public void SetChild71TranslationValue(float3 val)
    {
        Child71TranslationValueX = (int)(val.x * 100);
        Child71TranslationValueY = (int)(val.y * 100);
        Child71TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild72RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild72RotationValue();
    }
    public quaternion GetChild72RotationValue()
    {
        return new quaternion(Child72RotationValueX * 0.001f, Child72RotationValueY * 0.001f, Child72RotationValueZ * 0.001f, Child72RotationValueW * 0.001f);
    }
    public void SetChild72RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild72RotationValue(q);
    }
    public void SetChild72RotationValue(quaternion q)
    {
        Child72RotationValueX = (int)(q.value.x * 1000);
        Child72RotationValueY = (int)(q.value.y * 1000);
        Child72RotationValueZ = (int)(q.value.z * 1000);
        Child72RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild72TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild72TranslationValue();
    }
    public float3 GetChild72TranslationValue()
    {
        return new float3(Child72TranslationValueX * 0.01f, Child72TranslationValueY * 0.01f, Child72TranslationValueZ * 0.01f);
    }
    public void SetChild72TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild72TranslationValue(val);
    }
    public void SetChild72TranslationValue(float3 val)
    {
        Child72TranslationValueX = (int)(val.x * 100);
        Child72TranslationValueY = (int)(val.y * 100);
        Child72TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild73RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild73RotationValue();
    }
    public quaternion GetChild73RotationValue()
    {
        return new quaternion(Child73RotationValueX * 0.001f, Child73RotationValueY * 0.001f, Child73RotationValueZ * 0.001f, Child73RotationValueW * 0.001f);
    }
    public void SetChild73RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild73RotationValue(q);
    }
    public void SetChild73RotationValue(quaternion q)
    {
        Child73RotationValueX = (int)(q.value.x * 1000);
        Child73RotationValueY = (int)(q.value.y * 1000);
        Child73RotationValueZ = (int)(q.value.z * 1000);
        Child73RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild73TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild73TranslationValue();
    }
    public float3 GetChild73TranslationValue()
    {
        return new float3(Child73TranslationValueX * 0.01f, Child73TranslationValueY * 0.01f, Child73TranslationValueZ * 0.01f);
    }
    public void SetChild73TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild73TranslationValue(val);
    }
    public void SetChild73TranslationValue(float3 val)
    {
        Child73TranslationValueX = (int)(val.x * 100);
        Child73TranslationValueY = (int)(val.y * 100);
        Child73TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild74RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild74RotationValue();
    }
    public quaternion GetChild74RotationValue()
    {
        return new quaternion(Child74RotationValueX * 0.001f, Child74RotationValueY * 0.001f, Child74RotationValueZ * 0.001f, Child74RotationValueW * 0.001f);
    }
    public void SetChild74RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild74RotationValue(q);
    }
    public void SetChild74RotationValue(quaternion q)
    {
        Child74RotationValueX = (int)(q.value.x * 1000);
        Child74RotationValueY = (int)(q.value.y * 1000);
        Child74RotationValueZ = (int)(q.value.z * 1000);
        Child74RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild74TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild74TranslationValue();
    }
    public float3 GetChild74TranslationValue()
    {
        return new float3(Child74TranslationValueX * 0.01f, Child74TranslationValueY * 0.01f, Child74TranslationValueZ * 0.01f);
    }
    public void SetChild74TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild74TranslationValue(val);
    }
    public void SetChild74TranslationValue(float3 val)
    {
        Child74TranslationValueX = (int)(val.x * 100);
        Child74TranslationValueY = (int)(val.y * 100);
        Child74TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild75RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild75RotationValue();
    }
    public quaternion GetChild75RotationValue()
    {
        return new quaternion(Child75RotationValueX * 0.001f, Child75RotationValueY * 0.001f, Child75RotationValueZ * 0.001f, Child75RotationValueW * 0.001f);
    }
    public void SetChild75RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild75RotationValue(q);
    }
    public void SetChild75RotationValue(quaternion q)
    {
        Child75RotationValueX = (int)(q.value.x * 1000);
        Child75RotationValueY = (int)(q.value.y * 1000);
        Child75RotationValueZ = (int)(q.value.z * 1000);
        Child75RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild75TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild75TranslationValue();
    }
    public float3 GetChild75TranslationValue()
    {
        return new float3(Child75TranslationValueX * 0.01f, Child75TranslationValueY * 0.01f, Child75TranslationValueZ * 0.01f);
    }
    public void SetChild75TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild75TranslationValue(val);
    }
    public void SetChild75TranslationValue(float3 val)
    {
        Child75TranslationValueX = (int)(val.x * 100);
        Child75TranslationValueY = (int)(val.y * 100);
        Child75TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild76RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild76RotationValue();
    }
    public quaternion GetChild76RotationValue()
    {
        return new quaternion(Child76RotationValueX * 0.001f, Child76RotationValueY * 0.001f, Child76RotationValueZ * 0.001f, Child76RotationValueW * 0.001f);
    }
    public void SetChild76RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild76RotationValue(q);
    }
    public void SetChild76RotationValue(quaternion q)
    {
        Child76RotationValueX = (int)(q.value.x * 1000);
        Child76RotationValueY = (int)(q.value.y * 1000);
        Child76RotationValueZ = (int)(q.value.z * 1000);
        Child76RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild76TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild76TranslationValue();
    }
    public float3 GetChild76TranslationValue()
    {
        return new float3(Child76TranslationValueX * 0.01f, Child76TranslationValueY * 0.01f, Child76TranslationValueZ * 0.01f);
    }
    public void SetChild76TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild76TranslationValue(val);
    }
    public void SetChild76TranslationValue(float3 val)
    {
        Child76TranslationValueX = (int)(val.x * 100);
        Child76TranslationValueY = (int)(val.y * 100);
        Child76TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild77RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild77RotationValue();
    }
    public quaternion GetChild77RotationValue()
    {
        return new quaternion(Child77RotationValueX * 0.001f, Child77RotationValueY * 0.001f, Child77RotationValueZ * 0.001f, Child77RotationValueW * 0.001f);
    }
    public void SetChild77RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild77RotationValue(q);
    }
    public void SetChild77RotationValue(quaternion q)
    {
        Child77RotationValueX = (int)(q.value.x * 1000);
        Child77RotationValueY = (int)(q.value.y * 1000);
        Child77RotationValueZ = (int)(q.value.z * 1000);
        Child77RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild77TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild77TranslationValue();
    }
    public float3 GetChild77TranslationValue()
    {
        return new float3(Child77TranslationValueX * 0.01f, Child77TranslationValueY * 0.01f, Child77TranslationValueZ * 0.01f);
    }
    public void SetChild77TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild77TranslationValue(val);
    }
    public void SetChild77TranslationValue(float3 val)
    {
        Child77TranslationValueX = (int)(val.x * 100);
        Child77TranslationValueY = (int)(val.y * 100);
        Child77TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild78RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild78RotationValue();
    }
    public quaternion GetChild78RotationValue()
    {
        return new quaternion(Child78RotationValueX * 0.001f, Child78RotationValueY * 0.001f, Child78RotationValueZ * 0.001f, Child78RotationValueW * 0.001f);
    }
    public void SetChild78RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild78RotationValue(q);
    }
    public void SetChild78RotationValue(quaternion q)
    {
        Child78RotationValueX = (int)(q.value.x * 1000);
        Child78RotationValueY = (int)(q.value.y * 1000);
        Child78RotationValueZ = (int)(q.value.z * 1000);
        Child78RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild78TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild78TranslationValue();
    }
    public float3 GetChild78TranslationValue()
    {
        return new float3(Child78TranslationValueX * 0.01f, Child78TranslationValueY * 0.01f, Child78TranslationValueZ * 0.01f);
    }
    public void SetChild78TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild78TranslationValue(val);
    }
    public void SetChild78TranslationValue(float3 val)
    {
        Child78TranslationValueX = (int)(val.x * 100);
        Child78TranslationValueY = (int)(val.y * 100);
        Child78TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild79RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild79RotationValue();
    }
    public quaternion GetChild79RotationValue()
    {
        return new quaternion(Child79RotationValueX * 0.001f, Child79RotationValueY * 0.001f, Child79RotationValueZ * 0.001f, Child79RotationValueW * 0.001f);
    }
    public void SetChild79RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild79RotationValue(q);
    }
    public void SetChild79RotationValue(quaternion q)
    {
        Child79RotationValueX = (int)(q.value.x * 1000);
        Child79RotationValueY = (int)(q.value.y * 1000);
        Child79RotationValueZ = (int)(q.value.z * 1000);
        Child79RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild79TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild79TranslationValue();
    }
    public float3 GetChild79TranslationValue()
    {
        return new float3(Child79TranslationValueX * 0.01f, Child79TranslationValueY * 0.01f, Child79TranslationValueZ * 0.01f);
    }
    public void SetChild79TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild79TranslationValue(val);
    }
    public void SetChild79TranslationValue(float3 val)
    {
        Child79TranslationValueX = (int)(val.x * 100);
        Child79TranslationValueY = (int)(val.y * 100);
        Child79TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild80RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild80RotationValue();
    }
    public quaternion GetChild80RotationValue()
    {
        return new quaternion(Child80RotationValueX * 0.001f, Child80RotationValueY * 0.001f, Child80RotationValueZ * 0.001f, Child80RotationValueW * 0.001f);
    }
    public void SetChild80RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild80RotationValue(q);
    }
    public void SetChild80RotationValue(quaternion q)
    {
        Child80RotationValueX = (int)(q.value.x * 1000);
        Child80RotationValueY = (int)(q.value.y * 1000);
        Child80RotationValueZ = (int)(q.value.z * 1000);
        Child80RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild80TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild80TranslationValue();
    }
    public float3 GetChild80TranslationValue()
    {
        return new float3(Child80TranslationValueX * 0.01f, Child80TranslationValueY * 0.01f, Child80TranslationValueZ * 0.01f);
    }
    public void SetChild80TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild80TranslationValue(val);
    }
    public void SetChild80TranslationValue(float3 val)
    {
        Child80TranslationValueX = (int)(val.x * 100);
        Child80TranslationValueY = (int)(val.y * 100);
        Child80TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild81RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild81RotationValue();
    }
    public quaternion GetChild81RotationValue()
    {
        return new quaternion(Child81RotationValueX * 0.001f, Child81RotationValueY * 0.001f, Child81RotationValueZ * 0.001f, Child81RotationValueW * 0.001f);
    }
    public void SetChild81RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild81RotationValue(q);
    }
    public void SetChild81RotationValue(quaternion q)
    {
        Child81RotationValueX = (int)(q.value.x * 1000);
        Child81RotationValueY = (int)(q.value.y * 1000);
        Child81RotationValueZ = (int)(q.value.z * 1000);
        Child81RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild81TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild81TranslationValue();
    }
    public float3 GetChild81TranslationValue()
    {
        return new float3(Child81TranslationValueX * 0.01f, Child81TranslationValueY * 0.01f, Child81TranslationValueZ * 0.01f);
    }
    public void SetChild81TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild81TranslationValue(val);
    }
    public void SetChild81TranslationValue(float3 val)
    {
        Child81TranslationValueX = (int)(val.x * 100);
        Child81TranslationValueY = (int)(val.y * 100);
        Child81TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild82RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild82RotationValue();
    }
    public quaternion GetChild82RotationValue()
    {
        return new quaternion(Child82RotationValueX * 0.001f, Child82RotationValueY * 0.001f, Child82RotationValueZ * 0.001f, Child82RotationValueW * 0.001f);
    }
    public void SetChild82RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild82RotationValue(q);
    }
    public void SetChild82RotationValue(quaternion q)
    {
        Child82RotationValueX = (int)(q.value.x * 1000);
        Child82RotationValueY = (int)(q.value.y * 1000);
        Child82RotationValueZ = (int)(q.value.z * 1000);
        Child82RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild82TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild82TranslationValue();
    }
    public float3 GetChild82TranslationValue()
    {
        return new float3(Child82TranslationValueX * 0.01f, Child82TranslationValueY * 0.01f, Child82TranslationValueZ * 0.01f);
    }
    public void SetChild82TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild82TranslationValue(val);
    }
    public void SetChild82TranslationValue(float3 val)
    {
        Child82TranslationValueX = (int)(val.x * 100);
        Child82TranslationValueY = (int)(val.y * 100);
        Child82TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild83RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild83RotationValue();
    }
    public quaternion GetChild83RotationValue()
    {
        return new quaternion(Child83RotationValueX * 0.001f, Child83RotationValueY * 0.001f, Child83RotationValueZ * 0.001f, Child83RotationValueW * 0.001f);
    }
    public void SetChild83RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild83RotationValue(q);
    }
    public void SetChild83RotationValue(quaternion q)
    {
        Child83RotationValueX = (int)(q.value.x * 1000);
        Child83RotationValueY = (int)(q.value.y * 1000);
        Child83RotationValueZ = (int)(q.value.z * 1000);
        Child83RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild83TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild83TranslationValue();
    }
    public float3 GetChild83TranslationValue()
    {
        return new float3(Child83TranslationValueX * 0.01f, Child83TranslationValueY * 0.01f, Child83TranslationValueZ * 0.01f);
    }
    public void SetChild83TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild83TranslationValue(val);
    }
    public void SetChild83TranslationValue(float3 val)
    {
        Child83TranslationValueX = (int)(val.x * 100);
        Child83TranslationValueY = (int)(val.y * 100);
        Child83TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild84RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild84RotationValue();
    }
    public quaternion GetChild84RotationValue()
    {
        return new quaternion(Child84RotationValueX * 0.001f, Child84RotationValueY * 0.001f, Child84RotationValueZ * 0.001f, Child84RotationValueW * 0.001f);
    }
    public void SetChild84RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild84RotationValue(q);
    }
    public void SetChild84RotationValue(quaternion q)
    {
        Child84RotationValueX = (int)(q.value.x * 1000);
        Child84RotationValueY = (int)(q.value.y * 1000);
        Child84RotationValueZ = (int)(q.value.z * 1000);
        Child84RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild84TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild84TranslationValue();
    }
    public float3 GetChild84TranslationValue()
    {
        return new float3(Child84TranslationValueX * 0.01f, Child84TranslationValueY * 0.01f, Child84TranslationValueZ * 0.01f);
    }
    public void SetChild84TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild84TranslationValue(val);
    }
    public void SetChild84TranslationValue(float3 val)
    {
        Child84TranslationValueX = (int)(val.x * 100);
        Child84TranslationValueY = (int)(val.y * 100);
        Child84TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild85RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild85RotationValue();
    }
    public quaternion GetChild85RotationValue()
    {
        return new quaternion(Child85RotationValueX * 0.001f, Child85RotationValueY * 0.001f, Child85RotationValueZ * 0.001f, Child85RotationValueW * 0.001f);
    }
    public void SetChild85RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild85RotationValue(q);
    }
    public void SetChild85RotationValue(quaternion q)
    {
        Child85RotationValueX = (int)(q.value.x * 1000);
        Child85RotationValueY = (int)(q.value.y * 1000);
        Child85RotationValueZ = (int)(q.value.z * 1000);
        Child85RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild85TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild85TranslationValue();
    }
    public float3 GetChild85TranslationValue()
    {
        return new float3(Child85TranslationValueX * 0.01f, Child85TranslationValueY * 0.01f, Child85TranslationValueZ * 0.01f);
    }
    public void SetChild85TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild85TranslationValue(val);
    }
    public void SetChild85TranslationValue(float3 val)
    {
        Child85TranslationValueX = (int)(val.x * 100);
        Child85TranslationValueY = (int)(val.y * 100);
        Child85TranslationValueZ = (int)(val.z * 100);
    }
    public quaternion GetChild86RotationValue(GhostDeserializerState deserializerState)
    {
        return GetChild86RotationValue();
    }
    public quaternion GetChild86RotationValue()
    {
        return new quaternion(Child86RotationValueX * 0.001f, Child86RotationValueY * 0.001f, Child86RotationValueZ * 0.001f, Child86RotationValueW * 0.001f);
    }
    public void SetChild86RotationValue(quaternion q, GhostSerializerState serializerState)
    {
        SetChild86RotationValue(q);
    }
    public void SetChild86RotationValue(quaternion q)
    {
        Child86RotationValueX = (int)(q.value.x * 1000);
        Child86RotationValueY = (int)(q.value.y * 1000);
        Child86RotationValueZ = (int)(q.value.z * 1000);
        Child86RotationValueW = (int)(q.value.w * 1000);
    }
    public float3 GetChild86TranslationValue(GhostDeserializerState deserializerState)
    {
        return GetChild86TranslationValue();
    }
    public float3 GetChild86TranslationValue()
    {
        return new float3(Child86TranslationValueX * 0.01f, Child86TranslationValueY * 0.01f, Child86TranslationValueZ * 0.01f);
    }
    public void SetChild86TranslationValue(float3 val, GhostSerializerState serializerState)
    {
        SetChild86TranslationValue(val);
    }
    public void SetChild86TranslationValue(float3 val)
    {
        Child86TranslationValueX = (int)(val.x * 100);
        Child86TranslationValueY = (int)(val.y * 100);
        Child86TranslationValueZ = (int)(val.z * 100);
    }

    public void PredictDelta(uint tick, ref ThirdPersonControllerSnapshotData baseline1, ref ThirdPersonControllerSnapshotData baseline2)
    {
        var predictor = new GhostDeltaPredictor(tick, this.tick, baseline1.tick, baseline2.tick);
        MovablePlayerPlayerId = predictor.PredictInt(MovablePlayerPlayerId, baseline1.MovablePlayerPlayerId, baseline2.MovablePlayerPlayerId);
        RotationValueX = predictor.PredictInt(RotationValueX, baseline1.RotationValueX, baseline2.RotationValueX);
        RotationValueY = predictor.PredictInt(RotationValueY, baseline1.RotationValueY, baseline2.RotationValueY);
        RotationValueZ = predictor.PredictInt(RotationValueZ, baseline1.RotationValueZ, baseline2.RotationValueZ);
        RotationValueW = predictor.PredictInt(RotationValueW, baseline1.RotationValueW, baseline2.RotationValueW);
        TranslationValueX = predictor.PredictInt(TranslationValueX, baseline1.TranslationValueX, baseline2.TranslationValueX);
        TranslationValueY = predictor.PredictInt(TranslationValueY, baseline1.TranslationValueY, baseline2.TranslationValueY);
        TranslationValueZ = predictor.PredictInt(TranslationValueZ, baseline1.TranslationValueZ, baseline2.TranslationValueZ);
        Child0RotationValueX = predictor.PredictInt(Child0RotationValueX, baseline1.Child0RotationValueX, baseline2.Child0RotationValueX);
        Child0RotationValueY = predictor.PredictInt(Child0RotationValueY, baseline1.Child0RotationValueY, baseline2.Child0RotationValueY);
        Child0RotationValueZ = predictor.PredictInt(Child0RotationValueZ, baseline1.Child0RotationValueZ, baseline2.Child0RotationValueZ);
        Child0RotationValueW = predictor.PredictInt(Child0RotationValueW, baseline1.Child0RotationValueW, baseline2.Child0RotationValueW);
        Child0TranslationValueX = predictor.PredictInt(Child0TranslationValueX, baseline1.Child0TranslationValueX, baseline2.Child0TranslationValueX);
        Child0TranslationValueY = predictor.PredictInt(Child0TranslationValueY, baseline1.Child0TranslationValueY, baseline2.Child0TranslationValueY);
        Child0TranslationValueZ = predictor.PredictInt(Child0TranslationValueZ, baseline1.Child0TranslationValueZ, baseline2.Child0TranslationValueZ);
        Child1RotationValueX = predictor.PredictInt(Child1RotationValueX, baseline1.Child1RotationValueX, baseline2.Child1RotationValueX);
        Child1RotationValueY = predictor.PredictInt(Child1RotationValueY, baseline1.Child1RotationValueY, baseline2.Child1RotationValueY);
        Child1RotationValueZ = predictor.PredictInt(Child1RotationValueZ, baseline1.Child1RotationValueZ, baseline2.Child1RotationValueZ);
        Child1RotationValueW = predictor.PredictInt(Child1RotationValueW, baseline1.Child1RotationValueW, baseline2.Child1RotationValueW);
        Child1TranslationValueX = predictor.PredictInt(Child1TranslationValueX, baseline1.Child1TranslationValueX, baseline2.Child1TranslationValueX);
        Child1TranslationValueY = predictor.PredictInt(Child1TranslationValueY, baseline1.Child1TranslationValueY, baseline2.Child1TranslationValueY);
        Child1TranslationValueZ = predictor.PredictInt(Child1TranslationValueZ, baseline1.Child1TranslationValueZ, baseline2.Child1TranslationValueZ);
        Child2RotationValueX = predictor.PredictInt(Child2RotationValueX, baseline1.Child2RotationValueX, baseline2.Child2RotationValueX);
        Child2RotationValueY = predictor.PredictInt(Child2RotationValueY, baseline1.Child2RotationValueY, baseline2.Child2RotationValueY);
        Child2RotationValueZ = predictor.PredictInt(Child2RotationValueZ, baseline1.Child2RotationValueZ, baseline2.Child2RotationValueZ);
        Child2RotationValueW = predictor.PredictInt(Child2RotationValueW, baseline1.Child2RotationValueW, baseline2.Child2RotationValueW);
        Child2TranslationValueX = predictor.PredictInt(Child2TranslationValueX, baseline1.Child2TranslationValueX, baseline2.Child2TranslationValueX);
        Child2TranslationValueY = predictor.PredictInt(Child2TranslationValueY, baseline1.Child2TranslationValueY, baseline2.Child2TranslationValueY);
        Child2TranslationValueZ = predictor.PredictInt(Child2TranslationValueZ, baseline1.Child2TranslationValueZ, baseline2.Child2TranslationValueZ);
        Child3RotationValueX = predictor.PredictInt(Child3RotationValueX, baseline1.Child3RotationValueX, baseline2.Child3RotationValueX);
        Child3RotationValueY = predictor.PredictInt(Child3RotationValueY, baseline1.Child3RotationValueY, baseline2.Child3RotationValueY);
        Child3RotationValueZ = predictor.PredictInt(Child3RotationValueZ, baseline1.Child3RotationValueZ, baseline2.Child3RotationValueZ);
        Child3RotationValueW = predictor.PredictInt(Child3RotationValueW, baseline1.Child3RotationValueW, baseline2.Child3RotationValueW);
        Child3TranslationValueX = predictor.PredictInt(Child3TranslationValueX, baseline1.Child3TranslationValueX, baseline2.Child3TranslationValueX);
        Child3TranslationValueY = predictor.PredictInt(Child3TranslationValueY, baseline1.Child3TranslationValueY, baseline2.Child3TranslationValueY);
        Child3TranslationValueZ = predictor.PredictInt(Child3TranslationValueZ, baseline1.Child3TranslationValueZ, baseline2.Child3TranslationValueZ);
        Child4RotationValueX = predictor.PredictInt(Child4RotationValueX, baseline1.Child4RotationValueX, baseline2.Child4RotationValueX);
        Child4RotationValueY = predictor.PredictInt(Child4RotationValueY, baseline1.Child4RotationValueY, baseline2.Child4RotationValueY);
        Child4RotationValueZ = predictor.PredictInt(Child4RotationValueZ, baseline1.Child4RotationValueZ, baseline2.Child4RotationValueZ);
        Child4RotationValueW = predictor.PredictInt(Child4RotationValueW, baseline1.Child4RotationValueW, baseline2.Child4RotationValueW);
        Child4TranslationValueX = predictor.PredictInt(Child4TranslationValueX, baseline1.Child4TranslationValueX, baseline2.Child4TranslationValueX);
        Child4TranslationValueY = predictor.PredictInt(Child4TranslationValueY, baseline1.Child4TranslationValueY, baseline2.Child4TranslationValueY);
        Child4TranslationValueZ = predictor.PredictInt(Child4TranslationValueZ, baseline1.Child4TranslationValueZ, baseline2.Child4TranslationValueZ);
        Child5RotationValueX = predictor.PredictInt(Child5RotationValueX, baseline1.Child5RotationValueX, baseline2.Child5RotationValueX);
        Child5RotationValueY = predictor.PredictInt(Child5RotationValueY, baseline1.Child5RotationValueY, baseline2.Child5RotationValueY);
        Child5RotationValueZ = predictor.PredictInt(Child5RotationValueZ, baseline1.Child5RotationValueZ, baseline2.Child5RotationValueZ);
        Child5RotationValueW = predictor.PredictInt(Child5RotationValueW, baseline1.Child5RotationValueW, baseline2.Child5RotationValueW);
        Child5TranslationValueX = predictor.PredictInt(Child5TranslationValueX, baseline1.Child5TranslationValueX, baseline2.Child5TranslationValueX);
        Child5TranslationValueY = predictor.PredictInt(Child5TranslationValueY, baseline1.Child5TranslationValueY, baseline2.Child5TranslationValueY);
        Child5TranslationValueZ = predictor.PredictInt(Child5TranslationValueZ, baseline1.Child5TranslationValueZ, baseline2.Child5TranslationValueZ);
        Child6RotationValueX = predictor.PredictInt(Child6RotationValueX, baseline1.Child6RotationValueX, baseline2.Child6RotationValueX);
        Child6RotationValueY = predictor.PredictInt(Child6RotationValueY, baseline1.Child6RotationValueY, baseline2.Child6RotationValueY);
        Child6RotationValueZ = predictor.PredictInt(Child6RotationValueZ, baseline1.Child6RotationValueZ, baseline2.Child6RotationValueZ);
        Child6RotationValueW = predictor.PredictInt(Child6RotationValueW, baseline1.Child6RotationValueW, baseline2.Child6RotationValueW);
        Child6TranslationValueX = predictor.PredictInt(Child6TranslationValueX, baseline1.Child6TranslationValueX, baseline2.Child6TranslationValueX);
        Child6TranslationValueY = predictor.PredictInt(Child6TranslationValueY, baseline1.Child6TranslationValueY, baseline2.Child6TranslationValueY);
        Child6TranslationValueZ = predictor.PredictInt(Child6TranslationValueZ, baseline1.Child6TranslationValueZ, baseline2.Child6TranslationValueZ);
        Child7RotationValueX = predictor.PredictInt(Child7RotationValueX, baseline1.Child7RotationValueX, baseline2.Child7RotationValueX);
        Child7RotationValueY = predictor.PredictInt(Child7RotationValueY, baseline1.Child7RotationValueY, baseline2.Child7RotationValueY);
        Child7RotationValueZ = predictor.PredictInt(Child7RotationValueZ, baseline1.Child7RotationValueZ, baseline2.Child7RotationValueZ);
        Child7RotationValueW = predictor.PredictInt(Child7RotationValueW, baseline1.Child7RotationValueW, baseline2.Child7RotationValueW);
        Child7TranslationValueX = predictor.PredictInt(Child7TranslationValueX, baseline1.Child7TranslationValueX, baseline2.Child7TranslationValueX);
        Child7TranslationValueY = predictor.PredictInt(Child7TranslationValueY, baseline1.Child7TranslationValueY, baseline2.Child7TranslationValueY);
        Child7TranslationValueZ = predictor.PredictInt(Child7TranslationValueZ, baseline1.Child7TranslationValueZ, baseline2.Child7TranslationValueZ);
        Child8RotationValueX = predictor.PredictInt(Child8RotationValueX, baseline1.Child8RotationValueX, baseline2.Child8RotationValueX);
        Child8RotationValueY = predictor.PredictInt(Child8RotationValueY, baseline1.Child8RotationValueY, baseline2.Child8RotationValueY);
        Child8RotationValueZ = predictor.PredictInt(Child8RotationValueZ, baseline1.Child8RotationValueZ, baseline2.Child8RotationValueZ);
        Child8RotationValueW = predictor.PredictInt(Child8RotationValueW, baseline1.Child8RotationValueW, baseline2.Child8RotationValueW);
        Child8TranslationValueX = predictor.PredictInt(Child8TranslationValueX, baseline1.Child8TranslationValueX, baseline2.Child8TranslationValueX);
        Child8TranslationValueY = predictor.PredictInt(Child8TranslationValueY, baseline1.Child8TranslationValueY, baseline2.Child8TranslationValueY);
        Child8TranslationValueZ = predictor.PredictInt(Child8TranslationValueZ, baseline1.Child8TranslationValueZ, baseline2.Child8TranslationValueZ);
        Child9RotationValueX = predictor.PredictInt(Child9RotationValueX, baseline1.Child9RotationValueX, baseline2.Child9RotationValueX);
        Child9RotationValueY = predictor.PredictInt(Child9RotationValueY, baseline1.Child9RotationValueY, baseline2.Child9RotationValueY);
        Child9RotationValueZ = predictor.PredictInt(Child9RotationValueZ, baseline1.Child9RotationValueZ, baseline2.Child9RotationValueZ);
        Child9RotationValueW = predictor.PredictInt(Child9RotationValueW, baseline1.Child9RotationValueW, baseline2.Child9RotationValueW);
        Child9TranslationValueX = predictor.PredictInt(Child9TranslationValueX, baseline1.Child9TranslationValueX, baseline2.Child9TranslationValueX);
        Child9TranslationValueY = predictor.PredictInt(Child9TranslationValueY, baseline1.Child9TranslationValueY, baseline2.Child9TranslationValueY);
        Child9TranslationValueZ = predictor.PredictInt(Child9TranslationValueZ, baseline1.Child9TranslationValueZ, baseline2.Child9TranslationValueZ);
        Child10RotationValueX = predictor.PredictInt(Child10RotationValueX, baseline1.Child10RotationValueX, baseline2.Child10RotationValueX);
        Child10RotationValueY = predictor.PredictInt(Child10RotationValueY, baseline1.Child10RotationValueY, baseline2.Child10RotationValueY);
        Child10RotationValueZ = predictor.PredictInt(Child10RotationValueZ, baseline1.Child10RotationValueZ, baseline2.Child10RotationValueZ);
        Child10RotationValueW = predictor.PredictInt(Child10RotationValueW, baseline1.Child10RotationValueW, baseline2.Child10RotationValueW);
        Child10TranslationValueX = predictor.PredictInt(Child10TranslationValueX, baseline1.Child10TranslationValueX, baseline2.Child10TranslationValueX);
        Child10TranslationValueY = predictor.PredictInt(Child10TranslationValueY, baseline1.Child10TranslationValueY, baseline2.Child10TranslationValueY);
        Child10TranslationValueZ = predictor.PredictInt(Child10TranslationValueZ, baseline1.Child10TranslationValueZ, baseline2.Child10TranslationValueZ);
        Child11RotationValueX = predictor.PredictInt(Child11RotationValueX, baseline1.Child11RotationValueX, baseline2.Child11RotationValueX);
        Child11RotationValueY = predictor.PredictInt(Child11RotationValueY, baseline1.Child11RotationValueY, baseline2.Child11RotationValueY);
        Child11RotationValueZ = predictor.PredictInt(Child11RotationValueZ, baseline1.Child11RotationValueZ, baseline2.Child11RotationValueZ);
        Child11RotationValueW = predictor.PredictInt(Child11RotationValueW, baseline1.Child11RotationValueW, baseline2.Child11RotationValueW);
        Child11TranslationValueX = predictor.PredictInt(Child11TranslationValueX, baseline1.Child11TranslationValueX, baseline2.Child11TranslationValueX);
        Child11TranslationValueY = predictor.PredictInt(Child11TranslationValueY, baseline1.Child11TranslationValueY, baseline2.Child11TranslationValueY);
        Child11TranslationValueZ = predictor.PredictInt(Child11TranslationValueZ, baseline1.Child11TranslationValueZ, baseline2.Child11TranslationValueZ);
        Child12RotationValueX = predictor.PredictInt(Child12RotationValueX, baseline1.Child12RotationValueX, baseline2.Child12RotationValueX);
        Child12RotationValueY = predictor.PredictInt(Child12RotationValueY, baseline1.Child12RotationValueY, baseline2.Child12RotationValueY);
        Child12RotationValueZ = predictor.PredictInt(Child12RotationValueZ, baseline1.Child12RotationValueZ, baseline2.Child12RotationValueZ);
        Child12RotationValueW = predictor.PredictInt(Child12RotationValueW, baseline1.Child12RotationValueW, baseline2.Child12RotationValueW);
        Child12TranslationValueX = predictor.PredictInt(Child12TranslationValueX, baseline1.Child12TranslationValueX, baseline2.Child12TranslationValueX);
        Child12TranslationValueY = predictor.PredictInt(Child12TranslationValueY, baseline1.Child12TranslationValueY, baseline2.Child12TranslationValueY);
        Child12TranslationValueZ = predictor.PredictInt(Child12TranslationValueZ, baseline1.Child12TranslationValueZ, baseline2.Child12TranslationValueZ);
        Child13RotationValueX = predictor.PredictInt(Child13RotationValueX, baseline1.Child13RotationValueX, baseline2.Child13RotationValueX);
        Child13RotationValueY = predictor.PredictInt(Child13RotationValueY, baseline1.Child13RotationValueY, baseline2.Child13RotationValueY);
        Child13RotationValueZ = predictor.PredictInt(Child13RotationValueZ, baseline1.Child13RotationValueZ, baseline2.Child13RotationValueZ);
        Child13RotationValueW = predictor.PredictInt(Child13RotationValueW, baseline1.Child13RotationValueW, baseline2.Child13RotationValueW);
        Child13TranslationValueX = predictor.PredictInt(Child13TranslationValueX, baseline1.Child13TranslationValueX, baseline2.Child13TranslationValueX);
        Child13TranslationValueY = predictor.PredictInt(Child13TranslationValueY, baseline1.Child13TranslationValueY, baseline2.Child13TranslationValueY);
        Child13TranslationValueZ = predictor.PredictInt(Child13TranslationValueZ, baseline1.Child13TranslationValueZ, baseline2.Child13TranslationValueZ);
        Child14RotationValueX = predictor.PredictInt(Child14RotationValueX, baseline1.Child14RotationValueX, baseline2.Child14RotationValueX);
        Child14RotationValueY = predictor.PredictInt(Child14RotationValueY, baseline1.Child14RotationValueY, baseline2.Child14RotationValueY);
        Child14RotationValueZ = predictor.PredictInt(Child14RotationValueZ, baseline1.Child14RotationValueZ, baseline2.Child14RotationValueZ);
        Child14RotationValueW = predictor.PredictInt(Child14RotationValueW, baseline1.Child14RotationValueW, baseline2.Child14RotationValueW);
        Child14TranslationValueX = predictor.PredictInt(Child14TranslationValueX, baseline1.Child14TranslationValueX, baseline2.Child14TranslationValueX);
        Child14TranslationValueY = predictor.PredictInt(Child14TranslationValueY, baseline1.Child14TranslationValueY, baseline2.Child14TranslationValueY);
        Child14TranslationValueZ = predictor.PredictInt(Child14TranslationValueZ, baseline1.Child14TranslationValueZ, baseline2.Child14TranslationValueZ);
        Child15RotationValueX = predictor.PredictInt(Child15RotationValueX, baseline1.Child15RotationValueX, baseline2.Child15RotationValueX);
        Child15RotationValueY = predictor.PredictInt(Child15RotationValueY, baseline1.Child15RotationValueY, baseline2.Child15RotationValueY);
        Child15RotationValueZ = predictor.PredictInt(Child15RotationValueZ, baseline1.Child15RotationValueZ, baseline2.Child15RotationValueZ);
        Child15RotationValueW = predictor.PredictInt(Child15RotationValueW, baseline1.Child15RotationValueW, baseline2.Child15RotationValueW);
        Child15TranslationValueX = predictor.PredictInt(Child15TranslationValueX, baseline1.Child15TranslationValueX, baseline2.Child15TranslationValueX);
        Child15TranslationValueY = predictor.PredictInt(Child15TranslationValueY, baseline1.Child15TranslationValueY, baseline2.Child15TranslationValueY);
        Child15TranslationValueZ = predictor.PredictInt(Child15TranslationValueZ, baseline1.Child15TranslationValueZ, baseline2.Child15TranslationValueZ);
        Child16RotationValueX = predictor.PredictInt(Child16RotationValueX, baseline1.Child16RotationValueX, baseline2.Child16RotationValueX);
        Child16RotationValueY = predictor.PredictInt(Child16RotationValueY, baseline1.Child16RotationValueY, baseline2.Child16RotationValueY);
        Child16RotationValueZ = predictor.PredictInt(Child16RotationValueZ, baseline1.Child16RotationValueZ, baseline2.Child16RotationValueZ);
        Child16RotationValueW = predictor.PredictInt(Child16RotationValueW, baseline1.Child16RotationValueW, baseline2.Child16RotationValueW);
        Child16TranslationValueX = predictor.PredictInt(Child16TranslationValueX, baseline1.Child16TranslationValueX, baseline2.Child16TranslationValueX);
        Child16TranslationValueY = predictor.PredictInt(Child16TranslationValueY, baseline1.Child16TranslationValueY, baseline2.Child16TranslationValueY);
        Child16TranslationValueZ = predictor.PredictInt(Child16TranslationValueZ, baseline1.Child16TranslationValueZ, baseline2.Child16TranslationValueZ);
        Child17RotationValueX = predictor.PredictInt(Child17RotationValueX, baseline1.Child17RotationValueX, baseline2.Child17RotationValueX);
        Child17RotationValueY = predictor.PredictInt(Child17RotationValueY, baseline1.Child17RotationValueY, baseline2.Child17RotationValueY);
        Child17RotationValueZ = predictor.PredictInt(Child17RotationValueZ, baseline1.Child17RotationValueZ, baseline2.Child17RotationValueZ);
        Child17RotationValueW = predictor.PredictInt(Child17RotationValueW, baseline1.Child17RotationValueW, baseline2.Child17RotationValueW);
        Child17TranslationValueX = predictor.PredictInt(Child17TranslationValueX, baseline1.Child17TranslationValueX, baseline2.Child17TranslationValueX);
        Child17TranslationValueY = predictor.PredictInt(Child17TranslationValueY, baseline1.Child17TranslationValueY, baseline2.Child17TranslationValueY);
        Child17TranslationValueZ = predictor.PredictInt(Child17TranslationValueZ, baseline1.Child17TranslationValueZ, baseline2.Child17TranslationValueZ);
        Child18RotationValueX = predictor.PredictInt(Child18RotationValueX, baseline1.Child18RotationValueX, baseline2.Child18RotationValueX);
        Child18RotationValueY = predictor.PredictInt(Child18RotationValueY, baseline1.Child18RotationValueY, baseline2.Child18RotationValueY);
        Child18RotationValueZ = predictor.PredictInt(Child18RotationValueZ, baseline1.Child18RotationValueZ, baseline2.Child18RotationValueZ);
        Child18RotationValueW = predictor.PredictInt(Child18RotationValueW, baseline1.Child18RotationValueW, baseline2.Child18RotationValueW);
        Child18TranslationValueX = predictor.PredictInt(Child18TranslationValueX, baseline1.Child18TranslationValueX, baseline2.Child18TranslationValueX);
        Child18TranslationValueY = predictor.PredictInt(Child18TranslationValueY, baseline1.Child18TranslationValueY, baseline2.Child18TranslationValueY);
        Child18TranslationValueZ = predictor.PredictInt(Child18TranslationValueZ, baseline1.Child18TranslationValueZ, baseline2.Child18TranslationValueZ);
        Child19RotationValueX = predictor.PredictInt(Child19RotationValueX, baseline1.Child19RotationValueX, baseline2.Child19RotationValueX);
        Child19RotationValueY = predictor.PredictInt(Child19RotationValueY, baseline1.Child19RotationValueY, baseline2.Child19RotationValueY);
        Child19RotationValueZ = predictor.PredictInt(Child19RotationValueZ, baseline1.Child19RotationValueZ, baseline2.Child19RotationValueZ);
        Child19RotationValueW = predictor.PredictInt(Child19RotationValueW, baseline1.Child19RotationValueW, baseline2.Child19RotationValueW);
        Child19TranslationValueX = predictor.PredictInt(Child19TranslationValueX, baseline1.Child19TranslationValueX, baseline2.Child19TranslationValueX);
        Child19TranslationValueY = predictor.PredictInt(Child19TranslationValueY, baseline1.Child19TranslationValueY, baseline2.Child19TranslationValueY);
        Child19TranslationValueZ = predictor.PredictInt(Child19TranslationValueZ, baseline1.Child19TranslationValueZ, baseline2.Child19TranslationValueZ);
        Child20RotationValueX = predictor.PredictInt(Child20RotationValueX, baseline1.Child20RotationValueX, baseline2.Child20RotationValueX);
        Child20RotationValueY = predictor.PredictInt(Child20RotationValueY, baseline1.Child20RotationValueY, baseline2.Child20RotationValueY);
        Child20RotationValueZ = predictor.PredictInt(Child20RotationValueZ, baseline1.Child20RotationValueZ, baseline2.Child20RotationValueZ);
        Child20RotationValueW = predictor.PredictInt(Child20RotationValueW, baseline1.Child20RotationValueW, baseline2.Child20RotationValueW);
        Child20TranslationValueX = predictor.PredictInt(Child20TranslationValueX, baseline1.Child20TranslationValueX, baseline2.Child20TranslationValueX);
        Child20TranslationValueY = predictor.PredictInt(Child20TranslationValueY, baseline1.Child20TranslationValueY, baseline2.Child20TranslationValueY);
        Child20TranslationValueZ = predictor.PredictInt(Child20TranslationValueZ, baseline1.Child20TranslationValueZ, baseline2.Child20TranslationValueZ);
        Child21RotationValueX = predictor.PredictInt(Child21RotationValueX, baseline1.Child21RotationValueX, baseline2.Child21RotationValueX);
        Child21RotationValueY = predictor.PredictInt(Child21RotationValueY, baseline1.Child21RotationValueY, baseline2.Child21RotationValueY);
        Child21RotationValueZ = predictor.PredictInt(Child21RotationValueZ, baseline1.Child21RotationValueZ, baseline2.Child21RotationValueZ);
        Child21RotationValueW = predictor.PredictInt(Child21RotationValueW, baseline1.Child21RotationValueW, baseline2.Child21RotationValueW);
        Child21TranslationValueX = predictor.PredictInt(Child21TranslationValueX, baseline1.Child21TranslationValueX, baseline2.Child21TranslationValueX);
        Child21TranslationValueY = predictor.PredictInt(Child21TranslationValueY, baseline1.Child21TranslationValueY, baseline2.Child21TranslationValueY);
        Child21TranslationValueZ = predictor.PredictInt(Child21TranslationValueZ, baseline1.Child21TranslationValueZ, baseline2.Child21TranslationValueZ);
        Child22RotationValueX = predictor.PredictInt(Child22RotationValueX, baseline1.Child22RotationValueX, baseline2.Child22RotationValueX);
        Child22RotationValueY = predictor.PredictInt(Child22RotationValueY, baseline1.Child22RotationValueY, baseline2.Child22RotationValueY);
        Child22RotationValueZ = predictor.PredictInt(Child22RotationValueZ, baseline1.Child22RotationValueZ, baseline2.Child22RotationValueZ);
        Child22RotationValueW = predictor.PredictInt(Child22RotationValueW, baseline1.Child22RotationValueW, baseline2.Child22RotationValueW);
        Child22TranslationValueX = predictor.PredictInt(Child22TranslationValueX, baseline1.Child22TranslationValueX, baseline2.Child22TranslationValueX);
        Child22TranslationValueY = predictor.PredictInt(Child22TranslationValueY, baseline1.Child22TranslationValueY, baseline2.Child22TranslationValueY);
        Child22TranslationValueZ = predictor.PredictInt(Child22TranslationValueZ, baseline1.Child22TranslationValueZ, baseline2.Child22TranslationValueZ);
        Child23RotationValueX = predictor.PredictInt(Child23RotationValueX, baseline1.Child23RotationValueX, baseline2.Child23RotationValueX);
        Child23RotationValueY = predictor.PredictInt(Child23RotationValueY, baseline1.Child23RotationValueY, baseline2.Child23RotationValueY);
        Child23RotationValueZ = predictor.PredictInt(Child23RotationValueZ, baseline1.Child23RotationValueZ, baseline2.Child23RotationValueZ);
        Child23RotationValueW = predictor.PredictInt(Child23RotationValueW, baseline1.Child23RotationValueW, baseline2.Child23RotationValueW);
        Child23TranslationValueX = predictor.PredictInt(Child23TranslationValueX, baseline1.Child23TranslationValueX, baseline2.Child23TranslationValueX);
        Child23TranslationValueY = predictor.PredictInt(Child23TranslationValueY, baseline1.Child23TranslationValueY, baseline2.Child23TranslationValueY);
        Child23TranslationValueZ = predictor.PredictInt(Child23TranslationValueZ, baseline1.Child23TranslationValueZ, baseline2.Child23TranslationValueZ);
        Child24RotationValueX = predictor.PredictInt(Child24RotationValueX, baseline1.Child24RotationValueX, baseline2.Child24RotationValueX);
        Child24RotationValueY = predictor.PredictInt(Child24RotationValueY, baseline1.Child24RotationValueY, baseline2.Child24RotationValueY);
        Child24RotationValueZ = predictor.PredictInt(Child24RotationValueZ, baseline1.Child24RotationValueZ, baseline2.Child24RotationValueZ);
        Child24RotationValueW = predictor.PredictInt(Child24RotationValueW, baseline1.Child24RotationValueW, baseline2.Child24RotationValueW);
        Child24TranslationValueX = predictor.PredictInt(Child24TranslationValueX, baseline1.Child24TranslationValueX, baseline2.Child24TranslationValueX);
        Child24TranslationValueY = predictor.PredictInt(Child24TranslationValueY, baseline1.Child24TranslationValueY, baseline2.Child24TranslationValueY);
        Child24TranslationValueZ = predictor.PredictInt(Child24TranslationValueZ, baseline1.Child24TranslationValueZ, baseline2.Child24TranslationValueZ);
        Child25RotationValueX = predictor.PredictInt(Child25RotationValueX, baseline1.Child25RotationValueX, baseline2.Child25RotationValueX);
        Child25RotationValueY = predictor.PredictInt(Child25RotationValueY, baseline1.Child25RotationValueY, baseline2.Child25RotationValueY);
        Child25RotationValueZ = predictor.PredictInt(Child25RotationValueZ, baseline1.Child25RotationValueZ, baseline2.Child25RotationValueZ);
        Child25RotationValueW = predictor.PredictInt(Child25RotationValueW, baseline1.Child25RotationValueW, baseline2.Child25RotationValueW);
        Child25TranslationValueX = predictor.PredictInt(Child25TranslationValueX, baseline1.Child25TranslationValueX, baseline2.Child25TranslationValueX);
        Child25TranslationValueY = predictor.PredictInt(Child25TranslationValueY, baseline1.Child25TranslationValueY, baseline2.Child25TranslationValueY);
        Child25TranslationValueZ = predictor.PredictInt(Child25TranslationValueZ, baseline1.Child25TranslationValueZ, baseline2.Child25TranslationValueZ);
        Child26RotationValueX = predictor.PredictInt(Child26RotationValueX, baseline1.Child26RotationValueX, baseline2.Child26RotationValueX);
        Child26RotationValueY = predictor.PredictInt(Child26RotationValueY, baseline1.Child26RotationValueY, baseline2.Child26RotationValueY);
        Child26RotationValueZ = predictor.PredictInt(Child26RotationValueZ, baseline1.Child26RotationValueZ, baseline2.Child26RotationValueZ);
        Child26RotationValueW = predictor.PredictInt(Child26RotationValueW, baseline1.Child26RotationValueW, baseline2.Child26RotationValueW);
        Child26TranslationValueX = predictor.PredictInt(Child26TranslationValueX, baseline1.Child26TranslationValueX, baseline2.Child26TranslationValueX);
        Child26TranslationValueY = predictor.PredictInt(Child26TranslationValueY, baseline1.Child26TranslationValueY, baseline2.Child26TranslationValueY);
        Child26TranslationValueZ = predictor.PredictInt(Child26TranslationValueZ, baseline1.Child26TranslationValueZ, baseline2.Child26TranslationValueZ);
        Child27RotationValueX = predictor.PredictInt(Child27RotationValueX, baseline1.Child27RotationValueX, baseline2.Child27RotationValueX);
        Child27RotationValueY = predictor.PredictInt(Child27RotationValueY, baseline1.Child27RotationValueY, baseline2.Child27RotationValueY);
        Child27RotationValueZ = predictor.PredictInt(Child27RotationValueZ, baseline1.Child27RotationValueZ, baseline2.Child27RotationValueZ);
        Child27RotationValueW = predictor.PredictInt(Child27RotationValueW, baseline1.Child27RotationValueW, baseline2.Child27RotationValueW);
        Child27TranslationValueX = predictor.PredictInt(Child27TranslationValueX, baseline1.Child27TranslationValueX, baseline2.Child27TranslationValueX);
        Child27TranslationValueY = predictor.PredictInt(Child27TranslationValueY, baseline1.Child27TranslationValueY, baseline2.Child27TranslationValueY);
        Child27TranslationValueZ = predictor.PredictInt(Child27TranslationValueZ, baseline1.Child27TranslationValueZ, baseline2.Child27TranslationValueZ);
        Child28RotationValueX = predictor.PredictInt(Child28RotationValueX, baseline1.Child28RotationValueX, baseline2.Child28RotationValueX);
        Child28RotationValueY = predictor.PredictInt(Child28RotationValueY, baseline1.Child28RotationValueY, baseline2.Child28RotationValueY);
        Child28RotationValueZ = predictor.PredictInt(Child28RotationValueZ, baseline1.Child28RotationValueZ, baseline2.Child28RotationValueZ);
        Child28RotationValueW = predictor.PredictInt(Child28RotationValueW, baseline1.Child28RotationValueW, baseline2.Child28RotationValueW);
        Child28TranslationValueX = predictor.PredictInt(Child28TranslationValueX, baseline1.Child28TranslationValueX, baseline2.Child28TranslationValueX);
        Child28TranslationValueY = predictor.PredictInt(Child28TranslationValueY, baseline1.Child28TranslationValueY, baseline2.Child28TranslationValueY);
        Child28TranslationValueZ = predictor.PredictInt(Child28TranslationValueZ, baseline1.Child28TranslationValueZ, baseline2.Child28TranslationValueZ);
        Child29RotationValueX = predictor.PredictInt(Child29RotationValueX, baseline1.Child29RotationValueX, baseline2.Child29RotationValueX);
        Child29RotationValueY = predictor.PredictInt(Child29RotationValueY, baseline1.Child29RotationValueY, baseline2.Child29RotationValueY);
        Child29RotationValueZ = predictor.PredictInt(Child29RotationValueZ, baseline1.Child29RotationValueZ, baseline2.Child29RotationValueZ);
        Child29RotationValueW = predictor.PredictInt(Child29RotationValueW, baseline1.Child29RotationValueW, baseline2.Child29RotationValueW);
        Child29TranslationValueX = predictor.PredictInt(Child29TranslationValueX, baseline1.Child29TranslationValueX, baseline2.Child29TranslationValueX);
        Child29TranslationValueY = predictor.PredictInt(Child29TranslationValueY, baseline1.Child29TranslationValueY, baseline2.Child29TranslationValueY);
        Child29TranslationValueZ = predictor.PredictInt(Child29TranslationValueZ, baseline1.Child29TranslationValueZ, baseline2.Child29TranslationValueZ);
        Child30RotationValueX = predictor.PredictInt(Child30RotationValueX, baseline1.Child30RotationValueX, baseline2.Child30RotationValueX);
        Child30RotationValueY = predictor.PredictInt(Child30RotationValueY, baseline1.Child30RotationValueY, baseline2.Child30RotationValueY);
        Child30RotationValueZ = predictor.PredictInt(Child30RotationValueZ, baseline1.Child30RotationValueZ, baseline2.Child30RotationValueZ);
        Child30RotationValueW = predictor.PredictInt(Child30RotationValueW, baseline1.Child30RotationValueW, baseline2.Child30RotationValueW);
        Child30TranslationValueX = predictor.PredictInt(Child30TranslationValueX, baseline1.Child30TranslationValueX, baseline2.Child30TranslationValueX);
        Child30TranslationValueY = predictor.PredictInt(Child30TranslationValueY, baseline1.Child30TranslationValueY, baseline2.Child30TranslationValueY);
        Child30TranslationValueZ = predictor.PredictInt(Child30TranslationValueZ, baseline1.Child30TranslationValueZ, baseline2.Child30TranslationValueZ);
        Child31RotationValueX = predictor.PredictInt(Child31RotationValueX, baseline1.Child31RotationValueX, baseline2.Child31RotationValueX);
        Child31RotationValueY = predictor.PredictInt(Child31RotationValueY, baseline1.Child31RotationValueY, baseline2.Child31RotationValueY);
        Child31RotationValueZ = predictor.PredictInt(Child31RotationValueZ, baseline1.Child31RotationValueZ, baseline2.Child31RotationValueZ);
        Child31RotationValueW = predictor.PredictInt(Child31RotationValueW, baseline1.Child31RotationValueW, baseline2.Child31RotationValueW);
        Child31TranslationValueX = predictor.PredictInt(Child31TranslationValueX, baseline1.Child31TranslationValueX, baseline2.Child31TranslationValueX);
        Child31TranslationValueY = predictor.PredictInt(Child31TranslationValueY, baseline1.Child31TranslationValueY, baseline2.Child31TranslationValueY);
        Child31TranslationValueZ = predictor.PredictInt(Child31TranslationValueZ, baseline1.Child31TranslationValueZ, baseline2.Child31TranslationValueZ);
        Child32RotationValueX = predictor.PredictInt(Child32RotationValueX, baseline1.Child32RotationValueX, baseline2.Child32RotationValueX);
        Child32RotationValueY = predictor.PredictInt(Child32RotationValueY, baseline1.Child32RotationValueY, baseline2.Child32RotationValueY);
        Child32RotationValueZ = predictor.PredictInt(Child32RotationValueZ, baseline1.Child32RotationValueZ, baseline2.Child32RotationValueZ);
        Child32RotationValueW = predictor.PredictInt(Child32RotationValueW, baseline1.Child32RotationValueW, baseline2.Child32RotationValueW);
        Child32TranslationValueX = predictor.PredictInt(Child32TranslationValueX, baseline1.Child32TranslationValueX, baseline2.Child32TranslationValueX);
        Child32TranslationValueY = predictor.PredictInt(Child32TranslationValueY, baseline1.Child32TranslationValueY, baseline2.Child32TranslationValueY);
        Child32TranslationValueZ = predictor.PredictInt(Child32TranslationValueZ, baseline1.Child32TranslationValueZ, baseline2.Child32TranslationValueZ);
        Child33RotationValueX = predictor.PredictInt(Child33RotationValueX, baseline1.Child33RotationValueX, baseline2.Child33RotationValueX);
        Child33RotationValueY = predictor.PredictInt(Child33RotationValueY, baseline1.Child33RotationValueY, baseline2.Child33RotationValueY);
        Child33RotationValueZ = predictor.PredictInt(Child33RotationValueZ, baseline1.Child33RotationValueZ, baseline2.Child33RotationValueZ);
        Child33RotationValueW = predictor.PredictInt(Child33RotationValueW, baseline1.Child33RotationValueW, baseline2.Child33RotationValueW);
        Child33TranslationValueX = predictor.PredictInt(Child33TranslationValueX, baseline1.Child33TranslationValueX, baseline2.Child33TranslationValueX);
        Child33TranslationValueY = predictor.PredictInt(Child33TranslationValueY, baseline1.Child33TranslationValueY, baseline2.Child33TranslationValueY);
        Child33TranslationValueZ = predictor.PredictInt(Child33TranslationValueZ, baseline1.Child33TranslationValueZ, baseline2.Child33TranslationValueZ);
        Child34RotationValueX = predictor.PredictInt(Child34RotationValueX, baseline1.Child34RotationValueX, baseline2.Child34RotationValueX);
        Child34RotationValueY = predictor.PredictInt(Child34RotationValueY, baseline1.Child34RotationValueY, baseline2.Child34RotationValueY);
        Child34RotationValueZ = predictor.PredictInt(Child34RotationValueZ, baseline1.Child34RotationValueZ, baseline2.Child34RotationValueZ);
        Child34RotationValueW = predictor.PredictInt(Child34RotationValueW, baseline1.Child34RotationValueW, baseline2.Child34RotationValueW);
        Child34TranslationValueX = predictor.PredictInt(Child34TranslationValueX, baseline1.Child34TranslationValueX, baseline2.Child34TranslationValueX);
        Child34TranslationValueY = predictor.PredictInt(Child34TranslationValueY, baseline1.Child34TranslationValueY, baseline2.Child34TranslationValueY);
        Child34TranslationValueZ = predictor.PredictInt(Child34TranslationValueZ, baseline1.Child34TranslationValueZ, baseline2.Child34TranslationValueZ);
        Child35RotationValueX = predictor.PredictInt(Child35RotationValueX, baseline1.Child35RotationValueX, baseline2.Child35RotationValueX);
        Child35RotationValueY = predictor.PredictInt(Child35RotationValueY, baseline1.Child35RotationValueY, baseline2.Child35RotationValueY);
        Child35RotationValueZ = predictor.PredictInt(Child35RotationValueZ, baseline1.Child35RotationValueZ, baseline2.Child35RotationValueZ);
        Child35RotationValueW = predictor.PredictInt(Child35RotationValueW, baseline1.Child35RotationValueW, baseline2.Child35RotationValueW);
        Child35TranslationValueX = predictor.PredictInt(Child35TranslationValueX, baseline1.Child35TranslationValueX, baseline2.Child35TranslationValueX);
        Child35TranslationValueY = predictor.PredictInt(Child35TranslationValueY, baseline1.Child35TranslationValueY, baseline2.Child35TranslationValueY);
        Child35TranslationValueZ = predictor.PredictInt(Child35TranslationValueZ, baseline1.Child35TranslationValueZ, baseline2.Child35TranslationValueZ);
        Child36RotationValueX = predictor.PredictInt(Child36RotationValueX, baseline1.Child36RotationValueX, baseline2.Child36RotationValueX);
        Child36RotationValueY = predictor.PredictInt(Child36RotationValueY, baseline1.Child36RotationValueY, baseline2.Child36RotationValueY);
        Child36RotationValueZ = predictor.PredictInt(Child36RotationValueZ, baseline1.Child36RotationValueZ, baseline2.Child36RotationValueZ);
        Child36RotationValueW = predictor.PredictInt(Child36RotationValueW, baseline1.Child36RotationValueW, baseline2.Child36RotationValueW);
        Child36TranslationValueX = predictor.PredictInt(Child36TranslationValueX, baseline1.Child36TranslationValueX, baseline2.Child36TranslationValueX);
        Child36TranslationValueY = predictor.PredictInt(Child36TranslationValueY, baseline1.Child36TranslationValueY, baseline2.Child36TranslationValueY);
        Child36TranslationValueZ = predictor.PredictInt(Child36TranslationValueZ, baseline1.Child36TranslationValueZ, baseline2.Child36TranslationValueZ);
        Child37RotationValueX = predictor.PredictInt(Child37RotationValueX, baseline1.Child37RotationValueX, baseline2.Child37RotationValueX);
        Child37RotationValueY = predictor.PredictInt(Child37RotationValueY, baseline1.Child37RotationValueY, baseline2.Child37RotationValueY);
        Child37RotationValueZ = predictor.PredictInt(Child37RotationValueZ, baseline1.Child37RotationValueZ, baseline2.Child37RotationValueZ);
        Child37RotationValueW = predictor.PredictInt(Child37RotationValueW, baseline1.Child37RotationValueW, baseline2.Child37RotationValueW);
        Child37TranslationValueX = predictor.PredictInt(Child37TranslationValueX, baseline1.Child37TranslationValueX, baseline2.Child37TranslationValueX);
        Child37TranslationValueY = predictor.PredictInt(Child37TranslationValueY, baseline1.Child37TranslationValueY, baseline2.Child37TranslationValueY);
        Child37TranslationValueZ = predictor.PredictInt(Child37TranslationValueZ, baseline1.Child37TranslationValueZ, baseline2.Child37TranslationValueZ);
        Child38RotationValueX = predictor.PredictInt(Child38RotationValueX, baseline1.Child38RotationValueX, baseline2.Child38RotationValueX);
        Child38RotationValueY = predictor.PredictInt(Child38RotationValueY, baseline1.Child38RotationValueY, baseline2.Child38RotationValueY);
        Child38RotationValueZ = predictor.PredictInt(Child38RotationValueZ, baseline1.Child38RotationValueZ, baseline2.Child38RotationValueZ);
        Child38RotationValueW = predictor.PredictInt(Child38RotationValueW, baseline1.Child38RotationValueW, baseline2.Child38RotationValueW);
        Child38TranslationValueX = predictor.PredictInt(Child38TranslationValueX, baseline1.Child38TranslationValueX, baseline2.Child38TranslationValueX);
        Child38TranslationValueY = predictor.PredictInt(Child38TranslationValueY, baseline1.Child38TranslationValueY, baseline2.Child38TranslationValueY);
        Child38TranslationValueZ = predictor.PredictInt(Child38TranslationValueZ, baseline1.Child38TranslationValueZ, baseline2.Child38TranslationValueZ);
        Child39RotationValueX = predictor.PredictInt(Child39RotationValueX, baseline1.Child39RotationValueX, baseline2.Child39RotationValueX);
        Child39RotationValueY = predictor.PredictInt(Child39RotationValueY, baseline1.Child39RotationValueY, baseline2.Child39RotationValueY);
        Child39RotationValueZ = predictor.PredictInt(Child39RotationValueZ, baseline1.Child39RotationValueZ, baseline2.Child39RotationValueZ);
        Child39RotationValueW = predictor.PredictInt(Child39RotationValueW, baseline1.Child39RotationValueW, baseline2.Child39RotationValueW);
        Child39TranslationValueX = predictor.PredictInt(Child39TranslationValueX, baseline1.Child39TranslationValueX, baseline2.Child39TranslationValueX);
        Child39TranslationValueY = predictor.PredictInt(Child39TranslationValueY, baseline1.Child39TranslationValueY, baseline2.Child39TranslationValueY);
        Child39TranslationValueZ = predictor.PredictInt(Child39TranslationValueZ, baseline1.Child39TranslationValueZ, baseline2.Child39TranslationValueZ);
        Child40RotationValueX = predictor.PredictInt(Child40RotationValueX, baseline1.Child40RotationValueX, baseline2.Child40RotationValueX);
        Child40RotationValueY = predictor.PredictInt(Child40RotationValueY, baseline1.Child40RotationValueY, baseline2.Child40RotationValueY);
        Child40RotationValueZ = predictor.PredictInt(Child40RotationValueZ, baseline1.Child40RotationValueZ, baseline2.Child40RotationValueZ);
        Child40RotationValueW = predictor.PredictInt(Child40RotationValueW, baseline1.Child40RotationValueW, baseline2.Child40RotationValueW);
        Child40TranslationValueX = predictor.PredictInt(Child40TranslationValueX, baseline1.Child40TranslationValueX, baseline2.Child40TranslationValueX);
        Child40TranslationValueY = predictor.PredictInt(Child40TranslationValueY, baseline1.Child40TranslationValueY, baseline2.Child40TranslationValueY);
        Child40TranslationValueZ = predictor.PredictInt(Child40TranslationValueZ, baseline1.Child40TranslationValueZ, baseline2.Child40TranslationValueZ);
        Child41RotationValueX = predictor.PredictInt(Child41RotationValueX, baseline1.Child41RotationValueX, baseline2.Child41RotationValueX);
        Child41RotationValueY = predictor.PredictInt(Child41RotationValueY, baseline1.Child41RotationValueY, baseline2.Child41RotationValueY);
        Child41RotationValueZ = predictor.PredictInt(Child41RotationValueZ, baseline1.Child41RotationValueZ, baseline2.Child41RotationValueZ);
        Child41RotationValueW = predictor.PredictInt(Child41RotationValueW, baseline1.Child41RotationValueW, baseline2.Child41RotationValueW);
        Child41TranslationValueX = predictor.PredictInt(Child41TranslationValueX, baseline1.Child41TranslationValueX, baseline2.Child41TranslationValueX);
        Child41TranslationValueY = predictor.PredictInt(Child41TranslationValueY, baseline1.Child41TranslationValueY, baseline2.Child41TranslationValueY);
        Child41TranslationValueZ = predictor.PredictInt(Child41TranslationValueZ, baseline1.Child41TranslationValueZ, baseline2.Child41TranslationValueZ);
        Child42RotationValueX = predictor.PredictInt(Child42RotationValueX, baseline1.Child42RotationValueX, baseline2.Child42RotationValueX);
        Child42RotationValueY = predictor.PredictInt(Child42RotationValueY, baseline1.Child42RotationValueY, baseline2.Child42RotationValueY);
        Child42RotationValueZ = predictor.PredictInt(Child42RotationValueZ, baseline1.Child42RotationValueZ, baseline2.Child42RotationValueZ);
        Child42RotationValueW = predictor.PredictInt(Child42RotationValueW, baseline1.Child42RotationValueW, baseline2.Child42RotationValueW);
        Child42TranslationValueX = predictor.PredictInt(Child42TranslationValueX, baseline1.Child42TranslationValueX, baseline2.Child42TranslationValueX);
        Child42TranslationValueY = predictor.PredictInt(Child42TranslationValueY, baseline1.Child42TranslationValueY, baseline2.Child42TranslationValueY);
        Child42TranslationValueZ = predictor.PredictInt(Child42TranslationValueZ, baseline1.Child42TranslationValueZ, baseline2.Child42TranslationValueZ);
        Child43RotationValueX = predictor.PredictInt(Child43RotationValueX, baseline1.Child43RotationValueX, baseline2.Child43RotationValueX);
        Child43RotationValueY = predictor.PredictInt(Child43RotationValueY, baseline1.Child43RotationValueY, baseline2.Child43RotationValueY);
        Child43RotationValueZ = predictor.PredictInt(Child43RotationValueZ, baseline1.Child43RotationValueZ, baseline2.Child43RotationValueZ);
        Child43RotationValueW = predictor.PredictInt(Child43RotationValueW, baseline1.Child43RotationValueW, baseline2.Child43RotationValueW);
        Child43TranslationValueX = predictor.PredictInt(Child43TranslationValueX, baseline1.Child43TranslationValueX, baseline2.Child43TranslationValueX);
        Child43TranslationValueY = predictor.PredictInt(Child43TranslationValueY, baseline1.Child43TranslationValueY, baseline2.Child43TranslationValueY);
        Child43TranslationValueZ = predictor.PredictInt(Child43TranslationValueZ, baseline1.Child43TranslationValueZ, baseline2.Child43TranslationValueZ);
        Child44RotationValueX = predictor.PredictInt(Child44RotationValueX, baseline1.Child44RotationValueX, baseline2.Child44RotationValueX);
        Child44RotationValueY = predictor.PredictInt(Child44RotationValueY, baseline1.Child44RotationValueY, baseline2.Child44RotationValueY);
        Child44RotationValueZ = predictor.PredictInt(Child44RotationValueZ, baseline1.Child44RotationValueZ, baseline2.Child44RotationValueZ);
        Child44RotationValueW = predictor.PredictInt(Child44RotationValueW, baseline1.Child44RotationValueW, baseline2.Child44RotationValueW);
        Child44TranslationValueX = predictor.PredictInt(Child44TranslationValueX, baseline1.Child44TranslationValueX, baseline2.Child44TranslationValueX);
        Child44TranslationValueY = predictor.PredictInt(Child44TranslationValueY, baseline1.Child44TranslationValueY, baseline2.Child44TranslationValueY);
        Child44TranslationValueZ = predictor.PredictInt(Child44TranslationValueZ, baseline1.Child44TranslationValueZ, baseline2.Child44TranslationValueZ);
        Child45RotationValueX = predictor.PredictInt(Child45RotationValueX, baseline1.Child45RotationValueX, baseline2.Child45RotationValueX);
        Child45RotationValueY = predictor.PredictInt(Child45RotationValueY, baseline1.Child45RotationValueY, baseline2.Child45RotationValueY);
        Child45RotationValueZ = predictor.PredictInt(Child45RotationValueZ, baseline1.Child45RotationValueZ, baseline2.Child45RotationValueZ);
        Child45RotationValueW = predictor.PredictInt(Child45RotationValueW, baseline1.Child45RotationValueW, baseline2.Child45RotationValueW);
        Child45TranslationValueX = predictor.PredictInt(Child45TranslationValueX, baseline1.Child45TranslationValueX, baseline2.Child45TranslationValueX);
        Child45TranslationValueY = predictor.PredictInt(Child45TranslationValueY, baseline1.Child45TranslationValueY, baseline2.Child45TranslationValueY);
        Child45TranslationValueZ = predictor.PredictInt(Child45TranslationValueZ, baseline1.Child45TranslationValueZ, baseline2.Child45TranslationValueZ);
        Child46RotationValueX = predictor.PredictInt(Child46RotationValueX, baseline1.Child46RotationValueX, baseline2.Child46RotationValueX);
        Child46RotationValueY = predictor.PredictInt(Child46RotationValueY, baseline1.Child46RotationValueY, baseline2.Child46RotationValueY);
        Child46RotationValueZ = predictor.PredictInt(Child46RotationValueZ, baseline1.Child46RotationValueZ, baseline2.Child46RotationValueZ);
        Child46RotationValueW = predictor.PredictInt(Child46RotationValueW, baseline1.Child46RotationValueW, baseline2.Child46RotationValueW);
        Child46TranslationValueX = predictor.PredictInt(Child46TranslationValueX, baseline1.Child46TranslationValueX, baseline2.Child46TranslationValueX);
        Child46TranslationValueY = predictor.PredictInt(Child46TranslationValueY, baseline1.Child46TranslationValueY, baseline2.Child46TranslationValueY);
        Child46TranslationValueZ = predictor.PredictInt(Child46TranslationValueZ, baseline1.Child46TranslationValueZ, baseline2.Child46TranslationValueZ);
        Child47RotationValueX = predictor.PredictInt(Child47RotationValueX, baseline1.Child47RotationValueX, baseline2.Child47RotationValueX);
        Child47RotationValueY = predictor.PredictInt(Child47RotationValueY, baseline1.Child47RotationValueY, baseline2.Child47RotationValueY);
        Child47RotationValueZ = predictor.PredictInt(Child47RotationValueZ, baseline1.Child47RotationValueZ, baseline2.Child47RotationValueZ);
        Child47RotationValueW = predictor.PredictInt(Child47RotationValueW, baseline1.Child47RotationValueW, baseline2.Child47RotationValueW);
        Child47TranslationValueX = predictor.PredictInt(Child47TranslationValueX, baseline1.Child47TranslationValueX, baseline2.Child47TranslationValueX);
        Child47TranslationValueY = predictor.PredictInt(Child47TranslationValueY, baseline1.Child47TranslationValueY, baseline2.Child47TranslationValueY);
        Child47TranslationValueZ = predictor.PredictInt(Child47TranslationValueZ, baseline1.Child47TranslationValueZ, baseline2.Child47TranslationValueZ);
        Child48RotationValueX = predictor.PredictInt(Child48RotationValueX, baseline1.Child48RotationValueX, baseline2.Child48RotationValueX);
        Child48RotationValueY = predictor.PredictInt(Child48RotationValueY, baseline1.Child48RotationValueY, baseline2.Child48RotationValueY);
        Child48RotationValueZ = predictor.PredictInt(Child48RotationValueZ, baseline1.Child48RotationValueZ, baseline2.Child48RotationValueZ);
        Child48RotationValueW = predictor.PredictInt(Child48RotationValueW, baseline1.Child48RotationValueW, baseline2.Child48RotationValueW);
        Child48TranslationValueX = predictor.PredictInt(Child48TranslationValueX, baseline1.Child48TranslationValueX, baseline2.Child48TranslationValueX);
        Child48TranslationValueY = predictor.PredictInt(Child48TranslationValueY, baseline1.Child48TranslationValueY, baseline2.Child48TranslationValueY);
        Child48TranslationValueZ = predictor.PredictInt(Child48TranslationValueZ, baseline1.Child48TranslationValueZ, baseline2.Child48TranslationValueZ);
        Child49RotationValueX = predictor.PredictInt(Child49RotationValueX, baseline1.Child49RotationValueX, baseline2.Child49RotationValueX);
        Child49RotationValueY = predictor.PredictInt(Child49RotationValueY, baseline1.Child49RotationValueY, baseline2.Child49RotationValueY);
        Child49RotationValueZ = predictor.PredictInt(Child49RotationValueZ, baseline1.Child49RotationValueZ, baseline2.Child49RotationValueZ);
        Child49RotationValueW = predictor.PredictInt(Child49RotationValueW, baseline1.Child49RotationValueW, baseline2.Child49RotationValueW);
        Child49TranslationValueX = predictor.PredictInt(Child49TranslationValueX, baseline1.Child49TranslationValueX, baseline2.Child49TranslationValueX);
        Child49TranslationValueY = predictor.PredictInt(Child49TranslationValueY, baseline1.Child49TranslationValueY, baseline2.Child49TranslationValueY);
        Child49TranslationValueZ = predictor.PredictInt(Child49TranslationValueZ, baseline1.Child49TranslationValueZ, baseline2.Child49TranslationValueZ);
        Child50RotationValueX = predictor.PredictInt(Child50RotationValueX, baseline1.Child50RotationValueX, baseline2.Child50RotationValueX);
        Child50RotationValueY = predictor.PredictInt(Child50RotationValueY, baseline1.Child50RotationValueY, baseline2.Child50RotationValueY);
        Child50RotationValueZ = predictor.PredictInt(Child50RotationValueZ, baseline1.Child50RotationValueZ, baseline2.Child50RotationValueZ);
        Child50RotationValueW = predictor.PredictInt(Child50RotationValueW, baseline1.Child50RotationValueW, baseline2.Child50RotationValueW);
        Child50TranslationValueX = predictor.PredictInt(Child50TranslationValueX, baseline1.Child50TranslationValueX, baseline2.Child50TranslationValueX);
        Child50TranslationValueY = predictor.PredictInt(Child50TranslationValueY, baseline1.Child50TranslationValueY, baseline2.Child50TranslationValueY);
        Child50TranslationValueZ = predictor.PredictInt(Child50TranslationValueZ, baseline1.Child50TranslationValueZ, baseline2.Child50TranslationValueZ);
        Child51RotationValueX = predictor.PredictInt(Child51RotationValueX, baseline1.Child51RotationValueX, baseline2.Child51RotationValueX);
        Child51RotationValueY = predictor.PredictInt(Child51RotationValueY, baseline1.Child51RotationValueY, baseline2.Child51RotationValueY);
        Child51RotationValueZ = predictor.PredictInt(Child51RotationValueZ, baseline1.Child51RotationValueZ, baseline2.Child51RotationValueZ);
        Child51RotationValueW = predictor.PredictInt(Child51RotationValueW, baseline1.Child51RotationValueW, baseline2.Child51RotationValueW);
        Child51TranslationValueX = predictor.PredictInt(Child51TranslationValueX, baseline1.Child51TranslationValueX, baseline2.Child51TranslationValueX);
        Child51TranslationValueY = predictor.PredictInt(Child51TranslationValueY, baseline1.Child51TranslationValueY, baseline2.Child51TranslationValueY);
        Child51TranslationValueZ = predictor.PredictInt(Child51TranslationValueZ, baseline1.Child51TranslationValueZ, baseline2.Child51TranslationValueZ);
        Child52RotationValueX = predictor.PredictInt(Child52RotationValueX, baseline1.Child52RotationValueX, baseline2.Child52RotationValueX);
        Child52RotationValueY = predictor.PredictInt(Child52RotationValueY, baseline1.Child52RotationValueY, baseline2.Child52RotationValueY);
        Child52RotationValueZ = predictor.PredictInt(Child52RotationValueZ, baseline1.Child52RotationValueZ, baseline2.Child52RotationValueZ);
        Child52RotationValueW = predictor.PredictInt(Child52RotationValueW, baseline1.Child52RotationValueW, baseline2.Child52RotationValueW);
        Child52TranslationValueX = predictor.PredictInt(Child52TranslationValueX, baseline1.Child52TranslationValueX, baseline2.Child52TranslationValueX);
        Child52TranslationValueY = predictor.PredictInt(Child52TranslationValueY, baseline1.Child52TranslationValueY, baseline2.Child52TranslationValueY);
        Child52TranslationValueZ = predictor.PredictInt(Child52TranslationValueZ, baseline1.Child52TranslationValueZ, baseline2.Child52TranslationValueZ);
        Child53RotationValueX = predictor.PredictInt(Child53RotationValueX, baseline1.Child53RotationValueX, baseline2.Child53RotationValueX);
        Child53RotationValueY = predictor.PredictInt(Child53RotationValueY, baseline1.Child53RotationValueY, baseline2.Child53RotationValueY);
        Child53RotationValueZ = predictor.PredictInt(Child53RotationValueZ, baseline1.Child53RotationValueZ, baseline2.Child53RotationValueZ);
        Child53RotationValueW = predictor.PredictInt(Child53RotationValueW, baseline1.Child53RotationValueW, baseline2.Child53RotationValueW);
        Child53TranslationValueX = predictor.PredictInt(Child53TranslationValueX, baseline1.Child53TranslationValueX, baseline2.Child53TranslationValueX);
        Child53TranslationValueY = predictor.PredictInt(Child53TranslationValueY, baseline1.Child53TranslationValueY, baseline2.Child53TranslationValueY);
        Child53TranslationValueZ = predictor.PredictInt(Child53TranslationValueZ, baseline1.Child53TranslationValueZ, baseline2.Child53TranslationValueZ);
        Child54RotationValueX = predictor.PredictInt(Child54RotationValueX, baseline1.Child54RotationValueX, baseline2.Child54RotationValueX);
        Child54RotationValueY = predictor.PredictInt(Child54RotationValueY, baseline1.Child54RotationValueY, baseline2.Child54RotationValueY);
        Child54RotationValueZ = predictor.PredictInt(Child54RotationValueZ, baseline1.Child54RotationValueZ, baseline2.Child54RotationValueZ);
        Child54RotationValueW = predictor.PredictInt(Child54RotationValueW, baseline1.Child54RotationValueW, baseline2.Child54RotationValueW);
        Child54TranslationValueX = predictor.PredictInt(Child54TranslationValueX, baseline1.Child54TranslationValueX, baseline2.Child54TranslationValueX);
        Child54TranslationValueY = predictor.PredictInt(Child54TranslationValueY, baseline1.Child54TranslationValueY, baseline2.Child54TranslationValueY);
        Child54TranslationValueZ = predictor.PredictInt(Child54TranslationValueZ, baseline1.Child54TranslationValueZ, baseline2.Child54TranslationValueZ);
        Child55RotationValueX = predictor.PredictInt(Child55RotationValueX, baseline1.Child55RotationValueX, baseline2.Child55RotationValueX);
        Child55RotationValueY = predictor.PredictInt(Child55RotationValueY, baseline1.Child55RotationValueY, baseline2.Child55RotationValueY);
        Child55RotationValueZ = predictor.PredictInt(Child55RotationValueZ, baseline1.Child55RotationValueZ, baseline2.Child55RotationValueZ);
        Child55RotationValueW = predictor.PredictInt(Child55RotationValueW, baseline1.Child55RotationValueW, baseline2.Child55RotationValueW);
        Child55TranslationValueX = predictor.PredictInt(Child55TranslationValueX, baseline1.Child55TranslationValueX, baseline2.Child55TranslationValueX);
        Child55TranslationValueY = predictor.PredictInt(Child55TranslationValueY, baseline1.Child55TranslationValueY, baseline2.Child55TranslationValueY);
        Child55TranslationValueZ = predictor.PredictInt(Child55TranslationValueZ, baseline1.Child55TranslationValueZ, baseline2.Child55TranslationValueZ);
        Child56RotationValueX = predictor.PredictInt(Child56RotationValueX, baseline1.Child56RotationValueX, baseline2.Child56RotationValueX);
        Child56RotationValueY = predictor.PredictInt(Child56RotationValueY, baseline1.Child56RotationValueY, baseline2.Child56RotationValueY);
        Child56RotationValueZ = predictor.PredictInt(Child56RotationValueZ, baseline1.Child56RotationValueZ, baseline2.Child56RotationValueZ);
        Child56RotationValueW = predictor.PredictInt(Child56RotationValueW, baseline1.Child56RotationValueW, baseline2.Child56RotationValueW);
        Child56TranslationValueX = predictor.PredictInt(Child56TranslationValueX, baseline1.Child56TranslationValueX, baseline2.Child56TranslationValueX);
        Child56TranslationValueY = predictor.PredictInt(Child56TranslationValueY, baseline1.Child56TranslationValueY, baseline2.Child56TranslationValueY);
        Child56TranslationValueZ = predictor.PredictInt(Child56TranslationValueZ, baseline1.Child56TranslationValueZ, baseline2.Child56TranslationValueZ);
        Child57RotationValueX = predictor.PredictInt(Child57RotationValueX, baseline1.Child57RotationValueX, baseline2.Child57RotationValueX);
        Child57RotationValueY = predictor.PredictInt(Child57RotationValueY, baseline1.Child57RotationValueY, baseline2.Child57RotationValueY);
        Child57RotationValueZ = predictor.PredictInt(Child57RotationValueZ, baseline1.Child57RotationValueZ, baseline2.Child57RotationValueZ);
        Child57RotationValueW = predictor.PredictInt(Child57RotationValueW, baseline1.Child57RotationValueW, baseline2.Child57RotationValueW);
        Child57TranslationValueX = predictor.PredictInt(Child57TranslationValueX, baseline1.Child57TranslationValueX, baseline2.Child57TranslationValueX);
        Child57TranslationValueY = predictor.PredictInt(Child57TranslationValueY, baseline1.Child57TranslationValueY, baseline2.Child57TranslationValueY);
        Child57TranslationValueZ = predictor.PredictInt(Child57TranslationValueZ, baseline1.Child57TranslationValueZ, baseline2.Child57TranslationValueZ);
        Child58RotationValueX = predictor.PredictInt(Child58RotationValueX, baseline1.Child58RotationValueX, baseline2.Child58RotationValueX);
        Child58RotationValueY = predictor.PredictInt(Child58RotationValueY, baseline1.Child58RotationValueY, baseline2.Child58RotationValueY);
        Child58RotationValueZ = predictor.PredictInt(Child58RotationValueZ, baseline1.Child58RotationValueZ, baseline2.Child58RotationValueZ);
        Child58RotationValueW = predictor.PredictInt(Child58RotationValueW, baseline1.Child58RotationValueW, baseline2.Child58RotationValueW);
        Child58TranslationValueX = predictor.PredictInt(Child58TranslationValueX, baseline1.Child58TranslationValueX, baseline2.Child58TranslationValueX);
        Child58TranslationValueY = predictor.PredictInt(Child58TranslationValueY, baseline1.Child58TranslationValueY, baseline2.Child58TranslationValueY);
        Child58TranslationValueZ = predictor.PredictInt(Child58TranslationValueZ, baseline1.Child58TranslationValueZ, baseline2.Child58TranslationValueZ);
        Child59RotationValueX = predictor.PredictInt(Child59RotationValueX, baseline1.Child59RotationValueX, baseline2.Child59RotationValueX);
        Child59RotationValueY = predictor.PredictInt(Child59RotationValueY, baseline1.Child59RotationValueY, baseline2.Child59RotationValueY);
        Child59RotationValueZ = predictor.PredictInt(Child59RotationValueZ, baseline1.Child59RotationValueZ, baseline2.Child59RotationValueZ);
        Child59RotationValueW = predictor.PredictInt(Child59RotationValueW, baseline1.Child59RotationValueW, baseline2.Child59RotationValueW);
        Child59TranslationValueX = predictor.PredictInt(Child59TranslationValueX, baseline1.Child59TranslationValueX, baseline2.Child59TranslationValueX);
        Child59TranslationValueY = predictor.PredictInt(Child59TranslationValueY, baseline1.Child59TranslationValueY, baseline2.Child59TranslationValueY);
        Child59TranslationValueZ = predictor.PredictInt(Child59TranslationValueZ, baseline1.Child59TranslationValueZ, baseline2.Child59TranslationValueZ);
        Child60RotationValueX = predictor.PredictInt(Child60RotationValueX, baseline1.Child60RotationValueX, baseline2.Child60RotationValueX);
        Child60RotationValueY = predictor.PredictInt(Child60RotationValueY, baseline1.Child60RotationValueY, baseline2.Child60RotationValueY);
        Child60RotationValueZ = predictor.PredictInt(Child60RotationValueZ, baseline1.Child60RotationValueZ, baseline2.Child60RotationValueZ);
        Child60RotationValueW = predictor.PredictInt(Child60RotationValueW, baseline1.Child60RotationValueW, baseline2.Child60RotationValueW);
        Child60TranslationValueX = predictor.PredictInt(Child60TranslationValueX, baseline1.Child60TranslationValueX, baseline2.Child60TranslationValueX);
        Child60TranslationValueY = predictor.PredictInt(Child60TranslationValueY, baseline1.Child60TranslationValueY, baseline2.Child60TranslationValueY);
        Child60TranslationValueZ = predictor.PredictInt(Child60TranslationValueZ, baseline1.Child60TranslationValueZ, baseline2.Child60TranslationValueZ);
        Child61RotationValueX = predictor.PredictInt(Child61RotationValueX, baseline1.Child61RotationValueX, baseline2.Child61RotationValueX);
        Child61RotationValueY = predictor.PredictInt(Child61RotationValueY, baseline1.Child61RotationValueY, baseline2.Child61RotationValueY);
        Child61RotationValueZ = predictor.PredictInt(Child61RotationValueZ, baseline1.Child61RotationValueZ, baseline2.Child61RotationValueZ);
        Child61RotationValueW = predictor.PredictInt(Child61RotationValueW, baseline1.Child61RotationValueW, baseline2.Child61RotationValueW);
        Child61TranslationValueX = predictor.PredictInt(Child61TranslationValueX, baseline1.Child61TranslationValueX, baseline2.Child61TranslationValueX);
        Child61TranslationValueY = predictor.PredictInt(Child61TranslationValueY, baseline1.Child61TranslationValueY, baseline2.Child61TranslationValueY);
        Child61TranslationValueZ = predictor.PredictInt(Child61TranslationValueZ, baseline1.Child61TranslationValueZ, baseline2.Child61TranslationValueZ);
        Child62RotationValueX = predictor.PredictInt(Child62RotationValueX, baseline1.Child62RotationValueX, baseline2.Child62RotationValueX);
        Child62RotationValueY = predictor.PredictInt(Child62RotationValueY, baseline1.Child62RotationValueY, baseline2.Child62RotationValueY);
        Child62RotationValueZ = predictor.PredictInt(Child62RotationValueZ, baseline1.Child62RotationValueZ, baseline2.Child62RotationValueZ);
        Child62RotationValueW = predictor.PredictInt(Child62RotationValueW, baseline1.Child62RotationValueW, baseline2.Child62RotationValueW);
        Child62TranslationValueX = predictor.PredictInt(Child62TranslationValueX, baseline1.Child62TranslationValueX, baseline2.Child62TranslationValueX);
        Child62TranslationValueY = predictor.PredictInt(Child62TranslationValueY, baseline1.Child62TranslationValueY, baseline2.Child62TranslationValueY);
        Child62TranslationValueZ = predictor.PredictInt(Child62TranslationValueZ, baseline1.Child62TranslationValueZ, baseline2.Child62TranslationValueZ);
        Child63RotationValueX = predictor.PredictInt(Child63RotationValueX, baseline1.Child63RotationValueX, baseline2.Child63RotationValueX);
        Child63RotationValueY = predictor.PredictInt(Child63RotationValueY, baseline1.Child63RotationValueY, baseline2.Child63RotationValueY);
        Child63RotationValueZ = predictor.PredictInt(Child63RotationValueZ, baseline1.Child63RotationValueZ, baseline2.Child63RotationValueZ);
        Child63RotationValueW = predictor.PredictInt(Child63RotationValueW, baseline1.Child63RotationValueW, baseline2.Child63RotationValueW);
        Child63TranslationValueX = predictor.PredictInt(Child63TranslationValueX, baseline1.Child63TranslationValueX, baseline2.Child63TranslationValueX);
        Child63TranslationValueY = predictor.PredictInt(Child63TranslationValueY, baseline1.Child63TranslationValueY, baseline2.Child63TranslationValueY);
        Child63TranslationValueZ = predictor.PredictInt(Child63TranslationValueZ, baseline1.Child63TranslationValueZ, baseline2.Child63TranslationValueZ);
        Child64RotationValueX = predictor.PredictInt(Child64RotationValueX, baseline1.Child64RotationValueX, baseline2.Child64RotationValueX);
        Child64RotationValueY = predictor.PredictInt(Child64RotationValueY, baseline1.Child64RotationValueY, baseline2.Child64RotationValueY);
        Child64RotationValueZ = predictor.PredictInt(Child64RotationValueZ, baseline1.Child64RotationValueZ, baseline2.Child64RotationValueZ);
        Child64RotationValueW = predictor.PredictInt(Child64RotationValueW, baseline1.Child64RotationValueW, baseline2.Child64RotationValueW);
        Child64TranslationValueX = predictor.PredictInt(Child64TranslationValueX, baseline1.Child64TranslationValueX, baseline2.Child64TranslationValueX);
        Child64TranslationValueY = predictor.PredictInt(Child64TranslationValueY, baseline1.Child64TranslationValueY, baseline2.Child64TranslationValueY);
        Child64TranslationValueZ = predictor.PredictInt(Child64TranslationValueZ, baseline1.Child64TranslationValueZ, baseline2.Child64TranslationValueZ);
        Child65RotationValueX = predictor.PredictInt(Child65RotationValueX, baseline1.Child65RotationValueX, baseline2.Child65RotationValueX);
        Child65RotationValueY = predictor.PredictInt(Child65RotationValueY, baseline1.Child65RotationValueY, baseline2.Child65RotationValueY);
        Child65RotationValueZ = predictor.PredictInt(Child65RotationValueZ, baseline1.Child65RotationValueZ, baseline2.Child65RotationValueZ);
        Child65RotationValueW = predictor.PredictInt(Child65RotationValueW, baseline1.Child65RotationValueW, baseline2.Child65RotationValueW);
        Child65TranslationValueX = predictor.PredictInt(Child65TranslationValueX, baseline1.Child65TranslationValueX, baseline2.Child65TranslationValueX);
        Child65TranslationValueY = predictor.PredictInt(Child65TranslationValueY, baseline1.Child65TranslationValueY, baseline2.Child65TranslationValueY);
        Child65TranslationValueZ = predictor.PredictInt(Child65TranslationValueZ, baseline1.Child65TranslationValueZ, baseline2.Child65TranslationValueZ);
        Child66RotationValueX = predictor.PredictInt(Child66RotationValueX, baseline1.Child66RotationValueX, baseline2.Child66RotationValueX);
        Child66RotationValueY = predictor.PredictInt(Child66RotationValueY, baseline1.Child66RotationValueY, baseline2.Child66RotationValueY);
        Child66RotationValueZ = predictor.PredictInt(Child66RotationValueZ, baseline1.Child66RotationValueZ, baseline2.Child66RotationValueZ);
        Child66RotationValueW = predictor.PredictInt(Child66RotationValueW, baseline1.Child66RotationValueW, baseline2.Child66RotationValueW);
        Child66TranslationValueX = predictor.PredictInt(Child66TranslationValueX, baseline1.Child66TranslationValueX, baseline2.Child66TranslationValueX);
        Child66TranslationValueY = predictor.PredictInt(Child66TranslationValueY, baseline1.Child66TranslationValueY, baseline2.Child66TranslationValueY);
        Child66TranslationValueZ = predictor.PredictInt(Child66TranslationValueZ, baseline1.Child66TranslationValueZ, baseline2.Child66TranslationValueZ);
        Child67RotationValueX = predictor.PredictInt(Child67RotationValueX, baseline1.Child67RotationValueX, baseline2.Child67RotationValueX);
        Child67RotationValueY = predictor.PredictInt(Child67RotationValueY, baseline1.Child67RotationValueY, baseline2.Child67RotationValueY);
        Child67RotationValueZ = predictor.PredictInt(Child67RotationValueZ, baseline1.Child67RotationValueZ, baseline2.Child67RotationValueZ);
        Child67RotationValueW = predictor.PredictInt(Child67RotationValueW, baseline1.Child67RotationValueW, baseline2.Child67RotationValueW);
        Child67TranslationValueX = predictor.PredictInt(Child67TranslationValueX, baseline1.Child67TranslationValueX, baseline2.Child67TranslationValueX);
        Child67TranslationValueY = predictor.PredictInt(Child67TranslationValueY, baseline1.Child67TranslationValueY, baseline2.Child67TranslationValueY);
        Child67TranslationValueZ = predictor.PredictInt(Child67TranslationValueZ, baseline1.Child67TranslationValueZ, baseline2.Child67TranslationValueZ);
        Child68RotationValueX = predictor.PredictInt(Child68RotationValueX, baseline1.Child68RotationValueX, baseline2.Child68RotationValueX);
        Child68RotationValueY = predictor.PredictInt(Child68RotationValueY, baseline1.Child68RotationValueY, baseline2.Child68RotationValueY);
        Child68RotationValueZ = predictor.PredictInt(Child68RotationValueZ, baseline1.Child68RotationValueZ, baseline2.Child68RotationValueZ);
        Child68RotationValueW = predictor.PredictInt(Child68RotationValueW, baseline1.Child68RotationValueW, baseline2.Child68RotationValueW);
        Child68TranslationValueX = predictor.PredictInt(Child68TranslationValueX, baseline1.Child68TranslationValueX, baseline2.Child68TranslationValueX);
        Child68TranslationValueY = predictor.PredictInt(Child68TranslationValueY, baseline1.Child68TranslationValueY, baseline2.Child68TranslationValueY);
        Child68TranslationValueZ = predictor.PredictInt(Child68TranslationValueZ, baseline1.Child68TranslationValueZ, baseline2.Child68TranslationValueZ);
        Child69RotationValueX = predictor.PredictInt(Child69RotationValueX, baseline1.Child69RotationValueX, baseline2.Child69RotationValueX);
        Child69RotationValueY = predictor.PredictInt(Child69RotationValueY, baseline1.Child69RotationValueY, baseline2.Child69RotationValueY);
        Child69RotationValueZ = predictor.PredictInt(Child69RotationValueZ, baseline1.Child69RotationValueZ, baseline2.Child69RotationValueZ);
        Child69RotationValueW = predictor.PredictInt(Child69RotationValueW, baseline1.Child69RotationValueW, baseline2.Child69RotationValueW);
        Child69TranslationValueX = predictor.PredictInt(Child69TranslationValueX, baseline1.Child69TranslationValueX, baseline2.Child69TranslationValueX);
        Child69TranslationValueY = predictor.PredictInt(Child69TranslationValueY, baseline1.Child69TranslationValueY, baseline2.Child69TranslationValueY);
        Child69TranslationValueZ = predictor.PredictInt(Child69TranslationValueZ, baseline1.Child69TranslationValueZ, baseline2.Child69TranslationValueZ);
        Child70RotationValueX = predictor.PredictInt(Child70RotationValueX, baseline1.Child70RotationValueX, baseline2.Child70RotationValueX);
        Child70RotationValueY = predictor.PredictInt(Child70RotationValueY, baseline1.Child70RotationValueY, baseline2.Child70RotationValueY);
        Child70RotationValueZ = predictor.PredictInt(Child70RotationValueZ, baseline1.Child70RotationValueZ, baseline2.Child70RotationValueZ);
        Child70RotationValueW = predictor.PredictInt(Child70RotationValueW, baseline1.Child70RotationValueW, baseline2.Child70RotationValueW);
        Child70TranslationValueX = predictor.PredictInt(Child70TranslationValueX, baseline1.Child70TranslationValueX, baseline2.Child70TranslationValueX);
        Child70TranslationValueY = predictor.PredictInt(Child70TranslationValueY, baseline1.Child70TranslationValueY, baseline2.Child70TranslationValueY);
        Child70TranslationValueZ = predictor.PredictInt(Child70TranslationValueZ, baseline1.Child70TranslationValueZ, baseline2.Child70TranslationValueZ);
        Child71RotationValueX = predictor.PredictInt(Child71RotationValueX, baseline1.Child71RotationValueX, baseline2.Child71RotationValueX);
        Child71RotationValueY = predictor.PredictInt(Child71RotationValueY, baseline1.Child71RotationValueY, baseline2.Child71RotationValueY);
        Child71RotationValueZ = predictor.PredictInt(Child71RotationValueZ, baseline1.Child71RotationValueZ, baseline2.Child71RotationValueZ);
        Child71RotationValueW = predictor.PredictInt(Child71RotationValueW, baseline1.Child71RotationValueW, baseline2.Child71RotationValueW);
        Child71TranslationValueX = predictor.PredictInt(Child71TranslationValueX, baseline1.Child71TranslationValueX, baseline2.Child71TranslationValueX);
        Child71TranslationValueY = predictor.PredictInt(Child71TranslationValueY, baseline1.Child71TranslationValueY, baseline2.Child71TranslationValueY);
        Child71TranslationValueZ = predictor.PredictInt(Child71TranslationValueZ, baseline1.Child71TranslationValueZ, baseline2.Child71TranslationValueZ);
        Child72RotationValueX = predictor.PredictInt(Child72RotationValueX, baseline1.Child72RotationValueX, baseline2.Child72RotationValueX);
        Child72RotationValueY = predictor.PredictInt(Child72RotationValueY, baseline1.Child72RotationValueY, baseline2.Child72RotationValueY);
        Child72RotationValueZ = predictor.PredictInt(Child72RotationValueZ, baseline1.Child72RotationValueZ, baseline2.Child72RotationValueZ);
        Child72RotationValueW = predictor.PredictInt(Child72RotationValueW, baseline1.Child72RotationValueW, baseline2.Child72RotationValueW);
        Child72TranslationValueX = predictor.PredictInt(Child72TranslationValueX, baseline1.Child72TranslationValueX, baseline2.Child72TranslationValueX);
        Child72TranslationValueY = predictor.PredictInt(Child72TranslationValueY, baseline1.Child72TranslationValueY, baseline2.Child72TranslationValueY);
        Child72TranslationValueZ = predictor.PredictInt(Child72TranslationValueZ, baseline1.Child72TranslationValueZ, baseline2.Child72TranslationValueZ);
        Child73RotationValueX = predictor.PredictInt(Child73RotationValueX, baseline1.Child73RotationValueX, baseline2.Child73RotationValueX);
        Child73RotationValueY = predictor.PredictInt(Child73RotationValueY, baseline1.Child73RotationValueY, baseline2.Child73RotationValueY);
        Child73RotationValueZ = predictor.PredictInt(Child73RotationValueZ, baseline1.Child73RotationValueZ, baseline2.Child73RotationValueZ);
        Child73RotationValueW = predictor.PredictInt(Child73RotationValueW, baseline1.Child73RotationValueW, baseline2.Child73RotationValueW);
        Child73TranslationValueX = predictor.PredictInt(Child73TranslationValueX, baseline1.Child73TranslationValueX, baseline2.Child73TranslationValueX);
        Child73TranslationValueY = predictor.PredictInt(Child73TranslationValueY, baseline1.Child73TranslationValueY, baseline2.Child73TranslationValueY);
        Child73TranslationValueZ = predictor.PredictInt(Child73TranslationValueZ, baseline1.Child73TranslationValueZ, baseline2.Child73TranslationValueZ);
        Child74RotationValueX = predictor.PredictInt(Child74RotationValueX, baseline1.Child74RotationValueX, baseline2.Child74RotationValueX);
        Child74RotationValueY = predictor.PredictInt(Child74RotationValueY, baseline1.Child74RotationValueY, baseline2.Child74RotationValueY);
        Child74RotationValueZ = predictor.PredictInt(Child74RotationValueZ, baseline1.Child74RotationValueZ, baseline2.Child74RotationValueZ);
        Child74RotationValueW = predictor.PredictInt(Child74RotationValueW, baseline1.Child74RotationValueW, baseline2.Child74RotationValueW);
        Child74TranslationValueX = predictor.PredictInt(Child74TranslationValueX, baseline1.Child74TranslationValueX, baseline2.Child74TranslationValueX);
        Child74TranslationValueY = predictor.PredictInt(Child74TranslationValueY, baseline1.Child74TranslationValueY, baseline2.Child74TranslationValueY);
        Child74TranslationValueZ = predictor.PredictInt(Child74TranslationValueZ, baseline1.Child74TranslationValueZ, baseline2.Child74TranslationValueZ);
        Child75RotationValueX = predictor.PredictInt(Child75RotationValueX, baseline1.Child75RotationValueX, baseline2.Child75RotationValueX);
        Child75RotationValueY = predictor.PredictInt(Child75RotationValueY, baseline1.Child75RotationValueY, baseline2.Child75RotationValueY);
        Child75RotationValueZ = predictor.PredictInt(Child75RotationValueZ, baseline1.Child75RotationValueZ, baseline2.Child75RotationValueZ);
        Child75RotationValueW = predictor.PredictInt(Child75RotationValueW, baseline1.Child75RotationValueW, baseline2.Child75RotationValueW);
        Child75TranslationValueX = predictor.PredictInt(Child75TranslationValueX, baseline1.Child75TranslationValueX, baseline2.Child75TranslationValueX);
        Child75TranslationValueY = predictor.PredictInt(Child75TranslationValueY, baseline1.Child75TranslationValueY, baseline2.Child75TranslationValueY);
        Child75TranslationValueZ = predictor.PredictInt(Child75TranslationValueZ, baseline1.Child75TranslationValueZ, baseline2.Child75TranslationValueZ);
        Child76RotationValueX = predictor.PredictInt(Child76RotationValueX, baseline1.Child76RotationValueX, baseline2.Child76RotationValueX);
        Child76RotationValueY = predictor.PredictInt(Child76RotationValueY, baseline1.Child76RotationValueY, baseline2.Child76RotationValueY);
        Child76RotationValueZ = predictor.PredictInt(Child76RotationValueZ, baseline1.Child76RotationValueZ, baseline2.Child76RotationValueZ);
        Child76RotationValueW = predictor.PredictInt(Child76RotationValueW, baseline1.Child76RotationValueW, baseline2.Child76RotationValueW);
        Child76TranslationValueX = predictor.PredictInt(Child76TranslationValueX, baseline1.Child76TranslationValueX, baseline2.Child76TranslationValueX);
        Child76TranslationValueY = predictor.PredictInt(Child76TranslationValueY, baseline1.Child76TranslationValueY, baseline2.Child76TranslationValueY);
        Child76TranslationValueZ = predictor.PredictInt(Child76TranslationValueZ, baseline1.Child76TranslationValueZ, baseline2.Child76TranslationValueZ);
        Child77RotationValueX = predictor.PredictInt(Child77RotationValueX, baseline1.Child77RotationValueX, baseline2.Child77RotationValueX);
        Child77RotationValueY = predictor.PredictInt(Child77RotationValueY, baseline1.Child77RotationValueY, baseline2.Child77RotationValueY);
        Child77RotationValueZ = predictor.PredictInt(Child77RotationValueZ, baseline1.Child77RotationValueZ, baseline2.Child77RotationValueZ);
        Child77RotationValueW = predictor.PredictInt(Child77RotationValueW, baseline1.Child77RotationValueW, baseline2.Child77RotationValueW);
        Child77TranslationValueX = predictor.PredictInt(Child77TranslationValueX, baseline1.Child77TranslationValueX, baseline2.Child77TranslationValueX);
        Child77TranslationValueY = predictor.PredictInt(Child77TranslationValueY, baseline1.Child77TranslationValueY, baseline2.Child77TranslationValueY);
        Child77TranslationValueZ = predictor.PredictInt(Child77TranslationValueZ, baseline1.Child77TranslationValueZ, baseline2.Child77TranslationValueZ);
        Child78RotationValueX = predictor.PredictInt(Child78RotationValueX, baseline1.Child78RotationValueX, baseline2.Child78RotationValueX);
        Child78RotationValueY = predictor.PredictInt(Child78RotationValueY, baseline1.Child78RotationValueY, baseline2.Child78RotationValueY);
        Child78RotationValueZ = predictor.PredictInt(Child78RotationValueZ, baseline1.Child78RotationValueZ, baseline2.Child78RotationValueZ);
        Child78RotationValueW = predictor.PredictInt(Child78RotationValueW, baseline1.Child78RotationValueW, baseline2.Child78RotationValueW);
        Child78TranslationValueX = predictor.PredictInt(Child78TranslationValueX, baseline1.Child78TranslationValueX, baseline2.Child78TranslationValueX);
        Child78TranslationValueY = predictor.PredictInt(Child78TranslationValueY, baseline1.Child78TranslationValueY, baseline2.Child78TranslationValueY);
        Child78TranslationValueZ = predictor.PredictInt(Child78TranslationValueZ, baseline1.Child78TranslationValueZ, baseline2.Child78TranslationValueZ);
        Child79RotationValueX = predictor.PredictInt(Child79RotationValueX, baseline1.Child79RotationValueX, baseline2.Child79RotationValueX);
        Child79RotationValueY = predictor.PredictInt(Child79RotationValueY, baseline1.Child79RotationValueY, baseline2.Child79RotationValueY);
        Child79RotationValueZ = predictor.PredictInt(Child79RotationValueZ, baseline1.Child79RotationValueZ, baseline2.Child79RotationValueZ);
        Child79RotationValueW = predictor.PredictInt(Child79RotationValueW, baseline1.Child79RotationValueW, baseline2.Child79RotationValueW);
        Child79TranslationValueX = predictor.PredictInt(Child79TranslationValueX, baseline1.Child79TranslationValueX, baseline2.Child79TranslationValueX);
        Child79TranslationValueY = predictor.PredictInt(Child79TranslationValueY, baseline1.Child79TranslationValueY, baseline2.Child79TranslationValueY);
        Child79TranslationValueZ = predictor.PredictInt(Child79TranslationValueZ, baseline1.Child79TranslationValueZ, baseline2.Child79TranslationValueZ);
        Child80RotationValueX = predictor.PredictInt(Child80RotationValueX, baseline1.Child80RotationValueX, baseline2.Child80RotationValueX);
        Child80RotationValueY = predictor.PredictInt(Child80RotationValueY, baseline1.Child80RotationValueY, baseline2.Child80RotationValueY);
        Child80RotationValueZ = predictor.PredictInt(Child80RotationValueZ, baseline1.Child80RotationValueZ, baseline2.Child80RotationValueZ);
        Child80RotationValueW = predictor.PredictInt(Child80RotationValueW, baseline1.Child80RotationValueW, baseline2.Child80RotationValueW);
        Child80TranslationValueX = predictor.PredictInt(Child80TranslationValueX, baseline1.Child80TranslationValueX, baseline2.Child80TranslationValueX);
        Child80TranslationValueY = predictor.PredictInt(Child80TranslationValueY, baseline1.Child80TranslationValueY, baseline2.Child80TranslationValueY);
        Child80TranslationValueZ = predictor.PredictInt(Child80TranslationValueZ, baseline1.Child80TranslationValueZ, baseline2.Child80TranslationValueZ);
        Child81RotationValueX = predictor.PredictInt(Child81RotationValueX, baseline1.Child81RotationValueX, baseline2.Child81RotationValueX);
        Child81RotationValueY = predictor.PredictInt(Child81RotationValueY, baseline1.Child81RotationValueY, baseline2.Child81RotationValueY);
        Child81RotationValueZ = predictor.PredictInt(Child81RotationValueZ, baseline1.Child81RotationValueZ, baseline2.Child81RotationValueZ);
        Child81RotationValueW = predictor.PredictInt(Child81RotationValueW, baseline1.Child81RotationValueW, baseline2.Child81RotationValueW);
        Child81TranslationValueX = predictor.PredictInt(Child81TranslationValueX, baseline1.Child81TranslationValueX, baseline2.Child81TranslationValueX);
        Child81TranslationValueY = predictor.PredictInt(Child81TranslationValueY, baseline1.Child81TranslationValueY, baseline2.Child81TranslationValueY);
        Child81TranslationValueZ = predictor.PredictInt(Child81TranslationValueZ, baseline1.Child81TranslationValueZ, baseline2.Child81TranslationValueZ);
        Child82RotationValueX = predictor.PredictInt(Child82RotationValueX, baseline1.Child82RotationValueX, baseline2.Child82RotationValueX);
        Child82RotationValueY = predictor.PredictInt(Child82RotationValueY, baseline1.Child82RotationValueY, baseline2.Child82RotationValueY);
        Child82RotationValueZ = predictor.PredictInt(Child82RotationValueZ, baseline1.Child82RotationValueZ, baseline2.Child82RotationValueZ);
        Child82RotationValueW = predictor.PredictInt(Child82RotationValueW, baseline1.Child82RotationValueW, baseline2.Child82RotationValueW);
        Child82TranslationValueX = predictor.PredictInt(Child82TranslationValueX, baseline1.Child82TranslationValueX, baseline2.Child82TranslationValueX);
        Child82TranslationValueY = predictor.PredictInt(Child82TranslationValueY, baseline1.Child82TranslationValueY, baseline2.Child82TranslationValueY);
        Child82TranslationValueZ = predictor.PredictInt(Child82TranslationValueZ, baseline1.Child82TranslationValueZ, baseline2.Child82TranslationValueZ);
        Child83RotationValueX = predictor.PredictInt(Child83RotationValueX, baseline1.Child83RotationValueX, baseline2.Child83RotationValueX);
        Child83RotationValueY = predictor.PredictInt(Child83RotationValueY, baseline1.Child83RotationValueY, baseline2.Child83RotationValueY);
        Child83RotationValueZ = predictor.PredictInt(Child83RotationValueZ, baseline1.Child83RotationValueZ, baseline2.Child83RotationValueZ);
        Child83RotationValueW = predictor.PredictInt(Child83RotationValueW, baseline1.Child83RotationValueW, baseline2.Child83RotationValueW);
        Child83TranslationValueX = predictor.PredictInt(Child83TranslationValueX, baseline1.Child83TranslationValueX, baseline2.Child83TranslationValueX);
        Child83TranslationValueY = predictor.PredictInt(Child83TranslationValueY, baseline1.Child83TranslationValueY, baseline2.Child83TranslationValueY);
        Child83TranslationValueZ = predictor.PredictInt(Child83TranslationValueZ, baseline1.Child83TranslationValueZ, baseline2.Child83TranslationValueZ);
        Child84RotationValueX = predictor.PredictInt(Child84RotationValueX, baseline1.Child84RotationValueX, baseline2.Child84RotationValueX);
        Child84RotationValueY = predictor.PredictInt(Child84RotationValueY, baseline1.Child84RotationValueY, baseline2.Child84RotationValueY);
        Child84RotationValueZ = predictor.PredictInt(Child84RotationValueZ, baseline1.Child84RotationValueZ, baseline2.Child84RotationValueZ);
        Child84RotationValueW = predictor.PredictInt(Child84RotationValueW, baseline1.Child84RotationValueW, baseline2.Child84RotationValueW);
        Child84TranslationValueX = predictor.PredictInt(Child84TranslationValueX, baseline1.Child84TranslationValueX, baseline2.Child84TranslationValueX);
        Child84TranslationValueY = predictor.PredictInt(Child84TranslationValueY, baseline1.Child84TranslationValueY, baseline2.Child84TranslationValueY);
        Child84TranslationValueZ = predictor.PredictInt(Child84TranslationValueZ, baseline1.Child84TranslationValueZ, baseline2.Child84TranslationValueZ);
        Child85RotationValueX = predictor.PredictInt(Child85RotationValueX, baseline1.Child85RotationValueX, baseline2.Child85RotationValueX);
        Child85RotationValueY = predictor.PredictInt(Child85RotationValueY, baseline1.Child85RotationValueY, baseline2.Child85RotationValueY);
        Child85RotationValueZ = predictor.PredictInt(Child85RotationValueZ, baseline1.Child85RotationValueZ, baseline2.Child85RotationValueZ);
        Child85RotationValueW = predictor.PredictInt(Child85RotationValueW, baseline1.Child85RotationValueW, baseline2.Child85RotationValueW);
        Child85TranslationValueX = predictor.PredictInt(Child85TranslationValueX, baseline1.Child85TranslationValueX, baseline2.Child85TranslationValueX);
        Child85TranslationValueY = predictor.PredictInt(Child85TranslationValueY, baseline1.Child85TranslationValueY, baseline2.Child85TranslationValueY);
        Child85TranslationValueZ = predictor.PredictInt(Child85TranslationValueZ, baseline1.Child85TranslationValueZ, baseline2.Child85TranslationValueZ);
        Child86RotationValueX = predictor.PredictInt(Child86RotationValueX, baseline1.Child86RotationValueX, baseline2.Child86RotationValueX);
        Child86RotationValueY = predictor.PredictInt(Child86RotationValueY, baseline1.Child86RotationValueY, baseline2.Child86RotationValueY);
        Child86RotationValueZ = predictor.PredictInt(Child86RotationValueZ, baseline1.Child86RotationValueZ, baseline2.Child86RotationValueZ);
        Child86RotationValueW = predictor.PredictInt(Child86RotationValueW, baseline1.Child86RotationValueW, baseline2.Child86RotationValueW);
        Child86TranslationValueX = predictor.PredictInt(Child86TranslationValueX, baseline1.Child86TranslationValueX, baseline2.Child86TranslationValueX);
        Child86TranslationValueY = predictor.PredictInt(Child86TranslationValueY, baseline1.Child86TranslationValueY, baseline2.Child86TranslationValueY);
        Child86TranslationValueZ = predictor.PredictInt(Child86TranslationValueZ, baseline1.Child86TranslationValueZ, baseline2.Child86TranslationValueZ);
    }

    public void Serialize(int networkId, ref ThirdPersonControllerSnapshotData baseline, ref DataStreamWriter writer, NetworkCompressionModel compressionModel)
    {
        changeMask0 = (MovablePlayerPlayerId != baseline.MovablePlayerPlayerId) ? 1u : 0;
        changeMask0 |= (RotationValueX != baseline.RotationValueX ||
                                           RotationValueY != baseline.RotationValueY ||
                                           RotationValueZ != baseline.RotationValueZ ||
                                           RotationValueW != baseline.RotationValueW) ? (1u<<1) : 0;
        changeMask0 |= (TranslationValueX != baseline.TranslationValueX ||
                                           TranslationValueY != baseline.TranslationValueY ||
                                           TranslationValueZ != baseline.TranslationValueZ) ? (1u<<2) : 0;
        changeMask0 |= (Child0RotationValueX != baseline.Child0RotationValueX ||
                                           Child0RotationValueY != baseline.Child0RotationValueY ||
                                           Child0RotationValueZ != baseline.Child0RotationValueZ ||
                                           Child0RotationValueW != baseline.Child0RotationValueW) ? (1u<<3) : 0;
        changeMask0 |= (Child0TranslationValueX != baseline.Child0TranslationValueX ||
                                           Child0TranslationValueY != baseline.Child0TranslationValueY ||
                                           Child0TranslationValueZ != baseline.Child0TranslationValueZ) ? (1u<<4) : 0;
        changeMask0 |= (Child1RotationValueX != baseline.Child1RotationValueX ||
                                           Child1RotationValueY != baseline.Child1RotationValueY ||
                                           Child1RotationValueZ != baseline.Child1RotationValueZ ||
                                           Child1RotationValueW != baseline.Child1RotationValueW) ? (1u<<5) : 0;
        changeMask0 |= (Child1TranslationValueX != baseline.Child1TranslationValueX ||
                                           Child1TranslationValueY != baseline.Child1TranslationValueY ||
                                           Child1TranslationValueZ != baseline.Child1TranslationValueZ) ? (1u<<6) : 0;
        changeMask0 |= (Child2RotationValueX != baseline.Child2RotationValueX ||
                                           Child2RotationValueY != baseline.Child2RotationValueY ||
                                           Child2RotationValueZ != baseline.Child2RotationValueZ ||
                                           Child2RotationValueW != baseline.Child2RotationValueW) ? (1u<<7) : 0;
        changeMask0 |= (Child2TranslationValueX != baseline.Child2TranslationValueX ||
                                           Child2TranslationValueY != baseline.Child2TranslationValueY ||
                                           Child2TranslationValueZ != baseline.Child2TranslationValueZ) ? (1u<<8) : 0;
        changeMask0 |= (Child3RotationValueX != baseline.Child3RotationValueX ||
                                           Child3RotationValueY != baseline.Child3RotationValueY ||
                                           Child3RotationValueZ != baseline.Child3RotationValueZ ||
                                           Child3RotationValueW != baseline.Child3RotationValueW) ? (1u<<9) : 0;
        changeMask0 |= (Child3TranslationValueX != baseline.Child3TranslationValueX ||
                                           Child3TranslationValueY != baseline.Child3TranslationValueY ||
                                           Child3TranslationValueZ != baseline.Child3TranslationValueZ) ? (1u<<10) : 0;
        changeMask0 |= (Child4RotationValueX != baseline.Child4RotationValueX ||
                                           Child4RotationValueY != baseline.Child4RotationValueY ||
                                           Child4RotationValueZ != baseline.Child4RotationValueZ ||
                                           Child4RotationValueW != baseline.Child4RotationValueW) ? (1u<<11) : 0;
        changeMask0 |= (Child4TranslationValueX != baseline.Child4TranslationValueX ||
                                           Child4TranslationValueY != baseline.Child4TranslationValueY ||
                                           Child4TranslationValueZ != baseline.Child4TranslationValueZ) ? (1u<<12) : 0;
        changeMask0 |= (Child5RotationValueX != baseline.Child5RotationValueX ||
                                           Child5RotationValueY != baseline.Child5RotationValueY ||
                                           Child5RotationValueZ != baseline.Child5RotationValueZ ||
                                           Child5RotationValueW != baseline.Child5RotationValueW) ? (1u<<13) : 0;
        changeMask0 |= (Child5TranslationValueX != baseline.Child5TranslationValueX ||
                                           Child5TranslationValueY != baseline.Child5TranslationValueY ||
                                           Child5TranslationValueZ != baseline.Child5TranslationValueZ) ? (1u<<14) : 0;
        changeMask0 |= (Child6RotationValueX != baseline.Child6RotationValueX ||
                                           Child6RotationValueY != baseline.Child6RotationValueY ||
                                           Child6RotationValueZ != baseline.Child6RotationValueZ ||
                                           Child6RotationValueW != baseline.Child6RotationValueW) ? (1u<<15) : 0;
        changeMask0 |= (Child6TranslationValueX != baseline.Child6TranslationValueX ||
                                           Child6TranslationValueY != baseline.Child6TranslationValueY ||
                                           Child6TranslationValueZ != baseline.Child6TranslationValueZ) ? (1u<<16) : 0;
        changeMask0 |= (Child7RotationValueX != baseline.Child7RotationValueX ||
                                           Child7RotationValueY != baseline.Child7RotationValueY ||
                                           Child7RotationValueZ != baseline.Child7RotationValueZ ||
                                           Child7RotationValueW != baseline.Child7RotationValueW) ? (1u<<17) : 0;
        changeMask0 |= (Child7TranslationValueX != baseline.Child7TranslationValueX ||
                                           Child7TranslationValueY != baseline.Child7TranslationValueY ||
                                           Child7TranslationValueZ != baseline.Child7TranslationValueZ) ? (1u<<18) : 0;
        changeMask0 |= (Child8RotationValueX != baseline.Child8RotationValueX ||
                                           Child8RotationValueY != baseline.Child8RotationValueY ||
                                           Child8RotationValueZ != baseline.Child8RotationValueZ ||
                                           Child8RotationValueW != baseline.Child8RotationValueW) ? (1u<<19) : 0;
        changeMask0 |= (Child8TranslationValueX != baseline.Child8TranslationValueX ||
                                           Child8TranslationValueY != baseline.Child8TranslationValueY ||
                                           Child8TranslationValueZ != baseline.Child8TranslationValueZ) ? (1u<<20) : 0;
        changeMask0 |= (Child9RotationValueX != baseline.Child9RotationValueX ||
                                           Child9RotationValueY != baseline.Child9RotationValueY ||
                                           Child9RotationValueZ != baseline.Child9RotationValueZ ||
                                           Child9RotationValueW != baseline.Child9RotationValueW) ? (1u<<21) : 0;
        changeMask0 |= (Child9TranslationValueX != baseline.Child9TranslationValueX ||
                                           Child9TranslationValueY != baseline.Child9TranslationValueY ||
                                           Child9TranslationValueZ != baseline.Child9TranslationValueZ) ? (1u<<22) : 0;
        changeMask0 |= (Child10RotationValueX != baseline.Child10RotationValueX ||
                                           Child10RotationValueY != baseline.Child10RotationValueY ||
                                           Child10RotationValueZ != baseline.Child10RotationValueZ ||
                                           Child10RotationValueW != baseline.Child10RotationValueW) ? (1u<<23) : 0;
        changeMask0 |= (Child10TranslationValueX != baseline.Child10TranslationValueX ||
                                           Child10TranslationValueY != baseline.Child10TranslationValueY ||
                                           Child10TranslationValueZ != baseline.Child10TranslationValueZ) ? (1u<<24) : 0;
        changeMask0 |= (Child11RotationValueX != baseline.Child11RotationValueX ||
                                           Child11RotationValueY != baseline.Child11RotationValueY ||
                                           Child11RotationValueZ != baseline.Child11RotationValueZ ||
                                           Child11RotationValueW != baseline.Child11RotationValueW) ? (1u<<25) : 0;
        changeMask0 |= (Child11TranslationValueX != baseline.Child11TranslationValueX ||
                                           Child11TranslationValueY != baseline.Child11TranslationValueY ||
                                           Child11TranslationValueZ != baseline.Child11TranslationValueZ) ? (1u<<26) : 0;
        changeMask0 |= (Child12RotationValueX != baseline.Child12RotationValueX ||
                                           Child12RotationValueY != baseline.Child12RotationValueY ||
                                           Child12RotationValueZ != baseline.Child12RotationValueZ ||
                                           Child12RotationValueW != baseline.Child12RotationValueW) ? (1u<<27) : 0;
        changeMask0 |= (Child12TranslationValueX != baseline.Child12TranslationValueX ||
                                           Child12TranslationValueY != baseline.Child12TranslationValueY ||
                                           Child12TranslationValueZ != baseline.Child12TranslationValueZ) ? (1u<<28) : 0;
        changeMask0 |= (Child13RotationValueX != baseline.Child13RotationValueX ||
                                           Child13RotationValueY != baseline.Child13RotationValueY ||
                                           Child13RotationValueZ != baseline.Child13RotationValueZ ||
                                           Child13RotationValueW != baseline.Child13RotationValueW) ? (1u<<29) : 0;
        changeMask0 |= (Child13TranslationValueX != baseline.Child13TranslationValueX ||
                                           Child13TranslationValueY != baseline.Child13TranslationValueY ||
                                           Child13TranslationValueZ != baseline.Child13TranslationValueZ) ? (1u<<30) : 0;
        changeMask0 |= (Child14RotationValueX != baseline.Child14RotationValueX ||
                                           Child14RotationValueY != baseline.Child14RotationValueY ||
                                           Child14RotationValueZ != baseline.Child14RotationValueZ ||
                                           Child14RotationValueW != baseline.Child14RotationValueW) ? (1u<<31) : 0;
        changeMask1 = (Child14TranslationValueX != baseline.Child14TranslationValueX ||
                                          Child14TranslationValueY != baseline.Child14TranslationValueY ||
                                          Child14TranslationValueZ != baseline.Child14TranslationValueZ) ? 1u : 0;
        changeMask1 |= (Child15RotationValueX != baseline.Child15RotationValueX ||
                                           Child15RotationValueY != baseline.Child15RotationValueY ||
                                           Child15RotationValueZ != baseline.Child15RotationValueZ ||
                                           Child15RotationValueW != baseline.Child15RotationValueW) ? (1u<<1) : 0;
        changeMask1 |= (Child15TranslationValueX != baseline.Child15TranslationValueX ||
                                           Child15TranslationValueY != baseline.Child15TranslationValueY ||
                                           Child15TranslationValueZ != baseline.Child15TranslationValueZ) ? (1u<<2) : 0;
        changeMask1 |= (Child16RotationValueX != baseline.Child16RotationValueX ||
                                           Child16RotationValueY != baseline.Child16RotationValueY ||
                                           Child16RotationValueZ != baseline.Child16RotationValueZ ||
                                           Child16RotationValueW != baseline.Child16RotationValueW) ? (1u<<3) : 0;
        changeMask1 |= (Child16TranslationValueX != baseline.Child16TranslationValueX ||
                                           Child16TranslationValueY != baseline.Child16TranslationValueY ||
                                           Child16TranslationValueZ != baseline.Child16TranslationValueZ) ? (1u<<4) : 0;
        changeMask1 |= (Child17RotationValueX != baseline.Child17RotationValueX ||
                                           Child17RotationValueY != baseline.Child17RotationValueY ||
                                           Child17RotationValueZ != baseline.Child17RotationValueZ ||
                                           Child17RotationValueW != baseline.Child17RotationValueW) ? (1u<<5) : 0;
        changeMask1 |= (Child17TranslationValueX != baseline.Child17TranslationValueX ||
                                           Child17TranslationValueY != baseline.Child17TranslationValueY ||
                                           Child17TranslationValueZ != baseline.Child17TranslationValueZ) ? (1u<<6) : 0;
        changeMask1 |= (Child18RotationValueX != baseline.Child18RotationValueX ||
                                           Child18RotationValueY != baseline.Child18RotationValueY ||
                                           Child18RotationValueZ != baseline.Child18RotationValueZ ||
                                           Child18RotationValueW != baseline.Child18RotationValueW) ? (1u<<7) : 0;
        changeMask1 |= (Child18TranslationValueX != baseline.Child18TranslationValueX ||
                                           Child18TranslationValueY != baseline.Child18TranslationValueY ||
                                           Child18TranslationValueZ != baseline.Child18TranslationValueZ) ? (1u<<8) : 0;
        changeMask1 |= (Child19RotationValueX != baseline.Child19RotationValueX ||
                                           Child19RotationValueY != baseline.Child19RotationValueY ||
                                           Child19RotationValueZ != baseline.Child19RotationValueZ ||
                                           Child19RotationValueW != baseline.Child19RotationValueW) ? (1u<<9) : 0;
        changeMask1 |= (Child19TranslationValueX != baseline.Child19TranslationValueX ||
                                           Child19TranslationValueY != baseline.Child19TranslationValueY ||
                                           Child19TranslationValueZ != baseline.Child19TranslationValueZ) ? (1u<<10) : 0;
        changeMask1 |= (Child20RotationValueX != baseline.Child20RotationValueX ||
                                           Child20RotationValueY != baseline.Child20RotationValueY ||
                                           Child20RotationValueZ != baseline.Child20RotationValueZ ||
                                           Child20RotationValueW != baseline.Child20RotationValueW) ? (1u<<11) : 0;
        changeMask1 |= (Child20TranslationValueX != baseline.Child20TranslationValueX ||
                                           Child20TranslationValueY != baseline.Child20TranslationValueY ||
                                           Child20TranslationValueZ != baseline.Child20TranslationValueZ) ? (1u<<12) : 0;
        changeMask1 |= (Child21RotationValueX != baseline.Child21RotationValueX ||
                                           Child21RotationValueY != baseline.Child21RotationValueY ||
                                           Child21RotationValueZ != baseline.Child21RotationValueZ ||
                                           Child21RotationValueW != baseline.Child21RotationValueW) ? (1u<<13) : 0;
        changeMask1 |= (Child21TranslationValueX != baseline.Child21TranslationValueX ||
                                           Child21TranslationValueY != baseline.Child21TranslationValueY ||
                                           Child21TranslationValueZ != baseline.Child21TranslationValueZ) ? (1u<<14) : 0;
        changeMask1 |= (Child22RotationValueX != baseline.Child22RotationValueX ||
                                           Child22RotationValueY != baseline.Child22RotationValueY ||
                                           Child22RotationValueZ != baseline.Child22RotationValueZ ||
                                           Child22RotationValueW != baseline.Child22RotationValueW) ? (1u<<15) : 0;
        changeMask1 |= (Child22TranslationValueX != baseline.Child22TranslationValueX ||
                                           Child22TranslationValueY != baseline.Child22TranslationValueY ||
                                           Child22TranslationValueZ != baseline.Child22TranslationValueZ) ? (1u<<16) : 0;
        changeMask1 |= (Child23RotationValueX != baseline.Child23RotationValueX ||
                                           Child23RotationValueY != baseline.Child23RotationValueY ||
                                           Child23RotationValueZ != baseline.Child23RotationValueZ ||
                                           Child23RotationValueW != baseline.Child23RotationValueW) ? (1u<<17) : 0;
        changeMask1 |= (Child23TranslationValueX != baseline.Child23TranslationValueX ||
                                           Child23TranslationValueY != baseline.Child23TranslationValueY ||
                                           Child23TranslationValueZ != baseline.Child23TranslationValueZ) ? (1u<<18) : 0;
        changeMask1 |= (Child24RotationValueX != baseline.Child24RotationValueX ||
                                           Child24RotationValueY != baseline.Child24RotationValueY ||
                                           Child24RotationValueZ != baseline.Child24RotationValueZ ||
                                           Child24RotationValueW != baseline.Child24RotationValueW) ? (1u<<19) : 0;
        changeMask1 |= (Child24TranslationValueX != baseline.Child24TranslationValueX ||
                                           Child24TranslationValueY != baseline.Child24TranslationValueY ||
                                           Child24TranslationValueZ != baseline.Child24TranslationValueZ) ? (1u<<20) : 0;
        changeMask1 |= (Child25RotationValueX != baseline.Child25RotationValueX ||
                                           Child25RotationValueY != baseline.Child25RotationValueY ||
                                           Child25RotationValueZ != baseline.Child25RotationValueZ ||
                                           Child25RotationValueW != baseline.Child25RotationValueW) ? (1u<<21) : 0;
        changeMask1 |= (Child25TranslationValueX != baseline.Child25TranslationValueX ||
                                           Child25TranslationValueY != baseline.Child25TranslationValueY ||
                                           Child25TranslationValueZ != baseline.Child25TranslationValueZ) ? (1u<<22) : 0;
        changeMask1 |= (Child26RotationValueX != baseline.Child26RotationValueX ||
                                           Child26RotationValueY != baseline.Child26RotationValueY ||
                                           Child26RotationValueZ != baseline.Child26RotationValueZ ||
                                           Child26RotationValueW != baseline.Child26RotationValueW) ? (1u<<23) : 0;
        changeMask1 |= (Child26TranslationValueX != baseline.Child26TranslationValueX ||
                                           Child26TranslationValueY != baseline.Child26TranslationValueY ||
                                           Child26TranslationValueZ != baseline.Child26TranslationValueZ) ? (1u<<24) : 0;
        changeMask1 |= (Child27RotationValueX != baseline.Child27RotationValueX ||
                                           Child27RotationValueY != baseline.Child27RotationValueY ||
                                           Child27RotationValueZ != baseline.Child27RotationValueZ ||
                                           Child27RotationValueW != baseline.Child27RotationValueW) ? (1u<<25) : 0;
        changeMask1 |= (Child27TranslationValueX != baseline.Child27TranslationValueX ||
                                           Child27TranslationValueY != baseline.Child27TranslationValueY ||
                                           Child27TranslationValueZ != baseline.Child27TranslationValueZ) ? (1u<<26) : 0;
        changeMask1 |= (Child28RotationValueX != baseline.Child28RotationValueX ||
                                           Child28RotationValueY != baseline.Child28RotationValueY ||
                                           Child28RotationValueZ != baseline.Child28RotationValueZ ||
                                           Child28RotationValueW != baseline.Child28RotationValueW) ? (1u<<27) : 0;
        changeMask1 |= (Child28TranslationValueX != baseline.Child28TranslationValueX ||
                                           Child28TranslationValueY != baseline.Child28TranslationValueY ||
                                           Child28TranslationValueZ != baseline.Child28TranslationValueZ) ? (1u<<28) : 0;
        changeMask1 |= (Child29RotationValueX != baseline.Child29RotationValueX ||
                                           Child29RotationValueY != baseline.Child29RotationValueY ||
                                           Child29RotationValueZ != baseline.Child29RotationValueZ ||
                                           Child29RotationValueW != baseline.Child29RotationValueW) ? (1u<<29) : 0;
        changeMask1 |= (Child29TranslationValueX != baseline.Child29TranslationValueX ||
                                           Child29TranslationValueY != baseline.Child29TranslationValueY ||
                                           Child29TranslationValueZ != baseline.Child29TranslationValueZ) ? (1u<<30) : 0;
        changeMask1 |= (Child30RotationValueX != baseline.Child30RotationValueX ||
                                           Child30RotationValueY != baseline.Child30RotationValueY ||
                                           Child30RotationValueZ != baseline.Child30RotationValueZ ||
                                           Child30RotationValueW != baseline.Child30RotationValueW) ? (1u<<31) : 0;
        changeMask2 = (Child30TranslationValueX != baseline.Child30TranslationValueX ||
                                          Child30TranslationValueY != baseline.Child30TranslationValueY ||
                                          Child30TranslationValueZ != baseline.Child30TranslationValueZ) ? 1u : 0;
        changeMask2 |= (Child31RotationValueX != baseline.Child31RotationValueX ||
                                           Child31RotationValueY != baseline.Child31RotationValueY ||
                                           Child31RotationValueZ != baseline.Child31RotationValueZ ||
                                           Child31RotationValueW != baseline.Child31RotationValueW) ? (1u<<1) : 0;
        changeMask2 |= (Child31TranslationValueX != baseline.Child31TranslationValueX ||
                                           Child31TranslationValueY != baseline.Child31TranslationValueY ||
                                           Child31TranslationValueZ != baseline.Child31TranslationValueZ) ? (1u<<2) : 0;
        changeMask2 |= (Child32RotationValueX != baseline.Child32RotationValueX ||
                                           Child32RotationValueY != baseline.Child32RotationValueY ||
                                           Child32RotationValueZ != baseline.Child32RotationValueZ ||
                                           Child32RotationValueW != baseline.Child32RotationValueW) ? (1u<<3) : 0;
        changeMask2 |= (Child32TranslationValueX != baseline.Child32TranslationValueX ||
                                           Child32TranslationValueY != baseline.Child32TranslationValueY ||
                                           Child32TranslationValueZ != baseline.Child32TranslationValueZ) ? (1u<<4) : 0;
        changeMask2 |= (Child33RotationValueX != baseline.Child33RotationValueX ||
                                           Child33RotationValueY != baseline.Child33RotationValueY ||
                                           Child33RotationValueZ != baseline.Child33RotationValueZ ||
                                           Child33RotationValueW != baseline.Child33RotationValueW) ? (1u<<5) : 0;
        changeMask2 |= (Child33TranslationValueX != baseline.Child33TranslationValueX ||
                                           Child33TranslationValueY != baseline.Child33TranslationValueY ||
                                           Child33TranslationValueZ != baseline.Child33TranslationValueZ) ? (1u<<6) : 0;
        changeMask2 |= (Child34RotationValueX != baseline.Child34RotationValueX ||
                                           Child34RotationValueY != baseline.Child34RotationValueY ||
                                           Child34RotationValueZ != baseline.Child34RotationValueZ ||
                                           Child34RotationValueW != baseline.Child34RotationValueW) ? (1u<<7) : 0;
        changeMask2 |= (Child34TranslationValueX != baseline.Child34TranslationValueX ||
                                           Child34TranslationValueY != baseline.Child34TranslationValueY ||
                                           Child34TranslationValueZ != baseline.Child34TranslationValueZ) ? (1u<<8) : 0;
        changeMask2 |= (Child35RotationValueX != baseline.Child35RotationValueX ||
                                           Child35RotationValueY != baseline.Child35RotationValueY ||
                                           Child35RotationValueZ != baseline.Child35RotationValueZ ||
                                           Child35RotationValueW != baseline.Child35RotationValueW) ? (1u<<9) : 0;
        changeMask2 |= (Child35TranslationValueX != baseline.Child35TranslationValueX ||
                                           Child35TranslationValueY != baseline.Child35TranslationValueY ||
                                           Child35TranslationValueZ != baseline.Child35TranslationValueZ) ? (1u<<10) : 0;
        changeMask2 |= (Child36RotationValueX != baseline.Child36RotationValueX ||
                                           Child36RotationValueY != baseline.Child36RotationValueY ||
                                           Child36RotationValueZ != baseline.Child36RotationValueZ ||
                                           Child36RotationValueW != baseline.Child36RotationValueW) ? (1u<<11) : 0;
        changeMask2 |= (Child36TranslationValueX != baseline.Child36TranslationValueX ||
                                           Child36TranslationValueY != baseline.Child36TranslationValueY ||
                                           Child36TranslationValueZ != baseline.Child36TranslationValueZ) ? (1u<<12) : 0;
        changeMask2 |= (Child37RotationValueX != baseline.Child37RotationValueX ||
                                           Child37RotationValueY != baseline.Child37RotationValueY ||
                                           Child37RotationValueZ != baseline.Child37RotationValueZ ||
                                           Child37RotationValueW != baseline.Child37RotationValueW) ? (1u<<13) : 0;
        changeMask2 |= (Child37TranslationValueX != baseline.Child37TranslationValueX ||
                                           Child37TranslationValueY != baseline.Child37TranslationValueY ||
                                           Child37TranslationValueZ != baseline.Child37TranslationValueZ) ? (1u<<14) : 0;
        changeMask2 |= (Child38RotationValueX != baseline.Child38RotationValueX ||
                                           Child38RotationValueY != baseline.Child38RotationValueY ||
                                           Child38RotationValueZ != baseline.Child38RotationValueZ ||
                                           Child38RotationValueW != baseline.Child38RotationValueW) ? (1u<<15) : 0;
        changeMask2 |= (Child38TranslationValueX != baseline.Child38TranslationValueX ||
                                           Child38TranslationValueY != baseline.Child38TranslationValueY ||
                                           Child38TranslationValueZ != baseline.Child38TranslationValueZ) ? (1u<<16) : 0;
        changeMask2 |= (Child39RotationValueX != baseline.Child39RotationValueX ||
                                           Child39RotationValueY != baseline.Child39RotationValueY ||
                                           Child39RotationValueZ != baseline.Child39RotationValueZ ||
                                           Child39RotationValueW != baseline.Child39RotationValueW) ? (1u<<17) : 0;
        changeMask2 |= (Child39TranslationValueX != baseline.Child39TranslationValueX ||
                                           Child39TranslationValueY != baseline.Child39TranslationValueY ||
                                           Child39TranslationValueZ != baseline.Child39TranslationValueZ) ? (1u<<18) : 0;
        changeMask2 |= (Child40RotationValueX != baseline.Child40RotationValueX ||
                                           Child40RotationValueY != baseline.Child40RotationValueY ||
                                           Child40RotationValueZ != baseline.Child40RotationValueZ ||
                                           Child40RotationValueW != baseline.Child40RotationValueW) ? (1u<<19) : 0;
        changeMask2 |= (Child40TranslationValueX != baseline.Child40TranslationValueX ||
                                           Child40TranslationValueY != baseline.Child40TranslationValueY ||
                                           Child40TranslationValueZ != baseline.Child40TranslationValueZ) ? (1u<<20) : 0;
        changeMask2 |= (Child41RotationValueX != baseline.Child41RotationValueX ||
                                           Child41RotationValueY != baseline.Child41RotationValueY ||
                                           Child41RotationValueZ != baseline.Child41RotationValueZ ||
                                           Child41RotationValueW != baseline.Child41RotationValueW) ? (1u<<21) : 0;
        changeMask2 |= (Child41TranslationValueX != baseline.Child41TranslationValueX ||
                                           Child41TranslationValueY != baseline.Child41TranslationValueY ||
                                           Child41TranslationValueZ != baseline.Child41TranslationValueZ) ? (1u<<22) : 0;
        changeMask2 |= (Child42RotationValueX != baseline.Child42RotationValueX ||
                                           Child42RotationValueY != baseline.Child42RotationValueY ||
                                           Child42RotationValueZ != baseline.Child42RotationValueZ ||
                                           Child42RotationValueW != baseline.Child42RotationValueW) ? (1u<<23) : 0;
        changeMask2 |= (Child42TranslationValueX != baseline.Child42TranslationValueX ||
                                           Child42TranslationValueY != baseline.Child42TranslationValueY ||
                                           Child42TranslationValueZ != baseline.Child42TranslationValueZ) ? (1u<<24) : 0;
        changeMask2 |= (Child43RotationValueX != baseline.Child43RotationValueX ||
                                           Child43RotationValueY != baseline.Child43RotationValueY ||
                                           Child43RotationValueZ != baseline.Child43RotationValueZ ||
                                           Child43RotationValueW != baseline.Child43RotationValueW) ? (1u<<25) : 0;
        changeMask2 |= (Child43TranslationValueX != baseline.Child43TranslationValueX ||
                                           Child43TranslationValueY != baseline.Child43TranslationValueY ||
                                           Child43TranslationValueZ != baseline.Child43TranslationValueZ) ? (1u<<26) : 0;
        changeMask2 |= (Child44RotationValueX != baseline.Child44RotationValueX ||
                                           Child44RotationValueY != baseline.Child44RotationValueY ||
                                           Child44RotationValueZ != baseline.Child44RotationValueZ ||
                                           Child44RotationValueW != baseline.Child44RotationValueW) ? (1u<<27) : 0;
        changeMask2 |= (Child44TranslationValueX != baseline.Child44TranslationValueX ||
                                           Child44TranslationValueY != baseline.Child44TranslationValueY ||
                                           Child44TranslationValueZ != baseline.Child44TranslationValueZ) ? (1u<<28) : 0;
        changeMask2 |= (Child45RotationValueX != baseline.Child45RotationValueX ||
                                           Child45RotationValueY != baseline.Child45RotationValueY ||
                                           Child45RotationValueZ != baseline.Child45RotationValueZ ||
                                           Child45RotationValueW != baseline.Child45RotationValueW) ? (1u<<29) : 0;
        changeMask2 |= (Child45TranslationValueX != baseline.Child45TranslationValueX ||
                                           Child45TranslationValueY != baseline.Child45TranslationValueY ||
                                           Child45TranslationValueZ != baseline.Child45TranslationValueZ) ? (1u<<30) : 0;
        changeMask2 |= (Child46RotationValueX != baseline.Child46RotationValueX ||
                                           Child46RotationValueY != baseline.Child46RotationValueY ||
                                           Child46RotationValueZ != baseline.Child46RotationValueZ ||
                                           Child46RotationValueW != baseline.Child46RotationValueW) ? (1u<<31) : 0;
        changeMask3 = (Child46TranslationValueX != baseline.Child46TranslationValueX ||
                                          Child46TranslationValueY != baseline.Child46TranslationValueY ||
                                          Child46TranslationValueZ != baseline.Child46TranslationValueZ) ? 1u : 0;
        changeMask3 |= (Child47RotationValueX != baseline.Child47RotationValueX ||
                                           Child47RotationValueY != baseline.Child47RotationValueY ||
                                           Child47RotationValueZ != baseline.Child47RotationValueZ ||
                                           Child47RotationValueW != baseline.Child47RotationValueW) ? (1u<<1) : 0;
        changeMask3 |= (Child47TranslationValueX != baseline.Child47TranslationValueX ||
                                           Child47TranslationValueY != baseline.Child47TranslationValueY ||
                                           Child47TranslationValueZ != baseline.Child47TranslationValueZ) ? (1u<<2) : 0;
        changeMask3 |= (Child48RotationValueX != baseline.Child48RotationValueX ||
                                           Child48RotationValueY != baseline.Child48RotationValueY ||
                                           Child48RotationValueZ != baseline.Child48RotationValueZ ||
                                           Child48RotationValueW != baseline.Child48RotationValueW) ? (1u<<3) : 0;
        changeMask3 |= (Child48TranslationValueX != baseline.Child48TranslationValueX ||
                                           Child48TranslationValueY != baseline.Child48TranslationValueY ||
                                           Child48TranslationValueZ != baseline.Child48TranslationValueZ) ? (1u<<4) : 0;
        changeMask3 |= (Child49RotationValueX != baseline.Child49RotationValueX ||
                                           Child49RotationValueY != baseline.Child49RotationValueY ||
                                           Child49RotationValueZ != baseline.Child49RotationValueZ ||
                                           Child49RotationValueW != baseline.Child49RotationValueW) ? (1u<<5) : 0;
        changeMask3 |= (Child49TranslationValueX != baseline.Child49TranslationValueX ||
                                           Child49TranslationValueY != baseline.Child49TranslationValueY ||
                                           Child49TranslationValueZ != baseline.Child49TranslationValueZ) ? (1u<<6) : 0;
        changeMask3 |= (Child50RotationValueX != baseline.Child50RotationValueX ||
                                           Child50RotationValueY != baseline.Child50RotationValueY ||
                                           Child50RotationValueZ != baseline.Child50RotationValueZ ||
                                           Child50RotationValueW != baseline.Child50RotationValueW) ? (1u<<7) : 0;
        changeMask3 |= (Child50TranslationValueX != baseline.Child50TranslationValueX ||
                                           Child50TranslationValueY != baseline.Child50TranslationValueY ||
                                           Child50TranslationValueZ != baseline.Child50TranslationValueZ) ? (1u<<8) : 0;
        changeMask3 |= (Child51RotationValueX != baseline.Child51RotationValueX ||
                                           Child51RotationValueY != baseline.Child51RotationValueY ||
                                           Child51RotationValueZ != baseline.Child51RotationValueZ ||
                                           Child51RotationValueW != baseline.Child51RotationValueW) ? (1u<<9) : 0;
        changeMask3 |= (Child51TranslationValueX != baseline.Child51TranslationValueX ||
                                           Child51TranslationValueY != baseline.Child51TranslationValueY ||
                                           Child51TranslationValueZ != baseline.Child51TranslationValueZ) ? (1u<<10) : 0;
        changeMask3 |= (Child52RotationValueX != baseline.Child52RotationValueX ||
                                           Child52RotationValueY != baseline.Child52RotationValueY ||
                                           Child52RotationValueZ != baseline.Child52RotationValueZ ||
                                           Child52RotationValueW != baseline.Child52RotationValueW) ? (1u<<11) : 0;
        changeMask3 |= (Child52TranslationValueX != baseline.Child52TranslationValueX ||
                                           Child52TranslationValueY != baseline.Child52TranslationValueY ||
                                           Child52TranslationValueZ != baseline.Child52TranslationValueZ) ? (1u<<12) : 0;
        changeMask3 |= (Child53RotationValueX != baseline.Child53RotationValueX ||
                                           Child53RotationValueY != baseline.Child53RotationValueY ||
                                           Child53RotationValueZ != baseline.Child53RotationValueZ ||
                                           Child53RotationValueW != baseline.Child53RotationValueW) ? (1u<<13) : 0;
        changeMask3 |= (Child53TranslationValueX != baseline.Child53TranslationValueX ||
                                           Child53TranslationValueY != baseline.Child53TranslationValueY ||
                                           Child53TranslationValueZ != baseline.Child53TranslationValueZ) ? (1u<<14) : 0;
        changeMask3 |= (Child54RotationValueX != baseline.Child54RotationValueX ||
                                           Child54RotationValueY != baseline.Child54RotationValueY ||
                                           Child54RotationValueZ != baseline.Child54RotationValueZ ||
                                           Child54RotationValueW != baseline.Child54RotationValueW) ? (1u<<15) : 0;
        changeMask3 |= (Child54TranslationValueX != baseline.Child54TranslationValueX ||
                                           Child54TranslationValueY != baseline.Child54TranslationValueY ||
                                           Child54TranslationValueZ != baseline.Child54TranslationValueZ) ? (1u<<16) : 0;
        changeMask3 |= (Child55RotationValueX != baseline.Child55RotationValueX ||
                                           Child55RotationValueY != baseline.Child55RotationValueY ||
                                           Child55RotationValueZ != baseline.Child55RotationValueZ ||
                                           Child55RotationValueW != baseline.Child55RotationValueW) ? (1u<<17) : 0;
        changeMask3 |= (Child55TranslationValueX != baseline.Child55TranslationValueX ||
                                           Child55TranslationValueY != baseline.Child55TranslationValueY ||
                                           Child55TranslationValueZ != baseline.Child55TranslationValueZ) ? (1u<<18) : 0;
        changeMask3 |= (Child56RotationValueX != baseline.Child56RotationValueX ||
                                           Child56RotationValueY != baseline.Child56RotationValueY ||
                                           Child56RotationValueZ != baseline.Child56RotationValueZ ||
                                           Child56RotationValueW != baseline.Child56RotationValueW) ? (1u<<19) : 0;
        changeMask3 |= (Child56TranslationValueX != baseline.Child56TranslationValueX ||
                                           Child56TranslationValueY != baseline.Child56TranslationValueY ||
                                           Child56TranslationValueZ != baseline.Child56TranslationValueZ) ? (1u<<20) : 0;
        changeMask3 |= (Child57RotationValueX != baseline.Child57RotationValueX ||
                                           Child57RotationValueY != baseline.Child57RotationValueY ||
                                           Child57RotationValueZ != baseline.Child57RotationValueZ ||
                                           Child57RotationValueW != baseline.Child57RotationValueW) ? (1u<<21) : 0;
        changeMask3 |= (Child57TranslationValueX != baseline.Child57TranslationValueX ||
                                           Child57TranslationValueY != baseline.Child57TranslationValueY ||
                                           Child57TranslationValueZ != baseline.Child57TranslationValueZ) ? (1u<<22) : 0;
        changeMask3 |= (Child58RotationValueX != baseline.Child58RotationValueX ||
                                           Child58RotationValueY != baseline.Child58RotationValueY ||
                                           Child58RotationValueZ != baseline.Child58RotationValueZ ||
                                           Child58RotationValueW != baseline.Child58RotationValueW) ? (1u<<23) : 0;
        changeMask3 |= (Child58TranslationValueX != baseline.Child58TranslationValueX ||
                                           Child58TranslationValueY != baseline.Child58TranslationValueY ||
                                           Child58TranslationValueZ != baseline.Child58TranslationValueZ) ? (1u<<24) : 0;
        changeMask3 |= (Child59RotationValueX != baseline.Child59RotationValueX ||
                                           Child59RotationValueY != baseline.Child59RotationValueY ||
                                           Child59RotationValueZ != baseline.Child59RotationValueZ ||
                                           Child59RotationValueW != baseline.Child59RotationValueW) ? (1u<<25) : 0;
        changeMask3 |= (Child59TranslationValueX != baseline.Child59TranslationValueX ||
                                           Child59TranslationValueY != baseline.Child59TranslationValueY ||
                                           Child59TranslationValueZ != baseline.Child59TranslationValueZ) ? (1u<<26) : 0;
        changeMask3 |= (Child60RotationValueX != baseline.Child60RotationValueX ||
                                           Child60RotationValueY != baseline.Child60RotationValueY ||
                                           Child60RotationValueZ != baseline.Child60RotationValueZ ||
                                           Child60RotationValueW != baseline.Child60RotationValueW) ? (1u<<27) : 0;
        changeMask3 |= (Child60TranslationValueX != baseline.Child60TranslationValueX ||
                                           Child60TranslationValueY != baseline.Child60TranslationValueY ||
                                           Child60TranslationValueZ != baseline.Child60TranslationValueZ) ? (1u<<28) : 0;
        changeMask3 |= (Child61RotationValueX != baseline.Child61RotationValueX ||
                                           Child61RotationValueY != baseline.Child61RotationValueY ||
                                           Child61RotationValueZ != baseline.Child61RotationValueZ ||
                                           Child61RotationValueW != baseline.Child61RotationValueW) ? (1u<<29) : 0;
        changeMask3 |= (Child61TranslationValueX != baseline.Child61TranslationValueX ||
                                           Child61TranslationValueY != baseline.Child61TranslationValueY ||
                                           Child61TranslationValueZ != baseline.Child61TranslationValueZ) ? (1u<<30) : 0;
        changeMask3 |= (Child62RotationValueX != baseline.Child62RotationValueX ||
                                           Child62RotationValueY != baseline.Child62RotationValueY ||
                                           Child62RotationValueZ != baseline.Child62RotationValueZ ||
                                           Child62RotationValueW != baseline.Child62RotationValueW) ? (1u<<31) : 0;
        changeMask4 = (Child62TranslationValueX != baseline.Child62TranslationValueX ||
                                          Child62TranslationValueY != baseline.Child62TranslationValueY ||
                                          Child62TranslationValueZ != baseline.Child62TranslationValueZ) ? 1u : 0;
        changeMask4 |= (Child63RotationValueX != baseline.Child63RotationValueX ||
                                           Child63RotationValueY != baseline.Child63RotationValueY ||
                                           Child63RotationValueZ != baseline.Child63RotationValueZ ||
                                           Child63RotationValueW != baseline.Child63RotationValueW) ? (1u<<1) : 0;
        changeMask4 |= (Child63TranslationValueX != baseline.Child63TranslationValueX ||
                                           Child63TranslationValueY != baseline.Child63TranslationValueY ||
                                           Child63TranslationValueZ != baseline.Child63TranslationValueZ) ? (1u<<2) : 0;
        changeMask4 |= (Child64RotationValueX != baseline.Child64RotationValueX ||
                                           Child64RotationValueY != baseline.Child64RotationValueY ||
                                           Child64RotationValueZ != baseline.Child64RotationValueZ ||
                                           Child64RotationValueW != baseline.Child64RotationValueW) ? (1u<<3) : 0;
        changeMask4 |= (Child64TranslationValueX != baseline.Child64TranslationValueX ||
                                           Child64TranslationValueY != baseline.Child64TranslationValueY ||
                                           Child64TranslationValueZ != baseline.Child64TranslationValueZ) ? (1u<<4) : 0;
        changeMask4 |= (Child65RotationValueX != baseline.Child65RotationValueX ||
                                           Child65RotationValueY != baseline.Child65RotationValueY ||
                                           Child65RotationValueZ != baseline.Child65RotationValueZ ||
                                           Child65RotationValueW != baseline.Child65RotationValueW) ? (1u<<5) : 0;
        changeMask4 |= (Child65TranslationValueX != baseline.Child65TranslationValueX ||
                                           Child65TranslationValueY != baseline.Child65TranslationValueY ||
                                           Child65TranslationValueZ != baseline.Child65TranslationValueZ) ? (1u<<6) : 0;
        changeMask4 |= (Child66RotationValueX != baseline.Child66RotationValueX ||
                                           Child66RotationValueY != baseline.Child66RotationValueY ||
                                           Child66RotationValueZ != baseline.Child66RotationValueZ ||
                                           Child66RotationValueW != baseline.Child66RotationValueW) ? (1u<<7) : 0;
        changeMask4 |= (Child66TranslationValueX != baseline.Child66TranslationValueX ||
                                           Child66TranslationValueY != baseline.Child66TranslationValueY ||
                                           Child66TranslationValueZ != baseline.Child66TranslationValueZ) ? (1u<<8) : 0;
        changeMask4 |= (Child67RotationValueX != baseline.Child67RotationValueX ||
                                           Child67RotationValueY != baseline.Child67RotationValueY ||
                                           Child67RotationValueZ != baseline.Child67RotationValueZ ||
                                           Child67RotationValueW != baseline.Child67RotationValueW) ? (1u<<9) : 0;
        changeMask4 |= (Child67TranslationValueX != baseline.Child67TranslationValueX ||
                                           Child67TranslationValueY != baseline.Child67TranslationValueY ||
                                           Child67TranslationValueZ != baseline.Child67TranslationValueZ) ? (1u<<10) : 0;
        changeMask4 |= (Child68RotationValueX != baseline.Child68RotationValueX ||
                                           Child68RotationValueY != baseline.Child68RotationValueY ||
                                           Child68RotationValueZ != baseline.Child68RotationValueZ ||
                                           Child68RotationValueW != baseline.Child68RotationValueW) ? (1u<<11) : 0;
        changeMask4 |= (Child68TranslationValueX != baseline.Child68TranslationValueX ||
                                           Child68TranslationValueY != baseline.Child68TranslationValueY ||
                                           Child68TranslationValueZ != baseline.Child68TranslationValueZ) ? (1u<<12) : 0;
        changeMask4 |= (Child69RotationValueX != baseline.Child69RotationValueX ||
                                           Child69RotationValueY != baseline.Child69RotationValueY ||
                                           Child69RotationValueZ != baseline.Child69RotationValueZ ||
                                           Child69RotationValueW != baseline.Child69RotationValueW) ? (1u<<13) : 0;
        changeMask4 |= (Child69TranslationValueX != baseline.Child69TranslationValueX ||
                                           Child69TranslationValueY != baseline.Child69TranslationValueY ||
                                           Child69TranslationValueZ != baseline.Child69TranslationValueZ) ? (1u<<14) : 0;
        changeMask4 |= (Child70RotationValueX != baseline.Child70RotationValueX ||
                                           Child70RotationValueY != baseline.Child70RotationValueY ||
                                           Child70RotationValueZ != baseline.Child70RotationValueZ ||
                                           Child70RotationValueW != baseline.Child70RotationValueW) ? (1u<<15) : 0;
        changeMask4 |= (Child70TranslationValueX != baseline.Child70TranslationValueX ||
                                           Child70TranslationValueY != baseline.Child70TranslationValueY ||
                                           Child70TranslationValueZ != baseline.Child70TranslationValueZ) ? (1u<<16) : 0;
        changeMask4 |= (Child71RotationValueX != baseline.Child71RotationValueX ||
                                           Child71RotationValueY != baseline.Child71RotationValueY ||
                                           Child71RotationValueZ != baseline.Child71RotationValueZ ||
                                           Child71RotationValueW != baseline.Child71RotationValueW) ? (1u<<17) : 0;
        changeMask4 |= (Child71TranslationValueX != baseline.Child71TranslationValueX ||
                                           Child71TranslationValueY != baseline.Child71TranslationValueY ||
                                           Child71TranslationValueZ != baseline.Child71TranslationValueZ) ? (1u<<18) : 0;
        changeMask4 |= (Child72RotationValueX != baseline.Child72RotationValueX ||
                                           Child72RotationValueY != baseline.Child72RotationValueY ||
                                           Child72RotationValueZ != baseline.Child72RotationValueZ ||
                                           Child72RotationValueW != baseline.Child72RotationValueW) ? (1u<<19) : 0;
        changeMask4 |= (Child72TranslationValueX != baseline.Child72TranslationValueX ||
                                           Child72TranslationValueY != baseline.Child72TranslationValueY ||
                                           Child72TranslationValueZ != baseline.Child72TranslationValueZ) ? (1u<<20) : 0;
        changeMask4 |= (Child73RotationValueX != baseline.Child73RotationValueX ||
                                           Child73RotationValueY != baseline.Child73RotationValueY ||
                                           Child73RotationValueZ != baseline.Child73RotationValueZ ||
                                           Child73RotationValueW != baseline.Child73RotationValueW) ? (1u<<21) : 0;
        changeMask4 |= (Child73TranslationValueX != baseline.Child73TranslationValueX ||
                                           Child73TranslationValueY != baseline.Child73TranslationValueY ||
                                           Child73TranslationValueZ != baseline.Child73TranslationValueZ) ? (1u<<22) : 0;
        changeMask4 |= (Child74RotationValueX != baseline.Child74RotationValueX ||
                                           Child74RotationValueY != baseline.Child74RotationValueY ||
                                           Child74RotationValueZ != baseline.Child74RotationValueZ ||
                                           Child74RotationValueW != baseline.Child74RotationValueW) ? (1u<<23) : 0;
        changeMask4 |= (Child74TranslationValueX != baseline.Child74TranslationValueX ||
                                           Child74TranslationValueY != baseline.Child74TranslationValueY ||
                                           Child74TranslationValueZ != baseline.Child74TranslationValueZ) ? (1u<<24) : 0;
        changeMask4 |= (Child75RotationValueX != baseline.Child75RotationValueX ||
                                           Child75RotationValueY != baseline.Child75RotationValueY ||
                                           Child75RotationValueZ != baseline.Child75RotationValueZ ||
                                           Child75RotationValueW != baseline.Child75RotationValueW) ? (1u<<25) : 0;
        changeMask4 |= (Child75TranslationValueX != baseline.Child75TranslationValueX ||
                                           Child75TranslationValueY != baseline.Child75TranslationValueY ||
                                           Child75TranslationValueZ != baseline.Child75TranslationValueZ) ? (1u<<26) : 0;
        changeMask4 |= (Child76RotationValueX != baseline.Child76RotationValueX ||
                                           Child76RotationValueY != baseline.Child76RotationValueY ||
                                           Child76RotationValueZ != baseline.Child76RotationValueZ ||
                                           Child76RotationValueW != baseline.Child76RotationValueW) ? (1u<<27) : 0;
        changeMask4 |= (Child76TranslationValueX != baseline.Child76TranslationValueX ||
                                           Child76TranslationValueY != baseline.Child76TranslationValueY ||
                                           Child76TranslationValueZ != baseline.Child76TranslationValueZ) ? (1u<<28) : 0;
        changeMask4 |= (Child77RotationValueX != baseline.Child77RotationValueX ||
                                           Child77RotationValueY != baseline.Child77RotationValueY ||
                                           Child77RotationValueZ != baseline.Child77RotationValueZ ||
                                           Child77RotationValueW != baseline.Child77RotationValueW) ? (1u<<29) : 0;
        changeMask4 |= (Child77TranslationValueX != baseline.Child77TranslationValueX ||
                                           Child77TranslationValueY != baseline.Child77TranslationValueY ||
                                           Child77TranslationValueZ != baseline.Child77TranslationValueZ) ? (1u<<30) : 0;
        changeMask4 |= (Child78RotationValueX != baseline.Child78RotationValueX ||
                                           Child78RotationValueY != baseline.Child78RotationValueY ||
                                           Child78RotationValueZ != baseline.Child78RotationValueZ ||
                                           Child78RotationValueW != baseline.Child78RotationValueW) ? (1u<<31) : 0;
        changeMask5 = (Child78TranslationValueX != baseline.Child78TranslationValueX ||
                                          Child78TranslationValueY != baseline.Child78TranslationValueY ||
                                          Child78TranslationValueZ != baseline.Child78TranslationValueZ) ? 1u : 0;
        changeMask5 |= (Child79RotationValueX != baseline.Child79RotationValueX ||
                                           Child79RotationValueY != baseline.Child79RotationValueY ||
                                           Child79RotationValueZ != baseline.Child79RotationValueZ ||
                                           Child79RotationValueW != baseline.Child79RotationValueW) ? (1u<<1) : 0;
        changeMask5 |= (Child79TranslationValueX != baseline.Child79TranslationValueX ||
                                           Child79TranslationValueY != baseline.Child79TranslationValueY ||
                                           Child79TranslationValueZ != baseline.Child79TranslationValueZ) ? (1u<<2) : 0;
        changeMask5 |= (Child80RotationValueX != baseline.Child80RotationValueX ||
                                           Child80RotationValueY != baseline.Child80RotationValueY ||
                                           Child80RotationValueZ != baseline.Child80RotationValueZ ||
                                           Child80RotationValueW != baseline.Child80RotationValueW) ? (1u<<3) : 0;
        changeMask5 |= (Child80TranslationValueX != baseline.Child80TranslationValueX ||
                                           Child80TranslationValueY != baseline.Child80TranslationValueY ||
                                           Child80TranslationValueZ != baseline.Child80TranslationValueZ) ? (1u<<4) : 0;
        changeMask5 |= (Child81RotationValueX != baseline.Child81RotationValueX ||
                                           Child81RotationValueY != baseline.Child81RotationValueY ||
                                           Child81RotationValueZ != baseline.Child81RotationValueZ ||
                                           Child81RotationValueW != baseline.Child81RotationValueW) ? (1u<<5) : 0;
        changeMask5 |= (Child81TranslationValueX != baseline.Child81TranslationValueX ||
                                           Child81TranslationValueY != baseline.Child81TranslationValueY ||
                                           Child81TranslationValueZ != baseline.Child81TranslationValueZ) ? (1u<<6) : 0;
        changeMask5 |= (Child82RotationValueX != baseline.Child82RotationValueX ||
                                           Child82RotationValueY != baseline.Child82RotationValueY ||
                                           Child82RotationValueZ != baseline.Child82RotationValueZ ||
                                           Child82RotationValueW != baseline.Child82RotationValueW) ? (1u<<7) : 0;
        changeMask5 |= (Child82TranslationValueX != baseline.Child82TranslationValueX ||
                                           Child82TranslationValueY != baseline.Child82TranslationValueY ||
                                           Child82TranslationValueZ != baseline.Child82TranslationValueZ) ? (1u<<8) : 0;
        changeMask5 |= (Child83RotationValueX != baseline.Child83RotationValueX ||
                                           Child83RotationValueY != baseline.Child83RotationValueY ||
                                           Child83RotationValueZ != baseline.Child83RotationValueZ ||
                                           Child83RotationValueW != baseline.Child83RotationValueW) ? (1u<<9) : 0;
        changeMask5 |= (Child83TranslationValueX != baseline.Child83TranslationValueX ||
                                           Child83TranslationValueY != baseline.Child83TranslationValueY ||
                                           Child83TranslationValueZ != baseline.Child83TranslationValueZ) ? (1u<<10) : 0;
        changeMask5 |= (Child84RotationValueX != baseline.Child84RotationValueX ||
                                           Child84RotationValueY != baseline.Child84RotationValueY ||
                                           Child84RotationValueZ != baseline.Child84RotationValueZ ||
                                           Child84RotationValueW != baseline.Child84RotationValueW) ? (1u<<11) : 0;
        changeMask5 |= (Child84TranslationValueX != baseline.Child84TranslationValueX ||
                                           Child84TranslationValueY != baseline.Child84TranslationValueY ||
                                           Child84TranslationValueZ != baseline.Child84TranslationValueZ) ? (1u<<12) : 0;
        changeMask5 |= (Child85RotationValueX != baseline.Child85RotationValueX ||
                                           Child85RotationValueY != baseline.Child85RotationValueY ||
                                           Child85RotationValueZ != baseline.Child85RotationValueZ ||
                                           Child85RotationValueW != baseline.Child85RotationValueW) ? (1u<<13) : 0;
        changeMask5 |= (Child85TranslationValueX != baseline.Child85TranslationValueX ||
                                           Child85TranslationValueY != baseline.Child85TranslationValueY ||
                                           Child85TranslationValueZ != baseline.Child85TranslationValueZ) ? (1u<<14) : 0;
        changeMask5 |= (Child86RotationValueX != baseline.Child86RotationValueX ||
                                           Child86RotationValueY != baseline.Child86RotationValueY ||
                                           Child86RotationValueZ != baseline.Child86RotationValueZ ||
                                           Child86RotationValueW != baseline.Child86RotationValueW) ? (1u<<15) : 0;
        changeMask5 |= (Child86TranslationValueX != baseline.Child86TranslationValueX ||
                                           Child86TranslationValueY != baseline.Child86TranslationValueY ||
                                           Child86TranslationValueZ != baseline.Child86TranslationValueZ) ? (1u<<16) : 0;
        writer.WritePackedUIntDelta(changeMask0, baseline.changeMask0, compressionModel);
        writer.WritePackedUIntDelta(changeMask1, baseline.changeMask1, compressionModel);
        writer.WritePackedUIntDelta(changeMask2, baseline.changeMask2, compressionModel);
        writer.WritePackedUIntDelta(changeMask3, baseline.changeMask3, compressionModel);
        writer.WritePackedUIntDelta(changeMask4, baseline.changeMask4, compressionModel);
        writer.WritePackedUIntDelta(changeMask5, baseline.changeMask5, compressionModel);
        if ((changeMask0 & (1 << 0)) != 0)
            writer.WritePackedIntDelta(MovablePlayerPlayerId, baseline.MovablePlayerPlayerId, compressionModel);
        if ((changeMask0 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(RotationValueX, baseline.RotationValueX, compressionModel);
            writer.WritePackedIntDelta(RotationValueY, baseline.RotationValueY, compressionModel);
            writer.WritePackedIntDelta(RotationValueZ, baseline.RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(RotationValueW, baseline.RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(TranslationValueX, baseline.TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(TranslationValueY, baseline.TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(TranslationValueZ, baseline.TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child0RotationValueX, baseline.Child0RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child0RotationValueY, baseline.Child0RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child0RotationValueZ, baseline.Child0RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child0RotationValueW, baseline.Child0RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child0TranslationValueX, baseline.Child0TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child0TranslationValueY, baseline.Child0TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child0TranslationValueZ, baseline.Child0TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child1RotationValueX, baseline.Child1RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child1RotationValueY, baseline.Child1RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child1RotationValueZ, baseline.Child1RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child1RotationValueW, baseline.Child1RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child1TranslationValueX, baseline.Child1TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child1TranslationValueY, baseline.Child1TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child1TranslationValueZ, baseline.Child1TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child2RotationValueX, baseline.Child2RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child2RotationValueY, baseline.Child2RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child2RotationValueZ, baseline.Child2RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child2RotationValueW, baseline.Child2RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child2TranslationValueX, baseline.Child2TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child2TranslationValueY, baseline.Child2TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child2TranslationValueZ, baseline.Child2TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child3RotationValueX, baseline.Child3RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child3RotationValueY, baseline.Child3RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child3RotationValueZ, baseline.Child3RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child3RotationValueW, baseline.Child3RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child3TranslationValueX, baseline.Child3TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child3TranslationValueY, baseline.Child3TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child3TranslationValueZ, baseline.Child3TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child4RotationValueX, baseline.Child4RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child4RotationValueY, baseline.Child4RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child4RotationValueZ, baseline.Child4RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child4RotationValueW, baseline.Child4RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child4TranslationValueX, baseline.Child4TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child4TranslationValueY, baseline.Child4TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child4TranslationValueZ, baseline.Child4TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child5RotationValueX, baseline.Child5RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child5RotationValueY, baseline.Child5RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child5RotationValueZ, baseline.Child5RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child5RotationValueW, baseline.Child5RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child5TranslationValueX, baseline.Child5TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child5TranslationValueY, baseline.Child5TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child5TranslationValueZ, baseline.Child5TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child6RotationValueX, baseline.Child6RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child6RotationValueY, baseline.Child6RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child6RotationValueZ, baseline.Child6RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child6RotationValueW, baseline.Child6RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child6TranslationValueX, baseline.Child6TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child6TranslationValueY, baseline.Child6TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child6TranslationValueZ, baseline.Child6TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 17)) != 0)
        {
            writer.WritePackedIntDelta(Child7RotationValueX, baseline.Child7RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child7RotationValueY, baseline.Child7RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child7RotationValueZ, baseline.Child7RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child7RotationValueW, baseline.Child7RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 18)) != 0)
        {
            writer.WritePackedIntDelta(Child7TranslationValueX, baseline.Child7TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child7TranslationValueY, baseline.Child7TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child7TranslationValueZ, baseline.Child7TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 19)) != 0)
        {
            writer.WritePackedIntDelta(Child8RotationValueX, baseline.Child8RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child8RotationValueY, baseline.Child8RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child8RotationValueZ, baseline.Child8RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child8RotationValueW, baseline.Child8RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 20)) != 0)
        {
            writer.WritePackedIntDelta(Child8TranslationValueX, baseline.Child8TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child8TranslationValueY, baseline.Child8TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child8TranslationValueZ, baseline.Child8TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 21)) != 0)
        {
            writer.WritePackedIntDelta(Child9RotationValueX, baseline.Child9RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child9RotationValueY, baseline.Child9RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child9RotationValueZ, baseline.Child9RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child9RotationValueW, baseline.Child9RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 22)) != 0)
        {
            writer.WritePackedIntDelta(Child9TranslationValueX, baseline.Child9TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child9TranslationValueY, baseline.Child9TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child9TranslationValueZ, baseline.Child9TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 23)) != 0)
        {
            writer.WritePackedIntDelta(Child10RotationValueX, baseline.Child10RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child10RotationValueY, baseline.Child10RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child10RotationValueZ, baseline.Child10RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child10RotationValueW, baseline.Child10RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 24)) != 0)
        {
            writer.WritePackedIntDelta(Child10TranslationValueX, baseline.Child10TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child10TranslationValueY, baseline.Child10TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child10TranslationValueZ, baseline.Child10TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 25)) != 0)
        {
            writer.WritePackedIntDelta(Child11RotationValueX, baseline.Child11RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child11RotationValueY, baseline.Child11RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child11RotationValueZ, baseline.Child11RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child11RotationValueW, baseline.Child11RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 26)) != 0)
        {
            writer.WritePackedIntDelta(Child11TranslationValueX, baseline.Child11TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child11TranslationValueY, baseline.Child11TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child11TranslationValueZ, baseline.Child11TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 27)) != 0)
        {
            writer.WritePackedIntDelta(Child12RotationValueX, baseline.Child12RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child12RotationValueY, baseline.Child12RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child12RotationValueZ, baseline.Child12RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child12RotationValueW, baseline.Child12RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 28)) != 0)
        {
            writer.WritePackedIntDelta(Child12TranslationValueX, baseline.Child12TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child12TranslationValueY, baseline.Child12TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child12TranslationValueZ, baseline.Child12TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 29)) != 0)
        {
            writer.WritePackedIntDelta(Child13RotationValueX, baseline.Child13RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child13RotationValueY, baseline.Child13RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child13RotationValueZ, baseline.Child13RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child13RotationValueW, baseline.Child13RotationValueW, compressionModel);
        }
        if ((changeMask0 & (1 << 30)) != 0)
        {
            writer.WritePackedIntDelta(Child13TranslationValueX, baseline.Child13TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child13TranslationValueY, baseline.Child13TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child13TranslationValueZ, baseline.Child13TranslationValueZ, compressionModel);
        }
        if ((changeMask0 & (1 << 31)) != 0)
        {
            writer.WritePackedIntDelta(Child14RotationValueX, baseline.Child14RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child14RotationValueY, baseline.Child14RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child14RotationValueZ, baseline.Child14RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child14RotationValueW, baseline.Child14RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 0)) != 0)
        {
            writer.WritePackedIntDelta(Child14TranslationValueX, baseline.Child14TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child14TranslationValueY, baseline.Child14TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child14TranslationValueZ, baseline.Child14TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(Child15RotationValueX, baseline.Child15RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child15RotationValueY, baseline.Child15RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child15RotationValueZ, baseline.Child15RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child15RotationValueW, baseline.Child15RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(Child15TranslationValueX, baseline.Child15TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child15TranslationValueY, baseline.Child15TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child15TranslationValueZ, baseline.Child15TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child16RotationValueX, baseline.Child16RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child16RotationValueY, baseline.Child16RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child16RotationValueZ, baseline.Child16RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child16RotationValueW, baseline.Child16RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child16TranslationValueX, baseline.Child16TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child16TranslationValueY, baseline.Child16TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child16TranslationValueZ, baseline.Child16TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child17RotationValueX, baseline.Child17RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child17RotationValueY, baseline.Child17RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child17RotationValueZ, baseline.Child17RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child17RotationValueW, baseline.Child17RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child17TranslationValueX, baseline.Child17TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child17TranslationValueY, baseline.Child17TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child17TranslationValueZ, baseline.Child17TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child18RotationValueX, baseline.Child18RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child18RotationValueY, baseline.Child18RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child18RotationValueZ, baseline.Child18RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child18RotationValueW, baseline.Child18RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child18TranslationValueX, baseline.Child18TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child18TranslationValueY, baseline.Child18TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child18TranslationValueZ, baseline.Child18TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child19RotationValueX, baseline.Child19RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child19RotationValueY, baseline.Child19RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child19RotationValueZ, baseline.Child19RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child19RotationValueW, baseline.Child19RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child19TranslationValueX, baseline.Child19TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child19TranslationValueY, baseline.Child19TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child19TranslationValueZ, baseline.Child19TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child20RotationValueX, baseline.Child20RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child20RotationValueY, baseline.Child20RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child20RotationValueZ, baseline.Child20RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child20RotationValueW, baseline.Child20RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child20TranslationValueX, baseline.Child20TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child20TranslationValueY, baseline.Child20TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child20TranslationValueZ, baseline.Child20TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child21RotationValueX, baseline.Child21RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child21RotationValueY, baseline.Child21RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child21RotationValueZ, baseline.Child21RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child21RotationValueW, baseline.Child21RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child21TranslationValueX, baseline.Child21TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child21TranslationValueY, baseline.Child21TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child21TranslationValueZ, baseline.Child21TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child22RotationValueX, baseline.Child22RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child22RotationValueY, baseline.Child22RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child22RotationValueZ, baseline.Child22RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child22RotationValueW, baseline.Child22RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child22TranslationValueX, baseline.Child22TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child22TranslationValueY, baseline.Child22TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child22TranslationValueZ, baseline.Child22TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 17)) != 0)
        {
            writer.WritePackedIntDelta(Child23RotationValueX, baseline.Child23RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child23RotationValueY, baseline.Child23RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child23RotationValueZ, baseline.Child23RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child23RotationValueW, baseline.Child23RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 18)) != 0)
        {
            writer.WritePackedIntDelta(Child23TranslationValueX, baseline.Child23TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child23TranslationValueY, baseline.Child23TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child23TranslationValueZ, baseline.Child23TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 19)) != 0)
        {
            writer.WritePackedIntDelta(Child24RotationValueX, baseline.Child24RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child24RotationValueY, baseline.Child24RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child24RotationValueZ, baseline.Child24RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child24RotationValueW, baseline.Child24RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 20)) != 0)
        {
            writer.WritePackedIntDelta(Child24TranslationValueX, baseline.Child24TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child24TranslationValueY, baseline.Child24TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child24TranslationValueZ, baseline.Child24TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 21)) != 0)
        {
            writer.WritePackedIntDelta(Child25RotationValueX, baseline.Child25RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child25RotationValueY, baseline.Child25RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child25RotationValueZ, baseline.Child25RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child25RotationValueW, baseline.Child25RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 22)) != 0)
        {
            writer.WritePackedIntDelta(Child25TranslationValueX, baseline.Child25TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child25TranslationValueY, baseline.Child25TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child25TranslationValueZ, baseline.Child25TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 23)) != 0)
        {
            writer.WritePackedIntDelta(Child26RotationValueX, baseline.Child26RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child26RotationValueY, baseline.Child26RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child26RotationValueZ, baseline.Child26RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child26RotationValueW, baseline.Child26RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 24)) != 0)
        {
            writer.WritePackedIntDelta(Child26TranslationValueX, baseline.Child26TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child26TranslationValueY, baseline.Child26TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child26TranslationValueZ, baseline.Child26TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 25)) != 0)
        {
            writer.WritePackedIntDelta(Child27RotationValueX, baseline.Child27RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child27RotationValueY, baseline.Child27RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child27RotationValueZ, baseline.Child27RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child27RotationValueW, baseline.Child27RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 26)) != 0)
        {
            writer.WritePackedIntDelta(Child27TranslationValueX, baseline.Child27TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child27TranslationValueY, baseline.Child27TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child27TranslationValueZ, baseline.Child27TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 27)) != 0)
        {
            writer.WritePackedIntDelta(Child28RotationValueX, baseline.Child28RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child28RotationValueY, baseline.Child28RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child28RotationValueZ, baseline.Child28RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child28RotationValueW, baseline.Child28RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 28)) != 0)
        {
            writer.WritePackedIntDelta(Child28TranslationValueX, baseline.Child28TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child28TranslationValueY, baseline.Child28TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child28TranslationValueZ, baseline.Child28TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 29)) != 0)
        {
            writer.WritePackedIntDelta(Child29RotationValueX, baseline.Child29RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child29RotationValueY, baseline.Child29RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child29RotationValueZ, baseline.Child29RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child29RotationValueW, baseline.Child29RotationValueW, compressionModel);
        }
        if ((changeMask1 & (1 << 30)) != 0)
        {
            writer.WritePackedIntDelta(Child29TranslationValueX, baseline.Child29TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child29TranslationValueY, baseline.Child29TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child29TranslationValueZ, baseline.Child29TranslationValueZ, compressionModel);
        }
        if ((changeMask1 & (1 << 31)) != 0)
        {
            writer.WritePackedIntDelta(Child30RotationValueX, baseline.Child30RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child30RotationValueY, baseline.Child30RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child30RotationValueZ, baseline.Child30RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child30RotationValueW, baseline.Child30RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 0)) != 0)
        {
            writer.WritePackedIntDelta(Child30TranslationValueX, baseline.Child30TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child30TranslationValueY, baseline.Child30TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child30TranslationValueZ, baseline.Child30TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(Child31RotationValueX, baseline.Child31RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child31RotationValueY, baseline.Child31RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child31RotationValueZ, baseline.Child31RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child31RotationValueW, baseline.Child31RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(Child31TranslationValueX, baseline.Child31TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child31TranslationValueY, baseline.Child31TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child31TranslationValueZ, baseline.Child31TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child32RotationValueX, baseline.Child32RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child32RotationValueY, baseline.Child32RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child32RotationValueZ, baseline.Child32RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child32RotationValueW, baseline.Child32RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child32TranslationValueX, baseline.Child32TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child32TranslationValueY, baseline.Child32TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child32TranslationValueZ, baseline.Child32TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child33RotationValueX, baseline.Child33RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child33RotationValueY, baseline.Child33RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child33RotationValueZ, baseline.Child33RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child33RotationValueW, baseline.Child33RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child33TranslationValueX, baseline.Child33TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child33TranslationValueY, baseline.Child33TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child33TranslationValueZ, baseline.Child33TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child34RotationValueX, baseline.Child34RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child34RotationValueY, baseline.Child34RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child34RotationValueZ, baseline.Child34RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child34RotationValueW, baseline.Child34RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child34TranslationValueX, baseline.Child34TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child34TranslationValueY, baseline.Child34TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child34TranslationValueZ, baseline.Child34TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child35RotationValueX, baseline.Child35RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child35RotationValueY, baseline.Child35RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child35RotationValueZ, baseline.Child35RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child35RotationValueW, baseline.Child35RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child35TranslationValueX, baseline.Child35TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child35TranslationValueY, baseline.Child35TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child35TranslationValueZ, baseline.Child35TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child36RotationValueX, baseline.Child36RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child36RotationValueY, baseline.Child36RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child36RotationValueZ, baseline.Child36RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child36RotationValueW, baseline.Child36RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child36TranslationValueX, baseline.Child36TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child36TranslationValueY, baseline.Child36TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child36TranslationValueZ, baseline.Child36TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child37RotationValueX, baseline.Child37RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child37RotationValueY, baseline.Child37RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child37RotationValueZ, baseline.Child37RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child37RotationValueW, baseline.Child37RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child37TranslationValueX, baseline.Child37TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child37TranslationValueY, baseline.Child37TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child37TranslationValueZ, baseline.Child37TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child38RotationValueX, baseline.Child38RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child38RotationValueY, baseline.Child38RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child38RotationValueZ, baseline.Child38RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child38RotationValueW, baseline.Child38RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child38TranslationValueX, baseline.Child38TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child38TranslationValueY, baseline.Child38TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child38TranslationValueZ, baseline.Child38TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 17)) != 0)
        {
            writer.WritePackedIntDelta(Child39RotationValueX, baseline.Child39RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child39RotationValueY, baseline.Child39RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child39RotationValueZ, baseline.Child39RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child39RotationValueW, baseline.Child39RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 18)) != 0)
        {
            writer.WritePackedIntDelta(Child39TranslationValueX, baseline.Child39TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child39TranslationValueY, baseline.Child39TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child39TranslationValueZ, baseline.Child39TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 19)) != 0)
        {
            writer.WritePackedIntDelta(Child40RotationValueX, baseline.Child40RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child40RotationValueY, baseline.Child40RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child40RotationValueZ, baseline.Child40RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child40RotationValueW, baseline.Child40RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 20)) != 0)
        {
            writer.WritePackedIntDelta(Child40TranslationValueX, baseline.Child40TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child40TranslationValueY, baseline.Child40TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child40TranslationValueZ, baseline.Child40TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 21)) != 0)
        {
            writer.WritePackedIntDelta(Child41RotationValueX, baseline.Child41RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child41RotationValueY, baseline.Child41RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child41RotationValueZ, baseline.Child41RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child41RotationValueW, baseline.Child41RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 22)) != 0)
        {
            writer.WritePackedIntDelta(Child41TranslationValueX, baseline.Child41TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child41TranslationValueY, baseline.Child41TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child41TranslationValueZ, baseline.Child41TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 23)) != 0)
        {
            writer.WritePackedIntDelta(Child42RotationValueX, baseline.Child42RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child42RotationValueY, baseline.Child42RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child42RotationValueZ, baseline.Child42RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child42RotationValueW, baseline.Child42RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 24)) != 0)
        {
            writer.WritePackedIntDelta(Child42TranslationValueX, baseline.Child42TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child42TranslationValueY, baseline.Child42TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child42TranslationValueZ, baseline.Child42TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 25)) != 0)
        {
            writer.WritePackedIntDelta(Child43RotationValueX, baseline.Child43RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child43RotationValueY, baseline.Child43RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child43RotationValueZ, baseline.Child43RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child43RotationValueW, baseline.Child43RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 26)) != 0)
        {
            writer.WritePackedIntDelta(Child43TranslationValueX, baseline.Child43TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child43TranslationValueY, baseline.Child43TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child43TranslationValueZ, baseline.Child43TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 27)) != 0)
        {
            writer.WritePackedIntDelta(Child44RotationValueX, baseline.Child44RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child44RotationValueY, baseline.Child44RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child44RotationValueZ, baseline.Child44RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child44RotationValueW, baseline.Child44RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 28)) != 0)
        {
            writer.WritePackedIntDelta(Child44TranslationValueX, baseline.Child44TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child44TranslationValueY, baseline.Child44TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child44TranslationValueZ, baseline.Child44TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 29)) != 0)
        {
            writer.WritePackedIntDelta(Child45RotationValueX, baseline.Child45RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child45RotationValueY, baseline.Child45RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child45RotationValueZ, baseline.Child45RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child45RotationValueW, baseline.Child45RotationValueW, compressionModel);
        }
        if ((changeMask2 & (1 << 30)) != 0)
        {
            writer.WritePackedIntDelta(Child45TranslationValueX, baseline.Child45TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child45TranslationValueY, baseline.Child45TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child45TranslationValueZ, baseline.Child45TranslationValueZ, compressionModel);
        }
        if ((changeMask2 & (1 << 31)) != 0)
        {
            writer.WritePackedIntDelta(Child46RotationValueX, baseline.Child46RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child46RotationValueY, baseline.Child46RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child46RotationValueZ, baseline.Child46RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child46RotationValueW, baseline.Child46RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 0)) != 0)
        {
            writer.WritePackedIntDelta(Child46TranslationValueX, baseline.Child46TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child46TranslationValueY, baseline.Child46TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child46TranslationValueZ, baseline.Child46TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(Child47RotationValueX, baseline.Child47RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child47RotationValueY, baseline.Child47RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child47RotationValueZ, baseline.Child47RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child47RotationValueW, baseline.Child47RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(Child47TranslationValueX, baseline.Child47TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child47TranslationValueY, baseline.Child47TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child47TranslationValueZ, baseline.Child47TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child48RotationValueX, baseline.Child48RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child48RotationValueY, baseline.Child48RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child48RotationValueZ, baseline.Child48RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child48RotationValueW, baseline.Child48RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child48TranslationValueX, baseline.Child48TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child48TranslationValueY, baseline.Child48TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child48TranslationValueZ, baseline.Child48TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child49RotationValueX, baseline.Child49RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child49RotationValueY, baseline.Child49RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child49RotationValueZ, baseline.Child49RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child49RotationValueW, baseline.Child49RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child49TranslationValueX, baseline.Child49TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child49TranslationValueY, baseline.Child49TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child49TranslationValueZ, baseline.Child49TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child50RotationValueX, baseline.Child50RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child50RotationValueY, baseline.Child50RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child50RotationValueZ, baseline.Child50RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child50RotationValueW, baseline.Child50RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child50TranslationValueX, baseline.Child50TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child50TranslationValueY, baseline.Child50TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child50TranslationValueZ, baseline.Child50TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child51RotationValueX, baseline.Child51RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child51RotationValueY, baseline.Child51RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child51RotationValueZ, baseline.Child51RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child51RotationValueW, baseline.Child51RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child51TranslationValueX, baseline.Child51TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child51TranslationValueY, baseline.Child51TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child51TranslationValueZ, baseline.Child51TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child52RotationValueX, baseline.Child52RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child52RotationValueY, baseline.Child52RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child52RotationValueZ, baseline.Child52RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child52RotationValueW, baseline.Child52RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child52TranslationValueX, baseline.Child52TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child52TranslationValueY, baseline.Child52TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child52TranslationValueZ, baseline.Child52TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child53RotationValueX, baseline.Child53RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child53RotationValueY, baseline.Child53RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child53RotationValueZ, baseline.Child53RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child53RotationValueW, baseline.Child53RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child53TranslationValueX, baseline.Child53TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child53TranslationValueY, baseline.Child53TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child53TranslationValueZ, baseline.Child53TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child54RotationValueX, baseline.Child54RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child54RotationValueY, baseline.Child54RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child54RotationValueZ, baseline.Child54RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child54RotationValueW, baseline.Child54RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child54TranslationValueX, baseline.Child54TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child54TranslationValueY, baseline.Child54TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child54TranslationValueZ, baseline.Child54TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 17)) != 0)
        {
            writer.WritePackedIntDelta(Child55RotationValueX, baseline.Child55RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child55RotationValueY, baseline.Child55RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child55RotationValueZ, baseline.Child55RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child55RotationValueW, baseline.Child55RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 18)) != 0)
        {
            writer.WritePackedIntDelta(Child55TranslationValueX, baseline.Child55TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child55TranslationValueY, baseline.Child55TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child55TranslationValueZ, baseline.Child55TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 19)) != 0)
        {
            writer.WritePackedIntDelta(Child56RotationValueX, baseline.Child56RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child56RotationValueY, baseline.Child56RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child56RotationValueZ, baseline.Child56RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child56RotationValueW, baseline.Child56RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 20)) != 0)
        {
            writer.WritePackedIntDelta(Child56TranslationValueX, baseline.Child56TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child56TranslationValueY, baseline.Child56TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child56TranslationValueZ, baseline.Child56TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 21)) != 0)
        {
            writer.WritePackedIntDelta(Child57RotationValueX, baseline.Child57RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child57RotationValueY, baseline.Child57RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child57RotationValueZ, baseline.Child57RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child57RotationValueW, baseline.Child57RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 22)) != 0)
        {
            writer.WritePackedIntDelta(Child57TranslationValueX, baseline.Child57TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child57TranslationValueY, baseline.Child57TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child57TranslationValueZ, baseline.Child57TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 23)) != 0)
        {
            writer.WritePackedIntDelta(Child58RotationValueX, baseline.Child58RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child58RotationValueY, baseline.Child58RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child58RotationValueZ, baseline.Child58RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child58RotationValueW, baseline.Child58RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 24)) != 0)
        {
            writer.WritePackedIntDelta(Child58TranslationValueX, baseline.Child58TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child58TranslationValueY, baseline.Child58TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child58TranslationValueZ, baseline.Child58TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 25)) != 0)
        {
            writer.WritePackedIntDelta(Child59RotationValueX, baseline.Child59RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child59RotationValueY, baseline.Child59RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child59RotationValueZ, baseline.Child59RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child59RotationValueW, baseline.Child59RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 26)) != 0)
        {
            writer.WritePackedIntDelta(Child59TranslationValueX, baseline.Child59TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child59TranslationValueY, baseline.Child59TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child59TranslationValueZ, baseline.Child59TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 27)) != 0)
        {
            writer.WritePackedIntDelta(Child60RotationValueX, baseline.Child60RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child60RotationValueY, baseline.Child60RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child60RotationValueZ, baseline.Child60RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child60RotationValueW, baseline.Child60RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 28)) != 0)
        {
            writer.WritePackedIntDelta(Child60TranslationValueX, baseline.Child60TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child60TranslationValueY, baseline.Child60TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child60TranslationValueZ, baseline.Child60TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 29)) != 0)
        {
            writer.WritePackedIntDelta(Child61RotationValueX, baseline.Child61RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child61RotationValueY, baseline.Child61RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child61RotationValueZ, baseline.Child61RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child61RotationValueW, baseline.Child61RotationValueW, compressionModel);
        }
        if ((changeMask3 & (1 << 30)) != 0)
        {
            writer.WritePackedIntDelta(Child61TranslationValueX, baseline.Child61TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child61TranslationValueY, baseline.Child61TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child61TranslationValueZ, baseline.Child61TranslationValueZ, compressionModel);
        }
        if ((changeMask3 & (1 << 31)) != 0)
        {
            writer.WritePackedIntDelta(Child62RotationValueX, baseline.Child62RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child62RotationValueY, baseline.Child62RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child62RotationValueZ, baseline.Child62RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child62RotationValueW, baseline.Child62RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 0)) != 0)
        {
            writer.WritePackedIntDelta(Child62TranslationValueX, baseline.Child62TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child62TranslationValueY, baseline.Child62TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child62TranslationValueZ, baseline.Child62TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(Child63RotationValueX, baseline.Child63RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child63RotationValueY, baseline.Child63RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child63RotationValueZ, baseline.Child63RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child63RotationValueW, baseline.Child63RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(Child63TranslationValueX, baseline.Child63TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child63TranslationValueY, baseline.Child63TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child63TranslationValueZ, baseline.Child63TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child64RotationValueX, baseline.Child64RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child64RotationValueY, baseline.Child64RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child64RotationValueZ, baseline.Child64RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child64RotationValueW, baseline.Child64RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child64TranslationValueX, baseline.Child64TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child64TranslationValueY, baseline.Child64TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child64TranslationValueZ, baseline.Child64TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child65RotationValueX, baseline.Child65RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child65RotationValueY, baseline.Child65RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child65RotationValueZ, baseline.Child65RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child65RotationValueW, baseline.Child65RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child65TranslationValueX, baseline.Child65TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child65TranslationValueY, baseline.Child65TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child65TranslationValueZ, baseline.Child65TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child66RotationValueX, baseline.Child66RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child66RotationValueY, baseline.Child66RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child66RotationValueZ, baseline.Child66RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child66RotationValueW, baseline.Child66RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child66TranslationValueX, baseline.Child66TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child66TranslationValueY, baseline.Child66TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child66TranslationValueZ, baseline.Child66TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child67RotationValueX, baseline.Child67RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child67RotationValueY, baseline.Child67RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child67RotationValueZ, baseline.Child67RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child67RotationValueW, baseline.Child67RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child67TranslationValueX, baseline.Child67TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child67TranslationValueY, baseline.Child67TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child67TranslationValueZ, baseline.Child67TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child68RotationValueX, baseline.Child68RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child68RotationValueY, baseline.Child68RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child68RotationValueZ, baseline.Child68RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child68RotationValueW, baseline.Child68RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child68TranslationValueX, baseline.Child68TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child68TranslationValueY, baseline.Child68TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child68TranslationValueZ, baseline.Child68TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child69RotationValueX, baseline.Child69RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child69RotationValueY, baseline.Child69RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child69RotationValueZ, baseline.Child69RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child69RotationValueW, baseline.Child69RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child69TranslationValueX, baseline.Child69TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child69TranslationValueY, baseline.Child69TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child69TranslationValueZ, baseline.Child69TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child70RotationValueX, baseline.Child70RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child70RotationValueY, baseline.Child70RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child70RotationValueZ, baseline.Child70RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child70RotationValueW, baseline.Child70RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child70TranslationValueX, baseline.Child70TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child70TranslationValueY, baseline.Child70TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child70TranslationValueZ, baseline.Child70TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 17)) != 0)
        {
            writer.WritePackedIntDelta(Child71RotationValueX, baseline.Child71RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child71RotationValueY, baseline.Child71RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child71RotationValueZ, baseline.Child71RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child71RotationValueW, baseline.Child71RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 18)) != 0)
        {
            writer.WritePackedIntDelta(Child71TranslationValueX, baseline.Child71TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child71TranslationValueY, baseline.Child71TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child71TranslationValueZ, baseline.Child71TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 19)) != 0)
        {
            writer.WritePackedIntDelta(Child72RotationValueX, baseline.Child72RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child72RotationValueY, baseline.Child72RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child72RotationValueZ, baseline.Child72RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child72RotationValueW, baseline.Child72RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 20)) != 0)
        {
            writer.WritePackedIntDelta(Child72TranslationValueX, baseline.Child72TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child72TranslationValueY, baseline.Child72TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child72TranslationValueZ, baseline.Child72TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 21)) != 0)
        {
            writer.WritePackedIntDelta(Child73RotationValueX, baseline.Child73RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child73RotationValueY, baseline.Child73RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child73RotationValueZ, baseline.Child73RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child73RotationValueW, baseline.Child73RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 22)) != 0)
        {
            writer.WritePackedIntDelta(Child73TranslationValueX, baseline.Child73TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child73TranslationValueY, baseline.Child73TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child73TranslationValueZ, baseline.Child73TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 23)) != 0)
        {
            writer.WritePackedIntDelta(Child74RotationValueX, baseline.Child74RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child74RotationValueY, baseline.Child74RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child74RotationValueZ, baseline.Child74RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child74RotationValueW, baseline.Child74RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 24)) != 0)
        {
            writer.WritePackedIntDelta(Child74TranslationValueX, baseline.Child74TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child74TranslationValueY, baseline.Child74TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child74TranslationValueZ, baseline.Child74TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 25)) != 0)
        {
            writer.WritePackedIntDelta(Child75RotationValueX, baseline.Child75RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child75RotationValueY, baseline.Child75RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child75RotationValueZ, baseline.Child75RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child75RotationValueW, baseline.Child75RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 26)) != 0)
        {
            writer.WritePackedIntDelta(Child75TranslationValueX, baseline.Child75TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child75TranslationValueY, baseline.Child75TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child75TranslationValueZ, baseline.Child75TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 27)) != 0)
        {
            writer.WritePackedIntDelta(Child76RotationValueX, baseline.Child76RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child76RotationValueY, baseline.Child76RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child76RotationValueZ, baseline.Child76RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child76RotationValueW, baseline.Child76RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 28)) != 0)
        {
            writer.WritePackedIntDelta(Child76TranslationValueX, baseline.Child76TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child76TranslationValueY, baseline.Child76TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child76TranslationValueZ, baseline.Child76TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 29)) != 0)
        {
            writer.WritePackedIntDelta(Child77RotationValueX, baseline.Child77RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child77RotationValueY, baseline.Child77RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child77RotationValueZ, baseline.Child77RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child77RotationValueW, baseline.Child77RotationValueW, compressionModel);
        }
        if ((changeMask4 & (1 << 30)) != 0)
        {
            writer.WritePackedIntDelta(Child77TranslationValueX, baseline.Child77TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child77TranslationValueY, baseline.Child77TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child77TranslationValueZ, baseline.Child77TranslationValueZ, compressionModel);
        }
        if ((changeMask4 & (1 << 31)) != 0)
        {
            writer.WritePackedIntDelta(Child78RotationValueX, baseline.Child78RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child78RotationValueY, baseline.Child78RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child78RotationValueZ, baseline.Child78RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child78RotationValueW, baseline.Child78RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 0)) != 0)
        {
            writer.WritePackedIntDelta(Child78TranslationValueX, baseline.Child78TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child78TranslationValueY, baseline.Child78TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child78TranslationValueZ, baseline.Child78TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 1)) != 0)
        {
            writer.WritePackedIntDelta(Child79RotationValueX, baseline.Child79RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child79RotationValueY, baseline.Child79RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child79RotationValueZ, baseline.Child79RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child79RotationValueW, baseline.Child79RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 2)) != 0)
        {
            writer.WritePackedIntDelta(Child79TranslationValueX, baseline.Child79TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child79TranslationValueY, baseline.Child79TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child79TranslationValueZ, baseline.Child79TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 3)) != 0)
        {
            writer.WritePackedIntDelta(Child80RotationValueX, baseline.Child80RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child80RotationValueY, baseline.Child80RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child80RotationValueZ, baseline.Child80RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child80RotationValueW, baseline.Child80RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 4)) != 0)
        {
            writer.WritePackedIntDelta(Child80TranslationValueX, baseline.Child80TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child80TranslationValueY, baseline.Child80TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child80TranslationValueZ, baseline.Child80TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 5)) != 0)
        {
            writer.WritePackedIntDelta(Child81RotationValueX, baseline.Child81RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child81RotationValueY, baseline.Child81RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child81RotationValueZ, baseline.Child81RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child81RotationValueW, baseline.Child81RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 6)) != 0)
        {
            writer.WritePackedIntDelta(Child81TranslationValueX, baseline.Child81TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child81TranslationValueY, baseline.Child81TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child81TranslationValueZ, baseline.Child81TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 7)) != 0)
        {
            writer.WritePackedIntDelta(Child82RotationValueX, baseline.Child82RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child82RotationValueY, baseline.Child82RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child82RotationValueZ, baseline.Child82RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child82RotationValueW, baseline.Child82RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 8)) != 0)
        {
            writer.WritePackedIntDelta(Child82TranslationValueX, baseline.Child82TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child82TranslationValueY, baseline.Child82TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child82TranslationValueZ, baseline.Child82TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 9)) != 0)
        {
            writer.WritePackedIntDelta(Child83RotationValueX, baseline.Child83RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child83RotationValueY, baseline.Child83RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child83RotationValueZ, baseline.Child83RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child83RotationValueW, baseline.Child83RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 10)) != 0)
        {
            writer.WritePackedIntDelta(Child83TranslationValueX, baseline.Child83TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child83TranslationValueY, baseline.Child83TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child83TranslationValueZ, baseline.Child83TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 11)) != 0)
        {
            writer.WritePackedIntDelta(Child84RotationValueX, baseline.Child84RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child84RotationValueY, baseline.Child84RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child84RotationValueZ, baseline.Child84RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child84RotationValueW, baseline.Child84RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 12)) != 0)
        {
            writer.WritePackedIntDelta(Child84TranslationValueX, baseline.Child84TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child84TranslationValueY, baseline.Child84TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child84TranslationValueZ, baseline.Child84TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 13)) != 0)
        {
            writer.WritePackedIntDelta(Child85RotationValueX, baseline.Child85RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child85RotationValueY, baseline.Child85RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child85RotationValueZ, baseline.Child85RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child85RotationValueW, baseline.Child85RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 14)) != 0)
        {
            writer.WritePackedIntDelta(Child85TranslationValueX, baseline.Child85TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child85TranslationValueY, baseline.Child85TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child85TranslationValueZ, baseline.Child85TranslationValueZ, compressionModel);
        }
        if ((changeMask5 & (1 << 15)) != 0)
        {
            writer.WritePackedIntDelta(Child86RotationValueX, baseline.Child86RotationValueX, compressionModel);
            writer.WritePackedIntDelta(Child86RotationValueY, baseline.Child86RotationValueY, compressionModel);
            writer.WritePackedIntDelta(Child86RotationValueZ, baseline.Child86RotationValueZ, compressionModel);
            writer.WritePackedIntDelta(Child86RotationValueW, baseline.Child86RotationValueW, compressionModel);
        }
        if ((changeMask5 & (1 << 16)) != 0)
        {
            writer.WritePackedIntDelta(Child86TranslationValueX, baseline.Child86TranslationValueX, compressionModel);
            writer.WritePackedIntDelta(Child86TranslationValueY, baseline.Child86TranslationValueY, compressionModel);
            writer.WritePackedIntDelta(Child86TranslationValueZ, baseline.Child86TranslationValueZ, compressionModel);
        }
    }

    public void Deserialize(uint tick, ref ThirdPersonControllerSnapshotData baseline, ref DataStreamReader reader,
        NetworkCompressionModel compressionModel)
    {
        this.tick = tick;
        changeMask0 = reader.ReadPackedUIntDelta(baseline.changeMask0, compressionModel);
        changeMask1 = reader.ReadPackedUIntDelta(baseline.changeMask1, compressionModel);
        changeMask2 = reader.ReadPackedUIntDelta(baseline.changeMask2, compressionModel);
        changeMask3 = reader.ReadPackedUIntDelta(baseline.changeMask3, compressionModel);
        changeMask4 = reader.ReadPackedUIntDelta(baseline.changeMask4, compressionModel);
        changeMask5 = reader.ReadPackedUIntDelta(baseline.changeMask5, compressionModel);
        if ((changeMask0 & (1 << 0)) != 0)
            MovablePlayerPlayerId = reader.ReadPackedIntDelta(baseline.MovablePlayerPlayerId, compressionModel);
        else
            MovablePlayerPlayerId = baseline.MovablePlayerPlayerId;
        if ((changeMask0 & (1 << 1)) != 0)
        {
            RotationValueX = reader.ReadPackedIntDelta(baseline.RotationValueX, compressionModel);
            RotationValueY = reader.ReadPackedIntDelta(baseline.RotationValueY, compressionModel);
            RotationValueZ = reader.ReadPackedIntDelta(baseline.RotationValueZ, compressionModel);
            RotationValueW = reader.ReadPackedIntDelta(baseline.RotationValueW, compressionModel);
        }
        else
        {
            RotationValueX = baseline.RotationValueX;
            RotationValueY = baseline.RotationValueY;
            RotationValueZ = baseline.RotationValueZ;
            RotationValueW = baseline.RotationValueW;
        }
        if ((changeMask0 & (1 << 2)) != 0)
        {
            TranslationValueX = reader.ReadPackedIntDelta(baseline.TranslationValueX, compressionModel);
            TranslationValueY = reader.ReadPackedIntDelta(baseline.TranslationValueY, compressionModel);
            TranslationValueZ = reader.ReadPackedIntDelta(baseline.TranslationValueZ, compressionModel);
        }
        else
        {
            TranslationValueX = baseline.TranslationValueX;
            TranslationValueY = baseline.TranslationValueY;
            TranslationValueZ = baseline.TranslationValueZ;
        }
        if ((changeMask0 & (1 << 3)) != 0)
        {
            Child0RotationValueX = reader.ReadPackedIntDelta(baseline.Child0RotationValueX, compressionModel);
            Child0RotationValueY = reader.ReadPackedIntDelta(baseline.Child0RotationValueY, compressionModel);
            Child0RotationValueZ = reader.ReadPackedIntDelta(baseline.Child0RotationValueZ, compressionModel);
            Child0RotationValueW = reader.ReadPackedIntDelta(baseline.Child0RotationValueW, compressionModel);
        }
        else
        {
            Child0RotationValueX = baseline.Child0RotationValueX;
            Child0RotationValueY = baseline.Child0RotationValueY;
            Child0RotationValueZ = baseline.Child0RotationValueZ;
            Child0RotationValueW = baseline.Child0RotationValueW;
        }
        if ((changeMask0 & (1 << 4)) != 0)
        {
            Child0TranslationValueX = reader.ReadPackedIntDelta(baseline.Child0TranslationValueX, compressionModel);
            Child0TranslationValueY = reader.ReadPackedIntDelta(baseline.Child0TranslationValueY, compressionModel);
            Child0TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child0TranslationValueZ, compressionModel);
        }
        else
        {
            Child0TranslationValueX = baseline.Child0TranslationValueX;
            Child0TranslationValueY = baseline.Child0TranslationValueY;
            Child0TranslationValueZ = baseline.Child0TranslationValueZ;
        }
        if ((changeMask0 & (1 << 5)) != 0)
        {
            Child1RotationValueX = reader.ReadPackedIntDelta(baseline.Child1RotationValueX, compressionModel);
            Child1RotationValueY = reader.ReadPackedIntDelta(baseline.Child1RotationValueY, compressionModel);
            Child1RotationValueZ = reader.ReadPackedIntDelta(baseline.Child1RotationValueZ, compressionModel);
            Child1RotationValueW = reader.ReadPackedIntDelta(baseline.Child1RotationValueW, compressionModel);
        }
        else
        {
            Child1RotationValueX = baseline.Child1RotationValueX;
            Child1RotationValueY = baseline.Child1RotationValueY;
            Child1RotationValueZ = baseline.Child1RotationValueZ;
            Child1RotationValueW = baseline.Child1RotationValueW;
        }
        if ((changeMask0 & (1 << 6)) != 0)
        {
            Child1TranslationValueX = reader.ReadPackedIntDelta(baseline.Child1TranslationValueX, compressionModel);
            Child1TranslationValueY = reader.ReadPackedIntDelta(baseline.Child1TranslationValueY, compressionModel);
            Child1TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child1TranslationValueZ, compressionModel);
        }
        else
        {
            Child1TranslationValueX = baseline.Child1TranslationValueX;
            Child1TranslationValueY = baseline.Child1TranslationValueY;
            Child1TranslationValueZ = baseline.Child1TranslationValueZ;
        }
        if ((changeMask0 & (1 << 7)) != 0)
        {
            Child2RotationValueX = reader.ReadPackedIntDelta(baseline.Child2RotationValueX, compressionModel);
            Child2RotationValueY = reader.ReadPackedIntDelta(baseline.Child2RotationValueY, compressionModel);
            Child2RotationValueZ = reader.ReadPackedIntDelta(baseline.Child2RotationValueZ, compressionModel);
            Child2RotationValueW = reader.ReadPackedIntDelta(baseline.Child2RotationValueW, compressionModel);
        }
        else
        {
            Child2RotationValueX = baseline.Child2RotationValueX;
            Child2RotationValueY = baseline.Child2RotationValueY;
            Child2RotationValueZ = baseline.Child2RotationValueZ;
            Child2RotationValueW = baseline.Child2RotationValueW;
        }
        if ((changeMask0 & (1 << 8)) != 0)
        {
            Child2TranslationValueX = reader.ReadPackedIntDelta(baseline.Child2TranslationValueX, compressionModel);
            Child2TranslationValueY = reader.ReadPackedIntDelta(baseline.Child2TranslationValueY, compressionModel);
            Child2TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child2TranslationValueZ, compressionModel);
        }
        else
        {
            Child2TranslationValueX = baseline.Child2TranslationValueX;
            Child2TranslationValueY = baseline.Child2TranslationValueY;
            Child2TranslationValueZ = baseline.Child2TranslationValueZ;
        }
        if ((changeMask0 & (1 << 9)) != 0)
        {
            Child3RotationValueX = reader.ReadPackedIntDelta(baseline.Child3RotationValueX, compressionModel);
            Child3RotationValueY = reader.ReadPackedIntDelta(baseline.Child3RotationValueY, compressionModel);
            Child3RotationValueZ = reader.ReadPackedIntDelta(baseline.Child3RotationValueZ, compressionModel);
            Child3RotationValueW = reader.ReadPackedIntDelta(baseline.Child3RotationValueW, compressionModel);
        }
        else
        {
            Child3RotationValueX = baseline.Child3RotationValueX;
            Child3RotationValueY = baseline.Child3RotationValueY;
            Child3RotationValueZ = baseline.Child3RotationValueZ;
            Child3RotationValueW = baseline.Child3RotationValueW;
        }
        if ((changeMask0 & (1 << 10)) != 0)
        {
            Child3TranslationValueX = reader.ReadPackedIntDelta(baseline.Child3TranslationValueX, compressionModel);
            Child3TranslationValueY = reader.ReadPackedIntDelta(baseline.Child3TranslationValueY, compressionModel);
            Child3TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child3TranslationValueZ, compressionModel);
        }
        else
        {
            Child3TranslationValueX = baseline.Child3TranslationValueX;
            Child3TranslationValueY = baseline.Child3TranslationValueY;
            Child3TranslationValueZ = baseline.Child3TranslationValueZ;
        }
        if ((changeMask0 & (1 << 11)) != 0)
        {
            Child4RotationValueX = reader.ReadPackedIntDelta(baseline.Child4RotationValueX, compressionModel);
            Child4RotationValueY = reader.ReadPackedIntDelta(baseline.Child4RotationValueY, compressionModel);
            Child4RotationValueZ = reader.ReadPackedIntDelta(baseline.Child4RotationValueZ, compressionModel);
            Child4RotationValueW = reader.ReadPackedIntDelta(baseline.Child4RotationValueW, compressionModel);
        }
        else
        {
            Child4RotationValueX = baseline.Child4RotationValueX;
            Child4RotationValueY = baseline.Child4RotationValueY;
            Child4RotationValueZ = baseline.Child4RotationValueZ;
            Child4RotationValueW = baseline.Child4RotationValueW;
        }
        if ((changeMask0 & (1 << 12)) != 0)
        {
            Child4TranslationValueX = reader.ReadPackedIntDelta(baseline.Child4TranslationValueX, compressionModel);
            Child4TranslationValueY = reader.ReadPackedIntDelta(baseline.Child4TranslationValueY, compressionModel);
            Child4TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child4TranslationValueZ, compressionModel);
        }
        else
        {
            Child4TranslationValueX = baseline.Child4TranslationValueX;
            Child4TranslationValueY = baseline.Child4TranslationValueY;
            Child4TranslationValueZ = baseline.Child4TranslationValueZ;
        }
        if ((changeMask0 & (1 << 13)) != 0)
        {
            Child5RotationValueX = reader.ReadPackedIntDelta(baseline.Child5RotationValueX, compressionModel);
            Child5RotationValueY = reader.ReadPackedIntDelta(baseline.Child5RotationValueY, compressionModel);
            Child5RotationValueZ = reader.ReadPackedIntDelta(baseline.Child5RotationValueZ, compressionModel);
            Child5RotationValueW = reader.ReadPackedIntDelta(baseline.Child5RotationValueW, compressionModel);
        }
        else
        {
            Child5RotationValueX = baseline.Child5RotationValueX;
            Child5RotationValueY = baseline.Child5RotationValueY;
            Child5RotationValueZ = baseline.Child5RotationValueZ;
            Child5RotationValueW = baseline.Child5RotationValueW;
        }
        if ((changeMask0 & (1 << 14)) != 0)
        {
            Child5TranslationValueX = reader.ReadPackedIntDelta(baseline.Child5TranslationValueX, compressionModel);
            Child5TranslationValueY = reader.ReadPackedIntDelta(baseline.Child5TranslationValueY, compressionModel);
            Child5TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child5TranslationValueZ, compressionModel);
        }
        else
        {
            Child5TranslationValueX = baseline.Child5TranslationValueX;
            Child5TranslationValueY = baseline.Child5TranslationValueY;
            Child5TranslationValueZ = baseline.Child5TranslationValueZ;
        }
        if ((changeMask0 & (1 << 15)) != 0)
        {
            Child6RotationValueX = reader.ReadPackedIntDelta(baseline.Child6RotationValueX, compressionModel);
            Child6RotationValueY = reader.ReadPackedIntDelta(baseline.Child6RotationValueY, compressionModel);
            Child6RotationValueZ = reader.ReadPackedIntDelta(baseline.Child6RotationValueZ, compressionModel);
            Child6RotationValueW = reader.ReadPackedIntDelta(baseline.Child6RotationValueW, compressionModel);
        }
        else
        {
            Child6RotationValueX = baseline.Child6RotationValueX;
            Child6RotationValueY = baseline.Child6RotationValueY;
            Child6RotationValueZ = baseline.Child6RotationValueZ;
            Child6RotationValueW = baseline.Child6RotationValueW;
        }
        if ((changeMask0 & (1 << 16)) != 0)
        {
            Child6TranslationValueX = reader.ReadPackedIntDelta(baseline.Child6TranslationValueX, compressionModel);
            Child6TranslationValueY = reader.ReadPackedIntDelta(baseline.Child6TranslationValueY, compressionModel);
            Child6TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child6TranslationValueZ, compressionModel);
        }
        else
        {
            Child6TranslationValueX = baseline.Child6TranslationValueX;
            Child6TranslationValueY = baseline.Child6TranslationValueY;
            Child6TranslationValueZ = baseline.Child6TranslationValueZ;
        }
        if ((changeMask0 & (1 << 17)) != 0)
        {
            Child7RotationValueX = reader.ReadPackedIntDelta(baseline.Child7RotationValueX, compressionModel);
            Child7RotationValueY = reader.ReadPackedIntDelta(baseline.Child7RotationValueY, compressionModel);
            Child7RotationValueZ = reader.ReadPackedIntDelta(baseline.Child7RotationValueZ, compressionModel);
            Child7RotationValueW = reader.ReadPackedIntDelta(baseline.Child7RotationValueW, compressionModel);
        }
        else
        {
            Child7RotationValueX = baseline.Child7RotationValueX;
            Child7RotationValueY = baseline.Child7RotationValueY;
            Child7RotationValueZ = baseline.Child7RotationValueZ;
            Child7RotationValueW = baseline.Child7RotationValueW;
        }
        if ((changeMask0 & (1 << 18)) != 0)
        {
            Child7TranslationValueX = reader.ReadPackedIntDelta(baseline.Child7TranslationValueX, compressionModel);
            Child7TranslationValueY = reader.ReadPackedIntDelta(baseline.Child7TranslationValueY, compressionModel);
            Child7TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child7TranslationValueZ, compressionModel);
        }
        else
        {
            Child7TranslationValueX = baseline.Child7TranslationValueX;
            Child7TranslationValueY = baseline.Child7TranslationValueY;
            Child7TranslationValueZ = baseline.Child7TranslationValueZ;
        }
        if ((changeMask0 & (1 << 19)) != 0)
        {
            Child8RotationValueX = reader.ReadPackedIntDelta(baseline.Child8RotationValueX, compressionModel);
            Child8RotationValueY = reader.ReadPackedIntDelta(baseline.Child8RotationValueY, compressionModel);
            Child8RotationValueZ = reader.ReadPackedIntDelta(baseline.Child8RotationValueZ, compressionModel);
            Child8RotationValueW = reader.ReadPackedIntDelta(baseline.Child8RotationValueW, compressionModel);
        }
        else
        {
            Child8RotationValueX = baseline.Child8RotationValueX;
            Child8RotationValueY = baseline.Child8RotationValueY;
            Child8RotationValueZ = baseline.Child8RotationValueZ;
            Child8RotationValueW = baseline.Child8RotationValueW;
        }
        if ((changeMask0 & (1 << 20)) != 0)
        {
            Child8TranslationValueX = reader.ReadPackedIntDelta(baseline.Child8TranslationValueX, compressionModel);
            Child8TranslationValueY = reader.ReadPackedIntDelta(baseline.Child8TranslationValueY, compressionModel);
            Child8TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child8TranslationValueZ, compressionModel);
        }
        else
        {
            Child8TranslationValueX = baseline.Child8TranslationValueX;
            Child8TranslationValueY = baseline.Child8TranslationValueY;
            Child8TranslationValueZ = baseline.Child8TranslationValueZ;
        }
        if ((changeMask0 & (1 << 21)) != 0)
        {
            Child9RotationValueX = reader.ReadPackedIntDelta(baseline.Child9RotationValueX, compressionModel);
            Child9RotationValueY = reader.ReadPackedIntDelta(baseline.Child9RotationValueY, compressionModel);
            Child9RotationValueZ = reader.ReadPackedIntDelta(baseline.Child9RotationValueZ, compressionModel);
            Child9RotationValueW = reader.ReadPackedIntDelta(baseline.Child9RotationValueW, compressionModel);
        }
        else
        {
            Child9RotationValueX = baseline.Child9RotationValueX;
            Child9RotationValueY = baseline.Child9RotationValueY;
            Child9RotationValueZ = baseline.Child9RotationValueZ;
            Child9RotationValueW = baseline.Child9RotationValueW;
        }
        if ((changeMask0 & (1 << 22)) != 0)
        {
            Child9TranslationValueX = reader.ReadPackedIntDelta(baseline.Child9TranslationValueX, compressionModel);
            Child9TranslationValueY = reader.ReadPackedIntDelta(baseline.Child9TranslationValueY, compressionModel);
            Child9TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child9TranslationValueZ, compressionModel);
        }
        else
        {
            Child9TranslationValueX = baseline.Child9TranslationValueX;
            Child9TranslationValueY = baseline.Child9TranslationValueY;
            Child9TranslationValueZ = baseline.Child9TranslationValueZ;
        }
        if ((changeMask0 & (1 << 23)) != 0)
        {
            Child10RotationValueX = reader.ReadPackedIntDelta(baseline.Child10RotationValueX, compressionModel);
            Child10RotationValueY = reader.ReadPackedIntDelta(baseline.Child10RotationValueY, compressionModel);
            Child10RotationValueZ = reader.ReadPackedIntDelta(baseline.Child10RotationValueZ, compressionModel);
            Child10RotationValueW = reader.ReadPackedIntDelta(baseline.Child10RotationValueW, compressionModel);
        }
        else
        {
            Child10RotationValueX = baseline.Child10RotationValueX;
            Child10RotationValueY = baseline.Child10RotationValueY;
            Child10RotationValueZ = baseline.Child10RotationValueZ;
            Child10RotationValueW = baseline.Child10RotationValueW;
        }
        if ((changeMask0 & (1 << 24)) != 0)
        {
            Child10TranslationValueX = reader.ReadPackedIntDelta(baseline.Child10TranslationValueX, compressionModel);
            Child10TranslationValueY = reader.ReadPackedIntDelta(baseline.Child10TranslationValueY, compressionModel);
            Child10TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child10TranslationValueZ, compressionModel);
        }
        else
        {
            Child10TranslationValueX = baseline.Child10TranslationValueX;
            Child10TranslationValueY = baseline.Child10TranslationValueY;
            Child10TranslationValueZ = baseline.Child10TranslationValueZ;
        }
        if ((changeMask0 & (1 << 25)) != 0)
        {
            Child11RotationValueX = reader.ReadPackedIntDelta(baseline.Child11RotationValueX, compressionModel);
            Child11RotationValueY = reader.ReadPackedIntDelta(baseline.Child11RotationValueY, compressionModel);
            Child11RotationValueZ = reader.ReadPackedIntDelta(baseline.Child11RotationValueZ, compressionModel);
            Child11RotationValueW = reader.ReadPackedIntDelta(baseline.Child11RotationValueW, compressionModel);
        }
        else
        {
            Child11RotationValueX = baseline.Child11RotationValueX;
            Child11RotationValueY = baseline.Child11RotationValueY;
            Child11RotationValueZ = baseline.Child11RotationValueZ;
            Child11RotationValueW = baseline.Child11RotationValueW;
        }
        if ((changeMask0 & (1 << 26)) != 0)
        {
            Child11TranslationValueX = reader.ReadPackedIntDelta(baseline.Child11TranslationValueX, compressionModel);
            Child11TranslationValueY = reader.ReadPackedIntDelta(baseline.Child11TranslationValueY, compressionModel);
            Child11TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child11TranslationValueZ, compressionModel);
        }
        else
        {
            Child11TranslationValueX = baseline.Child11TranslationValueX;
            Child11TranslationValueY = baseline.Child11TranslationValueY;
            Child11TranslationValueZ = baseline.Child11TranslationValueZ;
        }
        if ((changeMask0 & (1 << 27)) != 0)
        {
            Child12RotationValueX = reader.ReadPackedIntDelta(baseline.Child12RotationValueX, compressionModel);
            Child12RotationValueY = reader.ReadPackedIntDelta(baseline.Child12RotationValueY, compressionModel);
            Child12RotationValueZ = reader.ReadPackedIntDelta(baseline.Child12RotationValueZ, compressionModel);
            Child12RotationValueW = reader.ReadPackedIntDelta(baseline.Child12RotationValueW, compressionModel);
        }
        else
        {
            Child12RotationValueX = baseline.Child12RotationValueX;
            Child12RotationValueY = baseline.Child12RotationValueY;
            Child12RotationValueZ = baseline.Child12RotationValueZ;
            Child12RotationValueW = baseline.Child12RotationValueW;
        }
        if ((changeMask0 & (1 << 28)) != 0)
        {
            Child12TranslationValueX = reader.ReadPackedIntDelta(baseline.Child12TranslationValueX, compressionModel);
            Child12TranslationValueY = reader.ReadPackedIntDelta(baseline.Child12TranslationValueY, compressionModel);
            Child12TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child12TranslationValueZ, compressionModel);
        }
        else
        {
            Child12TranslationValueX = baseline.Child12TranslationValueX;
            Child12TranslationValueY = baseline.Child12TranslationValueY;
            Child12TranslationValueZ = baseline.Child12TranslationValueZ;
        }
        if ((changeMask0 & (1 << 29)) != 0)
        {
            Child13RotationValueX = reader.ReadPackedIntDelta(baseline.Child13RotationValueX, compressionModel);
            Child13RotationValueY = reader.ReadPackedIntDelta(baseline.Child13RotationValueY, compressionModel);
            Child13RotationValueZ = reader.ReadPackedIntDelta(baseline.Child13RotationValueZ, compressionModel);
            Child13RotationValueW = reader.ReadPackedIntDelta(baseline.Child13RotationValueW, compressionModel);
        }
        else
        {
            Child13RotationValueX = baseline.Child13RotationValueX;
            Child13RotationValueY = baseline.Child13RotationValueY;
            Child13RotationValueZ = baseline.Child13RotationValueZ;
            Child13RotationValueW = baseline.Child13RotationValueW;
        }
        if ((changeMask0 & (1 << 30)) != 0)
        {
            Child13TranslationValueX = reader.ReadPackedIntDelta(baseline.Child13TranslationValueX, compressionModel);
            Child13TranslationValueY = reader.ReadPackedIntDelta(baseline.Child13TranslationValueY, compressionModel);
            Child13TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child13TranslationValueZ, compressionModel);
        }
        else
        {
            Child13TranslationValueX = baseline.Child13TranslationValueX;
            Child13TranslationValueY = baseline.Child13TranslationValueY;
            Child13TranslationValueZ = baseline.Child13TranslationValueZ;
        }
        if ((changeMask0 & (1 << 31)) != 0)
        {
            Child14RotationValueX = reader.ReadPackedIntDelta(baseline.Child14RotationValueX, compressionModel);
            Child14RotationValueY = reader.ReadPackedIntDelta(baseline.Child14RotationValueY, compressionModel);
            Child14RotationValueZ = reader.ReadPackedIntDelta(baseline.Child14RotationValueZ, compressionModel);
            Child14RotationValueW = reader.ReadPackedIntDelta(baseline.Child14RotationValueW, compressionModel);
        }
        else
        {
            Child14RotationValueX = baseline.Child14RotationValueX;
            Child14RotationValueY = baseline.Child14RotationValueY;
            Child14RotationValueZ = baseline.Child14RotationValueZ;
            Child14RotationValueW = baseline.Child14RotationValueW;
        }
        if ((changeMask1 & (1 << 0)) != 0)
        {
            Child14TranslationValueX = reader.ReadPackedIntDelta(baseline.Child14TranslationValueX, compressionModel);
            Child14TranslationValueY = reader.ReadPackedIntDelta(baseline.Child14TranslationValueY, compressionModel);
            Child14TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child14TranslationValueZ, compressionModel);
        }
        else
        {
            Child14TranslationValueX = baseline.Child14TranslationValueX;
            Child14TranslationValueY = baseline.Child14TranslationValueY;
            Child14TranslationValueZ = baseline.Child14TranslationValueZ;
        }
        if ((changeMask1 & (1 << 1)) != 0)
        {
            Child15RotationValueX = reader.ReadPackedIntDelta(baseline.Child15RotationValueX, compressionModel);
            Child15RotationValueY = reader.ReadPackedIntDelta(baseline.Child15RotationValueY, compressionModel);
            Child15RotationValueZ = reader.ReadPackedIntDelta(baseline.Child15RotationValueZ, compressionModel);
            Child15RotationValueW = reader.ReadPackedIntDelta(baseline.Child15RotationValueW, compressionModel);
        }
        else
        {
            Child15RotationValueX = baseline.Child15RotationValueX;
            Child15RotationValueY = baseline.Child15RotationValueY;
            Child15RotationValueZ = baseline.Child15RotationValueZ;
            Child15RotationValueW = baseline.Child15RotationValueW;
        }
        if ((changeMask1 & (1 << 2)) != 0)
        {
            Child15TranslationValueX = reader.ReadPackedIntDelta(baseline.Child15TranslationValueX, compressionModel);
            Child15TranslationValueY = reader.ReadPackedIntDelta(baseline.Child15TranslationValueY, compressionModel);
            Child15TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child15TranslationValueZ, compressionModel);
        }
        else
        {
            Child15TranslationValueX = baseline.Child15TranslationValueX;
            Child15TranslationValueY = baseline.Child15TranslationValueY;
            Child15TranslationValueZ = baseline.Child15TranslationValueZ;
        }
        if ((changeMask1 & (1 << 3)) != 0)
        {
            Child16RotationValueX = reader.ReadPackedIntDelta(baseline.Child16RotationValueX, compressionModel);
            Child16RotationValueY = reader.ReadPackedIntDelta(baseline.Child16RotationValueY, compressionModel);
            Child16RotationValueZ = reader.ReadPackedIntDelta(baseline.Child16RotationValueZ, compressionModel);
            Child16RotationValueW = reader.ReadPackedIntDelta(baseline.Child16RotationValueW, compressionModel);
        }
        else
        {
            Child16RotationValueX = baseline.Child16RotationValueX;
            Child16RotationValueY = baseline.Child16RotationValueY;
            Child16RotationValueZ = baseline.Child16RotationValueZ;
            Child16RotationValueW = baseline.Child16RotationValueW;
        }
        if ((changeMask1 & (1 << 4)) != 0)
        {
            Child16TranslationValueX = reader.ReadPackedIntDelta(baseline.Child16TranslationValueX, compressionModel);
            Child16TranslationValueY = reader.ReadPackedIntDelta(baseline.Child16TranslationValueY, compressionModel);
            Child16TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child16TranslationValueZ, compressionModel);
        }
        else
        {
            Child16TranslationValueX = baseline.Child16TranslationValueX;
            Child16TranslationValueY = baseline.Child16TranslationValueY;
            Child16TranslationValueZ = baseline.Child16TranslationValueZ;
        }
        if ((changeMask1 & (1 << 5)) != 0)
        {
            Child17RotationValueX = reader.ReadPackedIntDelta(baseline.Child17RotationValueX, compressionModel);
            Child17RotationValueY = reader.ReadPackedIntDelta(baseline.Child17RotationValueY, compressionModel);
            Child17RotationValueZ = reader.ReadPackedIntDelta(baseline.Child17RotationValueZ, compressionModel);
            Child17RotationValueW = reader.ReadPackedIntDelta(baseline.Child17RotationValueW, compressionModel);
        }
        else
        {
            Child17RotationValueX = baseline.Child17RotationValueX;
            Child17RotationValueY = baseline.Child17RotationValueY;
            Child17RotationValueZ = baseline.Child17RotationValueZ;
            Child17RotationValueW = baseline.Child17RotationValueW;
        }
        if ((changeMask1 & (1 << 6)) != 0)
        {
            Child17TranslationValueX = reader.ReadPackedIntDelta(baseline.Child17TranslationValueX, compressionModel);
            Child17TranslationValueY = reader.ReadPackedIntDelta(baseline.Child17TranslationValueY, compressionModel);
            Child17TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child17TranslationValueZ, compressionModel);
        }
        else
        {
            Child17TranslationValueX = baseline.Child17TranslationValueX;
            Child17TranslationValueY = baseline.Child17TranslationValueY;
            Child17TranslationValueZ = baseline.Child17TranslationValueZ;
        }
        if ((changeMask1 & (1 << 7)) != 0)
        {
            Child18RotationValueX = reader.ReadPackedIntDelta(baseline.Child18RotationValueX, compressionModel);
            Child18RotationValueY = reader.ReadPackedIntDelta(baseline.Child18RotationValueY, compressionModel);
            Child18RotationValueZ = reader.ReadPackedIntDelta(baseline.Child18RotationValueZ, compressionModel);
            Child18RotationValueW = reader.ReadPackedIntDelta(baseline.Child18RotationValueW, compressionModel);
        }
        else
        {
            Child18RotationValueX = baseline.Child18RotationValueX;
            Child18RotationValueY = baseline.Child18RotationValueY;
            Child18RotationValueZ = baseline.Child18RotationValueZ;
            Child18RotationValueW = baseline.Child18RotationValueW;
        }
        if ((changeMask1 & (1 << 8)) != 0)
        {
            Child18TranslationValueX = reader.ReadPackedIntDelta(baseline.Child18TranslationValueX, compressionModel);
            Child18TranslationValueY = reader.ReadPackedIntDelta(baseline.Child18TranslationValueY, compressionModel);
            Child18TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child18TranslationValueZ, compressionModel);
        }
        else
        {
            Child18TranslationValueX = baseline.Child18TranslationValueX;
            Child18TranslationValueY = baseline.Child18TranslationValueY;
            Child18TranslationValueZ = baseline.Child18TranslationValueZ;
        }
        if ((changeMask1 & (1 << 9)) != 0)
        {
            Child19RotationValueX = reader.ReadPackedIntDelta(baseline.Child19RotationValueX, compressionModel);
            Child19RotationValueY = reader.ReadPackedIntDelta(baseline.Child19RotationValueY, compressionModel);
            Child19RotationValueZ = reader.ReadPackedIntDelta(baseline.Child19RotationValueZ, compressionModel);
            Child19RotationValueW = reader.ReadPackedIntDelta(baseline.Child19RotationValueW, compressionModel);
        }
        else
        {
            Child19RotationValueX = baseline.Child19RotationValueX;
            Child19RotationValueY = baseline.Child19RotationValueY;
            Child19RotationValueZ = baseline.Child19RotationValueZ;
            Child19RotationValueW = baseline.Child19RotationValueW;
        }
        if ((changeMask1 & (1 << 10)) != 0)
        {
            Child19TranslationValueX = reader.ReadPackedIntDelta(baseline.Child19TranslationValueX, compressionModel);
            Child19TranslationValueY = reader.ReadPackedIntDelta(baseline.Child19TranslationValueY, compressionModel);
            Child19TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child19TranslationValueZ, compressionModel);
        }
        else
        {
            Child19TranslationValueX = baseline.Child19TranslationValueX;
            Child19TranslationValueY = baseline.Child19TranslationValueY;
            Child19TranslationValueZ = baseline.Child19TranslationValueZ;
        }
        if ((changeMask1 & (1 << 11)) != 0)
        {
            Child20RotationValueX = reader.ReadPackedIntDelta(baseline.Child20RotationValueX, compressionModel);
            Child20RotationValueY = reader.ReadPackedIntDelta(baseline.Child20RotationValueY, compressionModel);
            Child20RotationValueZ = reader.ReadPackedIntDelta(baseline.Child20RotationValueZ, compressionModel);
            Child20RotationValueW = reader.ReadPackedIntDelta(baseline.Child20RotationValueW, compressionModel);
        }
        else
        {
            Child20RotationValueX = baseline.Child20RotationValueX;
            Child20RotationValueY = baseline.Child20RotationValueY;
            Child20RotationValueZ = baseline.Child20RotationValueZ;
            Child20RotationValueW = baseline.Child20RotationValueW;
        }
        if ((changeMask1 & (1 << 12)) != 0)
        {
            Child20TranslationValueX = reader.ReadPackedIntDelta(baseline.Child20TranslationValueX, compressionModel);
            Child20TranslationValueY = reader.ReadPackedIntDelta(baseline.Child20TranslationValueY, compressionModel);
            Child20TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child20TranslationValueZ, compressionModel);
        }
        else
        {
            Child20TranslationValueX = baseline.Child20TranslationValueX;
            Child20TranslationValueY = baseline.Child20TranslationValueY;
            Child20TranslationValueZ = baseline.Child20TranslationValueZ;
        }
        if ((changeMask1 & (1 << 13)) != 0)
        {
            Child21RotationValueX = reader.ReadPackedIntDelta(baseline.Child21RotationValueX, compressionModel);
            Child21RotationValueY = reader.ReadPackedIntDelta(baseline.Child21RotationValueY, compressionModel);
            Child21RotationValueZ = reader.ReadPackedIntDelta(baseline.Child21RotationValueZ, compressionModel);
            Child21RotationValueW = reader.ReadPackedIntDelta(baseline.Child21RotationValueW, compressionModel);
        }
        else
        {
            Child21RotationValueX = baseline.Child21RotationValueX;
            Child21RotationValueY = baseline.Child21RotationValueY;
            Child21RotationValueZ = baseline.Child21RotationValueZ;
            Child21RotationValueW = baseline.Child21RotationValueW;
        }
        if ((changeMask1 & (1 << 14)) != 0)
        {
            Child21TranslationValueX = reader.ReadPackedIntDelta(baseline.Child21TranslationValueX, compressionModel);
            Child21TranslationValueY = reader.ReadPackedIntDelta(baseline.Child21TranslationValueY, compressionModel);
            Child21TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child21TranslationValueZ, compressionModel);
        }
        else
        {
            Child21TranslationValueX = baseline.Child21TranslationValueX;
            Child21TranslationValueY = baseline.Child21TranslationValueY;
            Child21TranslationValueZ = baseline.Child21TranslationValueZ;
        }
        if ((changeMask1 & (1 << 15)) != 0)
        {
            Child22RotationValueX = reader.ReadPackedIntDelta(baseline.Child22RotationValueX, compressionModel);
            Child22RotationValueY = reader.ReadPackedIntDelta(baseline.Child22RotationValueY, compressionModel);
            Child22RotationValueZ = reader.ReadPackedIntDelta(baseline.Child22RotationValueZ, compressionModel);
            Child22RotationValueW = reader.ReadPackedIntDelta(baseline.Child22RotationValueW, compressionModel);
        }
        else
        {
            Child22RotationValueX = baseline.Child22RotationValueX;
            Child22RotationValueY = baseline.Child22RotationValueY;
            Child22RotationValueZ = baseline.Child22RotationValueZ;
            Child22RotationValueW = baseline.Child22RotationValueW;
        }
        if ((changeMask1 & (1 << 16)) != 0)
        {
            Child22TranslationValueX = reader.ReadPackedIntDelta(baseline.Child22TranslationValueX, compressionModel);
            Child22TranslationValueY = reader.ReadPackedIntDelta(baseline.Child22TranslationValueY, compressionModel);
            Child22TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child22TranslationValueZ, compressionModel);
        }
        else
        {
            Child22TranslationValueX = baseline.Child22TranslationValueX;
            Child22TranslationValueY = baseline.Child22TranslationValueY;
            Child22TranslationValueZ = baseline.Child22TranslationValueZ;
        }
        if ((changeMask1 & (1 << 17)) != 0)
        {
            Child23RotationValueX = reader.ReadPackedIntDelta(baseline.Child23RotationValueX, compressionModel);
            Child23RotationValueY = reader.ReadPackedIntDelta(baseline.Child23RotationValueY, compressionModel);
            Child23RotationValueZ = reader.ReadPackedIntDelta(baseline.Child23RotationValueZ, compressionModel);
            Child23RotationValueW = reader.ReadPackedIntDelta(baseline.Child23RotationValueW, compressionModel);
        }
        else
        {
            Child23RotationValueX = baseline.Child23RotationValueX;
            Child23RotationValueY = baseline.Child23RotationValueY;
            Child23RotationValueZ = baseline.Child23RotationValueZ;
            Child23RotationValueW = baseline.Child23RotationValueW;
        }
        if ((changeMask1 & (1 << 18)) != 0)
        {
            Child23TranslationValueX = reader.ReadPackedIntDelta(baseline.Child23TranslationValueX, compressionModel);
            Child23TranslationValueY = reader.ReadPackedIntDelta(baseline.Child23TranslationValueY, compressionModel);
            Child23TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child23TranslationValueZ, compressionModel);
        }
        else
        {
            Child23TranslationValueX = baseline.Child23TranslationValueX;
            Child23TranslationValueY = baseline.Child23TranslationValueY;
            Child23TranslationValueZ = baseline.Child23TranslationValueZ;
        }
        if ((changeMask1 & (1 << 19)) != 0)
        {
            Child24RotationValueX = reader.ReadPackedIntDelta(baseline.Child24RotationValueX, compressionModel);
            Child24RotationValueY = reader.ReadPackedIntDelta(baseline.Child24RotationValueY, compressionModel);
            Child24RotationValueZ = reader.ReadPackedIntDelta(baseline.Child24RotationValueZ, compressionModel);
            Child24RotationValueW = reader.ReadPackedIntDelta(baseline.Child24RotationValueW, compressionModel);
        }
        else
        {
            Child24RotationValueX = baseline.Child24RotationValueX;
            Child24RotationValueY = baseline.Child24RotationValueY;
            Child24RotationValueZ = baseline.Child24RotationValueZ;
            Child24RotationValueW = baseline.Child24RotationValueW;
        }
        if ((changeMask1 & (1 << 20)) != 0)
        {
            Child24TranslationValueX = reader.ReadPackedIntDelta(baseline.Child24TranslationValueX, compressionModel);
            Child24TranslationValueY = reader.ReadPackedIntDelta(baseline.Child24TranslationValueY, compressionModel);
            Child24TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child24TranslationValueZ, compressionModel);
        }
        else
        {
            Child24TranslationValueX = baseline.Child24TranslationValueX;
            Child24TranslationValueY = baseline.Child24TranslationValueY;
            Child24TranslationValueZ = baseline.Child24TranslationValueZ;
        }
        if ((changeMask1 & (1 << 21)) != 0)
        {
            Child25RotationValueX = reader.ReadPackedIntDelta(baseline.Child25RotationValueX, compressionModel);
            Child25RotationValueY = reader.ReadPackedIntDelta(baseline.Child25RotationValueY, compressionModel);
            Child25RotationValueZ = reader.ReadPackedIntDelta(baseline.Child25RotationValueZ, compressionModel);
            Child25RotationValueW = reader.ReadPackedIntDelta(baseline.Child25RotationValueW, compressionModel);
        }
        else
        {
            Child25RotationValueX = baseline.Child25RotationValueX;
            Child25RotationValueY = baseline.Child25RotationValueY;
            Child25RotationValueZ = baseline.Child25RotationValueZ;
            Child25RotationValueW = baseline.Child25RotationValueW;
        }
        if ((changeMask1 & (1 << 22)) != 0)
        {
            Child25TranslationValueX = reader.ReadPackedIntDelta(baseline.Child25TranslationValueX, compressionModel);
            Child25TranslationValueY = reader.ReadPackedIntDelta(baseline.Child25TranslationValueY, compressionModel);
            Child25TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child25TranslationValueZ, compressionModel);
        }
        else
        {
            Child25TranslationValueX = baseline.Child25TranslationValueX;
            Child25TranslationValueY = baseline.Child25TranslationValueY;
            Child25TranslationValueZ = baseline.Child25TranslationValueZ;
        }
        if ((changeMask1 & (1 << 23)) != 0)
        {
            Child26RotationValueX = reader.ReadPackedIntDelta(baseline.Child26RotationValueX, compressionModel);
            Child26RotationValueY = reader.ReadPackedIntDelta(baseline.Child26RotationValueY, compressionModel);
            Child26RotationValueZ = reader.ReadPackedIntDelta(baseline.Child26RotationValueZ, compressionModel);
            Child26RotationValueW = reader.ReadPackedIntDelta(baseline.Child26RotationValueW, compressionModel);
        }
        else
        {
            Child26RotationValueX = baseline.Child26RotationValueX;
            Child26RotationValueY = baseline.Child26RotationValueY;
            Child26RotationValueZ = baseline.Child26RotationValueZ;
            Child26RotationValueW = baseline.Child26RotationValueW;
        }
        if ((changeMask1 & (1 << 24)) != 0)
        {
            Child26TranslationValueX = reader.ReadPackedIntDelta(baseline.Child26TranslationValueX, compressionModel);
            Child26TranslationValueY = reader.ReadPackedIntDelta(baseline.Child26TranslationValueY, compressionModel);
            Child26TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child26TranslationValueZ, compressionModel);
        }
        else
        {
            Child26TranslationValueX = baseline.Child26TranslationValueX;
            Child26TranslationValueY = baseline.Child26TranslationValueY;
            Child26TranslationValueZ = baseline.Child26TranslationValueZ;
        }
        if ((changeMask1 & (1 << 25)) != 0)
        {
            Child27RotationValueX = reader.ReadPackedIntDelta(baseline.Child27RotationValueX, compressionModel);
            Child27RotationValueY = reader.ReadPackedIntDelta(baseline.Child27RotationValueY, compressionModel);
            Child27RotationValueZ = reader.ReadPackedIntDelta(baseline.Child27RotationValueZ, compressionModel);
            Child27RotationValueW = reader.ReadPackedIntDelta(baseline.Child27RotationValueW, compressionModel);
        }
        else
        {
            Child27RotationValueX = baseline.Child27RotationValueX;
            Child27RotationValueY = baseline.Child27RotationValueY;
            Child27RotationValueZ = baseline.Child27RotationValueZ;
            Child27RotationValueW = baseline.Child27RotationValueW;
        }
        if ((changeMask1 & (1 << 26)) != 0)
        {
            Child27TranslationValueX = reader.ReadPackedIntDelta(baseline.Child27TranslationValueX, compressionModel);
            Child27TranslationValueY = reader.ReadPackedIntDelta(baseline.Child27TranslationValueY, compressionModel);
            Child27TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child27TranslationValueZ, compressionModel);
        }
        else
        {
            Child27TranslationValueX = baseline.Child27TranslationValueX;
            Child27TranslationValueY = baseline.Child27TranslationValueY;
            Child27TranslationValueZ = baseline.Child27TranslationValueZ;
        }
        if ((changeMask1 & (1 << 27)) != 0)
        {
            Child28RotationValueX = reader.ReadPackedIntDelta(baseline.Child28RotationValueX, compressionModel);
            Child28RotationValueY = reader.ReadPackedIntDelta(baseline.Child28RotationValueY, compressionModel);
            Child28RotationValueZ = reader.ReadPackedIntDelta(baseline.Child28RotationValueZ, compressionModel);
            Child28RotationValueW = reader.ReadPackedIntDelta(baseline.Child28RotationValueW, compressionModel);
        }
        else
        {
            Child28RotationValueX = baseline.Child28RotationValueX;
            Child28RotationValueY = baseline.Child28RotationValueY;
            Child28RotationValueZ = baseline.Child28RotationValueZ;
            Child28RotationValueW = baseline.Child28RotationValueW;
        }
        if ((changeMask1 & (1 << 28)) != 0)
        {
            Child28TranslationValueX = reader.ReadPackedIntDelta(baseline.Child28TranslationValueX, compressionModel);
            Child28TranslationValueY = reader.ReadPackedIntDelta(baseline.Child28TranslationValueY, compressionModel);
            Child28TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child28TranslationValueZ, compressionModel);
        }
        else
        {
            Child28TranslationValueX = baseline.Child28TranslationValueX;
            Child28TranslationValueY = baseline.Child28TranslationValueY;
            Child28TranslationValueZ = baseline.Child28TranslationValueZ;
        }
        if ((changeMask1 & (1 << 29)) != 0)
        {
            Child29RotationValueX = reader.ReadPackedIntDelta(baseline.Child29RotationValueX, compressionModel);
            Child29RotationValueY = reader.ReadPackedIntDelta(baseline.Child29RotationValueY, compressionModel);
            Child29RotationValueZ = reader.ReadPackedIntDelta(baseline.Child29RotationValueZ, compressionModel);
            Child29RotationValueW = reader.ReadPackedIntDelta(baseline.Child29RotationValueW, compressionModel);
        }
        else
        {
            Child29RotationValueX = baseline.Child29RotationValueX;
            Child29RotationValueY = baseline.Child29RotationValueY;
            Child29RotationValueZ = baseline.Child29RotationValueZ;
            Child29RotationValueW = baseline.Child29RotationValueW;
        }
        if ((changeMask1 & (1 << 30)) != 0)
        {
            Child29TranslationValueX = reader.ReadPackedIntDelta(baseline.Child29TranslationValueX, compressionModel);
            Child29TranslationValueY = reader.ReadPackedIntDelta(baseline.Child29TranslationValueY, compressionModel);
            Child29TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child29TranslationValueZ, compressionModel);
        }
        else
        {
            Child29TranslationValueX = baseline.Child29TranslationValueX;
            Child29TranslationValueY = baseline.Child29TranslationValueY;
            Child29TranslationValueZ = baseline.Child29TranslationValueZ;
        }
        if ((changeMask1 & (1 << 31)) != 0)
        {
            Child30RotationValueX = reader.ReadPackedIntDelta(baseline.Child30RotationValueX, compressionModel);
            Child30RotationValueY = reader.ReadPackedIntDelta(baseline.Child30RotationValueY, compressionModel);
            Child30RotationValueZ = reader.ReadPackedIntDelta(baseline.Child30RotationValueZ, compressionModel);
            Child30RotationValueW = reader.ReadPackedIntDelta(baseline.Child30RotationValueW, compressionModel);
        }
        else
        {
            Child30RotationValueX = baseline.Child30RotationValueX;
            Child30RotationValueY = baseline.Child30RotationValueY;
            Child30RotationValueZ = baseline.Child30RotationValueZ;
            Child30RotationValueW = baseline.Child30RotationValueW;
        }
        if ((changeMask2 & (1 << 0)) != 0)
        {
            Child30TranslationValueX = reader.ReadPackedIntDelta(baseline.Child30TranslationValueX, compressionModel);
            Child30TranslationValueY = reader.ReadPackedIntDelta(baseline.Child30TranslationValueY, compressionModel);
            Child30TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child30TranslationValueZ, compressionModel);
        }
        else
        {
            Child30TranslationValueX = baseline.Child30TranslationValueX;
            Child30TranslationValueY = baseline.Child30TranslationValueY;
            Child30TranslationValueZ = baseline.Child30TranslationValueZ;
        }
        if ((changeMask2 & (1 << 1)) != 0)
        {
            Child31RotationValueX = reader.ReadPackedIntDelta(baseline.Child31RotationValueX, compressionModel);
            Child31RotationValueY = reader.ReadPackedIntDelta(baseline.Child31RotationValueY, compressionModel);
            Child31RotationValueZ = reader.ReadPackedIntDelta(baseline.Child31RotationValueZ, compressionModel);
            Child31RotationValueW = reader.ReadPackedIntDelta(baseline.Child31RotationValueW, compressionModel);
        }
        else
        {
            Child31RotationValueX = baseline.Child31RotationValueX;
            Child31RotationValueY = baseline.Child31RotationValueY;
            Child31RotationValueZ = baseline.Child31RotationValueZ;
            Child31RotationValueW = baseline.Child31RotationValueW;
        }
        if ((changeMask2 & (1 << 2)) != 0)
        {
            Child31TranslationValueX = reader.ReadPackedIntDelta(baseline.Child31TranslationValueX, compressionModel);
            Child31TranslationValueY = reader.ReadPackedIntDelta(baseline.Child31TranslationValueY, compressionModel);
            Child31TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child31TranslationValueZ, compressionModel);
        }
        else
        {
            Child31TranslationValueX = baseline.Child31TranslationValueX;
            Child31TranslationValueY = baseline.Child31TranslationValueY;
            Child31TranslationValueZ = baseline.Child31TranslationValueZ;
        }
        if ((changeMask2 & (1 << 3)) != 0)
        {
            Child32RotationValueX = reader.ReadPackedIntDelta(baseline.Child32RotationValueX, compressionModel);
            Child32RotationValueY = reader.ReadPackedIntDelta(baseline.Child32RotationValueY, compressionModel);
            Child32RotationValueZ = reader.ReadPackedIntDelta(baseline.Child32RotationValueZ, compressionModel);
            Child32RotationValueW = reader.ReadPackedIntDelta(baseline.Child32RotationValueW, compressionModel);
        }
        else
        {
            Child32RotationValueX = baseline.Child32RotationValueX;
            Child32RotationValueY = baseline.Child32RotationValueY;
            Child32RotationValueZ = baseline.Child32RotationValueZ;
            Child32RotationValueW = baseline.Child32RotationValueW;
        }
        if ((changeMask2 & (1 << 4)) != 0)
        {
            Child32TranslationValueX = reader.ReadPackedIntDelta(baseline.Child32TranslationValueX, compressionModel);
            Child32TranslationValueY = reader.ReadPackedIntDelta(baseline.Child32TranslationValueY, compressionModel);
            Child32TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child32TranslationValueZ, compressionModel);
        }
        else
        {
            Child32TranslationValueX = baseline.Child32TranslationValueX;
            Child32TranslationValueY = baseline.Child32TranslationValueY;
            Child32TranslationValueZ = baseline.Child32TranslationValueZ;
        }
        if ((changeMask2 & (1 << 5)) != 0)
        {
            Child33RotationValueX = reader.ReadPackedIntDelta(baseline.Child33RotationValueX, compressionModel);
            Child33RotationValueY = reader.ReadPackedIntDelta(baseline.Child33RotationValueY, compressionModel);
            Child33RotationValueZ = reader.ReadPackedIntDelta(baseline.Child33RotationValueZ, compressionModel);
            Child33RotationValueW = reader.ReadPackedIntDelta(baseline.Child33RotationValueW, compressionModel);
        }
        else
        {
            Child33RotationValueX = baseline.Child33RotationValueX;
            Child33RotationValueY = baseline.Child33RotationValueY;
            Child33RotationValueZ = baseline.Child33RotationValueZ;
            Child33RotationValueW = baseline.Child33RotationValueW;
        }
        if ((changeMask2 & (1 << 6)) != 0)
        {
            Child33TranslationValueX = reader.ReadPackedIntDelta(baseline.Child33TranslationValueX, compressionModel);
            Child33TranslationValueY = reader.ReadPackedIntDelta(baseline.Child33TranslationValueY, compressionModel);
            Child33TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child33TranslationValueZ, compressionModel);
        }
        else
        {
            Child33TranslationValueX = baseline.Child33TranslationValueX;
            Child33TranslationValueY = baseline.Child33TranslationValueY;
            Child33TranslationValueZ = baseline.Child33TranslationValueZ;
        }
        if ((changeMask2 & (1 << 7)) != 0)
        {
            Child34RotationValueX = reader.ReadPackedIntDelta(baseline.Child34RotationValueX, compressionModel);
            Child34RotationValueY = reader.ReadPackedIntDelta(baseline.Child34RotationValueY, compressionModel);
            Child34RotationValueZ = reader.ReadPackedIntDelta(baseline.Child34RotationValueZ, compressionModel);
            Child34RotationValueW = reader.ReadPackedIntDelta(baseline.Child34RotationValueW, compressionModel);
        }
        else
        {
            Child34RotationValueX = baseline.Child34RotationValueX;
            Child34RotationValueY = baseline.Child34RotationValueY;
            Child34RotationValueZ = baseline.Child34RotationValueZ;
            Child34RotationValueW = baseline.Child34RotationValueW;
        }
        if ((changeMask2 & (1 << 8)) != 0)
        {
            Child34TranslationValueX = reader.ReadPackedIntDelta(baseline.Child34TranslationValueX, compressionModel);
            Child34TranslationValueY = reader.ReadPackedIntDelta(baseline.Child34TranslationValueY, compressionModel);
            Child34TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child34TranslationValueZ, compressionModel);
        }
        else
        {
            Child34TranslationValueX = baseline.Child34TranslationValueX;
            Child34TranslationValueY = baseline.Child34TranslationValueY;
            Child34TranslationValueZ = baseline.Child34TranslationValueZ;
        }
        if ((changeMask2 & (1 << 9)) != 0)
        {
            Child35RotationValueX = reader.ReadPackedIntDelta(baseline.Child35RotationValueX, compressionModel);
            Child35RotationValueY = reader.ReadPackedIntDelta(baseline.Child35RotationValueY, compressionModel);
            Child35RotationValueZ = reader.ReadPackedIntDelta(baseline.Child35RotationValueZ, compressionModel);
            Child35RotationValueW = reader.ReadPackedIntDelta(baseline.Child35RotationValueW, compressionModel);
        }
        else
        {
            Child35RotationValueX = baseline.Child35RotationValueX;
            Child35RotationValueY = baseline.Child35RotationValueY;
            Child35RotationValueZ = baseline.Child35RotationValueZ;
            Child35RotationValueW = baseline.Child35RotationValueW;
        }
        if ((changeMask2 & (1 << 10)) != 0)
        {
            Child35TranslationValueX = reader.ReadPackedIntDelta(baseline.Child35TranslationValueX, compressionModel);
            Child35TranslationValueY = reader.ReadPackedIntDelta(baseline.Child35TranslationValueY, compressionModel);
            Child35TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child35TranslationValueZ, compressionModel);
        }
        else
        {
            Child35TranslationValueX = baseline.Child35TranslationValueX;
            Child35TranslationValueY = baseline.Child35TranslationValueY;
            Child35TranslationValueZ = baseline.Child35TranslationValueZ;
        }
        if ((changeMask2 & (1 << 11)) != 0)
        {
            Child36RotationValueX = reader.ReadPackedIntDelta(baseline.Child36RotationValueX, compressionModel);
            Child36RotationValueY = reader.ReadPackedIntDelta(baseline.Child36RotationValueY, compressionModel);
            Child36RotationValueZ = reader.ReadPackedIntDelta(baseline.Child36RotationValueZ, compressionModel);
            Child36RotationValueW = reader.ReadPackedIntDelta(baseline.Child36RotationValueW, compressionModel);
        }
        else
        {
            Child36RotationValueX = baseline.Child36RotationValueX;
            Child36RotationValueY = baseline.Child36RotationValueY;
            Child36RotationValueZ = baseline.Child36RotationValueZ;
            Child36RotationValueW = baseline.Child36RotationValueW;
        }
        if ((changeMask2 & (1 << 12)) != 0)
        {
            Child36TranslationValueX = reader.ReadPackedIntDelta(baseline.Child36TranslationValueX, compressionModel);
            Child36TranslationValueY = reader.ReadPackedIntDelta(baseline.Child36TranslationValueY, compressionModel);
            Child36TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child36TranslationValueZ, compressionModel);
        }
        else
        {
            Child36TranslationValueX = baseline.Child36TranslationValueX;
            Child36TranslationValueY = baseline.Child36TranslationValueY;
            Child36TranslationValueZ = baseline.Child36TranslationValueZ;
        }
        if ((changeMask2 & (1 << 13)) != 0)
        {
            Child37RotationValueX = reader.ReadPackedIntDelta(baseline.Child37RotationValueX, compressionModel);
            Child37RotationValueY = reader.ReadPackedIntDelta(baseline.Child37RotationValueY, compressionModel);
            Child37RotationValueZ = reader.ReadPackedIntDelta(baseline.Child37RotationValueZ, compressionModel);
            Child37RotationValueW = reader.ReadPackedIntDelta(baseline.Child37RotationValueW, compressionModel);
        }
        else
        {
            Child37RotationValueX = baseline.Child37RotationValueX;
            Child37RotationValueY = baseline.Child37RotationValueY;
            Child37RotationValueZ = baseline.Child37RotationValueZ;
            Child37RotationValueW = baseline.Child37RotationValueW;
        }
        if ((changeMask2 & (1 << 14)) != 0)
        {
            Child37TranslationValueX = reader.ReadPackedIntDelta(baseline.Child37TranslationValueX, compressionModel);
            Child37TranslationValueY = reader.ReadPackedIntDelta(baseline.Child37TranslationValueY, compressionModel);
            Child37TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child37TranslationValueZ, compressionModel);
        }
        else
        {
            Child37TranslationValueX = baseline.Child37TranslationValueX;
            Child37TranslationValueY = baseline.Child37TranslationValueY;
            Child37TranslationValueZ = baseline.Child37TranslationValueZ;
        }
        if ((changeMask2 & (1 << 15)) != 0)
        {
            Child38RotationValueX = reader.ReadPackedIntDelta(baseline.Child38RotationValueX, compressionModel);
            Child38RotationValueY = reader.ReadPackedIntDelta(baseline.Child38RotationValueY, compressionModel);
            Child38RotationValueZ = reader.ReadPackedIntDelta(baseline.Child38RotationValueZ, compressionModel);
            Child38RotationValueW = reader.ReadPackedIntDelta(baseline.Child38RotationValueW, compressionModel);
        }
        else
        {
            Child38RotationValueX = baseline.Child38RotationValueX;
            Child38RotationValueY = baseline.Child38RotationValueY;
            Child38RotationValueZ = baseline.Child38RotationValueZ;
            Child38RotationValueW = baseline.Child38RotationValueW;
        }
        if ((changeMask2 & (1 << 16)) != 0)
        {
            Child38TranslationValueX = reader.ReadPackedIntDelta(baseline.Child38TranslationValueX, compressionModel);
            Child38TranslationValueY = reader.ReadPackedIntDelta(baseline.Child38TranslationValueY, compressionModel);
            Child38TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child38TranslationValueZ, compressionModel);
        }
        else
        {
            Child38TranslationValueX = baseline.Child38TranslationValueX;
            Child38TranslationValueY = baseline.Child38TranslationValueY;
            Child38TranslationValueZ = baseline.Child38TranslationValueZ;
        }
        if ((changeMask2 & (1 << 17)) != 0)
        {
            Child39RotationValueX = reader.ReadPackedIntDelta(baseline.Child39RotationValueX, compressionModel);
            Child39RotationValueY = reader.ReadPackedIntDelta(baseline.Child39RotationValueY, compressionModel);
            Child39RotationValueZ = reader.ReadPackedIntDelta(baseline.Child39RotationValueZ, compressionModel);
            Child39RotationValueW = reader.ReadPackedIntDelta(baseline.Child39RotationValueW, compressionModel);
        }
        else
        {
            Child39RotationValueX = baseline.Child39RotationValueX;
            Child39RotationValueY = baseline.Child39RotationValueY;
            Child39RotationValueZ = baseline.Child39RotationValueZ;
            Child39RotationValueW = baseline.Child39RotationValueW;
        }
        if ((changeMask2 & (1 << 18)) != 0)
        {
            Child39TranslationValueX = reader.ReadPackedIntDelta(baseline.Child39TranslationValueX, compressionModel);
            Child39TranslationValueY = reader.ReadPackedIntDelta(baseline.Child39TranslationValueY, compressionModel);
            Child39TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child39TranslationValueZ, compressionModel);
        }
        else
        {
            Child39TranslationValueX = baseline.Child39TranslationValueX;
            Child39TranslationValueY = baseline.Child39TranslationValueY;
            Child39TranslationValueZ = baseline.Child39TranslationValueZ;
        }
        if ((changeMask2 & (1 << 19)) != 0)
        {
            Child40RotationValueX = reader.ReadPackedIntDelta(baseline.Child40RotationValueX, compressionModel);
            Child40RotationValueY = reader.ReadPackedIntDelta(baseline.Child40RotationValueY, compressionModel);
            Child40RotationValueZ = reader.ReadPackedIntDelta(baseline.Child40RotationValueZ, compressionModel);
            Child40RotationValueW = reader.ReadPackedIntDelta(baseline.Child40RotationValueW, compressionModel);
        }
        else
        {
            Child40RotationValueX = baseline.Child40RotationValueX;
            Child40RotationValueY = baseline.Child40RotationValueY;
            Child40RotationValueZ = baseline.Child40RotationValueZ;
            Child40RotationValueW = baseline.Child40RotationValueW;
        }
        if ((changeMask2 & (1 << 20)) != 0)
        {
            Child40TranslationValueX = reader.ReadPackedIntDelta(baseline.Child40TranslationValueX, compressionModel);
            Child40TranslationValueY = reader.ReadPackedIntDelta(baseline.Child40TranslationValueY, compressionModel);
            Child40TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child40TranslationValueZ, compressionModel);
        }
        else
        {
            Child40TranslationValueX = baseline.Child40TranslationValueX;
            Child40TranslationValueY = baseline.Child40TranslationValueY;
            Child40TranslationValueZ = baseline.Child40TranslationValueZ;
        }
        if ((changeMask2 & (1 << 21)) != 0)
        {
            Child41RotationValueX = reader.ReadPackedIntDelta(baseline.Child41RotationValueX, compressionModel);
            Child41RotationValueY = reader.ReadPackedIntDelta(baseline.Child41RotationValueY, compressionModel);
            Child41RotationValueZ = reader.ReadPackedIntDelta(baseline.Child41RotationValueZ, compressionModel);
            Child41RotationValueW = reader.ReadPackedIntDelta(baseline.Child41RotationValueW, compressionModel);
        }
        else
        {
            Child41RotationValueX = baseline.Child41RotationValueX;
            Child41RotationValueY = baseline.Child41RotationValueY;
            Child41RotationValueZ = baseline.Child41RotationValueZ;
            Child41RotationValueW = baseline.Child41RotationValueW;
        }
        if ((changeMask2 & (1 << 22)) != 0)
        {
            Child41TranslationValueX = reader.ReadPackedIntDelta(baseline.Child41TranslationValueX, compressionModel);
            Child41TranslationValueY = reader.ReadPackedIntDelta(baseline.Child41TranslationValueY, compressionModel);
            Child41TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child41TranslationValueZ, compressionModel);
        }
        else
        {
            Child41TranslationValueX = baseline.Child41TranslationValueX;
            Child41TranslationValueY = baseline.Child41TranslationValueY;
            Child41TranslationValueZ = baseline.Child41TranslationValueZ;
        }
        if ((changeMask2 & (1 << 23)) != 0)
        {
            Child42RotationValueX = reader.ReadPackedIntDelta(baseline.Child42RotationValueX, compressionModel);
            Child42RotationValueY = reader.ReadPackedIntDelta(baseline.Child42RotationValueY, compressionModel);
            Child42RotationValueZ = reader.ReadPackedIntDelta(baseline.Child42RotationValueZ, compressionModel);
            Child42RotationValueW = reader.ReadPackedIntDelta(baseline.Child42RotationValueW, compressionModel);
        }
        else
        {
            Child42RotationValueX = baseline.Child42RotationValueX;
            Child42RotationValueY = baseline.Child42RotationValueY;
            Child42RotationValueZ = baseline.Child42RotationValueZ;
            Child42RotationValueW = baseline.Child42RotationValueW;
        }
        if ((changeMask2 & (1 << 24)) != 0)
        {
            Child42TranslationValueX = reader.ReadPackedIntDelta(baseline.Child42TranslationValueX, compressionModel);
            Child42TranslationValueY = reader.ReadPackedIntDelta(baseline.Child42TranslationValueY, compressionModel);
            Child42TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child42TranslationValueZ, compressionModel);
        }
        else
        {
            Child42TranslationValueX = baseline.Child42TranslationValueX;
            Child42TranslationValueY = baseline.Child42TranslationValueY;
            Child42TranslationValueZ = baseline.Child42TranslationValueZ;
        }
        if ((changeMask2 & (1 << 25)) != 0)
        {
            Child43RotationValueX = reader.ReadPackedIntDelta(baseline.Child43RotationValueX, compressionModel);
            Child43RotationValueY = reader.ReadPackedIntDelta(baseline.Child43RotationValueY, compressionModel);
            Child43RotationValueZ = reader.ReadPackedIntDelta(baseline.Child43RotationValueZ, compressionModel);
            Child43RotationValueW = reader.ReadPackedIntDelta(baseline.Child43RotationValueW, compressionModel);
        }
        else
        {
            Child43RotationValueX = baseline.Child43RotationValueX;
            Child43RotationValueY = baseline.Child43RotationValueY;
            Child43RotationValueZ = baseline.Child43RotationValueZ;
            Child43RotationValueW = baseline.Child43RotationValueW;
        }
        if ((changeMask2 & (1 << 26)) != 0)
        {
            Child43TranslationValueX = reader.ReadPackedIntDelta(baseline.Child43TranslationValueX, compressionModel);
            Child43TranslationValueY = reader.ReadPackedIntDelta(baseline.Child43TranslationValueY, compressionModel);
            Child43TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child43TranslationValueZ, compressionModel);
        }
        else
        {
            Child43TranslationValueX = baseline.Child43TranslationValueX;
            Child43TranslationValueY = baseline.Child43TranslationValueY;
            Child43TranslationValueZ = baseline.Child43TranslationValueZ;
        }
        if ((changeMask2 & (1 << 27)) != 0)
        {
            Child44RotationValueX = reader.ReadPackedIntDelta(baseline.Child44RotationValueX, compressionModel);
            Child44RotationValueY = reader.ReadPackedIntDelta(baseline.Child44RotationValueY, compressionModel);
            Child44RotationValueZ = reader.ReadPackedIntDelta(baseline.Child44RotationValueZ, compressionModel);
            Child44RotationValueW = reader.ReadPackedIntDelta(baseline.Child44RotationValueW, compressionModel);
        }
        else
        {
            Child44RotationValueX = baseline.Child44RotationValueX;
            Child44RotationValueY = baseline.Child44RotationValueY;
            Child44RotationValueZ = baseline.Child44RotationValueZ;
            Child44RotationValueW = baseline.Child44RotationValueW;
        }
        if ((changeMask2 & (1 << 28)) != 0)
        {
            Child44TranslationValueX = reader.ReadPackedIntDelta(baseline.Child44TranslationValueX, compressionModel);
            Child44TranslationValueY = reader.ReadPackedIntDelta(baseline.Child44TranslationValueY, compressionModel);
            Child44TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child44TranslationValueZ, compressionModel);
        }
        else
        {
            Child44TranslationValueX = baseline.Child44TranslationValueX;
            Child44TranslationValueY = baseline.Child44TranslationValueY;
            Child44TranslationValueZ = baseline.Child44TranslationValueZ;
        }
        if ((changeMask2 & (1 << 29)) != 0)
        {
            Child45RotationValueX = reader.ReadPackedIntDelta(baseline.Child45RotationValueX, compressionModel);
            Child45RotationValueY = reader.ReadPackedIntDelta(baseline.Child45RotationValueY, compressionModel);
            Child45RotationValueZ = reader.ReadPackedIntDelta(baseline.Child45RotationValueZ, compressionModel);
            Child45RotationValueW = reader.ReadPackedIntDelta(baseline.Child45RotationValueW, compressionModel);
        }
        else
        {
            Child45RotationValueX = baseline.Child45RotationValueX;
            Child45RotationValueY = baseline.Child45RotationValueY;
            Child45RotationValueZ = baseline.Child45RotationValueZ;
            Child45RotationValueW = baseline.Child45RotationValueW;
        }
        if ((changeMask2 & (1 << 30)) != 0)
        {
            Child45TranslationValueX = reader.ReadPackedIntDelta(baseline.Child45TranslationValueX, compressionModel);
            Child45TranslationValueY = reader.ReadPackedIntDelta(baseline.Child45TranslationValueY, compressionModel);
            Child45TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child45TranslationValueZ, compressionModel);
        }
        else
        {
            Child45TranslationValueX = baseline.Child45TranslationValueX;
            Child45TranslationValueY = baseline.Child45TranslationValueY;
            Child45TranslationValueZ = baseline.Child45TranslationValueZ;
        }
        if ((changeMask2 & (1 << 31)) != 0)
        {
            Child46RotationValueX = reader.ReadPackedIntDelta(baseline.Child46RotationValueX, compressionModel);
            Child46RotationValueY = reader.ReadPackedIntDelta(baseline.Child46RotationValueY, compressionModel);
            Child46RotationValueZ = reader.ReadPackedIntDelta(baseline.Child46RotationValueZ, compressionModel);
            Child46RotationValueW = reader.ReadPackedIntDelta(baseline.Child46RotationValueW, compressionModel);
        }
        else
        {
            Child46RotationValueX = baseline.Child46RotationValueX;
            Child46RotationValueY = baseline.Child46RotationValueY;
            Child46RotationValueZ = baseline.Child46RotationValueZ;
            Child46RotationValueW = baseline.Child46RotationValueW;
        }
        if ((changeMask3 & (1 << 0)) != 0)
        {
            Child46TranslationValueX = reader.ReadPackedIntDelta(baseline.Child46TranslationValueX, compressionModel);
            Child46TranslationValueY = reader.ReadPackedIntDelta(baseline.Child46TranslationValueY, compressionModel);
            Child46TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child46TranslationValueZ, compressionModel);
        }
        else
        {
            Child46TranslationValueX = baseline.Child46TranslationValueX;
            Child46TranslationValueY = baseline.Child46TranslationValueY;
            Child46TranslationValueZ = baseline.Child46TranslationValueZ;
        }
        if ((changeMask3 & (1 << 1)) != 0)
        {
            Child47RotationValueX = reader.ReadPackedIntDelta(baseline.Child47RotationValueX, compressionModel);
            Child47RotationValueY = reader.ReadPackedIntDelta(baseline.Child47RotationValueY, compressionModel);
            Child47RotationValueZ = reader.ReadPackedIntDelta(baseline.Child47RotationValueZ, compressionModel);
            Child47RotationValueW = reader.ReadPackedIntDelta(baseline.Child47RotationValueW, compressionModel);
        }
        else
        {
            Child47RotationValueX = baseline.Child47RotationValueX;
            Child47RotationValueY = baseline.Child47RotationValueY;
            Child47RotationValueZ = baseline.Child47RotationValueZ;
            Child47RotationValueW = baseline.Child47RotationValueW;
        }
        if ((changeMask3 & (1 << 2)) != 0)
        {
            Child47TranslationValueX = reader.ReadPackedIntDelta(baseline.Child47TranslationValueX, compressionModel);
            Child47TranslationValueY = reader.ReadPackedIntDelta(baseline.Child47TranslationValueY, compressionModel);
            Child47TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child47TranslationValueZ, compressionModel);
        }
        else
        {
            Child47TranslationValueX = baseline.Child47TranslationValueX;
            Child47TranslationValueY = baseline.Child47TranslationValueY;
            Child47TranslationValueZ = baseline.Child47TranslationValueZ;
        }
        if ((changeMask3 & (1 << 3)) != 0)
        {
            Child48RotationValueX = reader.ReadPackedIntDelta(baseline.Child48RotationValueX, compressionModel);
            Child48RotationValueY = reader.ReadPackedIntDelta(baseline.Child48RotationValueY, compressionModel);
            Child48RotationValueZ = reader.ReadPackedIntDelta(baseline.Child48RotationValueZ, compressionModel);
            Child48RotationValueW = reader.ReadPackedIntDelta(baseline.Child48RotationValueW, compressionModel);
        }
        else
        {
            Child48RotationValueX = baseline.Child48RotationValueX;
            Child48RotationValueY = baseline.Child48RotationValueY;
            Child48RotationValueZ = baseline.Child48RotationValueZ;
            Child48RotationValueW = baseline.Child48RotationValueW;
        }
        if ((changeMask3 & (1 << 4)) != 0)
        {
            Child48TranslationValueX = reader.ReadPackedIntDelta(baseline.Child48TranslationValueX, compressionModel);
            Child48TranslationValueY = reader.ReadPackedIntDelta(baseline.Child48TranslationValueY, compressionModel);
            Child48TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child48TranslationValueZ, compressionModel);
        }
        else
        {
            Child48TranslationValueX = baseline.Child48TranslationValueX;
            Child48TranslationValueY = baseline.Child48TranslationValueY;
            Child48TranslationValueZ = baseline.Child48TranslationValueZ;
        }
        if ((changeMask3 & (1 << 5)) != 0)
        {
            Child49RotationValueX = reader.ReadPackedIntDelta(baseline.Child49RotationValueX, compressionModel);
            Child49RotationValueY = reader.ReadPackedIntDelta(baseline.Child49RotationValueY, compressionModel);
            Child49RotationValueZ = reader.ReadPackedIntDelta(baseline.Child49RotationValueZ, compressionModel);
            Child49RotationValueW = reader.ReadPackedIntDelta(baseline.Child49RotationValueW, compressionModel);
        }
        else
        {
            Child49RotationValueX = baseline.Child49RotationValueX;
            Child49RotationValueY = baseline.Child49RotationValueY;
            Child49RotationValueZ = baseline.Child49RotationValueZ;
            Child49RotationValueW = baseline.Child49RotationValueW;
        }
        if ((changeMask3 & (1 << 6)) != 0)
        {
            Child49TranslationValueX = reader.ReadPackedIntDelta(baseline.Child49TranslationValueX, compressionModel);
            Child49TranslationValueY = reader.ReadPackedIntDelta(baseline.Child49TranslationValueY, compressionModel);
            Child49TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child49TranslationValueZ, compressionModel);
        }
        else
        {
            Child49TranslationValueX = baseline.Child49TranslationValueX;
            Child49TranslationValueY = baseline.Child49TranslationValueY;
            Child49TranslationValueZ = baseline.Child49TranslationValueZ;
        }
        if ((changeMask3 & (1 << 7)) != 0)
        {
            Child50RotationValueX = reader.ReadPackedIntDelta(baseline.Child50RotationValueX, compressionModel);
            Child50RotationValueY = reader.ReadPackedIntDelta(baseline.Child50RotationValueY, compressionModel);
            Child50RotationValueZ = reader.ReadPackedIntDelta(baseline.Child50RotationValueZ, compressionModel);
            Child50RotationValueW = reader.ReadPackedIntDelta(baseline.Child50RotationValueW, compressionModel);
        }
        else
        {
            Child50RotationValueX = baseline.Child50RotationValueX;
            Child50RotationValueY = baseline.Child50RotationValueY;
            Child50RotationValueZ = baseline.Child50RotationValueZ;
            Child50RotationValueW = baseline.Child50RotationValueW;
        }
        if ((changeMask3 & (1 << 8)) != 0)
        {
            Child50TranslationValueX = reader.ReadPackedIntDelta(baseline.Child50TranslationValueX, compressionModel);
            Child50TranslationValueY = reader.ReadPackedIntDelta(baseline.Child50TranslationValueY, compressionModel);
            Child50TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child50TranslationValueZ, compressionModel);
        }
        else
        {
            Child50TranslationValueX = baseline.Child50TranslationValueX;
            Child50TranslationValueY = baseline.Child50TranslationValueY;
            Child50TranslationValueZ = baseline.Child50TranslationValueZ;
        }
        if ((changeMask3 & (1 << 9)) != 0)
        {
            Child51RotationValueX = reader.ReadPackedIntDelta(baseline.Child51RotationValueX, compressionModel);
            Child51RotationValueY = reader.ReadPackedIntDelta(baseline.Child51RotationValueY, compressionModel);
            Child51RotationValueZ = reader.ReadPackedIntDelta(baseline.Child51RotationValueZ, compressionModel);
            Child51RotationValueW = reader.ReadPackedIntDelta(baseline.Child51RotationValueW, compressionModel);
        }
        else
        {
            Child51RotationValueX = baseline.Child51RotationValueX;
            Child51RotationValueY = baseline.Child51RotationValueY;
            Child51RotationValueZ = baseline.Child51RotationValueZ;
            Child51RotationValueW = baseline.Child51RotationValueW;
        }
        if ((changeMask3 & (1 << 10)) != 0)
        {
            Child51TranslationValueX = reader.ReadPackedIntDelta(baseline.Child51TranslationValueX, compressionModel);
            Child51TranslationValueY = reader.ReadPackedIntDelta(baseline.Child51TranslationValueY, compressionModel);
            Child51TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child51TranslationValueZ, compressionModel);
        }
        else
        {
            Child51TranslationValueX = baseline.Child51TranslationValueX;
            Child51TranslationValueY = baseline.Child51TranslationValueY;
            Child51TranslationValueZ = baseline.Child51TranslationValueZ;
        }
        if ((changeMask3 & (1 << 11)) != 0)
        {
            Child52RotationValueX = reader.ReadPackedIntDelta(baseline.Child52RotationValueX, compressionModel);
            Child52RotationValueY = reader.ReadPackedIntDelta(baseline.Child52RotationValueY, compressionModel);
            Child52RotationValueZ = reader.ReadPackedIntDelta(baseline.Child52RotationValueZ, compressionModel);
            Child52RotationValueW = reader.ReadPackedIntDelta(baseline.Child52RotationValueW, compressionModel);
        }
        else
        {
            Child52RotationValueX = baseline.Child52RotationValueX;
            Child52RotationValueY = baseline.Child52RotationValueY;
            Child52RotationValueZ = baseline.Child52RotationValueZ;
            Child52RotationValueW = baseline.Child52RotationValueW;
        }
        if ((changeMask3 & (1 << 12)) != 0)
        {
            Child52TranslationValueX = reader.ReadPackedIntDelta(baseline.Child52TranslationValueX, compressionModel);
            Child52TranslationValueY = reader.ReadPackedIntDelta(baseline.Child52TranslationValueY, compressionModel);
            Child52TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child52TranslationValueZ, compressionModel);
        }
        else
        {
            Child52TranslationValueX = baseline.Child52TranslationValueX;
            Child52TranslationValueY = baseline.Child52TranslationValueY;
            Child52TranslationValueZ = baseline.Child52TranslationValueZ;
        }
        if ((changeMask3 & (1 << 13)) != 0)
        {
            Child53RotationValueX = reader.ReadPackedIntDelta(baseline.Child53RotationValueX, compressionModel);
            Child53RotationValueY = reader.ReadPackedIntDelta(baseline.Child53RotationValueY, compressionModel);
            Child53RotationValueZ = reader.ReadPackedIntDelta(baseline.Child53RotationValueZ, compressionModel);
            Child53RotationValueW = reader.ReadPackedIntDelta(baseline.Child53RotationValueW, compressionModel);
        }
        else
        {
            Child53RotationValueX = baseline.Child53RotationValueX;
            Child53RotationValueY = baseline.Child53RotationValueY;
            Child53RotationValueZ = baseline.Child53RotationValueZ;
            Child53RotationValueW = baseline.Child53RotationValueW;
        }
        if ((changeMask3 & (1 << 14)) != 0)
        {
            Child53TranslationValueX = reader.ReadPackedIntDelta(baseline.Child53TranslationValueX, compressionModel);
            Child53TranslationValueY = reader.ReadPackedIntDelta(baseline.Child53TranslationValueY, compressionModel);
            Child53TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child53TranslationValueZ, compressionModel);
        }
        else
        {
            Child53TranslationValueX = baseline.Child53TranslationValueX;
            Child53TranslationValueY = baseline.Child53TranslationValueY;
            Child53TranslationValueZ = baseline.Child53TranslationValueZ;
        }
        if ((changeMask3 & (1 << 15)) != 0)
        {
            Child54RotationValueX = reader.ReadPackedIntDelta(baseline.Child54RotationValueX, compressionModel);
            Child54RotationValueY = reader.ReadPackedIntDelta(baseline.Child54RotationValueY, compressionModel);
            Child54RotationValueZ = reader.ReadPackedIntDelta(baseline.Child54RotationValueZ, compressionModel);
            Child54RotationValueW = reader.ReadPackedIntDelta(baseline.Child54RotationValueW, compressionModel);
        }
        else
        {
            Child54RotationValueX = baseline.Child54RotationValueX;
            Child54RotationValueY = baseline.Child54RotationValueY;
            Child54RotationValueZ = baseline.Child54RotationValueZ;
            Child54RotationValueW = baseline.Child54RotationValueW;
        }
        if ((changeMask3 & (1 << 16)) != 0)
        {
            Child54TranslationValueX = reader.ReadPackedIntDelta(baseline.Child54TranslationValueX, compressionModel);
            Child54TranslationValueY = reader.ReadPackedIntDelta(baseline.Child54TranslationValueY, compressionModel);
            Child54TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child54TranslationValueZ, compressionModel);
        }
        else
        {
            Child54TranslationValueX = baseline.Child54TranslationValueX;
            Child54TranslationValueY = baseline.Child54TranslationValueY;
            Child54TranslationValueZ = baseline.Child54TranslationValueZ;
        }
        if ((changeMask3 & (1 << 17)) != 0)
        {
            Child55RotationValueX = reader.ReadPackedIntDelta(baseline.Child55RotationValueX, compressionModel);
            Child55RotationValueY = reader.ReadPackedIntDelta(baseline.Child55RotationValueY, compressionModel);
            Child55RotationValueZ = reader.ReadPackedIntDelta(baseline.Child55RotationValueZ, compressionModel);
            Child55RotationValueW = reader.ReadPackedIntDelta(baseline.Child55RotationValueW, compressionModel);
        }
        else
        {
            Child55RotationValueX = baseline.Child55RotationValueX;
            Child55RotationValueY = baseline.Child55RotationValueY;
            Child55RotationValueZ = baseline.Child55RotationValueZ;
            Child55RotationValueW = baseline.Child55RotationValueW;
        }
        if ((changeMask3 & (1 << 18)) != 0)
        {
            Child55TranslationValueX = reader.ReadPackedIntDelta(baseline.Child55TranslationValueX, compressionModel);
            Child55TranslationValueY = reader.ReadPackedIntDelta(baseline.Child55TranslationValueY, compressionModel);
            Child55TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child55TranslationValueZ, compressionModel);
        }
        else
        {
            Child55TranslationValueX = baseline.Child55TranslationValueX;
            Child55TranslationValueY = baseline.Child55TranslationValueY;
            Child55TranslationValueZ = baseline.Child55TranslationValueZ;
        }
        if ((changeMask3 & (1 << 19)) != 0)
        {
            Child56RotationValueX = reader.ReadPackedIntDelta(baseline.Child56RotationValueX, compressionModel);
            Child56RotationValueY = reader.ReadPackedIntDelta(baseline.Child56RotationValueY, compressionModel);
            Child56RotationValueZ = reader.ReadPackedIntDelta(baseline.Child56RotationValueZ, compressionModel);
            Child56RotationValueW = reader.ReadPackedIntDelta(baseline.Child56RotationValueW, compressionModel);
        }
        else
        {
            Child56RotationValueX = baseline.Child56RotationValueX;
            Child56RotationValueY = baseline.Child56RotationValueY;
            Child56RotationValueZ = baseline.Child56RotationValueZ;
            Child56RotationValueW = baseline.Child56RotationValueW;
        }
        if ((changeMask3 & (1 << 20)) != 0)
        {
            Child56TranslationValueX = reader.ReadPackedIntDelta(baseline.Child56TranslationValueX, compressionModel);
            Child56TranslationValueY = reader.ReadPackedIntDelta(baseline.Child56TranslationValueY, compressionModel);
            Child56TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child56TranslationValueZ, compressionModel);
        }
        else
        {
            Child56TranslationValueX = baseline.Child56TranslationValueX;
            Child56TranslationValueY = baseline.Child56TranslationValueY;
            Child56TranslationValueZ = baseline.Child56TranslationValueZ;
        }
        if ((changeMask3 & (1 << 21)) != 0)
        {
            Child57RotationValueX = reader.ReadPackedIntDelta(baseline.Child57RotationValueX, compressionModel);
            Child57RotationValueY = reader.ReadPackedIntDelta(baseline.Child57RotationValueY, compressionModel);
            Child57RotationValueZ = reader.ReadPackedIntDelta(baseline.Child57RotationValueZ, compressionModel);
            Child57RotationValueW = reader.ReadPackedIntDelta(baseline.Child57RotationValueW, compressionModel);
        }
        else
        {
            Child57RotationValueX = baseline.Child57RotationValueX;
            Child57RotationValueY = baseline.Child57RotationValueY;
            Child57RotationValueZ = baseline.Child57RotationValueZ;
            Child57RotationValueW = baseline.Child57RotationValueW;
        }
        if ((changeMask3 & (1 << 22)) != 0)
        {
            Child57TranslationValueX = reader.ReadPackedIntDelta(baseline.Child57TranslationValueX, compressionModel);
            Child57TranslationValueY = reader.ReadPackedIntDelta(baseline.Child57TranslationValueY, compressionModel);
            Child57TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child57TranslationValueZ, compressionModel);
        }
        else
        {
            Child57TranslationValueX = baseline.Child57TranslationValueX;
            Child57TranslationValueY = baseline.Child57TranslationValueY;
            Child57TranslationValueZ = baseline.Child57TranslationValueZ;
        }
        if ((changeMask3 & (1 << 23)) != 0)
        {
            Child58RotationValueX = reader.ReadPackedIntDelta(baseline.Child58RotationValueX, compressionModel);
            Child58RotationValueY = reader.ReadPackedIntDelta(baseline.Child58RotationValueY, compressionModel);
            Child58RotationValueZ = reader.ReadPackedIntDelta(baseline.Child58RotationValueZ, compressionModel);
            Child58RotationValueW = reader.ReadPackedIntDelta(baseline.Child58RotationValueW, compressionModel);
        }
        else
        {
            Child58RotationValueX = baseline.Child58RotationValueX;
            Child58RotationValueY = baseline.Child58RotationValueY;
            Child58RotationValueZ = baseline.Child58RotationValueZ;
            Child58RotationValueW = baseline.Child58RotationValueW;
        }
        if ((changeMask3 & (1 << 24)) != 0)
        {
            Child58TranslationValueX = reader.ReadPackedIntDelta(baseline.Child58TranslationValueX, compressionModel);
            Child58TranslationValueY = reader.ReadPackedIntDelta(baseline.Child58TranslationValueY, compressionModel);
            Child58TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child58TranslationValueZ, compressionModel);
        }
        else
        {
            Child58TranslationValueX = baseline.Child58TranslationValueX;
            Child58TranslationValueY = baseline.Child58TranslationValueY;
            Child58TranslationValueZ = baseline.Child58TranslationValueZ;
        }
        if ((changeMask3 & (1 << 25)) != 0)
        {
            Child59RotationValueX = reader.ReadPackedIntDelta(baseline.Child59RotationValueX, compressionModel);
            Child59RotationValueY = reader.ReadPackedIntDelta(baseline.Child59RotationValueY, compressionModel);
            Child59RotationValueZ = reader.ReadPackedIntDelta(baseline.Child59RotationValueZ, compressionModel);
            Child59RotationValueW = reader.ReadPackedIntDelta(baseline.Child59RotationValueW, compressionModel);
        }
        else
        {
            Child59RotationValueX = baseline.Child59RotationValueX;
            Child59RotationValueY = baseline.Child59RotationValueY;
            Child59RotationValueZ = baseline.Child59RotationValueZ;
            Child59RotationValueW = baseline.Child59RotationValueW;
        }
        if ((changeMask3 & (1 << 26)) != 0)
        {
            Child59TranslationValueX = reader.ReadPackedIntDelta(baseline.Child59TranslationValueX, compressionModel);
            Child59TranslationValueY = reader.ReadPackedIntDelta(baseline.Child59TranslationValueY, compressionModel);
            Child59TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child59TranslationValueZ, compressionModel);
        }
        else
        {
            Child59TranslationValueX = baseline.Child59TranslationValueX;
            Child59TranslationValueY = baseline.Child59TranslationValueY;
            Child59TranslationValueZ = baseline.Child59TranslationValueZ;
        }
        if ((changeMask3 & (1 << 27)) != 0)
        {
            Child60RotationValueX = reader.ReadPackedIntDelta(baseline.Child60RotationValueX, compressionModel);
            Child60RotationValueY = reader.ReadPackedIntDelta(baseline.Child60RotationValueY, compressionModel);
            Child60RotationValueZ = reader.ReadPackedIntDelta(baseline.Child60RotationValueZ, compressionModel);
            Child60RotationValueW = reader.ReadPackedIntDelta(baseline.Child60RotationValueW, compressionModel);
        }
        else
        {
            Child60RotationValueX = baseline.Child60RotationValueX;
            Child60RotationValueY = baseline.Child60RotationValueY;
            Child60RotationValueZ = baseline.Child60RotationValueZ;
            Child60RotationValueW = baseline.Child60RotationValueW;
        }
        if ((changeMask3 & (1 << 28)) != 0)
        {
            Child60TranslationValueX = reader.ReadPackedIntDelta(baseline.Child60TranslationValueX, compressionModel);
            Child60TranslationValueY = reader.ReadPackedIntDelta(baseline.Child60TranslationValueY, compressionModel);
            Child60TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child60TranslationValueZ, compressionModel);
        }
        else
        {
            Child60TranslationValueX = baseline.Child60TranslationValueX;
            Child60TranslationValueY = baseline.Child60TranslationValueY;
            Child60TranslationValueZ = baseline.Child60TranslationValueZ;
        }
        if ((changeMask3 & (1 << 29)) != 0)
        {
            Child61RotationValueX = reader.ReadPackedIntDelta(baseline.Child61RotationValueX, compressionModel);
            Child61RotationValueY = reader.ReadPackedIntDelta(baseline.Child61RotationValueY, compressionModel);
            Child61RotationValueZ = reader.ReadPackedIntDelta(baseline.Child61RotationValueZ, compressionModel);
            Child61RotationValueW = reader.ReadPackedIntDelta(baseline.Child61RotationValueW, compressionModel);
        }
        else
        {
            Child61RotationValueX = baseline.Child61RotationValueX;
            Child61RotationValueY = baseline.Child61RotationValueY;
            Child61RotationValueZ = baseline.Child61RotationValueZ;
            Child61RotationValueW = baseline.Child61RotationValueW;
        }
        if ((changeMask3 & (1 << 30)) != 0)
        {
            Child61TranslationValueX = reader.ReadPackedIntDelta(baseline.Child61TranslationValueX, compressionModel);
            Child61TranslationValueY = reader.ReadPackedIntDelta(baseline.Child61TranslationValueY, compressionModel);
            Child61TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child61TranslationValueZ, compressionModel);
        }
        else
        {
            Child61TranslationValueX = baseline.Child61TranslationValueX;
            Child61TranslationValueY = baseline.Child61TranslationValueY;
            Child61TranslationValueZ = baseline.Child61TranslationValueZ;
        }
        if ((changeMask3 & (1 << 31)) != 0)
        {
            Child62RotationValueX = reader.ReadPackedIntDelta(baseline.Child62RotationValueX, compressionModel);
            Child62RotationValueY = reader.ReadPackedIntDelta(baseline.Child62RotationValueY, compressionModel);
            Child62RotationValueZ = reader.ReadPackedIntDelta(baseline.Child62RotationValueZ, compressionModel);
            Child62RotationValueW = reader.ReadPackedIntDelta(baseline.Child62RotationValueW, compressionModel);
        }
        else
        {
            Child62RotationValueX = baseline.Child62RotationValueX;
            Child62RotationValueY = baseline.Child62RotationValueY;
            Child62RotationValueZ = baseline.Child62RotationValueZ;
            Child62RotationValueW = baseline.Child62RotationValueW;
        }
        if ((changeMask4 & (1 << 0)) != 0)
        {
            Child62TranslationValueX = reader.ReadPackedIntDelta(baseline.Child62TranslationValueX, compressionModel);
            Child62TranslationValueY = reader.ReadPackedIntDelta(baseline.Child62TranslationValueY, compressionModel);
            Child62TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child62TranslationValueZ, compressionModel);
        }
        else
        {
            Child62TranslationValueX = baseline.Child62TranslationValueX;
            Child62TranslationValueY = baseline.Child62TranslationValueY;
            Child62TranslationValueZ = baseline.Child62TranslationValueZ;
        }
        if ((changeMask4 & (1 << 1)) != 0)
        {
            Child63RotationValueX = reader.ReadPackedIntDelta(baseline.Child63RotationValueX, compressionModel);
            Child63RotationValueY = reader.ReadPackedIntDelta(baseline.Child63RotationValueY, compressionModel);
            Child63RotationValueZ = reader.ReadPackedIntDelta(baseline.Child63RotationValueZ, compressionModel);
            Child63RotationValueW = reader.ReadPackedIntDelta(baseline.Child63RotationValueW, compressionModel);
        }
        else
        {
            Child63RotationValueX = baseline.Child63RotationValueX;
            Child63RotationValueY = baseline.Child63RotationValueY;
            Child63RotationValueZ = baseline.Child63RotationValueZ;
            Child63RotationValueW = baseline.Child63RotationValueW;
        }
        if ((changeMask4 & (1 << 2)) != 0)
        {
            Child63TranslationValueX = reader.ReadPackedIntDelta(baseline.Child63TranslationValueX, compressionModel);
            Child63TranslationValueY = reader.ReadPackedIntDelta(baseline.Child63TranslationValueY, compressionModel);
            Child63TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child63TranslationValueZ, compressionModel);
        }
        else
        {
            Child63TranslationValueX = baseline.Child63TranslationValueX;
            Child63TranslationValueY = baseline.Child63TranslationValueY;
            Child63TranslationValueZ = baseline.Child63TranslationValueZ;
        }
        if ((changeMask4 & (1 << 3)) != 0)
        {
            Child64RotationValueX = reader.ReadPackedIntDelta(baseline.Child64RotationValueX, compressionModel);
            Child64RotationValueY = reader.ReadPackedIntDelta(baseline.Child64RotationValueY, compressionModel);
            Child64RotationValueZ = reader.ReadPackedIntDelta(baseline.Child64RotationValueZ, compressionModel);
            Child64RotationValueW = reader.ReadPackedIntDelta(baseline.Child64RotationValueW, compressionModel);
        }
        else
        {
            Child64RotationValueX = baseline.Child64RotationValueX;
            Child64RotationValueY = baseline.Child64RotationValueY;
            Child64RotationValueZ = baseline.Child64RotationValueZ;
            Child64RotationValueW = baseline.Child64RotationValueW;
        }
        if ((changeMask4 & (1 << 4)) != 0)
        {
            Child64TranslationValueX = reader.ReadPackedIntDelta(baseline.Child64TranslationValueX, compressionModel);
            Child64TranslationValueY = reader.ReadPackedIntDelta(baseline.Child64TranslationValueY, compressionModel);
            Child64TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child64TranslationValueZ, compressionModel);
        }
        else
        {
            Child64TranslationValueX = baseline.Child64TranslationValueX;
            Child64TranslationValueY = baseline.Child64TranslationValueY;
            Child64TranslationValueZ = baseline.Child64TranslationValueZ;
        }
        if ((changeMask4 & (1 << 5)) != 0)
        {
            Child65RotationValueX = reader.ReadPackedIntDelta(baseline.Child65RotationValueX, compressionModel);
            Child65RotationValueY = reader.ReadPackedIntDelta(baseline.Child65RotationValueY, compressionModel);
            Child65RotationValueZ = reader.ReadPackedIntDelta(baseline.Child65RotationValueZ, compressionModel);
            Child65RotationValueW = reader.ReadPackedIntDelta(baseline.Child65RotationValueW, compressionModel);
        }
        else
        {
            Child65RotationValueX = baseline.Child65RotationValueX;
            Child65RotationValueY = baseline.Child65RotationValueY;
            Child65RotationValueZ = baseline.Child65RotationValueZ;
            Child65RotationValueW = baseline.Child65RotationValueW;
        }
        if ((changeMask4 & (1 << 6)) != 0)
        {
            Child65TranslationValueX = reader.ReadPackedIntDelta(baseline.Child65TranslationValueX, compressionModel);
            Child65TranslationValueY = reader.ReadPackedIntDelta(baseline.Child65TranslationValueY, compressionModel);
            Child65TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child65TranslationValueZ, compressionModel);
        }
        else
        {
            Child65TranslationValueX = baseline.Child65TranslationValueX;
            Child65TranslationValueY = baseline.Child65TranslationValueY;
            Child65TranslationValueZ = baseline.Child65TranslationValueZ;
        }
        if ((changeMask4 & (1 << 7)) != 0)
        {
            Child66RotationValueX = reader.ReadPackedIntDelta(baseline.Child66RotationValueX, compressionModel);
            Child66RotationValueY = reader.ReadPackedIntDelta(baseline.Child66RotationValueY, compressionModel);
            Child66RotationValueZ = reader.ReadPackedIntDelta(baseline.Child66RotationValueZ, compressionModel);
            Child66RotationValueW = reader.ReadPackedIntDelta(baseline.Child66RotationValueW, compressionModel);
        }
        else
        {
            Child66RotationValueX = baseline.Child66RotationValueX;
            Child66RotationValueY = baseline.Child66RotationValueY;
            Child66RotationValueZ = baseline.Child66RotationValueZ;
            Child66RotationValueW = baseline.Child66RotationValueW;
        }
        if ((changeMask4 & (1 << 8)) != 0)
        {
            Child66TranslationValueX = reader.ReadPackedIntDelta(baseline.Child66TranslationValueX, compressionModel);
            Child66TranslationValueY = reader.ReadPackedIntDelta(baseline.Child66TranslationValueY, compressionModel);
            Child66TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child66TranslationValueZ, compressionModel);
        }
        else
        {
            Child66TranslationValueX = baseline.Child66TranslationValueX;
            Child66TranslationValueY = baseline.Child66TranslationValueY;
            Child66TranslationValueZ = baseline.Child66TranslationValueZ;
        }
        if ((changeMask4 & (1 << 9)) != 0)
        {
            Child67RotationValueX = reader.ReadPackedIntDelta(baseline.Child67RotationValueX, compressionModel);
            Child67RotationValueY = reader.ReadPackedIntDelta(baseline.Child67RotationValueY, compressionModel);
            Child67RotationValueZ = reader.ReadPackedIntDelta(baseline.Child67RotationValueZ, compressionModel);
            Child67RotationValueW = reader.ReadPackedIntDelta(baseline.Child67RotationValueW, compressionModel);
        }
        else
        {
            Child67RotationValueX = baseline.Child67RotationValueX;
            Child67RotationValueY = baseline.Child67RotationValueY;
            Child67RotationValueZ = baseline.Child67RotationValueZ;
            Child67RotationValueW = baseline.Child67RotationValueW;
        }
        if ((changeMask4 & (1 << 10)) != 0)
        {
            Child67TranslationValueX = reader.ReadPackedIntDelta(baseline.Child67TranslationValueX, compressionModel);
            Child67TranslationValueY = reader.ReadPackedIntDelta(baseline.Child67TranslationValueY, compressionModel);
            Child67TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child67TranslationValueZ, compressionModel);
        }
        else
        {
            Child67TranslationValueX = baseline.Child67TranslationValueX;
            Child67TranslationValueY = baseline.Child67TranslationValueY;
            Child67TranslationValueZ = baseline.Child67TranslationValueZ;
        }
        if ((changeMask4 & (1 << 11)) != 0)
        {
            Child68RotationValueX = reader.ReadPackedIntDelta(baseline.Child68RotationValueX, compressionModel);
            Child68RotationValueY = reader.ReadPackedIntDelta(baseline.Child68RotationValueY, compressionModel);
            Child68RotationValueZ = reader.ReadPackedIntDelta(baseline.Child68RotationValueZ, compressionModel);
            Child68RotationValueW = reader.ReadPackedIntDelta(baseline.Child68RotationValueW, compressionModel);
        }
        else
        {
            Child68RotationValueX = baseline.Child68RotationValueX;
            Child68RotationValueY = baseline.Child68RotationValueY;
            Child68RotationValueZ = baseline.Child68RotationValueZ;
            Child68RotationValueW = baseline.Child68RotationValueW;
        }
        if ((changeMask4 & (1 << 12)) != 0)
        {
            Child68TranslationValueX = reader.ReadPackedIntDelta(baseline.Child68TranslationValueX, compressionModel);
            Child68TranslationValueY = reader.ReadPackedIntDelta(baseline.Child68TranslationValueY, compressionModel);
            Child68TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child68TranslationValueZ, compressionModel);
        }
        else
        {
            Child68TranslationValueX = baseline.Child68TranslationValueX;
            Child68TranslationValueY = baseline.Child68TranslationValueY;
            Child68TranslationValueZ = baseline.Child68TranslationValueZ;
        }
        if ((changeMask4 & (1 << 13)) != 0)
        {
            Child69RotationValueX = reader.ReadPackedIntDelta(baseline.Child69RotationValueX, compressionModel);
            Child69RotationValueY = reader.ReadPackedIntDelta(baseline.Child69RotationValueY, compressionModel);
            Child69RotationValueZ = reader.ReadPackedIntDelta(baseline.Child69RotationValueZ, compressionModel);
            Child69RotationValueW = reader.ReadPackedIntDelta(baseline.Child69RotationValueW, compressionModel);
        }
        else
        {
            Child69RotationValueX = baseline.Child69RotationValueX;
            Child69RotationValueY = baseline.Child69RotationValueY;
            Child69RotationValueZ = baseline.Child69RotationValueZ;
            Child69RotationValueW = baseline.Child69RotationValueW;
        }
        if ((changeMask4 & (1 << 14)) != 0)
        {
            Child69TranslationValueX = reader.ReadPackedIntDelta(baseline.Child69TranslationValueX, compressionModel);
            Child69TranslationValueY = reader.ReadPackedIntDelta(baseline.Child69TranslationValueY, compressionModel);
            Child69TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child69TranslationValueZ, compressionModel);
        }
        else
        {
            Child69TranslationValueX = baseline.Child69TranslationValueX;
            Child69TranslationValueY = baseline.Child69TranslationValueY;
            Child69TranslationValueZ = baseline.Child69TranslationValueZ;
        }
        if ((changeMask4 & (1 << 15)) != 0)
        {
            Child70RotationValueX = reader.ReadPackedIntDelta(baseline.Child70RotationValueX, compressionModel);
            Child70RotationValueY = reader.ReadPackedIntDelta(baseline.Child70RotationValueY, compressionModel);
            Child70RotationValueZ = reader.ReadPackedIntDelta(baseline.Child70RotationValueZ, compressionModel);
            Child70RotationValueW = reader.ReadPackedIntDelta(baseline.Child70RotationValueW, compressionModel);
        }
        else
        {
            Child70RotationValueX = baseline.Child70RotationValueX;
            Child70RotationValueY = baseline.Child70RotationValueY;
            Child70RotationValueZ = baseline.Child70RotationValueZ;
            Child70RotationValueW = baseline.Child70RotationValueW;
        }
        if ((changeMask4 & (1 << 16)) != 0)
        {
            Child70TranslationValueX = reader.ReadPackedIntDelta(baseline.Child70TranslationValueX, compressionModel);
            Child70TranslationValueY = reader.ReadPackedIntDelta(baseline.Child70TranslationValueY, compressionModel);
            Child70TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child70TranslationValueZ, compressionModel);
        }
        else
        {
            Child70TranslationValueX = baseline.Child70TranslationValueX;
            Child70TranslationValueY = baseline.Child70TranslationValueY;
            Child70TranslationValueZ = baseline.Child70TranslationValueZ;
        }
        if ((changeMask4 & (1 << 17)) != 0)
        {
            Child71RotationValueX = reader.ReadPackedIntDelta(baseline.Child71RotationValueX, compressionModel);
            Child71RotationValueY = reader.ReadPackedIntDelta(baseline.Child71RotationValueY, compressionModel);
            Child71RotationValueZ = reader.ReadPackedIntDelta(baseline.Child71RotationValueZ, compressionModel);
            Child71RotationValueW = reader.ReadPackedIntDelta(baseline.Child71RotationValueW, compressionModel);
        }
        else
        {
            Child71RotationValueX = baseline.Child71RotationValueX;
            Child71RotationValueY = baseline.Child71RotationValueY;
            Child71RotationValueZ = baseline.Child71RotationValueZ;
            Child71RotationValueW = baseline.Child71RotationValueW;
        }
        if ((changeMask4 & (1 << 18)) != 0)
        {
            Child71TranslationValueX = reader.ReadPackedIntDelta(baseline.Child71TranslationValueX, compressionModel);
            Child71TranslationValueY = reader.ReadPackedIntDelta(baseline.Child71TranslationValueY, compressionModel);
            Child71TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child71TranslationValueZ, compressionModel);
        }
        else
        {
            Child71TranslationValueX = baseline.Child71TranslationValueX;
            Child71TranslationValueY = baseline.Child71TranslationValueY;
            Child71TranslationValueZ = baseline.Child71TranslationValueZ;
        }
        if ((changeMask4 & (1 << 19)) != 0)
        {
            Child72RotationValueX = reader.ReadPackedIntDelta(baseline.Child72RotationValueX, compressionModel);
            Child72RotationValueY = reader.ReadPackedIntDelta(baseline.Child72RotationValueY, compressionModel);
            Child72RotationValueZ = reader.ReadPackedIntDelta(baseline.Child72RotationValueZ, compressionModel);
            Child72RotationValueW = reader.ReadPackedIntDelta(baseline.Child72RotationValueW, compressionModel);
        }
        else
        {
            Child72RotationValueX = baseline.Child72RotationValueX;
            Child72RotationValueY = baseline.Child72RotationValueY;
            Child72RotationValueZ = baseline.Child72RotationValueZ;
            Child72RotationValueW = baseline.Child72RotationValueW;
        }
        if ((changeMask4 & (1 << 20)) != 0)
        {
            Child72TranslationValueX = reader.ReadPackedIntDelta(baseline.Child72TranslationValueX, compressionModel);
            Child72TranslationValueY = reader.ReadPackedIntDelta(baseline.Child72TranslationValueY, compressionModel);
            Child72TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child72TranslationValueZ, compressionModel);
        }
        else
        {
            Child72TranslationValueX = baseline.Child72TranslationValueX;
            Child72TranslationValueY = baseline.Child72TranslationValueY;
            Child72TranslationValueZ = baseline.Child72TranslationValueZ;
        }
        if ((changeMask4 & (1 << 21)) != 0)
        {
            Child73RotationValueX = reader.ReadPackedIntDelta(baseline.Child73RotationValueX, compressionModel);
            Child73RotationValueY = reader.ReadPackedIntDelta(baseline.Child73RotationValueY, compressionModel);
            Child73RotationValueZ = reader.ReadPackedIntDelta(baseline.Child73RotationValueZ, compressionModel);
            Child73RotationValueW = reader.ReadPackedIntDelta(baseline.Child73RotationValueW, compressionModel);
        }
        else
        {
            Child73RotationValueX = baseline.Child73RotationValueX;
            Child73RotationValueY = baseline.Child73RotationValueY;
            Child73RotationValueZ = baseline.Child73RotationValueZ;
            Child73RotationValueW = baseline.Child73RotationValueW;
        }
        if ((changeMask4 & (1 << 22)) != 0)
        {
            Child73TranslationValueX = reader.ReadPackedIntDelta(baseline.Child73TranslationValueX, compressionModel);
            Child73TranslationValueY = reader.ReadPackedIntDelta(baseline.Child73TranslationValueY, compressionModel);
            Child73TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child73TranslationValueZ, compressionModel);
        }
        else
        {
            Child73TranslationValueX = baseline.Child73TranslationValueX;
            Child73TranslationValueY = baseline.Child73TranslationValueY;
            Child73TranslationValueZ = baseline.Child73TranslationValueZ;
        }
        if ((changeMask4 & (1 << 23)) != 0)
        {
            Child74RotationValueX = reader.ReadPackedIntDelta(baseline.Child74RotationValueX, compressionModel);
            Child74RotationValueY = reader.ReadPackedIntDelta(baseline.Child74RotationValueY, compressionModel);
            Child74RotationValueZ = reader.ReadPackedIntDelta(baseline.Child74RotationValueZ, compressionModel);
            Child74RotationValueW = reader.ReadPackedIntDelta(baseline.Child74RotationValueW, compressionModel);
        }
        else
        {
            Child74RotationValueX = baseline.Child74RotationValueX;
            Child74RotationValueY = baseline.Child74RotationValueY;
            Child74RotationValueZ = baseline.Child74RotationValueZ;
            Child74RotationValueW = baseline.Child74RotationValueW;
        }
        if ((changeMask4 & (1 << 24)) != 0)
        {
            Child74TranslationValueX = reader.ReadPackedIntDelta(baseline.Child74TranslationValueX, compressionModel);
            Child74TranslationValueY = reader.ReadPackedIntDelta(baseline.Child74TranslationValueY, compressionModel);
            Child74TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child74TranslationValueZ, compressionModel);
        }
        else
        {
            Child74TranslationValueX = baseline.Child74TranslationValueX;
            Child74TranslationValueY = baseline.Child74TranslationValueY;
            Child74TranslationValueZ = baseline.Child74TranslationValueZ;
        }
        if ((changeMask4 & (1 << 25)) != 0)
        {
            Child75RotationValueX = reader.ReadPackedIntDelta(baseline.Child75RotationValueX, compressionModel);
            Child75RotationValueY = reader.ReadPackedIntDelta(baseline.Child75RotationValueY, compressionModel);
            Child75RotationValueZ = reader.ReadPackedIntDelta(baseline.Child75RotationValueZ, compressionModel);
            Child75RotationValueW = reader.ReadPackedIntDelta(baseline.Child75RotationValueW, compressionModel);
        }
        else
        {
            Child75RotationValueX = baseline.Child75RotationValueX;
            Child75RotationValueY = baseline.Child75RotationValueY;
            Child75RotationValueZ = baseline.Child75RotationValueZ;
            Child75RotationValueW = baseline.Child75RotationValueW;
        }
        if ((changeMask4 & (1 << 26)) != 0)
        {
            Child75TranslationValueX = reader.ReadPackedIntDelta(baseline.Child75TranslationValueX, compressionModel);
            Child75TranslationValueY = reader.ReadPackedIntDelta(baseline.Child75TranslationValueY, compressionModel);
            Child75TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child75TranslationValueZ, compressionModel);
        }
        else
        {
            Child75TranslationValueX = baseline.Child75TranslationValueX;
            Child75TranslationValueY = baseline.Child75TranslationValueY;
            Child75TranslationValueZ = baseline.Child75TranslationValueZ;
        }
        if ((changeMask4 & (1 << 27)) != 0)
        {
            Child76RotationValueX = reader.ReadPackedIntDelta(baseline.Child76RotationValueX, compressionModel);
            Child76RotationValueY = reader.ReadPackedIntDelta(baseline.Child76RotationValueY, compressionModel);
            Child76RotationValueZ = reader.ReadPackedIntDelta(baseline.Child76RotationValueZ, compressionModel);
            Child76RotationValueW = reader.ReadPackedIntDelta(baseline.Child76RotationValueW, compressionModel);
        }
        else
        {
            Child76RotationValueX = baseline.Child76RotationValueX;
            Child76RotationValueY = baseline.Child76RotationValueY;
            Child76RotationValueZ = baseline.Child76RotationValueZ;
            Child76RotationValueW = baseline.Child76RotationValueW;
        }
        if ((changeMask4 & (1 << 28)) != 0)
        {
            Child76TranslationValueX = reader.ReadPackedIntDelta(baseline.Child76TranslationValueX, compressionModel);
            Child76TranslationValueY = reader.ReadPackedIntDelta(baseline.Child76TranslationValueY, compressionModel);
            Child76TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child76TranslationValueZ, compressionModel);
        }
        else
        {
            Child76TranslationValueX = baseline.Child76TranslationValueX;
            Child76TranslationValueY = baseline.Child76TranslationValueY;
            Child76TranslationValueZ = baseline.Child76TranslationValueZ;
        }
        if ((changeMask4 & (1 << 29)) != 0)
        {
            Child77RotationValueX = reader.ReadPackedIntDelta(baseline.Child77RotationValueX, compressionModel);
            Child77RotationValueY = reader.ReadPackedIntDelta(baseline.Child77RotationValueY, compressionModel);
            Child77RotationValueZ = reader.ReadPackedIntDelta(baseline.Child77RotationValueZ, compressionModel);
            Child77RotationValueW = reader.ReadPackedIntDelta(baseline.Child77RotationValueW, compressionModel);
        }
        else
        {
            Child77RotationValueX = baseline.Child77RotationValueX;
            Child77RotationValueY = baseline.Child77RotationValueY;
            Child77RotationValueZ = baseline.Child77RotationValueZ;
            Child77RotationValueW = baseline.Child77RotationValueW;
        }
        if ((changeMask4 & (1 << 30)) != 0)
        {
            Child77TranslationValueX = reader.ReadPackedIntDelta(baseline.Child77TranslationValueX, compressionModel);
            Child77TranslationValueY = reader.ReadPackedIntDelta(baseline.Child77TranslationValueY, compressionModel);
            Child77TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child77TranslationValueZ, compressionModel);
        }
        else
        {
            Child77TranslationValueX = baseline.Child77TranslationValueX;
            Child77TranslationValueY = baseline.Child77TranslationValueY;
            Child77TranslationValueZ = baseline.Child77TranslationValueZ;
        }
        if ((changeMask4 & (1 << 31)) != 0)
        {
            Child78RotationValueX = reader.ReadPackedIntDelta(baseline.Child78RotationValueX, compressionModel);
            Child78RotationValueY = reader.ReadPackedIntDelta(baseline.Child78RotationValueY, compressionModel);
            Child78RotationValueZ = reader.ReadPackedIntDelta(baseline.Child78RotationValueZ, compressionModel);
            Child78RotationValueW = reader.ReadPackedIntDelta(baseline.Child78RotationValueW, compressionModel);
        }
        else
        {
            Child78RotationValueX = baseline.Child78RotationValueX;
            Child78RotationValueY = baseline.Child78RotationValueY;
            Child78RotationValueZ = baseline.Child78RotationValueZ;
            Child78RotationValueW = baseline.Child78RotationValueW;
        }
        if ((changeMask5 & (1 << 0)) != 0)
        {
            Child78TranslationValueX = reader.ReadPackedIntDelta(baseline.Child78TranslationValueX, compressionModel);
            Child78TranslationValueY = reader.ReadPackedIntDelta(baseline.Child78TranslationValueY, compressionModel);
            Child78TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child78TranslationValueZ, compressionModel);
        }
        else
        {
            Child78TranslationValueX = baseline.Child78TranslationValueX;
            Child78TranslationValueY = baseline.Child78TranslationValueY;
            Child78TranslationValueZ = baseline.Child78TranslationValueZ;
        }
        if ((changeMask5 & (1 << 1)) != 0)
        {
            Child79RotationValueX = reader.ReadPackedIntDelta(baseline.Child79RotationValueX, compressionModel);
            Child79RotationValueY = reader.ReadPackedIntDelta(baseline.Child79RotationValueY, compressionModel);
            Child79RotationValueZ = reader.ReadPackedIntDelta(baseline.Child79RotationValueZ, compressionModel);
            Child79RotationValueW = reader.ReadPackedIntDelta(baseline.Child79RotationValueW, compressionModel);
        }
        else
        {
            Child79RotationValueX = baseline.Child79RotationValueX;
            Child79RotationValueY = baseline.Child79RotationValueY;
            Child79RotationValueZ = baseline.Child79RotationValueZ;
            Child79RotationValueW = baseline.Child79RotationValueW;
        }
        if ((changeMask5 & (1 << 2)) != 0)
        {
            Child79TranslationValueX = reader.ReadPackedIntDelta(baseline.Child79TranslationValueX, compressionModel);
            Child79TranslationValueY = reader.ReadPackedIntDelta(baseline.Child79TranslationValueY, compressionModel);
            Child79TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child79TranslationValueZ, compressionModel);
        }
        else
        {
            Child79TranslationValueX = baseline.Child79TranslationValueX;
            Child79TranslationValueY = baseline.Child79TranslationValueY;
            Child79TranslationValueZ = baseline.Child79TranslationValueZ;
        }
        if ((changeMask5 & (1 << 3)) != 0)
        {
            Child80RotationValueX = reader.ReadPackedIntDelta(baseline.Child80RotationValueX, compressionModel);
            Child80RotationValueY = reader.ReadPackedIntDelta(baseline.Child80RotationValueY, compressionModel);
            Child80RotationValueZ = reader.ReadPackedIntDelta(baseline.Child80RotationValueZ, compressionModel);
            Child80RotationValueW = reader.ReadPackedIntDelta(baseline.Child80RotationValueW, compressionModel);
        }
        else
        {
            Child80RotationValueX = baseline.Child80RotationValueX;
            Child80RotationValueY = baseline.Child80RotationValueY;
            Child80RotationValueZ = baseline.Child80RotationValueZ;
            Child80RotationValueW = baseline.Child80RotationValueW;
        }
        if ((changeMask5 & (1 << 4)) != 0)
        {
            Child80TranslationValueX = reader.ReadPackedIntDelta(baseline.Child80TranslationValueX, compressionModel);
            Child80TranslationValueY = reader.ReadPackedIntDelta(baseline.Child80TranslationValueY, compressionModel);
            Child80TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child80TranslationValueZ, compressionModel);
        }
        else
        {
            Child80TranslationValueX = baseline.Child80TranslationValueX;
            Child80TranslationValueY = baseline.Child80TranslationValueY;
            Child80TranslationValueZ = baseline.Child80TranslationValueZ;
        }
        if ((changeMask5 & (1 << 5)) != 0)
        {
            Child81RotationValueX = reader.ReadPackedIntDelta(baseline.Child81RotationValueX, compressionModel);
            Child81RotationValueY = reader.ReadPackedIntDelta(baseline.Child81RotationValueY, compressionModel);
            Child81RotationValueZ = reader.ReadPackedIntDelta(baseline.Child81RotationValueZ, compressionModel);
            Child81RotationValueW = reader.ReadPackedIntDelta(baseline.Child81RotationValueW, compressionModel);
        }
        else
        {
            Child81RotationValueX = baseline.Child81RotationValueX;
            Child81RotationValueY = baseline.Child81RotationValueY;
            Child81RotationValueZ = baseline.Child81RotationValueZ;
            Child81RotationValueW = baseline.Child81RotationValueW;
        }
        if ((changeMask5 & (1 << 6)) != 0)
        {
            Child81TranslationValueX = reader.ReadPackedIntDelta(baseline.Child81TranslationValueX, compressionModel);
            Child81TranslationValueY = reader.ReadPackedIntDelta(baseline.Child81TranslationValueY, compressionModel);
            Child81TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child81TranslationValueZ, compressionModel);
        }
        else
        {
            Child81TranslationValueX = baseline.Child81TranslationValueX;
            Child81TranslationValueY = baseline.Child81TranslationValueY;
            Child81TranslationValueZ = baseline.Child81TranslationValueZ;
        }
        if ((changeMask5 & (1 << 7)) != 0)
        {
            Child82RotationValueX = reader.ReadPackedIntDelta(baseline.Child82RotationValueX, compressionModel);
            Child82RotationValueY = reader.ReadPackedIntDelta(baseline.Child82RotationValueY, compressionModel);
            Child82RotationValueZ = reader.ReadPackedIntDelta(baseline.Child82RotationValueZ, compressionModel);
            Child82RotationValueW = reader.ReadPackedIntDelta(baseline.Child82RotationValueW, compressionModel);
        }
        else
        {
            Child82RotationValueX = baseline.Child82RotationValueX;
            Child82RotationValueY = baseline.Child82RotationValueY;
            Child82RotationValueZ = baseline.Child82RotationValueZ;
            Child82RotationValueW = baseline.Child82RotationValueW;
        }
        if ((changeMask5 & (1 << 8)) != 0)
        {
            Child82TranslationValueX = reader.ReadPackedIntDelta(baseline.Child82TranslationValueX, compressionModel);
            Child82TranslationValueY = reader.ReadPackedIntDelta(baseline.Child82TranslationValueY, compressionModel);
            Child82TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child82TranslationValueZ, compressionModel);
        }
        else
        {
            Child82TranslationValueX = baseline.Child82TranslationValueX;
            Child82TranslationValueY = baseline.Child82TranslationValueY;
            Child82TranslationValueZ = baseline.Child82TranslationValueZ;
        }
        if ((changeMask5 & (1 << 9)) != 0)
        {
            Child83RotationValueX = reader.ReadPackedIntDelta(baseline.Child83RotationValueX, compressionModel);
            Child83RotationValueY = reader.ReadPackedIntDelta(baseline.Child83RotationValueY, compressionModel);
            Child83RotationValueZ = reader.ReadPackedIntDelta(baseline.Child83RotationValueZ, compressionModel);
            Child83RotationValueW = reader.ReadPackedIntDelta(baseline.Child83RotationValueW, compressionModel);
        }
        else
        {
            Child83RotationValueX = baseline.Child83RotationValueX;
            Child83RotationValueY = baseline.Child83RotationValueY;
            Child83RotationValueZ = baseline.Child83RotationValueZ;
            Child83RotationValueW = baseline.Child83RotationValueW;
        }
        if ((changeMask5 & (1 << 10)) != 0)
        {
            Child83TranslationValueX = reader.ReadPackedIntDelta(baseline.Child83TranslationValueX, compressionModel);
            Child83TranslationValueY = reader.ReadPackedIntDelta(baseline.Child83TranslationValueY, compressionModel);
            Child83TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child83TranslationValueZ, compressionModel);
        }
        else
        {
            Child83TranslationValueX = baseline.Child83TranslationValueX;
            Child83TranslationValueY = baseline.Child83TranslationValueY;
            Child83TranslationValueZ = baseline.Child83TranslationValueZ;
        }
        if ((changeMask5 & (1 << 11)) != 0)
        {
            Child84RotationValueX = reader.ReadPackedIntDelta(baseline.Child84RotationValueX, compressionModel);
            Child84RotationValueY = reader.ReadPackedIntDelta(baseline.Child84RotationValueY, compressionModel);
            Child84RotationValueZ = reader.ReadPackedIntDelta(baseline.Child84RotationValueZ, compressionModel);
            Child84RotationValueW = reader.ReadPackedIntDelta(baseline.Child84RotationValueW, compressionModel);
        }
        else
        {
            Child84RotationValueX = baseline.Child84RotationValueX;
            Child84RotationValueY = baseline.Child84RotationValueY;
            Child84RotationValueZ = baseline.Child84RotationValueZ;
            Child84RotationValueW = baseline.Child84RotationValueW;
        }
        if ((changeMask5 & (1 << 12)) != 0)
        {
            Child84TranslationValueX = reader.ReadPackedIntDelta(baseline.Child84TranslationValueX, compressionModel);
            Child84TranslationValueY = reader.ReadPackedIntDelta(baseline.Child84TranslationValueY, compressionModel);
            Child84TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child84TranslationValueZ, compressionModel);
        }
        else
        {
            Child84TranslationValueX = baseline.Child84TranslationValueX;
            Child84TranslationValueY = baseline.Child84TranslationValueY;
            Child84TranslationValueZ = baseline.Child84TranslationValueZ;
        }
        if ((changeMask5 & (1 << 13)) != 0)
        {
            Child85RotationValueX = reader.ReadPackedIntDelta(baseline.Child85RotationValueX, compressionModel);
            Child85RotationValueY = reader.ReadPackedIntDelta(baseline.Child85RotationValueY, compressionModel);
            Child85RotationValueZ = reader.ReadPackedIntDelta(baseline.Child85RotationValueZ, compressionModel);
            Child85RotationValueW = reader.ReadPackedIntDelta(baseline.Child85RotationValueW, compressionModel);
        }
        else
        {
            Child85RotationValueX = baseline.Child85RotationValueX;
            Child85RotationValueY = baseline.Child85RotationValueY;
            Child85RotationValueZ = baseline.Child85RotationValueZ;
            Child85RotationValueW = baseline.Child85RotationValueW;
        }
        if ((changeMask5 & (1 << 14)) != 0)
        {
            Child85TranslationValueX = reader.ReadPackedIntDelta(baseline.Child85TranslationValueX, compressionModel);
            Child85TranslationValueY = reader.ReadPackedIntDelta(baseline.Child85TranslationValueY, compressionModel);
            Child85TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child85TranslationValueZ, compressionModel);
        }
        else
        {
            Child85TranslationValueX = baseline.Child85TranslationValueX;
            Child85TranslationValueY = baseline.Child85TranslationValueY;
            Child85TranslationValueZ = baseline.Child85TranslationValueZ;
        }
        if ((changeMask5 & (1 << 15)) != 0)
        {
            Child86RotationValueX = reader.ReadPackedIntDelta(baseline.Child86RotationValueX, compressionModel);
            Child86RotationValueY = reader.ReadPackedIntDelta(baseline.Child86RotationValueY, compressionModel);
            Child86RotationValueZ = reader.ReadPackedIntDelta(baseline.Child86RotationValueZ, compressionModel);
            Child86RotationValueW = reader.ReadPackedIntDelta(baseline.Child86RotationValueW, compressionModel);
        }
        else
        {
            Child86RotationValueX = baseline.Child86RotationValueX;
            Child86RotationValueY = baseline.Child86RotationValueY;
            Child86RotationValueZ = baseline.Child86RotationValueZ;
            Child86RotationValueW = baseline.Child86RotationValueW;
        }
        if ((changeMask5 & (1 << 16)) != 0)
        {
            Child86TranslationValueX = reader.ReadPackedIntDelta(baseline.Child86TranslationValueX, compressionModel);
            Child86TranslationValueY = reader.ReadPackedIntDelta(baseline.Child86TranslationValueY, compressionModel);
            Child86TranslationValueZ = reader.ReadPackedIntDelta(baseline.Child86TranslationValueZ, compressionModel);
        }
        else
        {
            Child86TranslationValueX = baseline.Child86TranslationValueX;
            Child86TranslationValueY = baseline.Child86TranslationValueY;
            Child86TranslationValueZ = baseline.Child86TranslationValueZ;
        }
    }
    public void Interpolate(ref ThirdPersonControllerSnapshotData target, float factor)
    {
        SetRotationValue(math.slerp(GetRotationValue(), target.GetRotationValue(), factor));
        SetTranslationValue(math.lerp(GetTranslationValue(), target.GetTranslationValue(), factor));
        SetChild0RotationValue(math.slerp(GetChild0RotationValue(), target.GetChild0RotationValue(), factor));
        SetChild0TranslationValue(math.lerp(GetChild0TranslationValue(), target.GetChild0TranslationValue(), factor));
        SetChild1RotationValue(math.slerp(GetChild1RotationValue(), target.GetChild1RotationValue(), factor));
        SetChild1TranslationValue(math.lerp(GetChild1TranslationValue(), target.GetChild1TranslationValue(), factor));
        SetChild2RotationValue(math.slerp(GetChild2RotationValue(), target.GetChild2RotationValue(), factor));
        SetChild2TranslationValue(math.lerp(GetChild2TranslationValue(), target.GetChild2TranslationValue(), factor));
        SetChild3RotationValue(math.slerp(GetChild3RotationValue(), target.GetChild3RotationValue(), factor));
        SetChild3TranslationValue(math.lerp(GetChild3TranslationValue(), target.GetChild3TranslationValue(), factor));
        SetChild4RotationValue(math.slerp(GetChild4RotationValue(), target.GetChild4RotationValue(), factor));
        SetChild4TranslationValue(math.lerp(GetChild4TranslationValue(), target.GetChild4TranslationValue(), factor));
        SetChild5RotationValue(math.slerp(GetChild5RotationValue(), target.GetChild5RotationValue(), factor));
        SetChild5TranslationValue(math.lerp(GetChild5TranslationValue(), target.GetChild5TranslationValue(), factor));
        SetChild6RotationValue(math.slerp(GetChild6RotationValue(), target.GetChild6RotationValue(), factor));
        SetChild6TranslationValue(math.lerp(GetChild6TranslationValue(), target.GetChild6TranslationValue(), factor));
        SetChild7RotationValue(math.slerp(GetChild7RotationValue(), target.GetChild7RotationValue(), factor));
        SetChild7TranslationValue(math.lerp(GetChild7TranslationValue(), target.GetChild7TranslationValue(), factor));
        SetChild8RotationValue(math.slerp(GetChild8RotationValue(), target.GetChild8RotationValue(), factor));
        SetChild8TranslationValue(math.lerp(GetChild8TranslationValue(), target.GetChild8TranslationValue(), factor));
        SetChild9RotationValue(math.slerp(GetChild9RotationValue(), target.GetChild9RotationValue(), factor));
        SetChild9TranslationValue(math.lerp(GetChild9TranslationValue(), target.GetChild9TranslationValue(), factor));
        SetChild10RotationValue(math.slerp(GetChild10RotationValue(), target.GetChild10RotationValue(), factor));
        SetChild10TranslationValue(math.lerp(GetChild10TranslationValue(), target.GetChild10TranslationValue(), factor));
        SetChild11RotationValue(math.slerp(GetChild11RotationValue(), target.GetChild11RotationValue(), factor));
        SetChild11TranslationValue(math.lerp(GetChild11TranslationValue(), target.GetChild11TranslationValue(), factor));
        SetChild12RotationValue(math.slerp(GetChild12RotationValue(), target.GetChild12RotationValue(), factor));
        SetChild12TranslationValue(math.lerp(GetChild12TranslationValue(), target.GetChild12TranslationValue(), factor));
        SetChild13RotationValue(math.slerp(GetChild13RotationValue(), target.GetChild13RotationValue(), factor));
        SetChild13TranslationValue(math.lerp(GetChild13TranslationValue(), target.GetChild13TranslationValue(), factor));
        SetChild14RotationValue(math.slerp(GetChild14RotationValue(), target.GetChild14RotationValue(), factor));
        SetChild14TranslationValue(math.lerp(GetChild14TranslationValue(), target.GetChild14TranslationValue(), factor));
        SetChild15RotationValue(math.slerp(GetChild15RotationValue(), target.GetChild15RotationValue(), factor));
        SetChild15TranslationValue(math.lerp(GetChild15TranslationValue(), target.GetChild15TranslationValue(), factor));
        SetChild16RotationValue(math.slerp(GetChild16RotationValue(), target.GetChild16RotationValue(), factor));
        SetChild16TranslationValue(math.lerp(GetChild16TranslationValue(), target.GetChild16TranslationValue(), factor));
        SetChild17RotationValue(math.slerp(GetChild17RotationValue(), target.GetChild17RotationValue(), factor));
        SetChild17TranslationValue(math.lerp(GetChild17TranslationValue(), target.GetChild17TranslationValue(), factor));
        SetChild18RotationValue(math.slerp(GetChild18RotationValue(), target.GetChild18RotationValue(), factor));
        SetChild18TranslationValue(math.lerp(GetChild18TranslationValue(), target.GetChild18TranslationValue(), factor));
        SetChild19RotationValue(math.slerp(GetChild19RotationValue(), target.GetChild19RotationValue(), factor));
        SetChild19TranslationValue(math.lerp(GetChild19TranslationValue(), target.GetChild19TranslationValue(), factor));
        SetChild20RotationValue(math.slerp(GetChild20RotationValue(), target.GetChild20RotationValue(), factor));
        SetChild20TranslationValue(math.lerp(GetChild20TranslationValue(), target.GetChild20TranslationValue(), factor));
        SetChild21RotationValue(math.slerp(GetChild21RotationValue(), target.GetChild21RotationValue(), factor));
        SetChild21TranslationValue(math.lerp(GetChild21TranslationValue(), target.GetChild21TranslationValue(), factor));
        SetChild22RotationValue(math.slerp(GetChild22RotationValue(), target.GetChild22RotationValue(), factor));
        SetChild22TranslationValue(math.lerp(GetChild22TranslationValue(), target.GetChild22TranslationValue(), factor));
        SetChild23RotationValue(math.slerp(GetChild23RotationValue(), target.GetChild23RotationValue(), factor));
        SetChild23TranslationValue(math.lerp(GetChild23TranslationValue(), target.GetChild23TranslationValue(), factor));
        SetChild24RotationValue(math.slerp(GetChild24RotationValue(), target.GetChild24RotationValue(), factor));
        SetChild24TranslationValue(math.lerp(GetChild24TranslationValue(), target.GetChild24TranslationValue(), factor));
        SetChild25RotationValue(math.slerp(GetChild25RotationValue(), target.GetChild25RotationValue(), factor));
        SetChild25TranslationValue(math.lerp(GetChild25TranslationValue(), target.GetChild25TranslationValue(), factor));
        SetChild26RotationValue(math.slerp(GetChild26RotationValue(), target.GetChild26RotationValue(), factor));
        SetChild26TranslationValue(math.lerp(GetChild26TranslationValue(), target.GetChild26TranslationValue(), factor));
        SetChild27RotationValue(math.slerp(GetChild27RotationValue(), target.GetChild27RotationValue(), factor));
        SetChild27TranslationValue(math.lerp(GetChild27TranslationValue(), target.GetChild27TranslationValue(), factor));
        SetChild28RotationValue(math.slerp(GetChild28RotationValue(), target.GetChild28RotationValue(), factor));
        SetChild28TranslationValue(math.lerp(GetChild28TranslationValue(), target.GetChild28TranslationValue(), factor));
        SetChild29RotationValue(math.slerp(GetChild29RotationValue(), target.GetChild29RotationValue(), factor));
        SetChild29TranslationValue(math.lerp(GetChild29TranslationValue(), target.GetChild29TranslationValue(), factor));
        SetChild30RotationValue(math.slerp(GetChild30RotationValue(), target.GetChild30RotationValue(), factor));
        SetChild30TranslationValue(math.lerp(GetChild30TranslationValue(), target.GetChild30TranslationValue(), factor));
        SetChild31RotationValue(math.slerp(GetChild31RotationValue(), target.GetChild31RotationValue(), factor));
        SetChild31TranslationValue(math.lerp(GetChild31TranslationValue(), target.GetChild31TranslationValue(), factor));
        SetChild32RotationValue(math.slerp(GetChild32RotationValue(), target.GetChild32RotationValue(), factor));
        SetChild32TranslationValue(math.lerp(GetChild32TranslationValue(), target.GetChild32TranslationValue(), factor));
        SetChild33RotationValue(math.slerp(GetChild33RotationValue(), target.GetChild33RotationValue(), factor));
        SetChild33TranslationValue(math.lerp(GetChild33TranslationValue(), target.GetChild33TranslationValue(), factor));
        SetChild34RotationValue(math.slerp(GetChild34RotationValue(), target.GetChild34RotationValue(), factor));
        SetChild34TranslationValue(math.lerp(GetChild34TranslationValue(), target.GetChild34TranslationValue(), factor));
        SetChild35RotationValue(math.slerp(GetChild35RotationValue(), target.GetChild35RotationValue(), factor));
        SetChild35TranslationValue(math.lerp(GetChild35TranslationValue(), target.GetChild35TranslationValue(), factor));
        SetChild36RotationValue(math.slerp(GetChild36RotationValue(), target.GetChild36RotationValue(), factor));
        SetChild36TranslationValue(math.lerp(GetChild36TranslationValue(), target.GetChild36TranslationValue(), factor));
        SetChild37RotationValue(math.slerp(GetChild37RotationValue(), target.GetChild37RotationValue(), factor));
        SetChild37TranslationValue(math.lerp(GetChild37TranslationValue(), target.GetChild37TranslationValue(), factor));
        SetChild38RotationValue(math.slerp(GetChild38RotationValue(), target.GetChild38RotationValue(), factor));
        SetChild38TranslationValue(math.lerp(GetChild38TranslationValue(), target.GetChild38TranslationValue(), factor));
        SetChild39RotationValue(math.slerp(GetChild39RotationValue(), target.GetChild39RotationValue(), factor));
        SetChild39TranslationValue(math.lerp(GetChild39TranslationValue(), target.GetChild39TranslationValue(), factor));
        SetChild40RotationValue(math.slerp(GetChild40RotationValue(), target.GetChild40RotationValue(), factor));
        SetChild40TranslationValue(math.lerp(GetChild40TranslationValue(), target.GetChild40TranslationValue(), factor));
        SetChild41RotationValue(math.slerp(GetChild41RotationValue(), target.GetChild41RotationValue(), factor));
        SetChild41TranslationValue(math.lerp(GetChild41TranslationValue(), target.GetChild41TranslationValue(), factor));
        SetChild42RotationValue(math.slerp(GetChild42RotationValue(), target.GetChild42RotationValue(), factor));
        SetChild42TranslationValue(math.lerp(GetChild42TranslationValue(), target.GetChild42TranslationValue(), factor));
        SetChild43RotationValue(math.slerp(GetChild43RotationValue(), target.GetChild43RotationValue(), factor));
        SetChild43TranslationValue(math.lerp(GetChild43TranslationValue(), target.GetChild43TranslationValue(), factor));
        SetChild44RotationValue(math.slerp(GetChild44RotationValue(), target.GetChild44RotationValue(), factor));
        SetChild44TranslationValue(math.lerp(GetChild44TranslationValue(), target.GetChild44TranslationValue(), factor));
        SetChild45RotationValue(math.slerp(GetChild45RotationValue(), target.GetChild45RotationValue(), factor));
        SetChild45TranslationValue(math.lerp(GetChild45TranslationValue(), target.GetChild45TranslationValue(), factor));
        SetChild46RotationValue(math.slerp(GetChild46RotationValue(), target.GetChild46RotationValue(), factor));
        SetChild46TranslationValue(math.lerp(GetChild46TranslationValue(), target.GetChild46TranslationValue(), factor));
        SetChild47RotationValue(math.slerp(GetChild47RotationValue(), target.GetChild47RotationValue(), factor));
        SetChild47TranslationValue(math.lerp(GetChild47TranslationValue(), target.GetChild47TranslationValue(), factor));
        SetChild48RotationValue(math.slerp(GetChild48RotationValue(), target.GetChild48RotationValue(), factor));
        SetChild48TranslationValue(math.lerp(GetChild48TranslationValue(), target.GetChild48TranslationValue(), factor));
        SetChild49RotationValue(math.slerp(GetChild49RotationValue(), target.GetChild49RotationValue(), factor));
        SetChild49TranslationValue(math.lerp(GetChild49TranslationValue(), target.GetChild49TranslationValue(), factor));
        SetChild50RotationValue(math.slerp(GetChild50RotationValue(), target.GetChild50RotationValue(), factor));
        SetChild50TranslationValue(math.lerp(GetChild50TranslationValue(), target.GetChild50TranslationValue(), factor));
        SetChild51RotationValue(math.slerp(GetChild51RotationValue(), target.GetChild51RotationValue(), factor));
        SetChild51TranslationValue(math.lerp(GetChild51TranslationValue(), target.GetChild51TranslationValue(), factor));
        SetChild52RotationValue(math.slerp(GetChild52RotationValue(), target.GetChild52RotationValue(), factor));
        SetChild52TranslationValue(math.lerp(GetChild52TranslationValue(), target.GetChild52TranslationValue(), factor));
        SetChild53RotationValue(math.slerp(GetChild53RotationValue(), target.GetChild53RotationValue(), factor));
        SetChild53TranslationValue(math.lerp(GetChild53TranslationValue(), target.GetChild53TranslationValue(), factor));
        SetChild54RotationValue(math.slerp(GetChild54RotationValue(), target.GetChild54RotationValue(), factor));
        SetChild54TranslationValue(math.lerp(GetChild54TranslationValue(), target.GetChild54TranslationValue(), factor));
        SetChild55RotationValue(math.slerp(GetChild55RotationValue(), target.GetChild55RotationValue(), factor));
        SetChild55TranslationValue(math.lerp(GetChild55TranslationValue(), target.GetChild55TranslationValue(), factor));
        SetChild56RotationValue(math.slerp(GetChild56RotationValue(), target.GetChild56RotationValue(), factor));
        SetChild56TranslationValue(math.lerp(GetChild56TranslationValue(), target.GetChild56TranslationValue(), factor));
        SetChild57RotationValue(math.slerp(GetChild57RotationValue(), target.GetChild57RotationValue(), factor));
        SetChild57TranslationValue(math.lerp(GetChild57TranslationValue(), target.GetChild57TranslationValue(), factor));
        SetChild58RotationValue(math.slerp(GetChild58RotationValue(), target.GetChild58RotationValue(), factor));
        SetChild58TranslationValue(math.lerp(GetChild58TranslationValue(), target.GetChild58TranslationValue(), factor));
        SetChild59RotationValue(math.slerp(GetChild59RotationValue(), target.GetChild59RotationValue(), factor));
        SetChild59TranslationValue(math.lerp(GetChild59TranslationValue(), target.GetChild59TranslationValue(), factor));
        SetChild60RotationValue(math.slerp(GetChild60RotationValue(), target.GetChild60RotationValue(), factor));
        SetChild60TranslationValue(math.lerp(GetChild60TranslationValue(), target.GetChild60TranslationValue(), factor));
        SetChild61RotationValue(math.slerp(GetChild61RotationValue(), target.GetChild61RotationValue(), factor));
        SetChild61TranslationValue(math.lerp(GetChild61TranslationValue(), target.GetChild61TranslationValue(), factor));
        SetChild62RotationValue(math.slerp(GetChild62RotationValue(), target.GetChild62RotationValue(), factor));
        SetChild62TranslationValue(math.lerp(GetChild62TranslationValue(), target.GetChild62TranslationValue(), factor));
        SetChild63RotationValue(math.slerp(GetChild63RotationValue(), target.GetChild63RotationValue(), factor));
        SetChild63TranslationValue(math.lerp(GetChild63TranslationValue(), target.GetChild63TranslationValue(), factor));
        SetChild64RotationValue(math.slerp(GetChild64RotationValue(), target.GetChild64RotationValue(), factor));
        SetChild64TranslationValue(math.lerp(GetChild64TranslationValue(), target.GetChild64TranslationValue(), factor));
        SetChild65RotationValue(math.slerp(GetChild65RotationValue(), target.GetChild65RotationValue(), factor));
        SetChild65TranslationValue(math.lerp(GetChild65TranslationValue(), target.GetChild65TranslationValue(), factor));
        SetChild66RotationValue(math.slerp(GetChild66RotationValue(), target.GetChild66RotationValue(), factor));
        SetChild66TranslationValue(math.lerp(GetChild66TranslationValue(), target.GetChild66TranslationValue(), factor));
        SetChild67RotationValue(math.slerp(GetChild67RotationValue(), target.GetChild67RotationValue(), factor));
        SetChild67TranslationValue(math.lerp(GetChild67TranslationValue(), target.GetChild67TranslationValue(), factor));
        SetChild68RotationValue(math.slerp(GetChild68RotationValue(), target.GetChild68RotationValue(), factor));
        SetChild68TranslationValue(math.lerp(GetChild68TranslationValue(), target.GetChild68TranslationValue(), factor));
        SetChild69RotationValue(math.slerp(GetChild69RotationValue(), target.GetChild69RotationValue(), factor));
        SetChild69TranslationValue(math.lerp(GetChild69TranslationValue(), target.GetChild69TranslationValue(), factor));
        SetChild70RotationValue(math.slerp(GetChild70RotationValue(), target.GetChild70RotationValue(), factor));
        SetChild70TranslationValue(math.lerp(GetChild70TranslationValue(), target.GetChild70TranslationValue(), factor));
        SetChild71RotationValue(math.slerp(GetChild71RotationValue(), target.GetChild71RotationValue(), factor));
        SetChild71TranslationValue(math.lerp(GetChild71TranslationValue(), target.GetChild71TranslationValue(), factor));
        SetChild72RotationValue(math.slerp(GetChild72RotationValue(), target.GetChild72RotationValue(), factor));
        SetChild72TranslationValue(math.lerp(GetChild72TranslationValue(), target.GetChild72TranslationValue(), factor));
        SetChild73RotationValue(math.slerp(GetChild73RotationValue(), target.GetChild73RotationValue(), factor));
        SetChild73TranslationValue(math.lerp(GetChild73TranslationValue(), target.GetChild73TranslationValue(), factor));
        SetChild74RotationValue(math.slerp(GetChild74RotationValue(), target.GetChild74RotationValue(), factor));
        SetChild74TranslationValue(math.lerp(GetChild74TranslationValue(), target.GetChild74TranslationValue(), factor));
        SetChild75RotationValue(math.slerp(GetChild75RotationValue(), target.GetChild75RotationValue(), factor));
        SetChild75TranslationValue(math.lerp(GetChild75TranslationValue(), target.GetChild75TranslationValue(), factor));
        SetChild76RotationValue(math.slerp(GetChild76RotationValue(), target.GetChild76RotationValue(), factor));
        SetChild76TranslationValue(math.lerp(GetChild76TranslationValue(), target.GetChild76TranslationValue(), factor));
        SetChild77RotationValue(math.slerp(GetChild77RotationValue(), target.GetChild77RotationValue(), factor));
        SetChild77TranslationValue(math.lerp(GetChild77TranslationValue(), target.GetChild77TranslationValue(), factor));
        SetChild78RotationValue(math.slerp(GetChild78RotationValue(), target.GetChild78RotationValue(), factor));
        SetChild78TranslationValue(math.lerp(GetChild78TranslationValue(), target.GetChild78TranslationValue(), factor));
        SetChild79RotationValue(math.slerp(GetChild79RotationValue(), target.GetChild79RotationValue(), factor));
        SetChild79TranslationValue(math.lerp(GetChild79TranslationValue(), target.GetChild79TranslationValue(), factor));
        SetChild80RotationValue(math.slerp(GetChild80RotationValue(), target.GetChild80RotationValue(), factor));
        SetChild80TranslationValue(math.lerp(GetChild80TranslationValue(), target.GetChild80TranslationValue(), factor));
        SetChild81RotationValue(math.slerp(GetChild81RotationValue(), target.GetChild81RotationValue(), factor));
        SetChild81TranslationValue(math.lerp(GetChild81TranslationValue(), target.GetChild81TranslationValue(), factor));
        SetChild82RotationValue(math.slerp(GetChild82RotationValue(), target.GetChild82RotationValue(), factor));
        SetChild82TranslationValue(math.lerp(GetChild82TranslationValue(), target.GetChild82TranslationValue(), factor));
        SetChild83RotationValue(math.slerp(GetChild83RotationValue(), target.GetChild83RotationValue(), factor));
        SetChild83TranslationValue(math.lerp(GetChild83TranslationValue(), target.GetChild83TranslationValue(), factor));
        SetChild84RotationValue(math.slerp(GetChild84RotationValue(), target.GetChild84RotationValue(), factor));
        SetChild84TranslationValue(math.lerp(GetChild84TranslationValue(), target.GetChild84TranslationValue(), factor));
        SetChild85RotationValue(math.slerp(GetChild85RotationValue(), target.GetChild85RotationValue(), factor));
        SetChild85TranslationValue(math.lerp(GetChild85TranslationValue(), target.GetChild85TranslationValue(), factor));
        SetChild86RotationValue(math.slerp(GetChild86RotationValue(), target.GetChild86RotationValue(), factor));
        SetChild86TranslationValue(math.lerp(GetChild86TranslationValue(), target.GetChild86TranslationValue(), factor));
    }
}
