using UnityEngine;

public class Rotate_Move : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0f, rotateSpeed * moveX * Time.deltaTime, 0f);

        }
    }
}
