using UnityEngine;

public class TutorialButton : MonoBehaviour
{
    public Tutorial tutorial;
    public void LeftTutorial()
    {
        Destroy(tutorial);
        Destroy(gameObject.transform.parent.gameObject);
        GameObject myPlayer = GameObject.Find("MyPlayer");
        myPlayer.transform.position = new Vector3(-85, 20, -30);
    }

    public void BackToPreviousStep()
    {
        tutorial.PreviousStep();
    }
}
