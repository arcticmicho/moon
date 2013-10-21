using UnityEngine;
using System.Collections;

public class Running : MonoBehaviour {
	
	public WalkController walker;
	public float speedWalk = 6.0F;
	public float speedRun = 20.0F;

	// Use this for initialization
	void Start () {
		walker.setMoveSpeed(speedWalk);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.Q)){
			if (walker.speed != speedRun){
				walker.setMoveSpeed(speedRun);
				Debug.Log("Aumente Velocidad");
			}
			
		}else{
			if (walker.speed != speedWalk){
				walker.setMoveSpeed(speedWalk);
				Debug.Log("Baje Velocidad");
			}
		}
	
	}
}
