using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windblow : MonoBehaviour
{
    private Animator anim;
    static public float windv;   // magnatitude of wind force
    static public float winda;   // direction of wind force
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.speed = 0.1f;

    }
}
