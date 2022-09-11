using UnityEngine;
using UnityEngine.Events;

public class MouseExitEvent : MonoBehaviour
{
    public UnityEvent MouseExitEvnt;

    public void OnMouseExit()
    {
        MouseExitEvnt.Invoke();
    }
}
