using UnityEngine;



public class PlayerHitSound : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip[] scrapSounds;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Scrap") && scrapSounds.Length > 0)
        {
            AudioClip clip = scrapSounds[Random.Range(0, scrapSounds.Length)];
            audioSource.PlayOneShot(clip);
        }



    }
}   