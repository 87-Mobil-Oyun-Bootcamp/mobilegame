using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{

    [Space]
    [SerializeField]
    private Sprite image;

    [Space]
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    float size = 0.2f;
    Texture2D texture2D;
    Vector3 cubePos = Vector3.zero;
    GameObject cubeObj;
    Color color;
    int x;
    int y;
    int count=0;
    public int width = 4;
    public int height = 4;
    public void Awake()
    {

        texture2D = image.texture;
        for (x = 0; x < texture2D.width; x++)
        {
            for (y = 0; y < texture2D.height; y++)
            {
                color = texture2D.GetPixel(x, y);
                if (color.a == 0)
                {
                    continue;
                }
                cubePos = new Vector3(0.5f, size * (x - (texture2D.width * 0.5f)), size * (y - (texture2D.height * .5f)));
                cubeObj = Instantiate(cube, transform);
                cubeObj.transform.localPosition = cubePos;
                cubeObj.GetComponent<Renderer>().material.color = Color.yellow;
                cubeObj.transform.localScale = Vector3.one * size;


            }
        } 
    }
        

    /*void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
               
            }
        }
    }*/

        
        
    }


