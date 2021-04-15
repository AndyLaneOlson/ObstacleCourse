using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float movementSpeed = 1.0f;

    void Start()
    {

    }


    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(-xValue, yValue, 0);
    }
}
