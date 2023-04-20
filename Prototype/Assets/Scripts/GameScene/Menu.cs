using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    GameObject menu; // メニューのオブジェクト
    bool menuFlg; // メニューが表示されているかされていないか(trueはされてる、falseはされてない)

    void Start()
    {
        menu = GameObject.Find("Menu"); // メニューのゲームオブジェクトをヒエラルキーから見つける
        menu.SetActive(false); // メニューをfalse(最初はメニュー画面を見えないように)
        menuFlg = false; // メニューのフラグ
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Escに押したら
        {
            if (menuFlg) // メニューが表示されてたら
            {
                menu.SetActive(false); // メニューを消す
                menuFlg = false; // メニューのフラグをfalse
                Time.timeScale = 1; // ゲームを再生
            }
            else // メニューが非表示だったら
            {
                menu.SetActive(true); // メニューを表示
                menuFlg = true; // メニューのフラグをtrue
                Time.timeScale = 0; // ゲームをポーズ
            }
        }
    }

}
