using UnityEngine;

public class ShovelScript : MonoBehaviour
{
    [SerializeField] int ShovelDamage = 10;
    [SerializeField] float ShovelCooldown = 1.0f; // Cooldown duration in seconds
    [SerializeField] private AudioSource hitAudio; // Sound for hitting an enemy
    [SerializeField] private AudioSource swingAudio; // Sound for swinging
    [SerializeField] private Animator animator; // Reference to Animator
    [SerializeField] float attackRange = 1.5f; // Attack distance
    [SerializeField] LayerMask enemyLayer; // Layer to detect enemies

    private float nextAttackTime = 0f; // Timer to track cooldown

    void Start()
    {
        // Ensure AudioSources and Animator are correctly assigned
        if (hitAudio == null || swingAudio == null)
        {
            Debug.LogWarning("AudioSources are not assigned in the Inspector!");
        }

        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime) // Left mouse click + cooldown check
        {
            Attack();
            nextAttackTime = Time.time + ShovelCooldown; // Set next attack time
        }
    }

    void Attack()
    {
        // Play the shovel attack animation
        animator.Play("SwingAnimation"); // Replace with actual animation name

        // Perform Raycast from player's position forward
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange, enemyLayer))
        {
            if (hit.collider.CompareTag("Enemy")) // Check if it hit an enemy
            {
                // Play hit sound
                if (hitAudio != null) hitAudio.Play();

                // Inflict damage (uncomment when using enemy health)
                // EnemyHealth enemy = hit.collider.GetComponent<EnemyHealth>();
                // if (enemy != null)
                // {
                //     enemy.TakeDamage(ShovelDamage); // Inflict damage
                // }

                return; // Exit function, preventing swing sound when hitting an enemy
            }
        }

        // If no enemy was hit, play the swing sound
        if (swingAudio != null) swingAudio.Play();
    }
}
