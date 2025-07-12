using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class Health : MonoBehaviour {
    public int maxHealth = 100;
    public int health = 0;
    public HealthBar healthBar;

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

    void TakeDamage(int damage) {
        health -= damage;
        healthBar.SetHealth(health);
    }
}
