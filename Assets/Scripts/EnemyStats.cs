using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Stats/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    public float EnemyMaxHealth;
    public float EnemyCurrentHealth;
    public int EnemyTier;
    public float EnemySpeed;
    public float EnemyDamage;
}