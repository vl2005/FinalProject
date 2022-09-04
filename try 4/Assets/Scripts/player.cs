using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    Rigidbody2D RB;
    float playerInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        playerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerInput * speed, 0);
    }

}
