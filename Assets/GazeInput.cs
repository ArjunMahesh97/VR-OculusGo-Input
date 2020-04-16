using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GazeInput : MonoBehaviour
{
    TextMeshProUGUI gazeText;

    // Start is called before the first frame update
    void Start()
    {
        gazeText = GameObject.Find("GazeText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GazeEnter()
    {
        gazeText.text = "Enter";
    }
    public void GazeExit()
    {
        gazeText.text = "Exit";
    }

}
