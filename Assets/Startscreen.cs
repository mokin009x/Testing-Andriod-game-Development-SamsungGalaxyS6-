using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Startscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void Playbutton()
    {
        SceneManager.LoadScene("1");
    }

   public  void QuitButton()
    {
        Application.Quit();
    }
}
