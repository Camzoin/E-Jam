using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vommer : MonoBehaviour
{
    public bool isVom = false;

    Animator character;

    Transform player;

    float interactRange = 3;

    public GameObject vomSound, pressE;

    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetComponentInChildren<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVom == true)
        {
            gameObject.GetComponent<Walker>().enabled = false;
            character.SetTrigger("vom");

            vomSound.SetActive(true);
            pressE.SetActive(true);

            if (Input.GetKeyDown("e"))
            {
                if (Vector3.Distance(player.position, transform.position) < interactRange)
                {
                    //set interacted

                    GameObject controller = GameObject.FindGameObjectWithTag("GameController");

                    controller.GetComponent<CollegeCont>().interacted = true;
                }
            }
        }
    }
}
