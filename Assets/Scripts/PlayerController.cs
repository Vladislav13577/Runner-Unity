using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    private Rigidbody _rb;
    public float jumpPower;
    public float xRange = 2;
    private float horizontalInput;
    public bool onGround;
    private GameManager gameManager;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (!gameManager.stopGame)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
            if (Input.GetKeyDown(KeyCode.Space) && onGround)
            {
                _rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                onGround = false;
            }
        }


        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }
}
