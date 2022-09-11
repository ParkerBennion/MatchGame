using System;
using UnityEngine;
using UnityEngine.Events;
public class TriggerEvent: MonoBehaviour
{

    public UnityEvent triggerEventEnter;

    public void OnTriggerEnter(Collider other)
    {
        triggerEventEnter.Invoke();
    }
}
