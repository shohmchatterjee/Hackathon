using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreboard;
    public GameObject gameOverScreen;

    [SerializeField] private List<string> _sceneList;

    [ContextMenu("Increase Score")]
    public void Score()
    {
        score = score + 1;
        scoreboard.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void nextLevel(){
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene < _sceneList.Count)
            SceneManager.LoadScene(_sceneList[currentScene + 1]);
        else
            gameOver();
    }
}
