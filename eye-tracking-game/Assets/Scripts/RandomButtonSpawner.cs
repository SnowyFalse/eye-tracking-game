using UnityEngine;

public class RandomButtonSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    // Start is called before the first frame update
   
    public float seconds;

    private float elapsedSeconds;

    
    protected void Update()
    {
        elapsedSeconds += Time.deltaTime;
        if (elapsedSeconds >= seconds)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            
            Vector2 randomPos = new Vector2(Random.Range(-2, 2), Random.Range(-4.3f, 4.3f));
            Instantiate(myObjects[randomIndex], randomPos, Quaternion.identity);
            
            elapsedSeconds = 0;
            if(seconds >= 0.25)
                seconds -= 0.01f;
        }
        Debug.Log("Seconds: "+ seconds);
    }
}
