using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float gravity;
    public float mess;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y);
    }
}
