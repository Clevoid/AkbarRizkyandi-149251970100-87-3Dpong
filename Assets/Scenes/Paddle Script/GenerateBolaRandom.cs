using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBolaRandom : MonoBehaviour
{
	public List<GameObject> BolaTemplate;
	public List<GameObject> BolaHasil;
	public int MaxSpawn;
	public int TimeSpawn;
	public bool gameOver;
	
    private float timer;
	private int addBall;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if(timer > TimeSpawn){
			GenerateRandom();
			timer -= TimeSpawn;
		}
    }
	
	private void GenerateRandom(){
		int randomInt = Random.Range(0, BolaTemplate.Count);
		if(addBall < MaxSpawn && !gameOver){
			Vector3 bolaTerpilih = BolaTemplate[randomInt].transform.position;
			GameObject BolaBaru = Instantiate(BolaTemplate[randomInt], new Vector3(bolaTerpilih.x, bolaTerpilih.y, bolaTerpilih.z), Quaternion.identity);
			BolaBaru.SetActive(true);
			
			BolaHasil.Add(BolaBaru);
			addBall += 1;
			//Debug.Log(addBall);
		}
		//Debug.Log(randomInt);
	}
	
	public void RemoveBolaHasil(GameObject bola) 
    { 
        BolaHasil.Remove(bola); 
        Destroy(bola);
		addBall -=1;
    } 
}
