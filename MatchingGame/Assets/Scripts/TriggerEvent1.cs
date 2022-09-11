using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent1 : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
