using TMPro;
using UnityEngine;


public class moneyschript : MonoBehaviour
{
    public static moneyschript original;
    public int moneylevel;
    float tid;
    public int money = 0;
    public TextMeshProUGUI Mcounter;
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
        tid = Time.deltaTime;
        if ()
        {

            if (tid <= 20000000000)
            {
                money++;
                int hundra = Mathf.RoundToInt(tid / 60);
                int ental = Mathf.RoundToInt(tid % 60);
                Mcounter.text = string.Format("{0:00}:{1:00}", hundra, ental);
                tid = 0;
            }
        }
        else ()
        {

        }
    }


}
