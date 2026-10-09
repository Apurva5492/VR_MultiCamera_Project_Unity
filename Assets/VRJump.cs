using UnityEngine;

public class VRJump : MonoBehaviour
{
    public CharacterController controller;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;

    private Vector3 velocity;

    void Update()
    {
        if (controller.isGrounded)
        {
            if (velocity.y < 0)
                velocity.y = -2f;

            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = Mathf.Sqrt(
                    jumpHeight * -2f * gravity
                );
            }
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(
            velocity * Time.deltaTime
        );
    }
}
