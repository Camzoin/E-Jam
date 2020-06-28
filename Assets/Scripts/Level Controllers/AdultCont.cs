using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultCont : MonoBehaviour
{
    public float timeToEvent = 30;

    public PlayerMovement playerMove;
    public MouseLook playerLook;

    float timeInLevel = 0;

    bool hasHappened = false;

    public bool interacted = false;

    GameObject sceneChanger;

    float curSparkleTime = 0;

    float sparkleTime = 3;

    public GameObject pressText, closePoint;

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
                //make text over picture

                pressText.SetActive(true);
                closePoint.SetActive(true);

                hasHappened = true;
            }
            //wait for palyer to remember

            if (interacted == true)
            {
                playerLook.playerControl = false;
                playerMove.playerControl = false;


                //if palyer in position

                curSparkleTime = curSparkleTime + Time.deltaTime;
                    //animate sparkler

                    if (curSparkleTime > sparkleTime)
                    {
                        //play fade to black anim
                        sceneChanger.GetComponent<Animator>().SetTrigger("nextLevel");
                    }
                
            }
        }
    }
}