using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private bool easyGame = true;
    private bool hardGame = false;

    public Image SelectEasy;
    public Image SelectHard;
    
    public Button button_easy;
    public Button button_hard;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        
        if(Input.GetKeyDown(KeyCode.X)) {
     
            //Invoke the button's onClick event.
            button_easy.onClick.Invoke();
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
