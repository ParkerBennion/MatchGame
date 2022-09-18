using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Match : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        //Debug.Log(idObj + "self");
        //Debug.Log(other.GetComponent<IDContainer>().idObj);

        if (other != null)
        {
            
            var tempObj = other.GetComponent<IDContainer>();
            if (tempObj == null)
                yield break;
            var otherID = tempObj.idObj;
            if (otherID == idObj)
            {
                matchEvent.Invoke();
            }
            else
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
