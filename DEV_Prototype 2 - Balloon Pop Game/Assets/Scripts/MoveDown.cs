using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = -10;
    public ScoreManager scoreManager; // A variable reference to the scoremanagement component
    public Balloon balloon; // referenc balloon script to get score


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-moveSpeed * Time.deltaTime, 0);

        if(transform.position.y < lowerBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
