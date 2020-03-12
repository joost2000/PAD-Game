using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public GameObject laser;
    private Rigidbody2D laserBody;

    private int lifetime;
    private bool active;
    // Start is called before the first frame update
    void Start()
    {
        laser.active = false;
        laserBody = laser.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            CheckLifeTime();
        }
    }

    private void CheckLifeTime()
    {
        lifetime--;
        if ( lifetime <= 0)
        {
            active = false;
            laser.active = false;
        }
    }

    public void Shoot(float angle)
    {
        active = true;
        laser.active = true;
        laserBody.SetRotation(angle);
        lifetime = 20;
    }
}
