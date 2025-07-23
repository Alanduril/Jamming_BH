using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Collections;

public class PlayerBase : MonoBehaviour
{
    public string playerName = "Hero";
    public float health = 100f;
    public float moveSpeed = 5f;
    public int level = 1;
    public float exp = 0f;
    public float expMagnetRange = 5f;
    public float dashDistance = 5f;


    public virtual void Move(Vector2 direction)
    {
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }

    public IEnumerator DashCoroutine(Vector2 direction, float duration = 0.1f)
    {
        Vector2 start = transform.position;
        Vector2 target = start + direction.normalized * dashDistance;
        float time = 0f;

        while (time < duration)
        {
            transform.position = Vector2.Lerp(start, target, time/duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.position = target;
    }
}