using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
	public Text score;
	public Text highScore;
	public int number;

	void Start()
	{		

		int.TryParse(score.text, out number);	

		highScore.text = ZPlayerPrefs.GetInt("HighScore", 0).ToString();
	}

	public void Update()
	{
		int.TryParse(score.text, out number); 

		if (number > ZPlayerPrefs.GetInt("HighScore", 0))
		{
			ZPlayerPrefs.SetInt("HighScore", number);
		}
	}



}
