using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zhuan : MonoBehaviour
{
    // Start is called before the first frame update
    int speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up*speed );
    }
}
