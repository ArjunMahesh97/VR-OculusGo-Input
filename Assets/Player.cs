using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject centerEye;
    [SerializeField] GameObject camObject;

    Vector2 joyStick;
    [SerializeField] float movementSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        joyStick = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        transform.eulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);
        transform.Translate(Vector3.forward * joyStick.y * movementSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * joyStick.x * movementSpeed * Time.deltaTime);

        camObject.transform.position = Vector3.Lerp(camObject.transform.position, transform.position, 10f * Time.deltaTime);
    }
}
