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


    // Update is called once per frame

    // (pewnie mozna czesc tego przesunac do klasy PlayerBase (skrypt Character) ale poki co to dziala)
    void Update()
    {
        //Moves character
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Move(input);

        //Animates and flips character
        if (input != Vector2.zero)
        {
            _animator.SetBool("isRunning", true);
            if (input.x != 0)
                spriteRenderer.flipX = input.x < 0;
        }
        else _animator.SetBool("isRunning", false);

        //Dash towards cursor
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - (Vector2)transform.position;
            StartCoroutine(DashCoroutine(direction));
        }
    }

}
