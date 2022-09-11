using UnityEngine;
[CreateAssetMenu]

public class Float_SO : ScriptableObject
{

    public float floatVal;

    public void UpdateVal(float num)
    {
        floatVal += num;
    }
    public void ClearVal()
    {
        floatVal = 0;
    }

    public void DoubleVal()
    {
        floatVal *= 2;
    }
}
