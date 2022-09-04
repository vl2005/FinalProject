using UnityEngine;
using UnityEngine.SceneManagement;


public class player4 : MonoBehaviour
{
    public AudioSource src;

    Rigidbody2D RB;
    float playerInputX;
    float playerInputY;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
        RB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        playerInputX = Input.GetAxis("Horizontal");
        playerInputY = Input.GetAxis("Vertical");

        RB.velocity = new Vector2(playerInputX * speed, playerInputY * speed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            src.Play();
            Invoke("Restart", 4f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BOX")
        {
            
        }
    }
}


