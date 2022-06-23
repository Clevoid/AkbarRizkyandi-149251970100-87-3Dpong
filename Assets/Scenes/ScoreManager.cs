using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public int ScorePlayer1;
	public int ScorePlayer2;
	public int ScorePlayer3;
	public int ScorePlayer4;
	public int maxScore;
	
	public Collider ColliderPlayer1;
	public Collider ColliderPlayer2;
	public Collider ColliderPlayer3;
	public Collider ColliderPlayer4;
	public GenerateBolaRandom GenerateBola;
	public Rigidbody PaddleP1;
	public Rigidbody PaddleP2;
	public Rigidbody PaddleP3;
	public Rigidbody PaddleP4;
	
	public GameObject gameOverScreen;
	public Text textPemenang;
	
	public void TambahScorePlayer1(int tambah) 
    {
		if(ScorePlayer1 + tambah >= maxScore){
			ColliderPlayer1.isTrigger = false;
			PaddleP1.constraints = RigidbodyConstraints.FreezeAll;
		}
		ScorePlayer1 += tambah;
		cekScore();
    } 
 
    public void TambahScorePlayer2(int tambah) 
    {
		if(ScorePlayer2  + tambah >= maxScore){
			ColliderPlayer2.isTrigger = false;
			PaddleP2.constraints = RigidbodyConstraints.FreezeAll;
		}
		ScorePlayer2 += tambah;
		cekScore();
    } 
	
	public void TambahScorePlayer3(int tambah) 
    {
		if(ScorePlayer3 + tambah >= maxScore){
			ColliderPlayer3.isTrigger = false;
			PaddleP3.constraints = RigidbodyConstraints.FreezeAll;
		}
		ScorePlayer3 += tambah;
		cekScore();
    } 
	
	public void TambahScorePlayer4(int tambah) 
    {
		if(ScorePlayer4 + tambah >= maxScore){
			ColliderPlayer4.isTrigger = false;
			PaddleP4.constraints = RigidbodyConstraints.FreezeAll;
		}
		ScorePlayer4 += tambah;
		cekScore();
    }
	
	void cekScore(){
		if(ScorePlayer1 < maxScore && ScorePlayer2 >= maxScore && ScorePlayer3 >= maxScore && ScorePlayer4 >= maxScore){
			GameOver("Player1");
		}
		else if(ScorePlayer1 >= maxScore && ScorePlayer2 < maxScore && ScorePlayer3 >= maxScore && ScorePlayer4 >= maxScore){
			GameOver("Player2");
		}
		else if(ScorePlayer1 >= maxScore && ScorePlayer2 >= maxScore && ScorePlayer3 < maxScore && ScorePlayer4 >= maxScore){
			GameOver("Player3");
		}
		else if(ScorePlayer1 >= maxScore && ScorePlayer2 >= maxScore && ScorePlayer3 >= maxScore && ScorePlayer4 < maxScore){
			GameOver("Player4");
		}
	}
 
    public void GameOver(string player) 
    {
		textPemenang.text = player;
		gameOverScreen.SetActive(true);
		gameOverScreen.transform.localScale = new Vector3(1.04f, 1.04f, 1.04f);
		GenerateBola.gameOver = true;
    }
}
