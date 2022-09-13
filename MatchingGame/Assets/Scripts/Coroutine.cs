using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutine : MonoBehaviour
{
    public int waitTime = 3;
    private WaitForSeconds wait;
    public int counterNum = 3;
    public UnityEvent repeatEvent;
    
    private IEnumerator StartCounter()
    {
        wait = new WaitForSeconds(waitTime);
        
        while (counterNum > 0)
        {
            yield return wait;
            repeatEvent.Invoke();
        }
    }
}
