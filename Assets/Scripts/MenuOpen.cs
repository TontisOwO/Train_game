using UnityEngine;

public class MenuOpen : MonoBehaviour
{
    [SerializeField] Vector2 startPos;
    [SerializeField] Vector2 endPos = new Vector2(960, 540);
    [SerializeField] float lerpAmount = 8;
    [SerializeField] bool open;
    [SerializeField] MouseLook mouseLook;
    void Awake()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Open();
            if (mouseLook != null)
            {
                mouseLook.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
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
        if (mouseLook != null)
        {
            mouseLook.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
