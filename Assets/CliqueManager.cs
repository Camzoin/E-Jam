using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.Examples;

public class CliqueManager : MonoBehaviour
{
    List<GameObject> persons = new List<GameObject>();

    float timer = 5, time;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            persons.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //next sentance

        time = time + Time.deltaTime;

        if (time > timer)
        {
            time = 0;

            foreach (GameObject person in persons)
            {
                person.GetComponentInChildren<TeleType>().outsideTrig = true;
                // everyone does something
            }
        }

        //tells each person when to talk and animate
    }
}
