using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {
    int score = 0;

    public int Length { get; private set; }

    private void Awake()
    {
        SetUpSingletone();
    }
    private void SetUpSingletone()
    {
        int numberGameSession = FindObjectOfType<GameSession>().Length;
        if(numberGameSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    public int GetScore()
    {
        return score;
    }
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame

}
