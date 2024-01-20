using System;
using System.Collections;
using Tobii.Gaming;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GazeAware))]
public class ButtonBehaviour : MonoBehaviour
{
    private GazeAware _gazeAwareComponent;
    private float waitingTime = 2f;
    private GameObject Indicator;


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
        if (GameObject.FindWithTag("Indicator"))
        {
            Indicator = GameObject.FindWithTag("Indicator");
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(kcode))
                {
                    Indicator.SetActive(false);
                }
            }
        }

        if (_gazeAwareComponent.HasGazeFocus)
        {
            if (CompareTag("B_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Joystick4Button1))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Debug.Log("Correct");
                    Destroy(gameObject);
                }
                else if (Input.GetKeyDown(KeyCode.Joystick1Button2) || Input.GetKeyDown(KeyCode.Joystick1Button3) ||
                         Input.GetKeyDown(KeyCode.Joystick1Button0))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            }
            else if (CompareTag("A_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button2))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                }
                else if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button3) ||
                         Input.GetKeyDown(KeyCode.Joystick1Button0))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            }
            else if (CompareTag("X_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button3))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                }
                else if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button2) ||
                         Input.GetKeyDown(KeyCode.Joystick1Button0))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            }
            else if (CompareTag("Y_Button"))
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button0))
                {
                    VirtualInputManager.Instance.winCounter++;
                    Destroy(gameObject);
                }
                else if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button2) ||
                         Input.GetKeyDown(KeyCode.Joystick1Button3))
                {
                    VirtualInputManager.Instance.loseCounter++;
                    Debug.Log("WRONG: " + VirtualInputManager.Instance.loseCounter);
                    Destroy(gameObject);
                }
            }
            else if (CompareTag("Glitch") && (Input.GetKeyDown(KeyCode.Joystick1Button0) ||
                                              Input.GetKeyDown(KeyCode.Joystick1Button1) ||
                                              Input.GetKeyDown(KeyCode.Joystick1Button2) ||
                                              Input.GetKeyDown(KeyCode.Joystick1Button3)))
            {
                VirtualInputManager.Instance.loseCounter = 3;
                Debug.Log("FAILED");
            }
        }

        if (waitingTime >= 1f)
            waitingTime -= 0.001f;
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(waitingTime);
        Destroy(gameObject);
    }
}