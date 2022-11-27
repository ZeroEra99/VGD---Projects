using UnityEngine;

public class BodyMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Transform _cameraRoot;
    //Input variables 
    public float cursorSpeedHorizontal = 18f;
    //Movement variables
    [SerializeField] private float walkingSpeed=2f;
    [SerializeField] private float sprintSpeed=4f;
    [SerializeField] private float jumpForce=4f;
    private float speedOffset=0;
    //Gravity variables
    private float gravity = 9.81f;
    private float verticalSpeed;
    
    public void move()
    {
        //Get keyboard inputs
        float cursorInputHorizontal = Input.GetAxis("Mouse X")*cursorSpeedHorizontal;
        float keybordInputHorizontal = Input.GetAxis("Horizontal");
        float keyboardInputVertical = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(keybordInputHorizontal, 0f, keyboardInputVertical).normalized;

        //While the character's moving, match the moving direction to the direction at which the camera is aiming
        if (movementDirection.magnitude >= 0.1f) 
        { 
            float targetAngle = Mathf.Atan2(movementDirection.x, movementDirection.z) * Mathf.Rad2Deg + _cameraRoot.eulerAngles.y;
            //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothTime, turnSmoothVelocity);
            //transform.rotation= Quaternion.Euler(0f,angle,0f);
            movementDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        }
        
        //If user presses Spacebar and the character is grounded, apply jump force. Otherwise let it fall :D
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded) verticalSpeed = jumpForce;
        else verticalSpeed -= gravity*Time.deltaTime;
        
        //If the user is holding Shift, assign sprintSpeed to the speedOffset. 
        if (Input.GetKey(KeyCode.LeftShift)) speedOffset = sprintSpeed;
        else speedOffset = walkingSpeed;
        
        //Update the movement vector with the new values
        movementDirection.y = verticalSpeed;
        movementDirection.x *= speedOffset;
        movementDirection.z *= speedOffset;
        //Apply the movement to the character
        _characterController.Move(movementDirection*Time.deltaTime);
        
        //Rotate character's body accordingly to cursor input
        _characterController.transform.RotateAround(Vector3.up,cursorInputHorizontal*Time.deltaTime);
    }
}