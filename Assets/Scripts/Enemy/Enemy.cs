using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public EnemyData data;

    private int currentHealth;

    private void Start() {
        if (data != null) {
            currentHealth = data.maxHealth;

            // Przypisz sprite z ScriptableObject
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr != null && data.sprite != null) {
                sr.sprite = data.sprite;
            }
        }
    }

    public void TakeDamage(int dmg) {
        currentHealth -= dmg;

        if (currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        Destroy(gameObject);
    }

    public int GetDamage() {
        return data.damage;
    }

    public float GetSpeed() {
        return data.speed;
    }
}
