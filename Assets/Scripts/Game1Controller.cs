using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Controller : MonoBehaviour
{
    public Animator clock;

    Animator arm;

    int hitCount;

    // Start is called before the first frame update
    void Start()
    {
        arm = GetComponent<Animator>();

        hitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Check for button input (input is not registered if already on the downswing)
        if (Input.GetButtonDown("Jump") && !arm.GetCurrentAnimatorStateInfo(0).IsName("swing"))
        {
            arm.SetTrigger("swingArm");
            hitCount++;

            clock.SetInteger("hitCount", hitCount);
        }

        if (hitCount >= 10)
        {
            GameManager.instance.queuedScene = 0;
            GameManager.instance.transition.SetTrigger("toBlack");

            hitCount = 0;
        }
    }
}
