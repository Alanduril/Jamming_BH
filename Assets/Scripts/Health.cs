using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class Health : MonoBehaviour {
    public int maxHealth = 100;
    public int health = 0;
    public HealthBar healthBar;
    // iframe system 
    public float iFrameDuration = 1f;
    private bool isInvincible = false;

    /* Dla serduszek ten system bêdzie musia³ wygl¹daæ inaczej
    public float health, maxHealth;
    */

    void Start() {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {

            TakeDamage(20);

        }
    }

    public void TakeDamage(int damage) {
        if (isInvincible) return;

        health -= damage;
        healthBar.SetHealth(health);

        // Start iframów
        StartCoroutine(InvincibilityCoroutine());
    }

    //dla iframów
    private IEnumerator InvincibilityCoroutine() {
        isInvincible = true;

        // migotanie?
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        Color originalColor = sprite.color;

        float elapsed = 0f;
        while (elapsed < iFrameDuration) {
            if (sprite != null) {
                sprite.color = new Color(1, 1, 1, 0.5f); // pó³przezroczystoœæ
                yield return new WaitForSeconds(0.1f);
                sprite.color = originalColor;
                yield return new WaitForSeconds(0.1f);
            }

            elapsed += 0.2f;
        }

        isInvincible = false;
    }
}
