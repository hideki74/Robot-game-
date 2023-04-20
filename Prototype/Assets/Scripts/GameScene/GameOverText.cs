using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    Text gameOver;
    Text description;
    GameOver gameover;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("GameOverText").GetComponent<Text>();
        description = GameObject.Find("description").GetComponent<Text>();
        gameOver.text = "";
        description.text = "";
    }

    public void ChangeText()
    {
        gameOver.text = "GAME OVER";
        description.text = "PRESS ANY KEY TO TRY AGAIN";
    }
}
