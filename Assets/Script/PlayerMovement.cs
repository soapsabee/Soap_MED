using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    public float speed;
    private Rigidbody2D rigidbody;
    private Vector2 moveVelocity;
    public Transform R_AttackSpawnPos;
    public Transform L_AttackSpawnPos;
    public Transform W_AttackSpawnPos;
    public Transform S_AttackSpawnPos;
    public Transform SD_AttackSpawnPos;
    public Transform SA_AttackSpawnPos;
    public Transform WD_AttackSpawnPos;
    public Transform WA_AttackSpawnPos;


    public GameObject LeftAttack, RightAttack ,UpAttack, DownAttack,
        LeftUpAttack, RightUpAttack, RightDownAttack, LeftDownAttack;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        print(moveInput);
        /* print(moveInput);
         if(Input.GetAxisRaw("Horizontal") == 0.0 && Input.GetAxisRaw("Vertical") == 1.0)
         {
             print("W");
         } เราจะใช้วิธีประมาณนี้เพื่อ set ท่าทาง sprite*/

        flipActor();

        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }

    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + moveVelocity * Time.fixedDeltaTime);
    }

    private string face;
    
    private void flipActor()
    {
       
    if (Input.GetAxisRaw("Horizontal") == 1.0 && Input.GetAxisRaw("Vertical") == 0.0)
        {
            face = "Right";
        }
    else if (Input.GetAxisRaw("Horizontal") == -1.0 && Input.GetAxisRaw("Vertical") == 0.0)
        {
            face = "Left";
        }
    else if (Input.GetAxisRaw("Horizontal") == 0.0 && Input.GetAxisRaw("Vertical") == 1.0)
        {
            face = "Up";
        }
    else if (Input.GetAxisRaw("Horizontal") == 0.0 && Input.GetAxisRaw("Vertical") == -1.0)
        {
            face = "Down";
        }
    else if (Input.GetAxisRaw("Horizontal") == -1.0 && Input.GetAxisRaw("Vertical") == 1.0)
        {
            face = "UpLeft";
        }
    else if (Input.GetAxisRaw("Horizontal") == 1.0 && Input.GetAxisRaw("Vertical") == 1.0)
        {
            face = "UpRight";
        }
    else if (Input.GetAxisRaw("Horizontal") == -1.0 && Input.GetAxisRaw("Vertical") == -1.0)
        {
            face = "DownLeft";
        }
    else if (Input.GetAxisRaw("Horizontal") == 1.0 && Input.GetAxisRaw("Vertical") == -1.0)
        {
            face = "DownRight";
        }
    }

    

    private void Attack()
    {
        if (face == "Right")
        {
            Instantiate(RightAttack, R_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "Left")
        {
            Instantiate(LeftAttack, L_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "Up")
        {
            Instantiate(UpAttack, W_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "Down")
        {
            Instantiate(DownAttack, S_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "UpLeft")
        {
            Instantiate(LeftUpAttack, WA_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "UpRight")
        {
            Instantiate(RightUpAttack, WD_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "DownLeft")
        {
            Instantiate(LeftDownAttack, SA_AttackSpawnPos.position, Quaternion.identity);
        }
        else if (face == "DownRight")
        {
            Instantiate(RightDownAttack, SD_AttackSpawnPos.position, Quaternion.identity);
        }

    }
}
