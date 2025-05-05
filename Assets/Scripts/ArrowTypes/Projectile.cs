using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public enum arrowType { ARROW, ICEARROW, BOOMERANG}

public abstract class Projectile 
{
    protected float speed;
    protected float damage;
    protected Rigidbody2D rb;
    private Sprite sprite;
    public Vector2 arrowmovement;

    //void start()
    //{
    //    arrowmovement = new Vector2(0, speed);
    //}

    public Projectile (float damage, float speed, Rigidbody2D rb)
    {
        this.damage = damage;
        this.speed = speed;
        this.rb = rb;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    //public abstract void Move()
    //{
        
    //}

}
