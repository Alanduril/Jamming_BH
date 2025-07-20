using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Enemies/Enemy Data")]
public class EnemyDataDefinition : ScriptableObject {
    public string enemyName;
    public int maxHealth;
    public int damage;
    public float speed;
    public Sprite sprite; 
}



