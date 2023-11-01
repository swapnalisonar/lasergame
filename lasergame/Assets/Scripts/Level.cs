using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    [SerializeField] float dealyInSeconds = 2f;

    public void LoadStarMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
        
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
        
    }
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(dealyInSeconds);
        SceneManager.LoadScene("Game Over");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
