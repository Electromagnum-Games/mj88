using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadQueuedScene : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (GameManager.instance.queuedScene >= 0 && GameManager.instance.queuedScene < 4)
        {
            SceneManager.LoadScene(GameManager.instance.queuedScene);
            GameManager.instance.queuedScene = -1;
        }
    }
}
