using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(1); // anyKey‚ğ‰Ÿ‚µ‚½‚ç1‚ğƒ[ƒh
        }
    }
}
