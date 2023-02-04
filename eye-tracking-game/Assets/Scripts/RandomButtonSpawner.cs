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
            Debug.Log("TEST");
            
            Vector2 randomPos = new Vector2(Random.Range(-7, 7), Random.Range(-4, 4));
            
            Instantiate(myObjects[randomIndex], randomPos, Quaternion.identity);
            elapsedSeconds = 0;
        }
    }
    
    // IEnumerator SpawnButton()
    // {
    //     int randomIndex = Random.Range(0, myObjects.Length);
    //     Debug.Log("TEST");
    //     Vector2 randomPos = new Vector2(Random.Range(-7, 7), Random.Range(-4, 4));
    //
    //     Instantiate(myObjects[randomIndex], randomPos, Quaternion.identity);
    // }
}
