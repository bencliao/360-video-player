using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 3;

    void Update() {
        if (Input.GetMouseButton(0)) {
            transform.RotateAround(transform.position, -Vector3.up, scrollSpeed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, transform.right, scrollSpeed * Input.GetAxis("Mouse Y"));
        }
    }
}
