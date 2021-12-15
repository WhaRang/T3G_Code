using UnityEngine;

[CreateAssetMenu(fileName = "New Movement", menuName = "Player Movement")]
public class PlayerMovementSO : ScriptableObject
{
    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float movementSpeed;

    public float JumpForce => jumpForce;

    public float MovementSpeed => movementSpeed;
}
