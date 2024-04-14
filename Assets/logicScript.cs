using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreboard;

    [ContextMenu("Increase Score")]
    public void Score()
    {
        score = score + 1;
        scoreboard.text = score.ToString();
    }
}
