using UnityEngine;
using UnityEngine.Events;

public class IDContainer : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;

    private void Start()
    {
        startEvent.Invoke();
    }
}
