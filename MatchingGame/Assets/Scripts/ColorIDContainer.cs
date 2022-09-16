using System;
using UnityEngine;

public class ColorIDContainer : IDContainer
{
    public ColorIDList_SO colorDatalistObj;

    private void Awake()
    {
        idObj = colorDatalistObj.currentColor;
    }
}
