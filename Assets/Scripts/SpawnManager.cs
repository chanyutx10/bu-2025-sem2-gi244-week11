
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    void Start()
    {
        // InvokeRepeating(nameof(RandomSpawn), 0, 5f);
        //StartCoroutine(Hello());
        StartCoroutine(SpawnRoutine());
    }

   

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(5);

        while (true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(1);

        }
    }

    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[index];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }







  //IEnumerator Hello()
    //
     // Debug.Log("Hello" + Time.frameCount);
    //  yield return null;
   //

}
