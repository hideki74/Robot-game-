using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    bool isGameOver;
    [SerializeField] GameOverText gameOverText;

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && Input.anyKeyDown)
        {
            // Playシーンをロードする
            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            GameOverFlg();
        }
    }

    public void GameOverFlg()
    {
        isGameOver = true;
    }
}
