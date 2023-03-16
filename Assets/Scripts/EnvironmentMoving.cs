using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    float distance = 0;
    void Start()
    {
        if (Player != null)
        {
            distance = Player.transform.position.x - this.transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 pos = this.transform.position;
            pos.x = Player.transform.position.x - distance;
        }
    }
}
