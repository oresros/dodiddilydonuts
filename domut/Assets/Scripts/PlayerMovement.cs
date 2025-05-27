using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb; // Creates Rigidbody (component that affects character physics)

    [System.Obsolete]
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Looks at inputs from "a" and "d" keys
        float vertical = Input.GetAxis("Vertical"); // Looks at inputs from "w" and "s" keys

        rb.velocity = new Vector2(horizontal, vertical) * speed; // moves the player in direction inputted by "w", "a", "s", and "d" keys
    }
}

