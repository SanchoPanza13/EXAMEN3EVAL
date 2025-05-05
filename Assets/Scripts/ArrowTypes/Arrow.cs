using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arrow : Projectile
{

    public Sprite sprite;

    Arrow(float damage, float speed, Rigidbody2D rb) : base(damage, speed, rb)
    {
        this.rb = rb;
        this.speed = 30;
        this.damage = 25;
    }




}
