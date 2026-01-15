using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    float elapsedTime = 0f;
    float victoryTime = 180f;


    void Start()
    {
        //if (elapsedTime == 0)
        //{
          //  SceneManager.LoadScene("scene till månen");
        //}
;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= victoryTime)
        {
            SceneManager.LoadScene("scene på månen");
           
 

        }


    }



   

















}
    




        
        
    

