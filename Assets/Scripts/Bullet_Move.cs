using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float BulletSpeed = 5f;
    public float deathZone = -38f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.left * BulletSpeed)* Time.deltaTime;
        if (transform.position.x < deathZone)
        {
            Destroy(gameObject);
        }
    }
}
