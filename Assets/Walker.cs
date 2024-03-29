﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Walker : MonoBehaviour
{
    public GameObject walkerPoints;

    List<Transform> points = new List<Transform>();

    float closeEnoughDist = 0.5f;

    Transform destination;

    float time, timer = 5;

    bool waiting = false;

    Animator character;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in walkerPoints.transform)
        {
            points.Add(child);
        }

        destination = points[Random.Range(0, points.Count)];

        gameObject.GetComponent<NavMeshAgent>().SetDestination(destination.position);

        character = transform.GetComponentInChildren<Animator>();

        character.SetBool("isWalking", true);
    }

    // Update is called once per frame
    void Update()
    {     
        if (Vector3.Distance(transform.position, destination.position) < closeEnoughDist)
        {
            //play idle
            character.SetBool("isWalking", false);


            waiting = true;

            gameObject.GetComponent<NavMeshAgent>().SetDestination(transform.position);

        }


        if (waiting == true)
        {
            time = time + Time.deltaTime;

            if (time > timer)
            {
                //play run
                character.SetBool("isWalking", true);

                timer = Random.Range(2, 10);
                time = 0;

                destination = points[Random.Range(0, points.Count)];

                gameObject.GetComponent<NavMeshAgent>().SetDestination(destination.position);

                waiting = false;

                //set new dest
            }
        }
    }
}
