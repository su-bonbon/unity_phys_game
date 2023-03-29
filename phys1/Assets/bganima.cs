using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bganima : MonoBehaviour
{
    private Animator anim;

    private float distance;
    public Text distanceUI;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            anim.speed = 2f;
            distance += 0.5f;
        }
        else
        {
            anim.speed = 0f;
            distanceUI.text = "distance: " + distance.ToString("F2") + " m";

        }
    }
}
