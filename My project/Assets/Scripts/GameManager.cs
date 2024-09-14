using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int round = 0;
    public int enemies = 0;
    public GameObject enemyPrefab;
    public GameObject[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies<=0){
            round++;
            Next(round);
        }
    }
    public void Next(int r)
    {
        for (int x = 0; x < r; x++)
        {

            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);

            enemies++;

        }
    }
}
