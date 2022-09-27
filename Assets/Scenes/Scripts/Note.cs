using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score = 0;
    private bool positive;
    public GameObject paper;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character")
        {
            positive = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (positive == true && Input.GetKeyDown(KeyCode.E))
        {
            score = 1;
            paper.SetActive(false);
        }
    }
}
