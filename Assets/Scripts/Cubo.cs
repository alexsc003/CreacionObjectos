using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public bool invertedAxes;

    public float velocidad;

    public float movimientoX;
   
    public float movimientoY;
    
    public float movimientoZ;


    private void Awake()
    {
        if (invertedAxes == true)
        {
            velocidad = velocidad * -1f;
        }
    }
    void Update()
    {
        movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
        transform.Translate(movimientoX, movimientoY, movimientoZ);
    }
}
