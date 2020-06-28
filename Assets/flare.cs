using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 700);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
