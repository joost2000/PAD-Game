using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    public GameObject player;
    private PlayerShoot playerShootScript;
    public GameObject inputField;
    private Text inputText;
    // Start is called before the first frame update
    void Start()
    {
        playerShootScript = player.GetComponent<PlayerShoot>();
        inputText = inputField.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PassIncline()
    {
       // playerShootScript.Shoot(float.Parse(inputText.text));
    }
}
