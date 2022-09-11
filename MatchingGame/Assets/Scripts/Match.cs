using System;
using UnityEngine;
using UnityEngine.Events;

public class Match : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(idObj + "self");
        //Debug.Log(other.GetComponent<IDContainer>().idObj);

        if (other != null)
        {
            
            var tempObj = other.GetComponent<IDContainer>();
            if (tempObj == null)
                return;
            var otherID = tempObj.idObj;
            if (otherID == idObj)
            {
                matchEvent.Invoke();
                Debug.Log("hit");
            }
            else
            {
                noMatchEvent.Invoke();
                Debug.Log("wrong");
            }
        }
    }
}
