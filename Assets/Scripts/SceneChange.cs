using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public void ChooseScene(int sceneNumber)
    {
        GameManager.instance.queuedScene = sceneNumber;
        GameManager.instance.transition.SetTrigger("toBlack");
    }
}
