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
    public float dashCooldown = 10f;
    protected bool canDash = true;      // is responsible for the cooldown
    protected bool isDashing = false;   // conditional used for when animations can be played
    public TrailRenderer tr;


    public virtual void Move(Vector2 direction)
    {
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
    }

    public IEnumerator DashCoroutine(Vector2 direction, float duration = 0.1f)
    {
        canDash = false;
        isDashing = true;
        Vector2 start = transform.position;
        Vector2 target = start + direction.normalized * dashDistance;
        float time = 0f;
        tr.emitting = true;

        while (time < duration)
        {
            transform.position = Vector2.Lerp(start, target, time/duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.position = target;
        tr.emitting = false;
        yield return new WaitForSeconds(0.25f);
        isDashing = false;
        yield return new WaitForSeconds(dashCooldown);
        Debug.Log("Can dash now");
        canDash = true;
    }
}