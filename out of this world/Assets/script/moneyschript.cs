using UnityEngine;

public class moneyschript : MonoBehaviour
{
    public static moneyschript original;
    public int moneylevel;
    float tid;
    int money = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (original != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            original = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        tid += Time.deltaTime;

        if (tid < 10)
        {
            money++;
            tid = 0;
        }
    }


}
