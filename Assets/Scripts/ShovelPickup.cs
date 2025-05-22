using UnityEngine;

public class ShovelPickup : MonoBehaviour
{
    public Transform playerHand;
    public Interactable interactable;

    void Start()
    {
        interactable.onInteract = () =>
        {
            transform.SetParent(playerHand);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        };
    }
}
