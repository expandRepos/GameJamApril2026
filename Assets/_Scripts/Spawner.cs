using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(CircleCollider2D))]
public class Spawner : MonoBehaviour
{

    private CircleCollider2D spawnArea;
    public GameObject prefabToSpawn;
    public List<GameObject> dropList = new List<GameObject>();
    public float spawnTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnArea = GetComponent<CircleCollider2D>();
        InvokeRepeating("SpawnObjects", 2f, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnObjects()
    {
        Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * spawnArea.radius;

        int randomIndex = Random.Range(0, dropList.Count);
        GameObject randomPrefab = dropList[randomIndex];

        Instantiate(randomPrefab, spawnPosition, Quaternion.identity);
        Debug.Log("Spawn)");
    }
}
