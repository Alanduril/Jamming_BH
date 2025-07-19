using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyDatabase database;
    public Transform player;
    public Vector2 spawnOffset = new Vector2(3f, 3f);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnEnemy(0);
        }
    }
    void SpawnEnemy(int index)
{
    if (index < 0 || index >= database.EnemiesCount)
    {
        Debug.LogWarning("Invalid enemy index!");
        return;
    }

    EnemyData data = database.GetEnemy(index);
    if (data == null || data.Prefab == null)
    {
        Debug.LogWarning($"Missing prefab or data for enemy at index {index}.");
        return;
    }

    Vector2 spawnPos = (Vector2)player.position + spawnOffset.normalized * 5f;
    GameObject enemy = Instantiate(data.Prefab, spawnPos, Quaternion.identity);

    Enemy2DBase enemyScript = enemy.GetComponent<Enemy2DBase>();
    if (enemyScript != null)
    {
        enemyScript.data = data;
    }
    else
    {
        Debug.LogWarning("Spawned prefab doesn't have an Enemy2D component!");
    }
}

}
