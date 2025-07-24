using UnityEngine;

public class Character_Apple : PlayerBase
{
    private CharacterAnimator _animator;

    void Awake()
    {
        _animator = GetComponent<CharacterAnimator>();
    }

    void Update()
    {
        //Moves
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Move(input);
        _animator.UpdateMovementAnimation(input);

        //Dash
        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            Vector2 direction = input.normalized;
            _animator.PlayDashAnimation(input);
            StartCoroutine(DashCoroutine(direction));
        }
    }

}
