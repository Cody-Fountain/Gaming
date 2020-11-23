using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make sure Player, Enemies, and all Projectiles have colliders, and rigid body components to allow the function to work (They need to all have triggers to activate as well)

public class EnemyProjectile_Move : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); //IF I want projectile to follow the player just put "player" instead of "target"
        
        if(transform.position.x == target.x && transform.position.y == target.y)//Change "target" to "player" here as well..
        {
            DestroyProjectile();
        }

    void OnTriggerEnter2D(Collider2D proj_hit)//Collision of projectile with player, if hits it destroys
        {
            if (proj_hit.CompareTag("Player"))
            {
                DestroyProjectile();
            }
        }

    void DestroyProjectile()
        {
            Destroy(gameObject);
        }
    }
}