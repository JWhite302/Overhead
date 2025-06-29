using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Transform firePosition;
    public GameObject projectile;

    private Vector2 moveDirection;
    void Update()
    {
        ProcessInputs();
        WeaponInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    void WeaponInputs()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateLeft();
            FireWeapon();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateRight();
            FireWeapon();
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            RotateUp();
            FireWeapon();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            RotateDown();
            FireWeapon();
        }
        /*else if(Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateUpLeft();
            FireWeapon();
        }*/
    }
    void RotateLeft()
    {
        transform.rotation = Quaternion.Euler(0, 0, 180);
    }
    void RotateRight()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

    }
    void RotateUp()
    {
        transform.rotation = Quaternion.Euler(0, 0, 90);

    }
    void RotateDown()
    {
        transform.rotation = Quaternion.Euler(0, 0, 270);

    }
    /*void RotateUpLeft()
    {
        transform.rotation = Quaternion.Euler(0, 0, 135);
    }
    void RotateUpRight()
    {
        transform.rotation = Quaternion.Euler(0, 0, 45);
    }
    void RotateDownLeft()
    {
        transform.rotation = Quaternion.Euler(0, 0, 225);
    }
    void RotateDownRight()
    {
        transform.rotation = Quaternion.Euler(0, 0, 315);
    }*/
    void FireWeapon()
    {
        Instantiate(projectile, firePosition.position, firePosition.rotation);
    }
    
}
