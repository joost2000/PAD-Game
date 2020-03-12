using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D playerBody;
    public GameObject laser;
    private LaserShoot laserShootScript;
   
    // Start is called before the first frame update
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
        laserShootScript = laser.GetComponent<LaserShoot>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Shoot(float helling)
    {
        float fireAngle = ( Mathf.Rad2Deg * Mathf.Atan(helling) + 90) ;
        playerBody.rotation = fireAngle;
        laserShootScript.Shoot(fireAngle);
       

    }
}
