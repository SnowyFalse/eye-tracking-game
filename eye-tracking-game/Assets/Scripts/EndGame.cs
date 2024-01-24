using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


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
        if(Input.GetKeyDown(KeyCode.Joystick1Button1)) {
     
            SceneManager.LoadScene("Start");
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Start");
    }
}
