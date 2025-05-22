using UnityEngine;
using UnityEngine.UI;

public class InteractionUI : MonoBehaviour
{
    public GameObject promptObject;
    public string message = "Press E to interact";
    public Text promptText;

    void Awake()
    {
        Hide();
    }

    public void Show(string customMessage = "")
    {
        if (!string.IsNullOrEmpty(customMessage))
            promptText.text = customMessage;
        else
            promptText.text = message;

        promptObject.SetActive(true);
    }

    public void Hide()
    {
        promptObject.SetActive(false);
    }
}
