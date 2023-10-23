using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 9;
    public GameObject enemyPrefab;
    public int enemyCount;
    public int waveNumber = 0;
    public GameObject powerupPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnStartUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        SpawnStartUpdate();
    }

    private void SpawnStartUpdate()
    {        
        if (enemyCount == 0)
        {
            Debug.Log("Level: " + waveNumber);
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(),
                powerupPrefab.transform.rotation);
            waveNumber++;
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i<enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(),
                enemyPrefab.transform.rotation);
        }
    }
}
