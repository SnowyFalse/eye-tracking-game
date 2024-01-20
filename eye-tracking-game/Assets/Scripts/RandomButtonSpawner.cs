using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomButtonSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
   
    public float seconds;
    public Image Indicator;


    private float elapsedSeconds;

    protected void Start()
    {
        StartCoroutine(ShowIndicator());

    }

    protected void Update()
    {
        
        foreach(KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                Destroy(Indicator);
                StopCoroutine(ShowIndicator());
            }
        }
        
        elapsedSeconds += Time.deltaTime;
        if (elapsedSeconds >= seconds)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            
            Vector2 randomPos = new Vector2(Random.Range(-2.3f, 2.3f), Random.Range(-3.5f, 3.7f));
            Instantiate(myObjects[randomIndex], randomPos, Quaternion.identity);
            
            elapsedSeconds = 0;
            if(seconds >= 0.25)
                seconds -= 0.01f;
        }
    }
    
    IEnumerator ShowIndicator()
    {
        yield return new WaitForSeconds(10); 
        if(Indicator) 
            Indicator.gameObject.SetActive(true);
    }
}
