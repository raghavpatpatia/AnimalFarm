using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    private float top = 76.0f;
    private float bottom = -47.0f;
    private float right = 31.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > top || transform.position.z < bottom || transform.position.x > right)
        {
            Destroy(gameObject);
        }
    }
}
