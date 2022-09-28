using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private bool positive;
    public GameObject purpleball;
    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character" && GameManager.Instance.score == 4)
        {
            positive = true;
            GameManager.Instance.score += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (positive == true && Input.GetKeyDown(KeyCode.E))
        {
            
            purpleball.SetActive(false);
            dialogue.SetActive(true);
        }
    }
}
