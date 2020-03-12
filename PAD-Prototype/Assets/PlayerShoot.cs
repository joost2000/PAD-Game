﻿using System.Collections;
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
       // Shoot(1);
    }

    public void Shoot(float helling)
    {
        float fireAngle = -(Mathf.Atan(helling) * Mathf.Rad2Deg);
        playerBody.SetRotation(fireAngle);
        laserShootScript.Shoot(fireAngle);
       

    }
}
