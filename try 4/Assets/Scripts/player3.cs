using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player3 : MonoBehaviour
{
    Rigidbody2D RB;
    float playerInputX;
    float playerInputY;
    public float speed;


    public AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        playerInputY = Input.GetAxis("Vertical");
        RB.velocity = new Vector2(0, playerInputY * speed);
        
    }


}
