using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	private Rigidbody rig;
	public Vector3 speed;
	public float multiper;
	public Collider Player1;
	public Collider Player2;
	public Collider Player3;
	public Collider Player4;
	
	public ScoreManager score;
	public GenerateBolaRandom generateBola;
	
	private float timer;
	private bool startBall;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
		rig.velocity = speed * multiper;
		startBall = true;
    }

    // Update is called once per frame
    void Update()
    {
		generateBolaAwal();
    }
	
	private void OnTriggerEnter(Collider collision){
		if(collision == Player1){
			score.TambahScorePlayer1(1);
			generateBola.RemoveBolaHasil(gameObject); 
		}
		else if(collision == Player2){
			score.TambahScorePlayer2(1);
			generateBola.RemoveBolaHasil(gameObject); 
		}
		else if(collision == Player3){
			score.TambahScorePlayer3(1);
			generateBola.RemoveBolaHasil(gameObject); 
		}
		else if(collision == Player4){
			score.TambahScorePlayer4(1);
			generateBola.RemoveBolaHasil(gameObject); 
		}
	}
	
	private void generateBolaAwal(){
		timer += Time.deltaTime;
		if(timer > 0.5f && startBall){
			rig.constraints = RigidbodyConstraints.FreezePositionY;
			//Debug.Log("freeze");
			startBall=false;
		}
	}
}
