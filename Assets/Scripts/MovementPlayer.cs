using UnityEngine;
using UnityEngine.InputSystem;
public class MovementPlayer : MonoBehaviour
{
    public Rigidbody rb;
    InputAction moveAction;
    InputAction jumpAction;
    Vector2 movement;
    public bool jump;
    public bool trueJump;
    public float speed = 10f;
    public float jumpForce = 10f;
    public int numJump = 2;
    [SerializeField] LayerMask groundCheck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        movement = moveAction.ReadValue<Vector2>();
        jump = jumpAction.WasPressedThisFrame();
        if (jump)
        {
            trueJump = true;
        }
        Ray myRay = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(myRay, out RaycastHit hit, 2f, groundCheck))
        {
            numJump = 2;
        }

    }
    private void FixedUpdate()
    {
        Vector3 forcomponent = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up).normalized * movement.y;
        Vector3 horComponent = Camera.main.transform.right * movement.x;
        Vector3 inputMove = (forcomponent + horComponent).normalized * speed * Time.deltaTime;
        if (trueJump && numJump > 0)
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            trueJump = false;
            numJump--;
        }
        rb.MovePosition(inputMove + transform.position);
        rb.AddForce(Vector3.down * 10);
    }
}
