using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacleMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.3f;
    
    private Vector3 _startPoint = new (3, 3, 0);
    private Vector3 _endPoint = new (1, 1, 0);

    private float _currentTime;

    void Update()
    {
        _currentTime += Time.deltaTime;
        float progress = Mathf.PingPong(_currentTime,moveSpeed)/moveSpeed;
        transform.localScale = Vector3.Lerp(_startPoint, _endPoint, progress);
    }
}
