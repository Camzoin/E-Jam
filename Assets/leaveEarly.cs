using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveEarly : MonoBehaviour
{
    GameObject sceneChanger;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.Find("Scene Changer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        sceneChanger.GetComponent<Animator>().SetTrigger("nextLevel");
    }
}
