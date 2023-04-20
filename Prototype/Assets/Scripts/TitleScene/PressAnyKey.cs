using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyKey : MonoBehaviour
{
    // Private
    Text text;
    float time;

    // Public
    public float speed = 1.0f;

    void Start()
    {
        text = GetComponent<Text>(); // 自分のゲームオブジェクトを持つ
    }

    void Update()
    {
        
        text.color = GetAlphaColor(text.color); // テキストの色をGetAlphaColorから持ってくる
    }

    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
