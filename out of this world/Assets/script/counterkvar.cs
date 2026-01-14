using UnityEngine;

public class counterkvar : MonoBehaviour
{
    public static counterkvar original;
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

    }
}
