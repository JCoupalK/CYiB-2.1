using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"

    public float forwardForce = 735f;
    public float sidewayForce = 60f;
    public SpawnManager spawnManager;
    public Vector3 jump;
    public float jumpForce = 280f;
    public float maxSpeed = 735f;
    public AudioSource Squish;
    public float delay = 1;


    void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed)

        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

    }

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 0.02f, 0f);

    }
    
    private void OnCollisionStay()
    {
        if (!isGrounded && rb.velocity.y == 0)
        {
            isGrounded = true; //jumpsLeft = 1; }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;

            Squish.PlayDelayed(delay);
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   // Add a force of 2000 on the z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        {
            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
