using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationCubo : MonoBehaviour
{

    public float velocidad;

    public float rotateY;



    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            
            rotateY = Time.deltaTime * velocidad;
            transform.Rotate(0.0f, rotateY, 0.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            
            rotateY = Time.deltaTime * velocidad * -1.0f;
            transform.Rotate(0.0f, rotateY, 0.0f);
        }
    }
}
