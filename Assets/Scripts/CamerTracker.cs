using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerTracker : MonoBehaviour
{
    public GameObject Player;
    List<float> positions = new List<float>();
    float currentPayerPos= 0;
    private float heightMove = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(Player!=null)
        {
            currentPayerPos = Player.transform.position.y;
            heightMove =  2.6f * (float) Mathf.Abs(Player.transform.position.y-transform.position.y);
            positions.Add(transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Player!=null)
        {
            if(currentPayerPos+heightMove < Player.transform.position.y)
            {
                Vector3 pos = transform.position;
                pos.y = positions[0] + heightMove/2;
                transform.position = pos;
            }else{
                Vector3 pos  = transform.position;
                pos.y = positions[0];
                transform.position = pos;
            }
        }
    }
}
