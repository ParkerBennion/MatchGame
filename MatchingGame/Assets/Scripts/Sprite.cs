using System;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class Sprite : MonoBehaviour
{
    private SpriteRenderer rendereObj;

    private void Awake()
    {
        rendereObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendereObj.color = obj.value;
    }

    public void ChangeRenderColor(ColorIDList_SO obj)
    {
        rendereObj.color = obj.currentColor.value;
    }
}
