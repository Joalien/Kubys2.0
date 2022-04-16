using UnityEngine;

public class GrabElementStep : TutorialStep
{
    private Element _earthElement;
    private GameObject _player;
    private PlayerElements _playerElements;

    public override string Message =>
        "Ramassez cet artefact !\nIl enchantera vos attaques et vous octroira de puissants bonus";

    public override void ActivateStep()
    {
        _player = GameObject.Find("MyPlayer");
        _playerElements = _player.GetComponent<PlayerElements>();
        var spawnerScript = GameObject.Find("ObjectSpawner").GetComponent<SpawnerScript>();
        _earthElement = spawnerScript.elements[5];

        spawnerScript.SpawnElement(_earthElement, new Vector3(75, 2, -25));
    }

    public override bool IsStepDone()
    {
        return _playerElements.mainElement != _playerElements.defaultEmptyElement;
    }
}
