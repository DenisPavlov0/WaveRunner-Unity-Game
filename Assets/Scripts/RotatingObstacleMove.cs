using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacleMove : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 90f;
    
    
    void Update()
    {
        var progress = _rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, progress);
    }
}
