using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float speed = 100.0f;
    public float maxSpeed = 100.0f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Debug.Log("x: "  + h + "y: " + v);

        Vector2 dir = new Vector2(h, v).normalized;
        rigidbody2D.AddForce(dir * speed);
        rigidbody2D.linearVelocity = Vector3.ClampMagnitude(rigidbody2D.linearVelocity, maxSpeed);
    }
}
