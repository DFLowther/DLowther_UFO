using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public Transform player;
    public float maxXYOffset = 5.0f;
    private Rigidbody2D rb2d;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.position;
        rb2d = player.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocityOffset = new Vector3(
                                rb2d.linearVelocity.x, 
                                rb2d.linearVelocity.y, 
                                0.0f);

        float len = velocityOffset.magnitude;

        if (len > maxXYOffset)
            velocityOffset = velocityOffset.normalized * maxXYOffset;

        transform.position = player.position +
                            offset;// + velocityOffset;
    }
}
