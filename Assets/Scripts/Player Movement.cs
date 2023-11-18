using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _horizontalMovementSpeed = 1f;

    private Vector3 m_movementVector;
    private Vector2 m_mousePreviousPosition;
    private float currentMovementSpeed;
    private bool gameStarted;

    private void Awake()
    {
        m_movementVector = new Vector3();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentMovementSpeed = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        CalculateMovement();
    }

    private void MovementInput()
    {
        if (!Input.anyKey)
        {
            m_movementVector = Vector3.zero;
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            m_mousePreviousPosition = Vector2.zero;
            if (!gameStarted)
            {
                
                gameStarted = true;
            }
        }

        if (Input.GetMouseButton(0))
        {
            float mouseDelta = 0;

            mouseDelta = Input.mousePosition.x - m_mousePreviousPosition.x;
            m_mousePreviousPosition = Input.mousePosition;

            m_movementVector = Vector3.right * mouseDelta;
            m_movementVector.Normalize();
          
        }
    }

    private void CalculateMovement()
    {
        MovementInput();
        
        m_movementVector.Normalize();

        Vector3 newPosition = new Vector3();
       
        //Move horizontal
        newPosition.x += m_movementVector.x * _horizontalMovementSpeed * Time.deltaTime;
        transform.position += newPosition;
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -1.75f, 1.75f),
            transform.position.y,
            transform.position.z);
    }
}
