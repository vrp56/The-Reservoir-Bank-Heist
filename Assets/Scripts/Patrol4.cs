using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 5.5f && transform.eulerAngles.y == 180.0f)
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
        else if (transform.position.x >= 16.0f && transform.eulerAngles.y == 90.0f)
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
        else if (transform.position.z >= 25.0f && transform.eulerAngles.y == 0.0f)
        {
            transform.Rotate(0.0f, 270.0f, 0.0f);
        }
        else if (transform.position.x <= 11.0f && transform.eulerAngles.y == 270.0f)
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }   
    }
}
