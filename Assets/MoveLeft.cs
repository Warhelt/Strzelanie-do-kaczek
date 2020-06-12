using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public int points;
    RaycastHit2D hit;
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    void OnMouseDown()
    {
        if (KillDuck.clicked) {
            rb.velocity = new Vector2(0, -3);
            rb.rotation = 90f;

            //Destroy (this.gameObject);
            Points.scoreValue += points;
        }
    }
    
    void Update()
    {
        if (transform.position.x < -15 || transform.position.x>15)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y < -2)
        {
            Destroy(this.gameObject);
        }

    }


}
