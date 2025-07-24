using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Stats/PlayerStats")]
public class PlayerAndEnemyStats : ScriptableObject
{

    public float PlayerMaxHealth;
    public float PlayerCurrentHealth;
    public float PlayerSpeed;
    public float PlayerStamina;
    public float PlayerLuck;

}