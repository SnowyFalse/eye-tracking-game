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
        if(Input.GetKeyDown(KeyCode.X)) {
     
            //Invoke the button's onClick event.
            startButton.onClick.Invoke();
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Start");
    }
}
