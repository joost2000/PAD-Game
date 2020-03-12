using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public Transform target;
    public static Random random;
    private float speed = 1.0f;

    public Vector2 Goal;
    float HP;
    bool hitbullet;
    bool hitplayer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        target = GetComponent<Transform>();
        random = new Random();

        Goal = new Vector2(0.0f, 0.0f);

        setPosition(Random.Range(-6f, 6f), Random.Range(-6f, 6f));




    }

    void setPosition(float x, float y)
    {

        target.position = new Vector2(x, y);

    }

    // Update is called once per frame
    void Update()
    {

        float step = speed * Time.deltaTime;

        target.position = Vector2.MoveTowards(target.position, Goal, step);


    }
}