using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private Vector3 spawnPos;
    private float offset = 1.2f;
    private int lineIndex;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("Spawner", 0, 2);
    }

    void Spawner()
    {
        if (!gameManager.stopGame)
        {
            lineIndex = Random.Range(0,4);
            spawnPos = new Vector3(-1.8f + (offset * lineIndex), 0.5f, 50);
            int i = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[i], spawnPos, obstacles[i].transform.rotation);
        }
    }

}
