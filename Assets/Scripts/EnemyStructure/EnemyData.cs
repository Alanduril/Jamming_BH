using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("Base Stats")]
    [SerializeField] private int maxHealth;
    [SerializeField] private float moveSpeed = 2f;

    [Header("Prefab Reference")]
    [SerializeField] private GameObject prefab;

    public int MaxHealt => maxHealth;
    public float MoveSpeed => moveSpeed;
    public GameObject Prefab => prefab;

}
