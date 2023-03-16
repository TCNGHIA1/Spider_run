using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Mapping : MonoBehaviour
{
    //speed
    public float ScrollSpeed = 0.5f;
    // Start is called before the first frame update

    //range
    float Offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //range when movement
        Offset += Time.deltaTime * ScrollSpeed;
        //render 
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Offset, 0.01f);
    }
}
