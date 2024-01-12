using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private bool easyGame = true;

    private bool hardGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
