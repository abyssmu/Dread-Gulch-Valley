using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	private Card[] cards = new Card[52];

	bool pressed, go;

	// Use this for initialization
	void Start () {
		pressed = false;
		go = true;

		//Loop through all cards and create new
		for (int i = 0; i < 52; ++i) {
			cards[i] = new Card();
		}

		//Load cards
		string[] suit = { "C", "S", "H", "D" };
		string value;
		string[] royal = { "A", "J", "Q", "K" };
		int val = 2;
		int pos = 0;

		for (int j = 0; j < 4; ++j) {
			for (int k = 0; k < 9; ++k) {
				value = val.ToString () + suit [j];
				cards [pos].cardName = value;
				cards [pos].value = val;
				++val;
				++pos;
			}
			val = 2;
		}

		for (int i = 0; i < 4; ++i) {
			for (int j = 0; j < 4; ++j) {
				value = royal [i] + suit [j];
				cards [pos].cardName = value;
				cards [pos].value = 11;
				++pos;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (pressed && go) {
			SelectCard ();
			go = false;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			pressed = true;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			go = true;
		}
	}

	void SelectCard()
	{
		int yourVal, myVal;
		yourVal = myVal = 0;

		int cardNum = Random.Range (0, 52);
		GameObject.FindGameObjectWithTag ("yourCard").GetComponent<Text> ().text = cards [cardNum].cardName;
		yourVal = cards [cardNum].value;

		cardNum = Random.Range (0, 52);
		GameObject.FindGameObjectWithTag ("myCard").GetComponent<Text> ().text = cards [cardNum].cardName;
		myVal = cards [cardNum].value;

		if (yourVal > myVal) {
			GameObject.FindGameObjectWithTag ("winLoss").GetComponent<Text> ().text = "You win!";
		} else if (yourVal < myVal) {
			GameObject.FindGameObjectWithTag ("winLoss").GetComponent<Text> ().text = "You lose!";
		} else {
			GameObject.FindGameObjectWithTag ("winLoss").GetComponent<Text> ().text = "Draw!";
		}

		pressed = false;
	}

	public class Card
	{
		public string cardName;
		public int value;
	}
}