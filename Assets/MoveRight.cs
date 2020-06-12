using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public int points;
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    void Update()
    {
        if (transform.position.x < -13.44 || transform.position.x > 14.82)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y < -1 && transform.position.y > -2 || transform.position.y < -15)
        {
            Destroy(this.gameObject);
        }
          
    }
	void OnMouseDown()
	{
		if (KillDuck.clicked) {
            rb.velocity = new Vector2(0, -3);
            rb.rotation = -90f;
			Points.scoreValue += points;
		}
	}
    
}
