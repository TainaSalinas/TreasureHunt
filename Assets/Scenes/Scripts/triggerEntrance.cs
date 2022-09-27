using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerEntrance : MonoBehaviour
{
    public bool enter;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Square")
        {
         
                SceneManager.LoadScene("Inside", LoadSceneMode.Single);
            
        }
    }


}
