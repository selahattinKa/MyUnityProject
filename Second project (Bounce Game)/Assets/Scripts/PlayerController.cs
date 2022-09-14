using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public float _speed = 0;

    private Rigidbody _rb;

    private float _movementX;

    private float _movementY;

    private int _score;

    public TextMeshProUGUI _scoreBoard;
    public GameObject _winObject;

    public GameObject _start;
    public GameObject _restart;
    public GameObject _newGame;
    public GameObject _exit;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        _rb = GetComponent<Rigidbody>();
        _score = 0;
        
        _winObject.SetActive(false);
        SetScoreBoard();
        _start.SetActive(true);
        
        _newGame.SetActive(false);
        _restart.SetActive(false);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;
        _movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(_movementX, 0.0f, _movementY);
        
        _rb.AddForce(movement*_speed) ;
    }

    private void Update()
    {
        if (Time.timeScale == 1)
        {
            _start.SetActive(false);
            _exit.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            _score++;
            SetScoreBoard();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PickSilver"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            _score--;
            SetScoreBoard();
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PickBronze"))
        {
                //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            _score++;
            SetScoreBoard();
            
        }
    }*/

    void SetScoreBoard()
    {
        _scoreBoard.text = _score.ToString();

        if (_score >= 7)
        {
            Time.timeScale = 0;
            _winObject.SetActive(true);
            
            _newGame.SetActive(true);
            _restart.SetActive(true);
        }
    }
}
