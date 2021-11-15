using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private float speed = 25f;
    private float turnSpeed = 10f;
    private float horizontalInput;
    private float verticalInput;
    private float advancespeed = 15f;

  
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //tomamos el eje horizontal del input manager
        verticalInput = Input.GetAxis("Vertical"); //tomamos el eje vertical del input Manager

        //movimiento hacia adelante automática
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //movimiento lateral al pulsar las flechas laterales
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        //movimiento lateral
        transform.Translate(Vector3.forward * advancespeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        //transform.Rotate(Vector3.right, turnSpeed * TimedeltaTime * verticalInput)
    }
}
