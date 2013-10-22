using UnityEngine;
using System.Collections;

public class WalkController : MonoBehaviour {
	[HideInInspector]public float speed = 6.0F;
	[HideInInspector]public enum facing {Right,Left}
	[HideInInspector]public enum moving {Right, Left, Stand}
	[HideInInspector]public bool isLeft;
	[HideInInspector]public bool isRight;
	[HideInInspector]public bool isJump;
	public facing facingDir;
	public moving movingDir;
	public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	
	void Start(){
		controller = GetComponent<CharacterController>();
	}
	
    void FixedUpdate() {
		
		isLeft = false;
		isRight = false;
		
        if (controller.isGrounded) {
			
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump")){
                moveDirection.y = jumpSpeed;
			}
        }else{
			if(Input.GetAxis("Horizontal")==0){
				
			}else{
				moveDirection = new Vector3(Input.GetAxis("Horizontal"),moveDirection.y,0);
				moveDirection = transform.TransformDirection(moveDirection);
            	moveDirection.x *= speed;
			}
		}
		
		if(moveDirection.x > 0){
			isRight=true;
			facingDir = facing.Right;
		}else{
			if(moveDirection.x < 0){
				isLeft = true;
				facingDir = facing.Left;
			}else{  }
		}
		
		moveDirection.y -= gravity * Time.deltaTime;
		moveDirection.Set(moveDirection.x,moveDirection.y,0);
        controller.Move(moveDirection * Time.deltaTime);

    }
	
	void OnTriggerEnter(Collider target){
		
		
	}
	
	void OnTriggerExit(Collider target){
		
	}
	
	public void setMoveSpeed(float speed){
		this.speed = speed;
	}
		
}

