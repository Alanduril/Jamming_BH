using UnityEngine;
using UnityEngine.Windows;

public class Character_Apple : PlayerBase
{
    private CharacterAnimator _animator;
    private Vector2 input;

    void Awake()
    {
        _animator = GetComponent<CharacterAnimator>();
    }

    void Update()
    {
        //Dash
        if (UnityEngine.Input.GetKeyDown(KeyCode.Space) && canDash && input != Vector2.zero)
        {
            Vector2 direction = input.normalized;
            _animator.PlayDashAnimation(input);
            StartCoroutine(DashCoroutine(direction));
        }

        //Moves
        input = new Vector2(UnityEngine.Input.GetAxisRaw("Horizontal"), UnityEngine.Input.GetAxisRaw("Vertical"));
        if (!isDashing)
        {
            Move(input);
            _animator.UpdateMovementAnimation(input, isDashing);
        }

    }

}
