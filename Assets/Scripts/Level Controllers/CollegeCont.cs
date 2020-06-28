using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollegeCont : MonoBehaviour
{
    public float timeToEvent = 30;

    public PlayerMovement playerMove;
    public MouseLook playerLook;

    float timeInLevel = 0;


    bool hasHappened = false;

    public bool interacted = false;


    GameObject sceneChanger;


    public GameObject vommer;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.Find("Scene Changer");
    }

    // Update is called once per frame
    void Update()
    {
        timeInLevel = timeInLevel + Time.deltaTime;

        if (timeInLevel > timeToEvent)
        {
            if (hasHappened == false)
            {
                //event

                //open door
                vommer.GetComponent<Vommer>().isVom = true;

                //voice line

                //spawn sparkler box

                hasHappened = true;
            }
            //wait for palyer to get sparkler

            if (interacted == true)
            {
                //player get sparkler

                //take controller from player

                playerMove.playerControl = false;


               //play fade to black anim
               sceneChanger.GetComponent<Animator>().SetTrigger("nextLevel");
                    
                
            }
        }
    }
}