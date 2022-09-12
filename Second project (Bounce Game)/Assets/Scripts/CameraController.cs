using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;

    private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _player.transform.position;

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;
    }
}
