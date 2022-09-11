using UnityEngine;
[CreateAssetMenu]
public class Int_SO : ScriptableObject
{
    public int intVal;
    

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
}
//same as float value. these could be put in inheritance to be more efficient;