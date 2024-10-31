using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleCubo : MonoBehaviour
{
    
    public float speedScale = 3.0f;
    
        void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += Vector3.one * Input.mouseScrollDelta.y * Time.deltaTime * speedScale;
        transform.localScale = newScale;
    }
}
