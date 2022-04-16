using System;
using UnityEngine;

public abstract class TutorialStep : MonoBehaviour
{
    public abstract String Message { get; }

    public virtual void ActivateStep()
    {

    } // Hook

    public abstract Boolean IsStepDone();
}

