using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    //子弹飞行速度  
    public float Speed = 4;

    // Update is called once per frame  
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if (transform.position.y >= 3.91f)
        {
            Destroy(this.gameObject);
        }
    }
}