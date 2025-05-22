using UnityEngine;

public class MenuOpen : MonoBehaviour
{
    Vector2 startPos;
    Vector2 endPos = new Vector2(960, 540);
    [SerializeField] float lerpAmount = 10;
    [SerializeField] bool open;
    void Awake()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (open)
        {
            transform.position = Vector2.Lerp(endPos, transform.position, Mathf.Pow(0.5f,lerpAmount * Time.deltaTime));
        }
        else
        {
            transform.position = Vector2.Lerp(startPos, transform.position, Mathf.Pow(0.5f, lerpAmount * Time.deltaTime));
        }
    }
    
    public void Open()
    {
        open = true;
    }
    
    public void Close() 
    {
        open = false;
    }
}
