using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {

        if (CompareTag("B_Button") && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("SUCCESS");
            Destroy(gameObject);
        } else if (CompareTag("A_Button") && Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("SUCCESS");
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
}
