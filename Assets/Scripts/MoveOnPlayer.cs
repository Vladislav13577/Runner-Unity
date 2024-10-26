using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPlayer : MonoBehaviour
{
    private int speed = 4;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        if (!gameManager.stopGame)
        {
            transform .Translate(Vector3.back *speed * Time.deltaTime, Space.World);
        }
        if (transform.position.z <-40)
        {
            Destroy(gameObject);
        }
    }
}
