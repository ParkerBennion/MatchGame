using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Drag : MonoBehaviour
{
    private Camera cameraObj;
    private bool dragable;
    private Vector3 position, offset, startPosition;
    public UnityEvent startDragEvent, endDragEvent;
    
    private void Start()
    {
        cameraObj = Camera.main;
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        dragable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();
        
        
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition)+offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        dragable = false;
        endDragEvent.Invoke();
    }

    public void ReplaceCharacter()
    {
        transform.position = startPosition;
    }
}
