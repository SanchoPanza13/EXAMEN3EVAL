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
    private Rigidbody2D rb;
    

    // Start is called before the first frame update            I'm tweaking vro
    void Start()
    {
        switch (arrowType)
        {
            case arrowType.ARROW:
                arrow = new Arrow(25, 30, rb);
                break;
            case arrowType.ICEARROW:
                iceArrow = new IceArrow(10, 15, rb);
                break;
            case arrowType.BOOMERANG:
                boomerang = new Boomerang(8, 10, rb);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
           Instantiate(projectile);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
