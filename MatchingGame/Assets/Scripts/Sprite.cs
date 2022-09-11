using System;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class Sprite : MonoBehaviour
{
    private SpriteRenderer rendereObj;

    private void Start()
    {
        rendereObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendereObj.color = obj.value;
    }
}