using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabel : MonoBehaviour
{
    public TextMeshProUGUI label;
    public Float_SO dataObj;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        label.text = dataObj.floatVal.ToString();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.floatVal.ToString();
    }
}
