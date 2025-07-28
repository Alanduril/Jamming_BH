using UnityEngine;
using UnityEngine.Windows;

// Contains logic for animating the character
public class CharacterAnimator : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    void Awake()
    {
        
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void UpdateMovementAnimation(Vector2 input, bool isDashing)
    { 
        if (isDashing)
        {
            _animator.SetBool("isRunning", false);
            return;
        }
        if (input != Vector2.zero)
        {
            _animator.SetBool("isRunning", true);
            if (input.x != 0)
                _spriteRenderer.flipX = input.x < 0;
        }
        else _animator.SetBool("isRunning", false);
    }
    public void PlayDashAnimation(Vector2 input)
    {
        _animator.SetTrigger("dash");
    }
}
