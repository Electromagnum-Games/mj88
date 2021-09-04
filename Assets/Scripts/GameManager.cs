using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int queuedScene = -1;
    public Animator transition;

    public int lives = 4;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            lives = 4;
        }

        if (lives <= 0)
        {
            lives = 4;
            queuedScene = 3;
            transition.SetTrigger("toBlack");
        }
    }
}
