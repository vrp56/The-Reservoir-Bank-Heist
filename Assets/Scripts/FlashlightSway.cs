using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSway : MonoBehaviour
{
    // Start is called before the first frame update
    bool goLeft = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(20.0f, 20.0f * Mathf.Sin(Time.time * 0.5f), 0f);
    }
}
