using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenCont : MonoBehaviour
{
    public float timeToEvent = 30;

    public PlayerMovement playerMove;
    public MouseLook playerLook;

    float timeInLevel = 0;

    public GameObject door;

    public GameObject sparklerBox, sparklerSpawn;

    bool hasHappened = false;

    public bool interacted = false;

    public bool candleHit = false;

    GameObject sceneChanger;

    public Transform sparkleSpot;

    public GameObject candle;

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
                door.GetComponent<Animator>().SetTrigger("open");

                //voice line

                //spawn sparkler box

                Instantiate(sparklerBox, sparklerSpawn.transform.position, Quaternion.identity);

                hasHappened = true;
            }
            //wait for palyer to get sparkler

            if (interacted == true)
            {
                //player get candle
                candle.SetActive(true);

                //take controller from player

                playerMove.playerControl = false;

                //move player to outside
                playerMove.transform.position = Vector3.Lerp(playerMove.transform.position, sparkleSpot.position, 1 * Time.deltaTime);

                //if palyer in position
                if (Vector3.Distance(playerMove.transform.position, sparkleSpot.position) < 0.25f)
                {

                    //Start Shooting Candle
                    candle.GetComponent<RomanCandle>().isShooting = true;


                    if (candleHit == true)
                    {
                        //play fade to black anim
                        sceneChanger.GetComponent<Animator>().SetTrigger("nextLevel");
                    }
                }
            }           
        }
    }
}