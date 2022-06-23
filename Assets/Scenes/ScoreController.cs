using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public Text ScoreP1;
	public Text ScoreP2;
	public Text ScoreP3;
	public Text ScoreP4;
	
	public ScoreManager manager;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreP1.text = manager.ScorePlayer1.ToString();
		ScoreP2.text = manager.ScorePlayer2.ToString();
		ScoreP3.text = manager.ScorePlayer3.ToString();
		ScoreP4.text = manager.ScorePlayer4.ToString();
    }
}
