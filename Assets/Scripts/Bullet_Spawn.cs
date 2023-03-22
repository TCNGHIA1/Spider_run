using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet_Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public float heightOffset = 4;
    public float bulletRate = 2;
    private float timer = 0;
    void Start()
    {
        MAKE();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < bulletRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            MAKE();
            timer = 0;
        }
    }
    void MAKE()
    {
        float hightOffset = transform.position.y + heightOffset;

        Instantiate(bullet,new Vector3(transform.position.x,Random.Range(transform.position.y,hightOffset),transform.position.z),transform.rotation);
    }
}
