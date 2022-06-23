using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Canvas : MonoBehaviour
{
    public void Replay(){
		SceneManager.LoadScene("GamePlay"); 
	}
	public void MainMenu(){
		SceneManager.LoadScene("MainMenu");
	}
}