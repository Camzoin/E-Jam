using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOffset : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    Animator thisAnim;

    // Start is called before the first frame update
    void Start()
    {
        Animator anim = GetComponent<Animator>();
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);
        anim.Play(state.fullPathHash, -1, Random.Range(0f, 1f));

        timer = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        thisAnim = gameObject.GetComponent<Animator>();


        time = time + Time.deltaTime;

        if (time > timer)
        {
            float chance = Random.Range(0, 10);

            Debug.Log("time but no trig" + chance);

            if (chance >= 8)
            {
               thisAnim.SetTrigger("talk");
               Debug.Log("tiggered");
            }

            timer = Random.Range(4, 8);
            time = 0;
        }
    }
}