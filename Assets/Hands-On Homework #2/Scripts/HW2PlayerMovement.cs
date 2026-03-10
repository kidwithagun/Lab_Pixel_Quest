using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float _xSpeed;
    private float _ySpeed;

    public float speedModifier = 3;

    private string InputX = "Horizontal";
    private string InputY = "Vertical";

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Get the WASD or arrow key inputs
        _xSpeed = Input.GetAxis(InputX);
        _ySpeed = Input.GetAxis(InputY);

        //Calculate the speed of the player
        _rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed) * speedModifier;
    }
}
