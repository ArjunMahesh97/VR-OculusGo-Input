using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ToolTip : MonoBehaviour
{
    TextMeshProUGUI helpText;
    TextMeshProUGUI toolTipText;

    [SerializeField] string helpString;
    [SerializeField] string tipString;


    // Start is called before the first frame update
    void Start()
    {
        helpText = GameObject.Find("HelpText").GetComponent<TextMeshProUGUI>();
        toolTipText = GameObject.Find("ToolTipText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVREnter()
    {
        helpText.text = helpString;
        toolTipText.text = tipString;
    }
    
    void OnVRExit()
    {
        helpText.text = "";
        toolTipText.text = "";
    }

}
