using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour {

    public Transform ShowMedia;
    public MediaPlayer mediaPlayer;


    Transform Item2;
    Transform Item3;
    Transform Item4; 
     
    // Use this for initialization
    void Start () {
        Item2 = transform.Find("Group/Item2");
        Item3 = transform.Find("Group/Item3");
        Item4 = transform.Find("Group/Item4");

        Item2.gameObject.SetActive(false);
        Item3.gameObject.SetActive(false);
        Item4.gameObject.SetActive(false);

        ShowMedia.gameObject.SetActive(false);

        ShowMedia.GetComponentInChildren<LightSpot>().LaunchBack = () =>
        {
            ShowMedia.gameObject.SetActive(false);
            mediaPlayer.Stop();
        };
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchKeJiChuangXinChild()
    {
        Item2.gameObject.SetActive(!Item2.gameObject.activeSelf);
        Item3.gameObject.SetActive(!Item3.gameObject.activeSelf);
        Item4.gameObject.SetActive(!Item4.gameObject.activeSelf);
    }

    public void PlayMedia()
    {
        ShowMedia.GetComponentInChildren<LightSpot>().Restart();
        ShowMedia.gameObject.SetActive(true); 
        mediaPlayer.Rewind(false);
        mediaPlayer.Play();
        
    }

    public void BackMenuFormMedia()
    {
        ShowMedia.gameObject.SetActive(false); 
        mediaPlayer.Stop();
    }
}
