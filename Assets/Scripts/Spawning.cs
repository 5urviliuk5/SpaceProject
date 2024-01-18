using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 2f;
    private Vector3 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(EnemiesWave());
    }

    void SpawnEnemy()
    {
        GameObject en = Instantiate(enemyPrefab) as GameObject;
        en.transform.position = new Vector3(screenBounds.x * 1.5f, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator EnemiesWave()
    { 
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}
