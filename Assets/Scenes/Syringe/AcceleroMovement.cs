using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleroMovement : MonoBehaviour
{
    [SerializeField] public float Movespeed = 0.5f;
    [SerializeField] public float maxMagnitude = 1.0f;
    private void Update()
    {
        Vector2 direction = new Vector2(Input.acceleration.x, Input.acceleration.y);
        float acceleration = Movespeed;

        // Restrict movement to 2D space
        direction = Vector2.ClampMagnitude(direction, maxMagnitude);

        transform.Translate(direction * acceleration);

        //Found some helpfull unity implementation https://docs.unity3d.com/ScriptReference/Vector2.html and took inspiration from 
    }
}