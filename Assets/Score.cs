using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	int score = 0;
	private GameObject scoreText;

	// Use this for initialization
	void Start () {

		scoreText = GameObject.Find ("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (collision.gameObject.tag == "LargeStarTag") {
			score += 20;
		} else if (collision.gameObject.tag == "SmallCloudTag") {
			score += 30;
		} else if (collision.gameObject.tag == "LargeCloudTag") {
			score += 50;
		}
		scoreText.GetComponent<Text> ().text = "score " + score.ToString();
	}
}
