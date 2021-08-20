using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehaviour : MonoBehaviour
{
    public GameObject rock;
    private float timer;
    public float thrust = 1000.0f;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (timer > 3) 
        {
            rb.AddForce(new Vector3(0f, 5.0f, 0f), ForceMode.Impulse);
            timer = 0;
        }
        if (rock.transform.position.z < -115)
        {
            Application.Quit();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}
