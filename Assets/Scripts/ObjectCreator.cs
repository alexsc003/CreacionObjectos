using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCube;
    
    [SerializeField]
    GameObject prefabCube2;
    
    GameObject objectoCreado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            objectoCreado = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            objectoCreado = Instantiate(prefabCube2, Vector3.zero, Quaternion.identity);
        }
        objectoCreado.SetActive(false);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            objectoCreado.transform.position = hit.point;
        }
        
        objectoCreado.SetActive(true);

    }
}
