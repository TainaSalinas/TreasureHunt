using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public bool positive;
    public GameObject purpleball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bowlingball")
        {
            positive = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
