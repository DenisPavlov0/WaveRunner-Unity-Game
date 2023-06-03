using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorChanger : MonoBehaviour
{
   
    [SerializeField]
    private float _recoloringSpeed = 0.5f;
    [SerializeField]
    private Color _startColor = Color.blue;
    [SerializeField]
    private Color _endColor = Color.green;
    
    private SpriteRenderer _spriteRenderer;
    private float _currentTime;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        
        float t = Mathf.PingPong(Time.time * _recoloringSpeed, 1f);
        Color newColor = Color.Lerp(_startColor, _endColor, t);
        _spriteRenderer.color = newColor;
    }
}
