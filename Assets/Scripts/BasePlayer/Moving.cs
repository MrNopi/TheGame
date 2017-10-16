using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Bullet bullet;
    private Animator anim;
    SpriteRenderer sprite;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float JumpForce;
    private bool isGrounded = true;
    [SerializeField]
    int health = 120;
    public static float score = 0;
    public static int dmg;
    public static int Xp = 0;
    private int MaxXp = 100 * BaseCharacterClass.Level;
    public static float currentHealth = BaseCharacterClass.MaxHealth;

    private enum animations
        {
            Idle,
            Run,
            Jump
        }
    private animations State
    {
        get { return (animations)anim.GetInteger("State"); }
        set { anim.SetInteger("State", (int) value); }

    }
    private void Awake()
    {
        bullet = Resources.Load<Bullet>("Bullet");
        anim = GetComponent<Animator>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
        if (isGrounded)
        if (Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
            Run();
        if (Input.GetButton("Horizontal"))
            Walk();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
        State = animations.Idle;
    }
    private void Run()
    {
        State = animations.Run;
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        speed /= 2;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, (speed * Time.deltaTime));
        sprite.flipX = direction.x < 0.0F;
    }
    private void Walk()
    {
        speed = 5f;
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0F;
        anim.SetFloat("Speed", speed);
        State = animations.Run;
    }
    private void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
        State = animations.Jump;
    }
    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(this.transform.position , 0.5F);
        isGrounded = colliders.Length > 1;
    }
    private void Shoot()
    {
        Vector3 pos = transform.position; pos.y += 0.8f;
       Bullet newBullet = Instantiate(bullet, pos, bullet.transform.rotation) as Bullet;
        newBullet.Direction = newBullet.transform.right * (sprite.flipX ? -1.0f : 1.0f);
    }
  

}

