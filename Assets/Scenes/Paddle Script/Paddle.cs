using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	public bool Pad1;
	public KeyCode TombolLeftP1;
	public KeyCode TombolRightP1;
	public bool Pad2;
	public KeyCode TombolUpP2;
	public KeyCode TombolBottomP2;
	public bool Pad3;
	public KeyCode TombolUpP3;
	public KeyCode TombolBottomP3;
	public bool Pad4;
	public KeyCode TombolLeftP4;
	public KeyCode TombolRightP4;
	
	public float multiperSpeed;
	private Vector3 speed;
	private Rigidbody rig;
	
	public ScoreManager manager;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		MovePaddle(InputMove());
    }
	
	private Vector3 InputMove(){
		speed = Vector3.zero; 
        // get input  && manager.MovePad1
		if(Pad1){
			if (Input.GetKey(TombolLeftP1)) 
			{ 
				speed = Vector3.left * multiperSpeed;
			} 
			else if (Input.GetKey(TombolRightP1)) 
			{ 
				speed = Vector3.right * multiperSpeed; 
			} 
		}
		else if(Pad2){
			if (Input.GetKey(TombolUpP2)) 
			{ 
				speed = Vector3.left * multiperSpeed; 
			} 
			else if (Input.GetKey(TombolBottomP2)) 
			{ 
				speed = Vector3.right * multiperSpeed; 
			}
		}
		else if(Pad3){
			if (Input.GetKey(TombolUpP3)) 
			{ 
				speed = Vector3.forward * multiperSpeed; 
			} 
			else if (Input.GetKey(TombolBottomP3)) 
			{ 
				speed = Vector3.back * multiperSpeed; 
			}
		}
		else if(Pad4){
			if (Input.GetKey(TombolLeftP4)) 
			{ 
				speed = Vector3.forward * multiperSpeed; 
			} 
			else if (Input.GetKey(TombolRightP4)) 
			{ 
				speed = Vector3.back * multiperSpeed; 
			} 
		}
		return speed;
	}
	
	private void MovePaddle(Vector3 move){
		//transform.Translate(speed * Time.deltaTime);
		rig.velocity = move;
	}
}
