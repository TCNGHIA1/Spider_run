using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Loop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Box;

    //object kieu A
    public GameObject A_Zone;
    //object kieu B
    public GameObject B_Zone;

    public float Speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MOVE();
    }
    //tao chuong ngai vat
    public void MAKE()
    {
        B_Zone = A_Zone;
        //ngau nhien vi tri
        int a = Random.Range(0, 5);
        //tao chuong ngai A;
        A_Zone = Instantiate(Box[a], new Vector3(30, -3, 0), transform.rotation) as GameObject;
    }

    public void MOVE()
    {
        //di chuyen A
        A_Zone.transform.Translate( Speed * Time.deltaTime* Vector3.left, Space.World);
        //di chuyen B
        B_Zone.transform.Translate(Speed * Time.deltaTime* Vector3.left, Space.World);
        if(A_Zone.transform.position.x < 0)
        {
            DEATH();
        }
    }
    //Huy chuong ngai
    public void DEATH()
    {
        Destroy(B_Zone);
        MAKE();
    }
}
