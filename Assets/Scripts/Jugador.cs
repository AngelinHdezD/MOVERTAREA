using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float Speed = 5f;

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(HorizontalInput,0,VerticalInput);
        transform.position = transform.position + movementDirection * Speed * Time.deltaTime;

    }
}
