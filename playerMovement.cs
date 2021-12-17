using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;

    private float horizontal = 2f;
    private float vertical = 2f;

    public float speed = 10; 
    void FixedUpdate() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontal * speed, vertical * speed); 
    }
}
