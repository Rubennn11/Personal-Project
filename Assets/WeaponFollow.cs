using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(1, 0, 0); // Default offset value

    void Start()
    {
        // Example: Adjust the offset values in code
        offset = new Vector3(1, 0, 0); // Adjust X offset
        // offset = new Vector3(0, 1, 0); // Adjust Y offset
        // offset = new Vector3(0, 0, 1); // Adjust Z offset (for sorting)
    }

    void Update()
    {
        // Make the weapon follow the player with the specified offset
        transform.position = player.position + offset;
    }
}
