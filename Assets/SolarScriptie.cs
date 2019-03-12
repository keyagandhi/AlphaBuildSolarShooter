﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarScriptie : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 3f;
    float velX;
    float velY;
    bool facingRight = true;
    Rigidbody2D rigBody;
    void Start()
    {
        rigBody = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        velY = rigBody.velocity.y;
        rigBody.velocity = new Vector2(velX * moveSpeed, velY);
               
    }
    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            facingRight = true;

        }
        else if (velX < 0) {
            facingRight = false;

        }
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }
        transform.localScale = localScale;
    }
}
