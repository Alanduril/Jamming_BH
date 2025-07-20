using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    private Enemy enemy;
    private bool hasDealtDamage = false;

    private void Start() {
        enemy = GetComponent<Enemy>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (hasDealtDamage) return;

        if (other.CompareTag("Player")) {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null) {
                int damageAmount = enemy != null ? enemy.GetDamage() : 10;
                playerHealth.TakeDamage(damageAmount);
                hasDealtDamage = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            hasDealtDamage = false;
        }
    }
}
