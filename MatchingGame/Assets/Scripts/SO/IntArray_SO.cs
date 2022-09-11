using System;
using System.Collections.Generic;
using UnityEngine;

public class IntArray_SO : ScriptableObject
{
    public List<string> listOfThings ;

    public void AddToArray(String nameToAdd)
    {
        listOfThings.Add(nameToAdd);
        Debug.Log(listOfThings);
    }
    //adds a name to a list. likely how i would start an inventory system;
}
