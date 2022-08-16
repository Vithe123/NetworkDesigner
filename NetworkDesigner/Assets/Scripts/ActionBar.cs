using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBar : MonoBehaviour
{
    public Image img1;
    public bool isImgOn1;

    public Image img2;
    public bool isImgOn2;

    public Image img3;
    public bool isImgOn3;

    public Image img4;
    public bool isImgOn4;

    public Image img5;
    public bool isImgOn5;

    public Image img6;
    public bool isImgOn6;

    public Image img7;
    public bool isImgOn7;

    public Image img8;
    public bool isImgOn8;
    // Start is called before the first frame update
    void Start()
    {

        img1.enabled = true;
        isImgOn1 = true;
        img2.enabled = false;
        isImgOn2 = false;

        img3.enabled = false;
        isImgOn3 = false;
        img4.enabled = true;
        isImgOn4 = true;

        img5.enabled = false;
        isImgOn5 = false;
        img6.enabled = true;
        isImgOn6 = true;

        img7.enabled = false;
        isImgOn7 = false;
        img8.enabled = true;
        isImgOn8 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (isImgOn1 == true)
            {
                img1.enabled = false;
                isImgOn1 = false;

                img2.enabled = true;
                isImgOn2 = true;
            }
            else
            {
                img1.enabled = true;
                isImgOn1 = true;

                img2.enabled = false;
                isImgOn2 = false;

                img3.enabled = false;
                isImgOn3 = false;
                img4.enabled = true;
                isImgOn4 = true;

                img5.enabled = false;
                isImgOn5 = false;
                img6.enabled = true;
                isImgOn6 = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (isImgOn3 == true)
            {
                img3.enabled = false;
                isImgOn3 = false;

                img4.enabled = true;
                isImgOn4 = true;
            }
            else
            {
                img3.enabled = true;
                isImgOn3 = true;

                img4.enabled = false;
                isImgOn4 = false;

                img1.enabled = false;
                isImgOn1 = false;
                img2.enabled = true;
                isImgOn2 = true;

                img5.enabled = false;
                isImgOn5 = false;
                img6.enabled = true;
                isImgOn6 = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (isImgOn5 == true)
            {
                img5.enabled = false;
                isImgOn5 = false;

                img6.enabled = true;
                isImgOn6 = true;
            }
            else
            {
                img5.enabled = true;
                isImgOn5 = true;

                img6.enabled = false;
                isImgOn6 = false;

                img1.enabled = false;
                isImgOn1 = false;
                img2.enabled = true;
                isImgOn2 = true;

                img3.enabled = false;
                isImgOn3 = false;
                img4.enabled = true;
                isImgOn4 = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if (isImgOn7 == true)
            {
                img7.enabled = false;
                isImgOn7 = false;

                img8.enabled = true;
                isImgOn8 = true;
            }
            else
            {
                img7.enabled = true;
                isImgOn7 = true;

                img8.enabled = false;
                isImgOn8 = false;
            }
        }
    }
}