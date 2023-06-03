using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingObstacleMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    private Vector3 startPoint = new (-3, 0);
    private Vector3 endPoint = new (3, 0);

    private float _currentTime;

    void Update()
    {
        _currentTime += Time.deltaTime;
        float progress = Mathf.PingPong(_currentTime,moveSpeed)/moveSpeed;
        transform.position = Vector3.Lerp(startPoint, endPoint, progress);
    }
}
