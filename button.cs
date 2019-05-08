using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public void EasyDown(){
        SceneManager.LoadScene("EasyMode");
    }
    public void NoramlDown(){
        SceneManager.LoadScene("Game Scene");
    }
    public void HardDown(){
        SceneManager.LoadScene("HardMode");
    }
}