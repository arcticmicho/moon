using UnityEngine;
using System.Collections;

public class WalkAnim : MonoBehaviour {
	
	public enum anim {Stand,WalkLeft,WalkRight,StandLeft,StandRight,RunLeft,RunRight,JumpLeft,JumpRight}
	private anim currentAnim;
	public WalkController character;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(character.isLeft && currentAnim != anim.WalkLeft){
			currentAnim = anim.WalkLeft;
			transform.localScale = new Vector3(-1,1,1);
			
		}
		
		if(!character.isLeft && currentAnim != anim.StandLeft && character.facingDir == WalkController.facing.Left){
			currentAnim = anim.StandLeft;
			transform.localScale = new Vector3(-1,1,1);
		}
		
		if(character.isRight && currentAnim != anim.WalkRight){
			currentAnim = anim.WalkRight;
			transform.localScale = new Vector3(1,1,1);
		}
		
		if(!character.isRight && currentAnim != anim.StandRight && character.facingDir == WalkController.facing.Right){
			currentAnim = anim.StandRight;
			transform.localScale = new Vector3(1,1,1);
		}
		
	
	}
}
