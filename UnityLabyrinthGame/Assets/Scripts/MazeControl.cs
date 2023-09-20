using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MazeControl : MonoBehaviour
{
    [SerializeField] [Range(1f, 100f)] float sensitivity;
    [SerializeField] InputAction mouseMovement;
    [SerializeField] InputAction enableRotation;

    // Start is called before the first frame update
    void Start()
    {
        mouseMovement.Enable();
        enableRotation.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (enableRotation.IsPressed())
        {
            Vector2 mouseDelta = mouseMovement.ReadValue<Vector2>().normalized;
            transform.rotation = Quaternion.Euler(
                transform.eulerAngles.x + -mouseDelta.y * sensitivity * Time.deltaTime,
                0,
                transform.eulerAngles.z + mouseDelta.x * sensitivity * Time.deltaTime
            );
        }
    }
}
