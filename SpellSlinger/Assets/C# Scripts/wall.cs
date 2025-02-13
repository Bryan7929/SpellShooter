using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Called when another collider enters this trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spell")
        {
            Debug.Log("Projectile Destroyed");
            Destroy(other.gameObject);
        }
    }
}
