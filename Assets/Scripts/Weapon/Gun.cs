using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 10f;
    public float fireCooldown = 0.3f;

    private float fireTimer = 0f;

    void Update() {
        RotateTowardMouse();

        fireTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && fireTimer <= 0f) {
            Shoot();
            fireTimer = fireCooldown;
        }
    }

    void RotateTowardMouse() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = firePoint.right * bulletForce;
    }
}
