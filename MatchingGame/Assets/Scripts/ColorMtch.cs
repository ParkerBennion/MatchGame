using UnityEngine;

public class ColorMtch : Match
{
    public ColorIDList_SO colorDatalistObj;

    private void Awake()
    {
        idObj = colorDatalistObj.currentColor;
    }


    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;

    }
}
