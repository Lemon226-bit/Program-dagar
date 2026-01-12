using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    Rigidbody2D enemyrigidbody;
    Collider2D enemycollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Asteroid;
    public GameObject Scrap;
    void Start()
    {
        enemyrigidbody = GetComponent<Rigidbody2D>();
        enemyrigidbody.linearVelocity = new Vector2(0, -3);

        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnlocation = new Vector2(Random.Range(-7, 7), Random.Range(8, 16));
            Instantiate(Asteroid, spawnlocation,Quaternion.identity);
        }

        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnlocation = new Vector2(Random.Range(-7, 7), Random.Range(8, 16));
            Instantiate(Scrap, spawnlocation, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            float randomXposition = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector2(randomXposition, 7);

            if (enemyrigidbody.linearVelocity.y > -10)
            {
                enemyrigidbody.linearVelocity += new Vector2(0, -0.5f);
            }
        }
    }
}
