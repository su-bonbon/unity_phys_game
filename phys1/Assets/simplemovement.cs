using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simplemovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float gravity;
    public float mass;
    

    private Rigidbody2D rb;

    private float distance;
    public Text distanceUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceUI.text = "distance: "+ distance.ToString("F2");
        distance += Time.deltaTime * 0.8f;
    }
}
