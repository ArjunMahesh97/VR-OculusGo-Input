using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool opened;
    Vector3 openPosition, closePosition;
    [SerializeField] float closeTime = 5f;


    // Start is called before the first frame update
    void Start()
    {
        closePosition = transform.position;
        openPosition = closePosition + Vector3.up * 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!opened)
        {
            transform.position = Vector3.Lerp(transform.position, closePosition, Time.deltaTime * closeTime);
        }

        if (opened)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, Time.deltaTime * closeTime);
        }
    }

    void OnVRTriggerDown()
    {
        opened = true;
    }
}
