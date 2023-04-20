using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    GameObject menu; // ���j���[�̃I�u�W�F�N�g
    bool menuFlg; // ���j���[���\������Ă��邩����Ă��Ȃ���(true�͂���Ă�Afalse�͂���ĂȂ�)

    void Start()
    {
        menu = GameObject.Find("Menu"); // ���j���[�̃Q�[���I�u�W�F�N�g���q�G�����L�[���猩����
        menu.SetActive(false); // ���j���[��false(�ŏ��̓��j���[��ʂ������Ȃ��悤��)
        menuFlg = false; // ���j���[�̃t���O
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Esc�ɉ�������
        {
            if (menuFlg) // ���j���[���\������Ă���
            {
                menu.SetActive(false); // ���j���[������
                menuFlg = false; // ���j���[�̃t���O��false
                Time.timeScale = 1; // �Q�[�����Đ�
            }
            else // ���j���[����\����������
            {
                menu.SetActive(true); // ���j���[��\��
                menuFlg = true; // ���j���[�̃t���O��true
                Time.timeScale = 0; // �Q�[�����|�[�Y
            }
        }
    }

}
