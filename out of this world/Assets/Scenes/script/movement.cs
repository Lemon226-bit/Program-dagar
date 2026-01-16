using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public PlayerStats playerstats;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerstats = FindFirstObjectByType<PlayerStats>();
        animator = GetComponent<Animator>();

        playerstats.baseHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x + -4, rb.linearVelocity.y);

        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x + 4, rb.linearVelocity.y);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y + 4);

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y + -4);

        }
        if ((transform.position.x <= -2.5))
        {
            transform.position = new Vector2(2.4f, -4.28f);

        }
        if ((transform.position.x >= 2.5))
        {
            transform.position = new Vector2(-2.4f, -4.28f);

        }
        if (((transform.position.y >= 5)))
        {
            transform.position = new Vector2(-2.4f, -5);
        }


        if (playerstats.baseHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadSceneAsync("gameover");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            playerstats.baseHealth -= 1;
        }
    }
}
