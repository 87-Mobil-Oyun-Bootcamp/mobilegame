using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exampleScript : MonoBehaviour
{
    Renderer rend;
    int colorPicker = 0;

    [Space]
    [SerializeField]
    private Sprite image;
    Texture2D texture2D;
    Color color;

    private void Start()
    {
        rend = GetComponent<Renderer>();

        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Finish"))
        {
            if (rend.enabled == false)
            {
                Destroy(other);
            }

            rend.enabled = true;
           
        }
    }
  

}


