using UnityEngine;


public class Bullet : MonoBehaviour {
    public float lifetime = 3f;
    public int damage = 10;

    void Start() {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Enemy")) {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
