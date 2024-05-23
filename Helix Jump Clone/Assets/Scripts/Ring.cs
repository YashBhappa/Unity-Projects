using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.y + 15f >= ball.transform.position.y)
     {
         Destroy(gameObject);
         gm.IncreaseGameScore(10);
    }
    }
}
