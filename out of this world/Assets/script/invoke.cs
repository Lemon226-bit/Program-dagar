using UnityEngine;
using UnityEngine.SceneManagement;

public class invoke : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("ChangeToNewGame", 9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeToNewGame()
    {
        SceneManager.LoadScene("end game scene");
    }
}
