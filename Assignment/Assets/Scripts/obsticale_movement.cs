using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticale_movement : MonoBehaviour
{

    public GameObject obsticale1;
    public GameObject obsticale2;
    public GameObject obsticale3;
    public GameObject obsticale4;

    // Use this for initialization
    void Start()
    {
        obsticale1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -4f, 0f);
        obsticale2.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 4f, 0f);
        obsticale3.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -3f, 0f);
        obsticale4.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (obsticale1.GetComponent<Rigidbody2D>().velocity.y < 0f)
        {
            obsticale1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -4f, 0f);
        }
        if (obsticale1.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            obsticale1.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 4f, 0f);
        }

        if (obsticale2.GetComponent<Rigidbody2D>().velocity.y < 0f)
        {
            obsticale2.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -4f, 0f);
        }
        if (obsticale2.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            obsticale2.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 4f, 0f);
        }

        if (obsticale3.GetComponent<Rigidbody2D>().velocity.y < 0f)
        {
            obsticale3.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -3f, 0f);
        }
        if (obsticale3.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            obsticale3.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 3f, 0f);
        }

        if (obsticale4.GetComponent<Rigidbody2D>().velocity.y < 0f)
        {
            obsticale4.GetComponent<Rigidbody2D>().velocity = new Vector3(0f,-5f, 0f);
        }
        if (obsticale4.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            obsticale4.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 5f, 0f);
        }
    }
}

