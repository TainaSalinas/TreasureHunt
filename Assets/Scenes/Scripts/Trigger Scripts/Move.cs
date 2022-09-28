using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody2D rb;

    public Transform EndofLane;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.score == 6)
        {
            Vector3 vecToEndofLane = EndofLane.position - this.transform.position;
            vecToEndofLane = vecToEndofLane.normalized;
            vecToEndofLane = vecToEndofLane * 0.01f;

            rb.AddForce(vecToEndofLane, ForceMode2D.Impulse);
        }
    }
}
