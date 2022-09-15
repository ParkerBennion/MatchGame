using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Coroutine : MonoBehaviour
{
    public UnityEvent repeatEvent,startEvent, endEvent;
    
    public int waitTime = 3;
    public int counterNum = 3;
    private WaitForSeconds wait;
    public TextMeshProUGUI textObj;
    
    
    private IEnumerator StartCounter()
    {
        wait = new WaitForSeconds(waitTime);
        
        while (counterNum > -1)
        {
            if (counterNum >=0)
            {
                textObj.text = counterNum.ToString();
                
                counterNum--;
                if (counterNum == -1)
                {
                    textObj.text = "GO!!!";
                }
                Debug.Log(counterNum);
                repeatEvent.Invoke();
                yield return wait;
            }
        }
        counterNum = 3;
        endEvent.Invoke();
    }

    public void StartCourouteneCounter()
    {
        StartCoroutine(StartCounter());
    }
}
