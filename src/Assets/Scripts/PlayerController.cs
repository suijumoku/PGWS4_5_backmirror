﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float FORWARD_ACCRLERATION = 30.0f; //加速
    [SerializeField] float SIDE_ACCELERATION = 100.0f;
    [SerializeField] float FORWARD_DAMPING = 4.0f; // 自動減速
    [SerializeField] float SIDE_DAMPING = 4.0f;

    float forward = 0.0f;
    float side = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        forward += z * FORWARD_ACCRLERATION * Time.deltaTime;
        side += x * SIDE_ACCELERATION * Time.deltaTime;

        // 移動
        transform.Translate(Vector3.forward * forward * Time.deltaTime);
        transform.Rotate(Vector3.up, side * forward * Time.deltaTime);

        // 自動減速
        forward -= forward * FORWARD_DAMPING * Time.deltaTime;
        side -= side * SIDE_DAMPING * Time.deltaTime;
    }
}
