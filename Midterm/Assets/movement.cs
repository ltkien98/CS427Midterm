using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 newVec;
    public float speed = 20f;
    public float jump = 800f;
    int jumpCount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Move");
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Move");
        }
        
        if (Input.GetKey(KeyCode.Space) && jumpCount < 5)
        {
            GetComponent<Animator>().SetTrigger("Jump");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
        
    }

}
