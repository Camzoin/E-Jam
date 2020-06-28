using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CredCont : MonoBehaviour
{
    public float timeToEvent = 30;

    float timeInLevel = 0;

    GameObject sceneChanger;

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
            sceneChanger.GetComponent<Animator>().SetTrigger("nextLevel");
        }
    }
}
