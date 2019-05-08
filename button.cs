using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {

	void Start () {
		}	
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
