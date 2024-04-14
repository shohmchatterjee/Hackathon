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
}
