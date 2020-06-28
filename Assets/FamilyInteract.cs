using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyInteract : MonoBehaviour
{
    Transform player;

    float interactRange = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (Vector3.Distance(player.position, transform.position) < interactRange)
            {
                //set interacted

                GameObject controller = GameObject.FindGameObjectWithTag("GameController");

                controller.GetComponent<FamilyCont>().interacted = true;
            }
        }
    }
}
