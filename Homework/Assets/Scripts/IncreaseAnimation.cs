using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseAnimation : MonoBehaviour
{
    [SerializeField] private float _incereaseSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_incereaseSpeed, _incereaseSpeed, _incereaseSpeed);
    }
}
