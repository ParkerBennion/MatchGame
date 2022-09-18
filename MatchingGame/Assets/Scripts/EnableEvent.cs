using System;
using UnityEngine;
using UnityEngine.Events;
public class EnableEvent : MonoBehaviour
{
    public UnityEvent OnEnableEvent, onStartEvent;

    public void OnCommand()
    {
        OnEnableEvent.Invoke();
    }

    public void Start()
    {
        onStartEvent.Invoke();
    }
}
