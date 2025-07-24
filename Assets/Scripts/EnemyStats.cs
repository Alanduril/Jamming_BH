using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Stats/EnemyStats")]
public class PlayerAndEnemyStats : ScriptableObject
{
    public float EnemyMaxHealth;
    public float EnemyCurrentHealth;
    public int EnemyTier;
    public float EnemySpeed;
    public float EnemyDamage;
}