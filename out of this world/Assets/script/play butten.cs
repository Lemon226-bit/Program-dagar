using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutten : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Play()
    {
        SceneManager.LoadSceneAsync("scene till månen");
    }
    public void buyui()
    {
        SceneManager.LoadSceneAsync("buyui");
    }
    public void startui()
    {
        SceneManager.LoadSceneAsync("start ui");
    }

}
