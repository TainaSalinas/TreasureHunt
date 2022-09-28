using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    // Start is called before the first frame update
    private bool positive;
    public GameObject paper;
    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character" && GameManager.Instance.score == 1)
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
            paper.SetActive(false);
            dialogue.SetActive(true);
        }
    }
}
