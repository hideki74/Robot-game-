using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    // Private
    Rigidbody2D rigidbody;
    Vector2 movingDirecion;
    bool isGround;
    int upForce;
    SpriteRenderer spriteRenderer;
    Text powerUpName;
    GameManager gameManager;
    int power;
    GameOver gameOver;

    // Public
    public float speedMagnification = 1.0f; //調整必要　例10
    public Vector2 movingVelocity;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        powerUpName = GameObject.Find("PowerUp").GetComponent<Text>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        upForce = 300;
        powerUpName.text = "通常";
        power = 100;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        movingDirecion = new Vector2(x, y);
        movingDirecion.Normalize(); // 斜めの距離が長くなるのを防ぎます
        movingVelocity = movingDirecion * speedMagnification;

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
            rigidbody.AddForce(new Vector3(0, upForce, 0));

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameManager.Arms();
            powerUpName.text = "アーム";
            spriteRenderer.color = Color.green;
            upForce = 0;
            speedMagnification = 5;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameManager.Normal();
            powerUpName.text = "通常";
            spriteRenderer.color = Color.white;
            upForce = 300;
            speedMagnification = 7;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameManager.Legs();
            powerUpName.text = "足";
            spriteRenderer.color = Color.yellow;
            upForce = 450;
            speedMagnification = 5;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameManager.Drill();
            powerUpName.text = "ドリル";
            spriteRenderer.color = Color.blue;
            upForce = 0;
            speedMagnification = 5;
        }



    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(movingVelocity.x, rigidbody.velocity.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            Debug.Log("ground");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) isGround = false;
    }

    public int GetPower()
    {
        return power;
    }

    public void DecreasePower(int decrease)
    {
        power -= decrease;

        if(power <= 0)
        {
            gameOver.GameOverFlg();
        }
    }
}