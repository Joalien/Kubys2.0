using UnityEngine;
using UnityEngine.Events;

public class PlayerElements : MonoBehaviour
{
    public Element defaultEmptyElement;

    [HideInInspector]
    public Element mainElement;
    [HideInInspector]
    public Element secondaryElement;
    [HideInInspector]
    public GameObject auraRing;

    [HideInInspector]
    public UnityEvent updateMainElement;
    [HideInInspector]
    public UnityEvent updateSecondaryElement;

    private void Awake()
    {
        updateMainElement = new UnityEvent();
        updateSecondaryElement = new UnityEvent();
    }

    private void Start()
    {
        AssignMainElement(defaultEmptyElement);
        AssignSecondaryElement(defaultEmptyElement);
    }

    public void DropMainElement()
    {
        if (mainElement != defaultEmptyElement)
        {
            var playerTransform = transform;
            FindObjectOfType<SpawnerScript>().SpawnElement(mainElement,
                playerTransform.position - 2 * playerTransform.forward + playerTransform.up);
            AssignMainElement(secondaryElement);
            AssignSecondaryElement(defaultEmptyElement);
        }
    }

    public void SwitchElement()
    {
        if (mainElement != defaultEmptyElement && secondaryElement != defaultEmptyElement)
        {
            Element oldMainElement = mainElement;
            AssignMainElement(secondaryElement);
            AssignSecondaryElement(oldMainElement);
        }
    }

    public bool AddElement(Element element)
    {
        if (mainElement == defaultEmptyElement)
        {
            AssignMainElement(element);
            
            var enchant = Instantiate(mainElement.enchant, transform);
            Destroy(enchant, enchant.GetComponent<ParticleSystem>().main.duration);
            
            return true;
        }
        else if (secondaryElement == defaultEmptyElement)
        {
            AssignSecondaryElement(element);
            
            var enchant = Instantiate(secondaryElement.enchant, transform);
            Destroy(enchant, enchant.GetComponent<ParticleSystem>().main.duration);
            
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AssignMainElement(Element element)
    {
        if (auraRing != null)
        {
            Destroy(auraRing);
        }
        
        mainElement = element;

        auraRing = Instantiate(mainElement.auraRing, transform);
        auraRing.transform.localScale *= 0.2f;
        auraRing.transform.position += Vector3.up * 0.1f;
        updateMainElement.Invoke();
    }
    
    public void AssignSecondaryElement(Element element)
    {
        secondaryElement = element;
        updateSecondaryElement.Invoke();
    }
}
