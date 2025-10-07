using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference move;
    public InputActionReference grow;
    private Rigidbody2D rigidbody2D;
    public float speed = 100.0f;
    public float maxSpeed = 100.0f;
    public float growthSpeed = 3.0f;
    public float shrinkSpeed = 1.0f;
    public Vector3 targetScale = Vector3.one;

    void OnEnable() 
    {
        grow.action.started += Grow;
    }

    void OnDisable()
    {
        grow.action.started -= Grow;
    }

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputDir = move.action.ReadValue<Vector2>();

        Vector2 dir = inputDir.normalized;
        rigidbody2D.AddForce(dir * speed);
        rigidbody2D.linearVelocity = Vector3.ClampMagnitude(rigidbody2D.linearVelocity, maxSpeed);
    }

    void Grow(InputAction.CallbackContext _context)
    {
        targetScale = new Vector3(2.0f, 2.0f, 2.0f);
    }

    void Update()
    {
        if (transform.localScale.x < targetScale.x)
        {
            transform.localScale = new Vector3(transform.localScale.x + growthSpeed * Time.deltaTime,
                                               transform.localScale.y + growthSpeed * Time.deltaTime,
                                               transform.localScale.z + growthSpeed * Time.deltaTime);

            if (transform.localScale.x >= targetScale.x)
            {
                targetScale = Vector3.one;
            }
        }    
    }


}
