using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private bool space;

    private ImageBabka imageBabka;
    private Health health;
    private bool deadStart;
    private float deathTime = 2f;

    private float timeToDeadFromTopValue = 7f;
    private float timeToDeadFromTop;
    private bool deadFromTop;

    [Header("Прыжок")]
    public Transform groundPoint;
    public LayerMask groundLayer;

    private float heightJump = 1f;

    [Header("Управление")]
    private InputControll controll;
    public GameObject joystickObject;
    public GameObject jumpButton;
    public Joystick joystick;

    private Touch touch;
    private Platform platform;

    private Rigidbody2D rb;

    private float speed = 6.5f;
    private float factorValue = 2f;
    private float jumpForce = 12f;

    private float moveInput;
    private float flipValue;

    private bool isGround;
    private bool run;

    private int extraJump;
    private int extraJumpValue = 1;

    private float gravityScale;
    private float gravityScaleSpace = .6f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        platform = GetComponent<Platform>();
        health = GetComponent<Health>();
        imageBabka = GetComponent<ImageBabka>();
        touch = GetComponent<Touch>();

        gravityScale = rb.gravityScale;

        if (space == true)
            InSpace();
    }
    
    private void Awake()
    {
        controll = new InputControll();
        
        //Jump
        controll.Controll.Jump.performed += context => Jump();
        
    }

    private void OnEnable()
    {
        controll.Enable();
    }

    private void OnDisable()
    {
        controll.Disable();
    }

    public void JumpPublic()
    {
        Jump();
    }

    public void GetMove(float speed)
    {
        rb.gravityScale = 0;
        rb.velocity = new Vector2(0, speed);
    }

    public void EndMove()
    {
        rb.gravityScale = gravityScale;
    }

    public void InSpace()
    {
        rb.gravityScale = gravityScaleSpace;
    }

    public float ReturnVerticalMove()
    {
        float move = MoveInputVertical();
        return move;
    }

    private void FixedUpdate()
    {
        if(health.isDead() == false)
        {
            float factor = 0;

            isGround = Ground();
            if (isGround)
            {
                extraJump = extraJumpValue;
                timeToDeadFromTop = 0f;
                if (deadFromTop)
                    health.GetDeath();

                /*if (Input.GetKey(KeyCode.LeftShift))
                    run = true;
                else
                    run = false;*/

            }
            else
            {
                if (deadFromTop == false)
                    timeToDeadFromTop += 1 * Time.deltaTime;
            }

            if (run)
                factor = factorValue;

            moveInput = MoveInput();
            rb.velocity = MovePerson(moveInput, speed + factor);

            if (moveInput != 0)
                flipValue = FlipValue(moveInput);
            
            transform.eulerAngles = VectorFlip(flipValue);

            if (timeToDeadFromTop > timeToDeadFromTopValue)
                deadFromTop = true;
        }
        else
        {
            rb.velocity = MovePerson(0, 0);
            rb.AddForce(transform.up * .3f, ForceMode2D.Impulse);
            imageBabka.StartTransperent();

            if (deadStart == false)
                StartCoroutine(Dead());
        }
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
            Jump();*/
        
        if(controll.Controll.Run.triggered)
            Debug.Log("run");

        if (platform.isAndroid())
            SetActiveControll(true);
        else
            SetActiveControll(false);

        if(transform.position.y < -25f)
            GetComponent<LoadLevel>().ReloadLevel();
        
        if(GetPlayerDown())
            touch.GetPlatformDown();
    }

    private void Jump()
    {
        if (extraJump == 1 && isGround)
        {
            extraJump -= 1;
            rb.velocity = Vector2.up * jumpForce * heightJump;
        }
    }

    private IEnumerator Dead()
    {
        deadStart = true;

        yield return new WaitForSeconds(deathTime);
        GetComponent<LoadLevel>().ReloadLevel();
    }


    // Вспомогательные методы
    private Vector3 VectorFlip(float count)
    {
        Vector3 vector = new Vector3(0, count, 0);
        return vector;
    }

    private float FlipValue(float count)
    {
        if (count > 0) return 180;
        return 0;
    }

    private Collider2D Ground()
    {
        Collider2D physics = Physics2D.OverlapCircle(groundPoint.position, 0.25f, groundLayer);
        return physics;
    }

    private Vector2 MovePerson(float moveInput, float speed)
    {
        Vector2 vector = new Vector2(moveInput * speed, rb.velocity.y);
        return vector;
    }

    private float MoveInput()
    {
        float input;
        if (platform.isAndroid())
            input = joystick.Horizontal;
        else
            input = controll.Controll.Move.ReadValue<float>();

        return input;
    }

    private float MoveInputVertical()
    {
        float input;
        if (platform.isAndroid())
            input = joystick.Vertical;
        else
            input = controll.Controll.MoveVertical.ReadValue<float>();

        return input;
    }

    private void SetActiveControll(bool active)
    {
        joystickObject.SetActive(active);
        jumpButton.SetActive(active);
    }

    private bool GetPlayerDown()
    {
        if (platform.isAndroid())
            return joystick.Vertical <= -.9f;
        else
            return controll.Controll.ActionS.triggered;
        
        return false;
    }
}
