using TMPro;
using UnityEngine;

public class timer1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float tid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tid += Time.deltaTime;
        int minutes = Mathf.RoundToInt(tid / 60);
        int sek = Mathf.RoundToInt(tid % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, sek);

    }
}

