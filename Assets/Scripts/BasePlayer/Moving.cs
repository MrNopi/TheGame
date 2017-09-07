using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public static bool evol = false;
    private Sprite Mage_class;
    private Sprite Warrior_class;
    private Sprite Rogue_class;
    SpriteRenderer sprite;
    [SerializeField]
    private float speed = 3.0F;
    public static float currentHealth = BaseCharacterClass.MaxHealth;
    public float JumpForce = 6.0F;
    private bool isGrounded = false;
    [SerializeField]
    public static int Xp = 0;
    public static int MaxXp = 100 * BaseCharacterClass.Level;
    public static float score = 0;
    public int dmg;

    private void Awake()
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            sprite = GetComponentInChildren<SpriteRenderer>();

            if (HeroGUI.CharClass == "Mage")
        {
            sprite.sprite = Mage_class;
        }
            else if (HeroGUI.CharClass == "Warrior")
        {
            this.GetComponent<SpriteRenderer>().sprite = Warrior_class;
        }
            else if (HeroGUI.CharClass == "Rogue")
            this.GetComponent<SpriteRenderer>().sprite = Rogue_class;
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
        {
            if (Input.GetButton("Horizontal"))Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();

        if (Xp > MaxXp - 1)
        {
            LevelUp(HeroGUI.CharClass);
        }
        if (Input.GetMouseButton(0))
        {
            evol = true;
        }
    }

        private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0F;
    }
    private void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * JumpForce, ForceMode2D.Impulse);

    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position , 0.3F);
        isGrounded = colliders.Length > 1;
    }

    private void LevelUp(string CharacterClass) {
        if (CharacterClass == "Mage")
        {
            BaseCharacterClass.Intellect += 2;
            BaseCharacterClass.Agility += 1;
            BaseCharacterClass.Strength += 1;
            BaseCharacterClass.Stamina += 2;
            BaseCharacterClass.MaxHealth += 1;
        }
        if (CharacterClass == "Warrior")
        {
            BaseCharacterClass.Intellect += 1;
            BaseCharacterClass.Agility += 1;
            BaseCharacterClass.Strength += 2;
            BaseCharacterClass.Stamina += 1;
            BaseCharacterClass.MaxHealth += 3;
        }
        if (CharacterClass == "Rogue")
        {
            BaseCharacterClass.Intellect += 1;
            BaseCharacterClass.Agility += 2;
            BaseCharacterClass.Strength += 1;
            BaseCharacterClass.Stamina += 3;
            BaseCharacterClass.MaxHealth += 1;
        }
    }

}

