using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("sheesh");
    }

    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
