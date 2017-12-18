using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleChange : MonoBehaviour {

    public int button; //button currently "selected"

    // Use this for initialization
    void Start()
    {
        button = 0;
    }

    // Update is called once per frame
    void Update()
    {
        button = button % 3; //always be on one of 3 buttons
        if (Input.GetKey(KeyCode.DownArrow))
        {
            button++;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            button--;
            if (button < 0)
            {
                button = 2;
            }
        }
        SwitchStage();
    }

    public int GetNum()
    {
        return button;
    }

    //checks if a option on screen has been chosen and switches to that if so.
    void SwitchStage()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            if (button == 0)
            {
                SceneManager.LoadScene("Single", LoadSceneMode.Single);
            }
            else if (button == 1)
            {
                SceneManager.LoadScene("2Player", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("Options", LoadSceneMode.Single);
            }
        }
    }
}
