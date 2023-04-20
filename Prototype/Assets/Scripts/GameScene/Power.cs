using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    Text powerText;
    CharacterController player;

    
    // Start is called before the first frame update
    void Start()
    {
        powerText = GameObject.Find("PowerText").GetComponent<Text>();
        player = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        powerText.text = player.GetPower().ToString();
    }
}
