using System.Collections;
using System.Collections.Generic;
using Tobii.Gaming;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    private GazeAware _gazeAwareComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        _gazeAwareComponent = GetComponent<GazeAware>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (_gazeAwareComponent.HasGazeFocus)
        {
            Debug.Log("Works");
        }
    }
    
    // private void OnCollisionEnter2D(Collision2D c)
    // {
    //     Debug.Log("Kinda Works");
    //     if (CompareTag("Gaze_Point"))
    //     {
    //         Debug.Log("Works");
    //     }
    // }
}
