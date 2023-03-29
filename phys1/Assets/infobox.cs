using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public static double mess = 60;
    // public static double velo = 1;
    // public static double accel = 0;
    // public static double grav = 9.8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = mess.ToString();
        // GetComponent<Text>().text = velo.ToString();
        // GetComponent<Text>().text = accel.ToString();
        // GetComponent<Text>().text = grav.ToString();
    }
}
