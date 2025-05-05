using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArrow : Projectile
{
    public Sprite sprite;
    public float xSpeed;

    IceArrow(float damage, float speed, Rigidbody2D rb): base (damage, speed, rb)
    {
        this.rb = rb;
        this.damage = 10;
        this.speed = 15;
    }

    public override void Move()
    {
        rb.velocity = new Vector2(Mathf.Sin(xSpeed)*Time.deltaTime,speed);
    }
}
