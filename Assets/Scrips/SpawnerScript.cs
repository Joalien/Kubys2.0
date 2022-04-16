using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnerScript : MonoBehaviour
{
    public List<Element> elements;
    public List<GameObject> objects;
    // Start is called before the first frame update
    void Awake()
    {
        var random = new Random();

        foreach (var element in elements)
        {
            Vector3 randomPosition = transform.position + Vector3.left * random.Next(-5, 5) + Vector3.forward * random.Next(-5, 5);
            SpawnElement(element, randomPosition);
        }
        
        foreach (var o in objects)
        {
            Vector3 randomPosition = transform.position + Vector3.left * random.Next(-5, 5) + Vector3.forward * random.Next(-5, 5);
            Instantiate(o, randomPosition, Quaternion.identity);
        }
    }
    
    public void SpawnElement(Element element, Vector3 position)
    {
        var charge = Instantiate(element.charge, position, Quaternion.identity);
        var elementScript = charge.AddComponent<ElementScript>();
        elementScript.element = element;
    }
}
