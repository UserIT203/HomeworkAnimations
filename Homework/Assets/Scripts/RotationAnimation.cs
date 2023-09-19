using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private float _rotationY;

    private void FixedUpdate()
    {
        _rotationY = _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, _rotationY, 0);
    }
}
