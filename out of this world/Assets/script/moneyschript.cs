using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class moneyschript : MonoBehaviour
{
    public static moneyschript original;
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

        }
    }
    public void Counter()
    {

    }


}
