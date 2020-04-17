using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    GameObject gObject;
    GameObject empty;

    //[SerializeField] TextMeshProUGUI rotationText;


    // Start is called before the first frame update
    void Start()
    {
        empty = new GameObject();
        gObject = empty;
        //rotationText = GameObject.Find("RotationText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //rotationText.text = transform.rotation.ToString();

        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider != null)
            {
                if (gObject != hit.collider.gameObject)
                {
                    gObject.transform.SendMessage("OnVRExit");
                    gObject = hit.transform.gameObject;
                    gObject.transform.SendMessage("OnVREnter");
                }

                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)){
                    gObject.transform.SendMessage("OnVRTriggerDown");
                }
            }
        }
        else
        {
            if (gObject != null) ;
            {
                gObject.transform.SendMessage("OnVRExit");
                gObject = empty;
            }
        }
    }
}
