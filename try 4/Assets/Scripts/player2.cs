using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player2 : MonoBehaviour
{
    public float inc;

    public AudioSource src;




    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new(transform.position.x + inc, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new(transform.position.x - inc, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new(transform.position.x, transform.position.y + inc, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new(transform.position.x, transform.position.y - inc, transform.position.z);
        }
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
        SceneManager.LoadScene(0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BOX")
        {
            
        }
    }
}


