using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CautionKey : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        this.text.color = Color.Lerp(this.text.color, Color.clear, Time.deltaTime);
    }

    public void Flash()
    {
        this.text.color = new Color(1f, 1f, 1f, 0.5f);
    }


}
