using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private Camera playerCamera;

    [SerializeField]
    private PlayerMovementSO movementSettings;

    [SerializeField]
    private float cameraSpeed;

    [SerializeField]
    private string floorTag = "";

    [SerializeField]
    private float raycastBestHeight;

    [SerializeField]
    private Rigidbody playerRb;

    [SerializeField]
    private PickableItemSpawner spawner;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameController.Instance.Controls.Player.Jump.performed += _ => Jump();
    }

    public void UpdateController()
    {
        Vector2 movementInput = GameController.Instance.Controls.Player.Move.ReadValue<Vector2>();
        Vector2 mouseInput = GameController.Instance.Controls.Player.CameraRotate.ReadValue<Vector2>();

        Move(movementInput);
        MoveCamera(mouseInput);
    }

    private void Move(Vector2 input)
    {
        Vector3 movement = new Vector3(input.x, 0.0f, input.y);
        transform.Translate(movement * movementSettings.MovementSpeed * Time.deltaTime, Space.Self);
    }

    private void MoveCamera(Vector2 input)
    {
        transform.Rotate(Vector3.up, input.x * cameraSpeed * Time.deltaTime);

        float currentRotationX = playerCamera.transform.localEulerAngles.x;
        currentRotationX += -input.y * cameraSpeed * Time.deltaTime;

        if (currentRotationX < 180)
        {
            currentRotationX = Mathf.Min(currentRotationX, 60);
        }
        else if (currentRotationX > 180)
        {
            currentRotationX = Mathf.Max(currentRotationX, 300);
        }

        playerCamera.transform.localEulerAngles
            = new Vector3(currentRotationX, 0, 0);
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            playerRb.AddForce(Vector3.up * movementSettings.JumpForce, ForceMode.Impulse);
            //to remove
            spawner.SpawnPickableItem();
            Debug.Log("Jump");
        }
    }

    private bool IsGrounded()
    {
        Vector3 directionalRay = transform.TransformDirection(Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, directionalRay, out hit, raycastBestHeight))
        {
            if (hit.collider.CompareTag(floorTag))
            {
                return true;
            }
        }

        return false;
    }
}
