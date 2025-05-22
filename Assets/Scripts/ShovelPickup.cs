using UnityEngine;

public class ShovelPickup : MonoBehaviour
{
    public Transform playerHand;
    private Interactable interactable;

    void Start()
    {
        interactable = GetComponent<Interactable>();

        interactable.onInteract = () =>
        {
            transform.SetParent(playerHand);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            interactable.enabled = false;
        };
    }
}
