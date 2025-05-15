using UnityEngine;

public class ShowelScript : MonoBehaviour
{
    [SerializeField] int ShowelDamage = 10;
    [SerializeField] float ShowelCooldown = 1.0f; // Cooldown duration in seconds
    [SerializeField] private AudioSource showelAudio; // Reference to AudioSource
    [SerializeField] private Animator animator; // Reference to Animator
    [SerializeField] float attackRange = 1.5f; // Attack distance
    [SerializeField] LayerMask enemyLayer; // Layer to detect enemies

    private float nextAttackTime = 0f; // Timer to track cooldown

    void Start()
    {
        // Ensure AudioSource and Animator are correctly assigned
        if (showelAudio == null)
        {
            showelAudio = GetComponent<AudioSource>();
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
            nextAttackTime = Time.time + ShowelCooldown; // Set next attack time
        }
    }

    void Attack()
    {
        PlaySound();

        // Play the shovel attack animation
        animator.Play("SwingAnimation");  // Replace "ShowelAttack" with the actual animation name

        // Perform Raycast from player's position forward
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange, enemyLayer))
        {
            if (hit.collider.CompareTag("Enemy")) // Check if it hit an enemy
            {
                //EnemyHealth enemy = hit.collider.GetComponent<EnemyHealth>();
                //if (enemy != null)
                //{
                //    enemy.TakeDamage(ShowelDamage); // Inflict damage
                //}
            }
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
