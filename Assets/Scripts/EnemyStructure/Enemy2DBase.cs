using UnityEngine;

public class Enemy2DBase : MonoBehaviour
{
   public EnemyData data;

    private int currentHealth;
    private Transform target;

    void Start()
    {
        currentHealth = data.MaxHealth;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 dir = (target.position - transform.position).normalized;
            transform.position += (Vector3)(dir * data.MoveSpeed * Time.deltaTime);
        }
    }
}

