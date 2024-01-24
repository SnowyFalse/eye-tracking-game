using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Start");
    }
}
