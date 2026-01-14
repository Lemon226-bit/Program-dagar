using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moneyschript : MonoBehaviour
{
    public static Moneyschript original;
    public PlayerStats playerStats;
    public int moneylevel;
    float tid;
    public float money = 0;
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

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            money += tid;
            tid = 0;
            Mcounter.text = Convert.ToString(money);
        }
    }
}

