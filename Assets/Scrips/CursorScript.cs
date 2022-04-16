using UnityEngine;
using UnityEngine.Events;

public class CursorScript : MonoBehaviour
{
    public Texture2D defaultCursor;
    [HideInInspector] public UnityEvent resetCursor;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
        resetCursor = new UnityEvent();
        resetCursor.AddListener(ResetCursor);
    }

    // Update is called once per frame
    void ResetCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
