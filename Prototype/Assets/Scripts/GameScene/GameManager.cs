using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool normal = false;
    bool arms = false;
    bool legs = false;
    bool drill = false;
    bool gameOver = false;
    bool key = false;
    bool gameClear = false;
    public GameObject keyImage;
    public GameObject keyText;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        normal = true;
        keyImage.SetActive(false);
    }

    public void Normal()
    {
        normal = true;
        arms = false;
        legs = false;
        drill = false;
    }

    public void Arms()
    {
        normal = false;
        arms = true;
        legs = false;
        drill = false;
    }

    public void Legs()
    {
        normal = false;
        arms = false;
        legs = true;
        drill = false;
    }

    public void Drill()
    {
        normal = false;
        arms = false;
        legs = false;
        drill = true;
    }

    public void Door()
    {
        gameClear = true;
    }

    public void OutDoor()
    {
        gameClear = false;
    }

    public void EarnKey()
    {
        key = true;
        keyImage.SetActive(true);
    }

    private void Update()
    {
        if (gameClear && key)
        {
            SceneManager.LoadScene(2);
        }
        else if (gameClear)
        {
           
        }
    }
}
