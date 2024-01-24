using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Joystick1Button0 ? Y
 * Joystick1Button1 ? B
 * Joystick1Button2 ? A
 * Joystick1Button3 ? X
 */

/*
 * Joystick1Button0 ? A
 * Joystick1Button1 ? B
 * Joystick1Button2 ? X
 * Joystick1Button3 ? Y
 */
public class StartGame : MonoBehaviour
{
    private bool easyGame = true;
    private bool hardGame = false;

    public Image SelectEasy;
    public Image SelectHard;
    
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                Debug.Log("Key: " + kcode);
            }
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            SetHardGame();
            Debug.Log("Hard game mode");
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            SetEasyGame();
            Debug.Log("Easy game mode");
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            StartMain();

        if (easyGame)
        {
            SelectEasy.gameObject.SetActive(true);
            SelectHard.gameObject.SetActive(false);
        }

        if (hardGame)
        {
            SelectEasy.gameObject.SetActive(false);
            SelectHard.gameObject.SetActive(true);
        }
       
    }

    public void SetEasyGame()
    {
        easyGame = true;
        hardGame = false;
    }
    
    public void SetHardGame()
    {
        easyGame = false;
        hardGame = true;
    }

    public void StartMain()
    {
        if (easyGame)
        {
            SceneManager.LoadScene("Gameplay_easy");
        }
        else
        {
            SceneManager.LoadScene("Gameplay_hard");
        }
    }
}
