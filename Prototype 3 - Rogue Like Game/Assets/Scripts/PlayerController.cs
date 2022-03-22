using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;
    
    
    [Header ("Player Movement")]
    public float moveSpeed = 5f; // Speed at which the player will move
    private Rigidbody2D rb; // Store the referenced 2D rigidbody

    Vector2 movement; //Store the players x,y position for movement

    [Header("Player Combat")]
    public float attackRange; // Range at which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public int damage; // Damage amount dealt to enemy
    public LayerMask enemyLayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      movement.x = Input.GetAxis("Horizontal"); // Input for Left Right Movement
      movement.y = Input.GetAxis("Vertical"); // Input for Up Down Movement
    }
    // Set number of calls per frame
    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        // Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    void Die()
    {
        Debug.Log("Player has bit the dust!");
    }
}
