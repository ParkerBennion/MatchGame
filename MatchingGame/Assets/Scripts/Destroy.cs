using System;
using System.Collections;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float seconds = 3;
    private WaitForSeconds waitObj;

    private IEnumerator Start()
    {
        waitObj = new WaitForSeconds(seconds);
        yield return waitObj;
        Destroy(gameObject);
    }
}
