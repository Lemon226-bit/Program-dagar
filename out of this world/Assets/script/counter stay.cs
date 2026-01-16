using UnityEngine;
using UnityEngine.SceneManagement;

public class counterstay : MonoBehaviour
{
    PlayerStats playerStats;
    public GameObject Playermoney;
    public static counterstay original;
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
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {

        }
    }

}
