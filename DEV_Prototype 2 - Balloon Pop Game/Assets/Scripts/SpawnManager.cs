using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public int balloonIndex;

    public float xSpawnRange;
    public float ySpawnPos;

    private float startDelay = 0.5f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }
    void SpawnRandomBalloon()
    {
        // Spawn balloons at random positions across the x-axis and y-position
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos, 0);
        //Pick random balloon prefab from array to spawn
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        //Create New Random Balloon
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
