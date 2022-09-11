using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabel : MonoBehaviour
{
    private TextMeshProUGUI label;
    public Int_SO dataObj;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        label.text = dataObj.intVal.ToString();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.intVal.ToString();
    }
}
