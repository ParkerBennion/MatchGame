using UnityEngine;
using UnityEngine.Events;
public class MouseEnterEvent : MonoBehaviour
{
    public UnityEvent MouseEnterEvnt;

    public void OnMouseEnter()
    {
        MouseEnterEvnt.Invoke();
    }
}
