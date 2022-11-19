using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    private int lives = 3;
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            lives = 0;
            Debug.Log("Game Over");
            Destroy(playerPrefab);
        }
        Debug.Log("Lives: " + lives);
    }

    public void Score(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}
