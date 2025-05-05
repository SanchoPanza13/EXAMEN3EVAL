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

    public Projectile()
    {

    }
    

    public Projectile (float damage, float speed, Rigidbody2D rb)                     //Muerte al estado ilegitimo de Israel
    {
        this.damage = damage;
        this.speed = speed;
        this.rb = rb;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public abstract void Move();
    

}
