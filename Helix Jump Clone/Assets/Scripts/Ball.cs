using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        // rb.AddForce(Vector3.up * jumpForce);

        rb.linearVelocity = new Vector3(0, jumpForce, 0);


        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), Quaternion.Euler(90,0,0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(materialName);

        if(materialName == "PlatformSafe (Instance)")
        {

        }else if(materialName == "PlatformDanger (Instance)"){
            gm.RestartGame();

        }else if(materialName == "LastRing (Instance)"){
            Debug.Log("Congrats");
        }
    }
}
