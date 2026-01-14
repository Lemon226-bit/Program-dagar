using UnityEngine;

public class LivBarAnimator : MonoBehaviour
{
    Animator animator;
    public PlayerStats playerstats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerstats = FindFirstObjectByType<PlayerStats>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerstats.baseHealth == 2)
        {
            animator.SetBool("stage2", true);
        }
        if (playerstats.baseHealth == 1)
        {
            animator.SetBool("stage2", false);
            animator.SetBool("stage3", true);
        }

    }
}
