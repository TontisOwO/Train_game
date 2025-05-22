using UnityEngine;

public class InteractionUI : MonoBehaviour
{
    public GameObject promptObject;

    void Awake()
    {
        Hide();
    }

    public void Show()
    {
        promptObject.SetActive(true);
    }

    public void Hide()
    {
        promptObject.SetActive(false);
    }
}
