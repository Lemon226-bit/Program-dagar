using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moneyschript : MonoBehaviour
{
    public PlayerStats moeny;
    public static Moneyschript original;
    public PlayerStats playerStats;
    public GameObject Playermoney;

    public int moneylevel;
    float tid;
    public float money = 0;
    public TextMeshProUGUI Mcounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerStats = Playermoney.GetComponent<PlayerStats>();
    }



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