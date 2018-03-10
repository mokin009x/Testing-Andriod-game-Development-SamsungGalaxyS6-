using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        SelectionMenu,
        Clicker,
        TextBasedGame,
        Runner,

    }

    // Use this for initialization
	void Start () {
	    StartClickerGame();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartClickerGame()
    {
        
       var gameselection = GameObject.Find("Canvas/InterFaces/GameSelect");
        gameselection.SetActive(true);
    }
}
