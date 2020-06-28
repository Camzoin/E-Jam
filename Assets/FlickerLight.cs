using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    float time;

    float timer = .2f;

    public float baseIntensity = 0.005f;

    float intensity = 0.005f;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;

        //if (time > timer)
        //{
        //    intensity = Mathf.Lerp(intensity, Random.Range(0.003f, 0.006f), 1 * Time.deltaTime);

        //    time = 0;
        //}

        intensity = Mathf.Lerp(intensity, baseIntensity * Random.Range(0.5f, 1.5f), 1 * Time.deltaTime);

        gameObject.GetComponent<Light>().intensity = intensity;
    }
}
