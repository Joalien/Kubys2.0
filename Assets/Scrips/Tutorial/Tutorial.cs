using System;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public TextPublisher text;

    private readonly LinkedList<TutorialStep> _steps = new LinkedList<TutorialStep>();
    private LinkedListNode<TutorialStep> _currentStep;

    private void Start()
    {
        text = FindObjectOfType<TextPublisher>();

        // Basic movements
        _steps.AddFirst(gameObject.AddComponent<InitialStep>());
        _steps.AddLast(gameObject.AddComponent<TakeTheHealStep>());
        // Advanced movements
        _steps.AddLast(gameObject.AddComponent<JumpStep>());
        _steps.AddLast(gameObject.AddComponent<WalkStep>());
        _steps.AddLast(gameObject.AddComponent<CrouchStep>());
        _steps.AddLast(gameObject.AddComponent<CongratulationStep>());
        // handle Elements
        _steps.AddLast(gameObject.AddComponent<GrabElementStep>());
        _steps.AddLast(gameObject.AddComponent<GrabSecondaryElementStep>());
        _steps.AddLast(gameObject.AddComponent<SwitchElementStep>());
        _steps.AddLast(gameObject.AddComponent<DropElementStep>());

        // Basic spell
        _steps.AddLast(gameObject.AddComponent<CastSpellStep>());
        _steps.AddLast(gameObject.AddComponent<DashStep>());
        _steps.AddLast(gameObject.AddComponent<LongDashStep>());
        _steps.AddLast(gameObject.AddComponent<UseShieldStep>());

        // Weapons

        // End
        _steps.AddLast(gameObject.AddComponent<EndOfTutorialStep>());

        _currentStep = _steps.First;
        RetryStep();
    }

    private void Update()
    {
        if (_currentStep.Value.IsStepDone())
        {
            NextStep();
        }
    }

    public void PreviousStep()
    {
        if (_currentStep != _steps.First)
        {
            _currentStep = _currentStep.Previous;
            RetryStep();
        }
    }

    public void NextStep()
    {
        if (_currentStep == _steps.Last)
        {
            GameObject.Find("TutorialCanvas").GetComponentInChildren<TutorialButton>().LeftTutorial();
        }
        else
        {
            _currentStep = _currentStep.Next;
            RetryStep();
        }
    }

    public void RetryStep()
    {
        text.SendNewMessage(_currentStep.Value.Message);
        _currentStep.Value.ActivateStep();
    }
}
