using UnityEngine;

public class ShowelScript : MonoBehaviour
{
    [SerializeField] int ShowelDamage;
    [SerializeField] float ShowelCooldown = 1.0f; // Cooldown duration in seconds
    [SerializeField] private AudioSource showelAudio; // Reference to AudioSource

    private float nextAttackTime = 0f; // Timer to track cooldown

    void Start()
    {
        if (showelAudio == null)
        {
            showelAudio = GetComponent<AudioSource>(); // Get the AudioSource component
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime) // Left mouse click + cooldown check
        {
            PlaySound();
            nextAttackTime = Time.time + ShowelCooldown; // Set next attack time
        }
    }

    void PlaySound()
    {
        if (showelAudio != null)
        {
            showelAudio.Play(); // Play weapon sound
        }
        else
        {
            Debug.LogWarning("No AudioSource assigned to ShowelScript.");
        }
    }
}
