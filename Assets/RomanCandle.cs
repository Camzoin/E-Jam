using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomanCandle : MonoBehaviour
{
    public bool isShooting = false;

    public GameObject flare;

    float time;

    float timer = 2;

    public Transform shooter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isShooting == true)
        {
            time = time + Time.deltaTime;

            if (time > timer)
            {
                //spawn ball
                Instantiate(flare, shooter.position, shooter.rotation);

                time = 0;
            }           
        }
    }
}
