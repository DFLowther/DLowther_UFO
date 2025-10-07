using UnityEngine;

public class Pickup : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int value;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            scoreManager.AddPoints(value);
            value = 0;
            Destroy(gameObject);
        }    
    }
}
