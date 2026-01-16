using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    Rigidbody2D enemy;
    Collider2D collision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();
    }
    public GameObject asteroid;
    public GameObject scrap1;
    public GameObject scrap2;
    public GameObject scrap3;
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Vector2 spawnlocation = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(8, 16));
            int rand = Random.Range(1, 5);
            if (rand == 1)
            {
                Instantiate(asteroid, spawnlocation, Quaternion.identity);
                timer = 0;
                Debug.Log("Spawned asteroid");
            }
            if (rand == 2)
            {
                Instantiate(scrap1, spawnlocation, Quaternion.identity);
                timer = 0;
                Debug.Log("Spawned scrap 1");
            }
            if (rand == 3)
            {
                Instantiate(scrap2, spawnlocation, Quaternion.identity);
                timer = 0;
                Debug.Log("Spawned scrap 2");
            }
            if (rand == 1)
            {
                Instantiate(scrap3, spawnlocation, Quaternion.identity);
                timer = 0;
                Debug.Log("Spawned scrap 3");
            }
        }


    }


}
