using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningController : MonoBehaviour
{

   public float hForce = 4;
   public float vForce = 4;

   
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(rightKey))
        {
            pos.x += hForce * Time.deltaTime;
        }

        if (Input.GetKey(leftKey))
        {
            pos.x -= hForce * Time.deltaTime;
        }

        transform.position = pos;
    }
}
