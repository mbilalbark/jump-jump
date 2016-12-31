using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreTable : MonoBehaviour {

    private int score;
    
    public Text text;
    // Use this for initialization
    void Awake() {
        score = 0;
        Updatescore();
        text = GetComponent<Text>();
        
    }
	// Update is called once per frame
    public void addScore( int newscore)
    {
        score += newscore;
        Updatescore();

    }

	void Updatescore () {
        text.text = "Score:" + score;
    }
}
