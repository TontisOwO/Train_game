using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float interactRange = 2f;
    public Transform player;
    public InteractionUI interactionUI;

    public System.Action onInteract;

    private bool hasInteracted = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < interactRange && !hasInteracted)
        {
            interactionUI.Show();

            if (Input.GetKeyDown(KeyCode.E))
            {
                onInteract?.Invoke();
                hasInteracted = true;
                interactionUI.Hide();
            }
        }
        else
        {
            if (!hasInteracted)
                interactionUI.Hide();
        }
    }
}
