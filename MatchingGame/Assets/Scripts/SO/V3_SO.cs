using UnityEngine;
[CreateAssetMenu]
public class V3_SO : ScriptableObject
{
    public Vector3 vector3Val;

    public void AddPos (float x, float y, float z)
    {
        vector3Val.x += x;
        vector3Val.y += y; 
        vector3Val.z += z;
    }
    //moves according to given values.

    public void PosUp()
    {
        vector3Val.y += 10; 
    }
    //gives predetermined upward movement.
}