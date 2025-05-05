using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile
{

    public Sprite sprite;

    Arrow(float damage, float speed, Rigidbody2D rb) : base(damage, speed, rb)
    {
        this.rb = rb;
        this.speed = 30;
        this.damage = 25;
    }

    public override void Move()
    {
        rb.velocity = new Vector2(0, speed);
    }
}
