using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moneyschript : MonoBehaviour
{
    public PlayerStats moeny;

    public static Moneyschript original;
    [SerializeField] PlayerStats playerStats;
    public GameObject fixheath;


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
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            money += tid;
            int minutes = Mathf.RoundToInt(tid / 60);
            int sek = Mathf.RoundToInt(tid % 60);
            Mcounter.text = string.Format("{0:00}:{1:00}", minutes, sek);
            tid = 0;
        }




    }
}
