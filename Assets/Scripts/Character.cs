using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public string playerName = "Hero";
    public float health = 100f;
    public float moveSpeed = 5f;
    public int level = 1;
    public float exp = 0f;
    public float expMagnetRange = 5f;


    public virtual void Move(Vector2 direction)
    {
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }
}