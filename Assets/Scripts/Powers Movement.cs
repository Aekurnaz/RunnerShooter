using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersMovement : MonoBehaviour
{

    [SerializeField] private float _powersSpeed;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * _powersSpeed * Time.deltaTime);
    }
}
