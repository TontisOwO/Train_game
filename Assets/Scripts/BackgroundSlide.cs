using UnityEngine;

public class BackgroundSlide : MonoBehaviour
{
    [SerializeField] Vector3 endPos;
    [SerializeField] float scrollSpeed;
    Vector3 position;
    Vector3 startPos;
    Vector3 trueEndPos;
    public bool speedUp;
    private void Awake()
    {
        position = transform.position;
        startPos = transform.position;
        trueEndPos = transform.position + endPos;
    }

    void Update()
    {
        if (speedUp)
        {
            scrollSpeed += Time.deltaTime;
        }
        if (position == trueEndPos)
        {
            position = startPos;
        }
        position = Vector3.MoveTowards(position, trueEndPos, scrollSpeed * Time.deltaTime);
        transform.position = position;
    }
}
