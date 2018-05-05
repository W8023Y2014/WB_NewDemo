using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchControl : MonoBehaviour {
     
    public LightSpot lightSpot;
    public MediaPlayer mediaPlayer;

    void Start () {

        lightSpot.LaunchBack = () =>  
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single); 
        };

        mediaPlayer.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
     
    public void ClickPoint()
    {

    }


}
