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
    }

    // Update is called once per frame
    void Update()
    {

        if (_gazeAwareComponent.HasGazeFocus)
        {
            Debug.Log("Works");
        }
        
        if (CompareTag("B_Button") && Input.GetKeyDown(KeyCode.B))
        {
            Destroy(gameObject);
        } else if (CompareTag("A_Button") && Input.GetKeyDown(KeyCode.A))
        {
            Destroy(gameObject);
        } else if (CompareTag("Glitch") && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B)))
        {
            Debug.Log("FAILED");
        }
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log("Kinda Works");
        if (CompareTag("Gaze_Point"))
        {
            Debug.Log("Works");
        }
    }
}
