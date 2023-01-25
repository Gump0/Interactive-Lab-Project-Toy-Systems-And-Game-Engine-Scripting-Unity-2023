using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] stars;
    public GameObject bomb;

    public float xBounds, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

  IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1,2));

        int randomStar = Random.Range(0, stars.Length);

        if(Random.value <= 10f)
            Instantiate(stars[randomStar],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        else
            Instantiate(bomb,
            new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }
    
}
