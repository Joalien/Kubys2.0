using UnityEngine;

public class GrabSecondaryElementStep : TutorialStep
{
    private Element _waterElement;
    private GameObject _player;
    private PlayerElements _playerElements;

    public override string Message =>
        "Vous pouvez posséder jusqu'à 2 éléments simultanément";

    public override void ActivateStep()
    {
        _player = GameObject.Find("MyPlayer");
        _playerElements = _player.GetComponent<PlayerElements>();
        var spawnerScript = GameObject.Find("ObjectSpawner").GetComponent<SpawnerScript>();
        _waterElement = spawnerScript.elements[0];

        spawnerScript.SpawnElement(_waterElement, new Vector3(80, 2, -15));
    }

    public override bool IsStepDone()
    {
        return _playerElements.secondaryElement != _playerElements.defaultEmptyElement;
    }
}
