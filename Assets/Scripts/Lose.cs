using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
    public float loseHeight = -50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < loseHeight)
        {
            gameObject.SetActive(false);

        }
    }
}
