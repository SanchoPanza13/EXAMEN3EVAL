using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn;
    private float currentTime;

    public Boomerang(float damage, float speed, Rigidbody2D rb) : base(damage, speed, rb)
    {
        this.rb = rb;
        this.speed = 10;
        this.damage = 8;
    }

    public override void Move()
    {
        rb.velocity = Vector2.up * speed;

        if (currentTime >= timeToReturn)
        {
            currentTime = 0;
            speed = -speed;
        }

    }
}
