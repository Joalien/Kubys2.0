using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Element")]
public class Element : ScriptableObject
{
    public GameObject charge;
    public GameObject enchant;
    public GameObject auraRing;
    public Texture icon;
    public GameObject shield;
    public GameObject missile;
    public GameObject beam;
    public GameObject beamStart;
}
