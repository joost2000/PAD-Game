using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
    public GameObject player;
    private PlayerShoot playerShootScript;
    public InputField inputField;
 
    // Start is called before the first frame update
    void Start()
    {
        playerShootScript = player.GetComponent<PlayerShoot>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PassIncline()
    {
         playerShootScript.Shoot(float.Parse(inputField.text));
    }
}