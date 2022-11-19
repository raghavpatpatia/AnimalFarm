using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float positiveBound = 34.0f;
    private float negativeBound = -14.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > positiveBound || transform.position.z < negativeBound)
        {
            Destroy(gameObject);
        }
    }
}
