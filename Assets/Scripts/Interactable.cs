using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Transform player;
    public InteractionUI interactionUI;

    public float interactRange = 2f;
    public System.Action onInteract;

    private bool isPlayerInRange = false;

    void Update()
    {
        if (player == null || interactionUI == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < interactRange)
        {
            if (!isPlayerInRange)
            {
                interactionUI.Show();
                isPlayerInRange = true;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                onInteract?.Invoke();
                interactionUI.Hide();
                isPlayerInRange = false;
            }
        }
        else
        {
            if (isPlayerInRange)
            {
                interactionUI.Hide();
                isPlayerInRange = false;
            }
        }
    }
}
