using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Int_SO : ScriptableObject
{
    public int intVal;

    public void resetValue(int num)
    {
        intVal = num;
    }
    public void UpdateVal(int num)
    {
        intVal += num;
    }
    public void ClearVal()
    {
        intVal = 0;
    }

    public void DoubleVal()
    {
        intVal *= 2;
    }

    public void SetValue(Int_SO obj)
    {
        intVal = obj.intVal;
    }

    public void CompareValues(Int_SO obj)
    {
        if (intVal>obj.intVal)
        {
            
        }
        else
        {
            intVal = obj.intVal;
        }
    }
    
}
//same as float value. these could be put in inheritance to be more efficient;