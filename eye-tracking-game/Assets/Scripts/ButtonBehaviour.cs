using System.Collections;
using Tobii.Gaming;
using UnityEngine;

[RequireComponent(typeof(GazeAware))]
public class ButtonBehaviour : MonoBehaviour
{
    private GazeAware _gazeAwareComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SelfDestruct());
        _gazeAwareComponent = GetComponent<GazeAware>();
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {

        if (_gazeAwareComponent.HasGazeFocus)
        {
            if (CompareTag("B_Button"))
            {
                if (Input.GetKeyDown(KeyCode.B))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Debug.Log("Correct");
                    Destroy(gameObject);
                } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Y))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            } else if (CompareTag("A_Button"))
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                } else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Y))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            } else if (CompareTag("X_Button"))
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                } else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Y))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            } else if (CompareTag("Y_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                } else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.A))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }

            } else if (CompareTag("Glitch") && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B)|| Input.GetKeyDown(KeyCode.X)|| Input.GetKeyDown(KeyCode.Y)))
            {
                VirtualInputManager.Instance.loseCounter = 3;
                Debug.Log("FAILED");
            }
        }
        
        
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    // private void OnCollisionEnter2D(Collision2D c)
    // {
    //     if (CompareTag("Gaze_Point"))
    //     {
    //         Debug.Log("Works");
    //     }
    // }
}
