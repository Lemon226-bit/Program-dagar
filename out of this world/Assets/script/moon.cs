using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
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



    void Start()
    {


    }

















}
    




        
        
    

