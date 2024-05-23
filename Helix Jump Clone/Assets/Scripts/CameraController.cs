using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float lerpSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, ball.position + offset, lerpSpeed);
        transform.position = newPos;
    }
}
