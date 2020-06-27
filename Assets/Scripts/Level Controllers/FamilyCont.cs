using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyCont : MonoBehaviour
{
    public float timeToEvent = 30;

    GameObject player;

    float timeInLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeInLevel = timeInLevel + Time.deltaTime;

        if (timeInLevel > timeToEvent)
        {
            //event

            
            //voice line

            //wait for palyer to get sparkler

            //player get sparkler
            //take controller from player
            //animate sparkler
            //play fade to black anim
        }
    }
}