using UnityEngine;
using UnityEngine.InputSystem;
public class CamMovement : MonoBehaviour
{
    Transform target;
    public float lerpFactor = .2f;
    Vector2 mouseInput;
    Vector2 camRot;
    InputAction lookAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lookAction = InputSystem.actions.FindAction("Look");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseInput = lookAction.ReadValue<Vector2>();
        camRot.x += mouseInput.x / 4;
        camRot.y -= mouseInput.y / 4;
        camRot.y = Mathf.Clamp(camRot.y, -40, 90);
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(camRot.y, camRot.x, 0);
        transform.position = Vector3.Lerp(transform.position, target.position, lerpFactor);
    }
}
