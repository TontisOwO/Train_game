using UnityEngine;

public class LockerHiding : MonoBehaviour
{
    public GameObject blackScreen;
    public PlayerMovement playerMovement;
    public MonoBehaviour playerMovementScript; // to disable movement script

    private bool isHidden = false;

    void Start()
    {
        Interactable interactable = GetComponent<Interactable>();

        interactable.onInteract = () =>
        {
            if (!isHidden)
            {
                blackScreen.SetActive(true);
                playerMovementScript.enabled = false;
                playerMovement.isHiding = true;
                isHidden = true;
            }
            else
            {
                blackScreen.SetActive(false);
                playerMovementScript.enabled = true;
                playerMovement.isHiding = false;
                isHidden = false;
            }
        };
    }
}
