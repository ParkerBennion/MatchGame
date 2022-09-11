using UnityEngine;
using UnityEngine.Events;
public class EnableEvent : MonoBehaviour
{
    public UnityEvent OnEnableEvent;

    public void OnEnable()
    {
        OnEnableEvent.Invoke();
    }
}
