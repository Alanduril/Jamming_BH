using UnityEngine;

public class Character_Apple : PlayerBase
{
    private SpriteRenderer spriteRenderer;
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
  protected void Update()
{
    Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    Move(input);

        if (input != Vector2.zero) // jezeli gracz sie porusza
        {
            _animator.SetBool("isRunning", true);
            if (input.x != 0)
                spriteRenderer.flipX = input.x < 0; // flipuje aset
        }
        else _animator.SetBool("isRunning", false);

}

}
