using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moneyschript : MonoBehaviour
{
    public PlayerStats moeny;

    public static Moneyschript original;
    [SerializeField] PlayerStats playerStats;
    public GameObject fixheath;

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
        Debug.Log(playerStats.moneyPerInterval);
    }

    // Update is called once per frame
    void Update()
    {
        tid = Time.deltaTime;

        money += tid;
        tid = 0;
        Mcounter.text = Convert.ToString(money);

        /*

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            money += tid;
            tid = 0;
            int minutes = Mathf.RoundToInt(tid / 60);
            int sek = Mathf.RoundToInt(tid % 60);
            Mcounter.text = Convert.ToString(money);

        }
        */
    }
}
