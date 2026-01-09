using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public int money = 0;

    public float moneyInterval = 10f;
    public int moneyPerInterval = 1;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= moneyInterval)
        {
            money += moneyPerInterval;
            timer -= moneyInterval;
        }
    }
}
