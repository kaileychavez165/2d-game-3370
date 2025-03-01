using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dead : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public bool once = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bomb_enemy"))
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("power_up"))
        {
             // Store the battery position before destroying it
            Vector3 batteryPosition = collision.gameObject.transform.position;

            // Destroy the battery
            Destroy(collision.gameObject);

            // Spawn particle system at the battery's position
            Instantiate(collisionParticleSystem, batteryPosition, Quaternion.identity);

            score_manager.instance.addPoints();

            var em = collisionParticleSystem.emission;

            if(once)
            {
                em.enabled = true;
                collisionParticleSystem.Play();
                once = false;
            }
        }
    }
}
