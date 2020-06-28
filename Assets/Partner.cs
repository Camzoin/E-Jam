using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Partner : MonoBehaviour
{
    public GameObject player;   

    float closeEnoughDist = 1;

    Animator character;

    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetComponentInChildren<Animator>();

        character.SetBool("isWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);

        if (Vector3.Distance(transform.position, player.transform.position) < closeEnoughDist)
        {
            //play idle
            character.SetBool("isWalking", false);

            gameObject.GetComponent<NavMeshAgent>().SetDestination(transform.position);

        }
        else


            //play run
            character.SetBool("isWalking", true);

          
            //set new dest
    }
}
