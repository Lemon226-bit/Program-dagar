using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public class TimerToVictory : MonoBehaviour
    {
        float elapsedTime = 0f;
        float victoryTime = 30f; 

        void Update()
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= victoryTime)
            {
                SceneManager.LoadScene("scene på månen");
               
            }
        }
    }
}
