using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float speed = 27.0f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, speed) * Time.fixedDeltaTime);
    }
}
