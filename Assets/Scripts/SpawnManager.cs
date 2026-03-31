using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    void Start()
    {
        //InvokeRepeating(nameof (RandomSpawn),0,5);
        StartCoroutine(SpawnRoutine());
    }
    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[index];
        Instantiate(enemyPrefab, spawnPoint.position,Quaternion.identity);
    }
   IEnumerator SpawnRoutine()
    {
            yield return new WaitForSeconds(5);
        while (true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(3);
        }
    }
    IEnumerator Goodbye()
    {
        while (true)
        {
            Debug.Log("Bye" + Time.frameCount + "" + Time.time);
           //yield return new WaitForSeconds(1);
           yield return null;
           //StartCoroutine(Hello());
           yield return Hello();
        }
    }
     
    IEnumerator Hello()
    {
        Debug.Log("Hello" + Time.frameCount);
        Debug.Log("Hello" + Time.frameCount);
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
    }
}
