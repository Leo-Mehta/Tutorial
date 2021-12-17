using UnityEngine;

public class CollisionHandler : MonoBehaviour {
    public PlayerHealth health;

    public float minDamage; // Initialize in the inspector
    public float maxDamage; // Initialize in the inspector 
    
    void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.name == "obstacle") {
            health.health -= Random.Range(minDamage, maxDamage);
        }
    }
}
