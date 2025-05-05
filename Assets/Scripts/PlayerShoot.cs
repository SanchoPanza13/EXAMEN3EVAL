using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float timeToShoot = 0.4f;
    public GameObject projectile;

    private float currentTime = 0;
    
    public arrowType arrowType;
    private Arrow arrow;
    private IceArrow iceArrow;
    private Boomerang boomerang;
    private Rigidbody2D rbArrow;
    private Rigidbody2D rbIceArrow;
    private Rigidbody2D rbBoomerang;

    // Start is called before the first frame update
    void Start()
    {
        switch (arrowType)
        {
            case arrowType.ARROW:
                arrow = new Arrow(25, 30, rbArrow);
                break;
            case arrowType.ICEARROW:
                iceArrow = new IceArrow(10, 15, rbIceArrow);
                break;
            case arrowType.BOOMERANG:
                boomerang = new Boomerang(8, 10, rbBoomerang);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
           
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
