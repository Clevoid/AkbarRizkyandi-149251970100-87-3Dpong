using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScropt : MonoBehaviour
{
    public void GameScreen(){
		SceneManager.LoadScene("GamePlay");
	}
	public void MainMenu(){
		SceneManager.LoadScene("MainMenu");
	}
	public void HowToPlay(){
		SceneManager.LoadScene("HowToPlay");
	}
	public void Exit(){
		Application.Quit();
	}
}
