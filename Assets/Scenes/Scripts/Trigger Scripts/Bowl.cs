using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{

    private bool positive;
    public GameObject purpleball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character" && GameManager.Instance.score == 5)
        {
            GameManager.Instance.score += 1;
            positive = true;            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (positive == true && Input.GetKeyDown(KeyCode.E))
        {

            purpleball.SetActive(true);
        }
    }
}
