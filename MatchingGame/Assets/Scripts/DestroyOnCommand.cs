using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyOnCommand : MonoBehaviour
{
    public UnityEvent onDestroy;

    public void DestroyThisObject()
    {
        onDestroy.Invoke();
        Destroy(gameObject);
    }
}
