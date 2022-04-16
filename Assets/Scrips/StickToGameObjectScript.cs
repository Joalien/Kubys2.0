using UnityEngine;

public class StickToGameObjectScript : MonoBehaviour
{
    public GameObject gameObjectToFollow;
    
    private Camera _main;
    
    void Start()
    {
        _main = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _3DPosition = _main.WorldToScreenPoint(gameObjectToFollow.transform.position);
        bool isNotBehindCamera = _3DPosition.z > 0;
        if (isNotBehindCamera)
        {
            transform.position = _3DPosition;
        }
    }
}
