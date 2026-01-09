using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutten : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void start()
    {
        SceneManager.LoadSceneAsync("maingame");
    }
}
