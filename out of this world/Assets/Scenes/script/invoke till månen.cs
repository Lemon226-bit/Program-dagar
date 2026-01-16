using UnityEngine;
using UnityEngine.SceneManagement;

public class invoketillmånen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ChangeToNewGame2", 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeToNewGame2()
    {
        SceneManager.LoadScene("maingame");
    }
}
