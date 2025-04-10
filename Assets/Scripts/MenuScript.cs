using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] float scaleDif = 1.1f;
    [SerializeField] float lerpAmount;
    Vector2 buttonSize;
    Vector2 buttonSizeLarge;
    [SerializeField] bool isOver;
    void Start()
    {
        buttonSize = transform.localScale;
        buttonSizeLarge = buttonSize * scaleDif;
    }
    public void Over()
    {
        isOver = true;
    }

    public void Exit()
    {
        isOver = false;
    }
    void Update()
    {
        if (isOver)
        {
            transform.localScale = Vector2.Lerp(buttonSizeLarge, transform.localScale, Mathf.Pow(0.5f, lerpAmount * Time.deltaTime));
        }
        else
        {
            transform.localScale = Vector2.Lerp(buttonSize, transform.localScale, Mathf.Pow(0.5f, lerpAmount * Time.deltaTime));
        }
    }
}
