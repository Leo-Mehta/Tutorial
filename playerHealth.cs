using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public float health;
    
    void Update()
    {
        if (health <= 0) {
            Destroy(gameObject, (float) 0.75);
            Debug.Log("Ded");
        }
    }
}
