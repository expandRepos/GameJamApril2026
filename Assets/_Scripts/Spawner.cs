using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public Collider2D spawnArea;
    public GameObject prefabToSpawn;
    public List<GameObject> dropList = new List<GameObject>();
    public float spawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObjects", 2f, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnObjects()
    {
        Bounds bounds = spawnArea.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        
        Vector2 spawnPos = new Vector2(x,y);
        int randomIndex = Random.Range(0, dropList.Count);
        GameObject randomPrefab = dropList[randomIndex];
        Instantiate(randomPrefab,spawnPos, Quaternion.identity);
        Debug.Log("Spawn)");
    }
}
