using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Stats/PlayerStats")]
public class PlayerStats : ScriptableObject
{

    public float PlayerMaxHealth;
    public float PlayerCurrentHealth;
    public float PlayerSpeed;
    public float PlayerStamina;
    public float PlayerLuck;
    public float Level;
    public float exp;

    public string exptxt;
}