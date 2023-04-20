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
        text = GetComponent<Text>(); // �����̃Q�[���I�u�W�F�N�g������
    }

    void Update()
    {
        
        text.color = GetAlphaColor(text.color); // �e�L�X�g�̐F��GetAlphaColor���玝���Ă���
    }

    //Alpha�l���X�V����Color��Ԃ�
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
