using UnityEngine;
[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3_SO obj)
    {
        Instantiate(prefab, obj.vectorValue, Quaternion.identity);
    }

    public void CreateInstanceFromList(V3List_SO obj)
    {
        for (int i = 0; i < obj.vector3List.Count; i++)
        {
            Instantiate(prefab, obj.vector3List[i].vectorValue, Quaternion.identity);
        }
    }
    public void CreateInstanceFromListCounting(V3List_SO obj)
    {
        Instantiate(prefab, obj.vector3List[num].vectorValue, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }

    }
    public void CreateInstanceFromListRandom(V3List_SO obj)
    {
        num = Random.Range(0, obj.vector3List.Count - 1);

        Instantiate(prefab, obj.vector3List[num].vectorValue, Quaternion.identity);

    }
}
