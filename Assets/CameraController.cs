using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public InputActions controls;

    private float camMoveSpeed = 20f;

    private void Awake()
    {
        controls = new InputActions();
    }

    private void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
        controls.Camera.Enable();
    }

    private void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");
        controls.Camera.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 moveCamera = controls.Camera.MoveCamera.ReadValue<Vector2>();
        Debug.Log(moveCamera);
        if (moveCamera != Vector2.zero)
        {
            transform.position += new Vector3(moveCamera.x, 0, moveCamera.y) * Time.deltaTime * camMoveSpeed;
        }
    }
}
