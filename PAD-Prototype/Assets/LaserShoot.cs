using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public GameObject laser;
    private Rigidbody2D laserBody;
    // Start is called before the first frame update
    void Start()
    {
        laserBody = laser.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(float angle)
    {
        laserBody.SetRotation(angle);
    }
}
