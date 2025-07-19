using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDatabase", menuName = "Scriptable Objects/EnemyDatabase")]
public class EnemyDatabase : ScriptableObject
{
    [SerializeField] private List<EnemyData> enemies;

    public EnemyData GetEnemy(int index)
    {
        if (index >= 0 && index < enemies.Count)
        {
            return enemies[index];
        }
        else
        {
            Debug.Log("Invalid enemy index.");
            return null;
        }
    }
    public int EnemiesCount => enemies.Count;
}
