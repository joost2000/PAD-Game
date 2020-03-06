using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public GameObject playButton;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(text.fontStyle);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver()
    {
        Debug.Log("testing");
        text.fontStyle = TMPro.FontStyles.Underline;
    }
}
