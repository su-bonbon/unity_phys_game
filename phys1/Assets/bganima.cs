using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bganima : MonoBehaviour
{
    private Animator anim;

    private float distance = 0;
    private float speed = 0;
    private float timer = 0;
    public Text distanceUI;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown("space"))
        {
            anim.speed = 15f;
            distance += 0.5f;
            speed = distance / timer;
        }
        else
        {
            anim.speed = 0f;
            distanceUI.text = "Distance: " + distance.ToString("F2") + " m\n" +
                              "Time: " + timer.ToString("F2") + " s\n" +
                              "Speed: " + speed.ToString("F2") + "m/s";

        }
    }
}
