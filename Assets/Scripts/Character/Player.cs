using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector2 _movementDirection;

    private Rigidbody _rb; 

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Initialize(myPlayer:this);
        InputManager.Gamemode(); 

        _rb = GetComponent<Rigidbody>();

    }

    public void SetMovementDirection(Vector2 newDirection)
    {
        _movementDirection = newDirection; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(speed * Time.deltaTime * _movementDirection); 
    }
}
