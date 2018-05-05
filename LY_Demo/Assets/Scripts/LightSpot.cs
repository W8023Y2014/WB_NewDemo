using RenderHeads.Media.AVProVideo;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightSpot : MonoBehaviour
{
    public MediaPlayer mediaPlayer;

    private Transform spot;
    private Transform launch;
    private Transform playback;
    private Transform pause;

    private Vector3 playbackPos;
    private Vector3 pausePos;

    public Action LaunchBack;

    private void Start()
    {
        spot = transform.Find("spot");
        launch = transform.Find("launch");
        playback = transform.Find("launch/playback");
        pause = transform.Find("launch/pause");
         
        playbackPos = playback.position;
        pausePos = pause.position;

        Restart();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void Restart()
    {
        spot.gameObject.SetActive(true);
        launch.gameObject.SetActive(false);
        playback.localPosition = Vector3.zero;
        pause.localPosition = Vector3.zero;
    }

    public void ClickSpot()
    {
        spot.gameObject.SetActive(false);
        launch.gameObject.SetActive(true);

        iTween.MoveTo(playback.gameObject, playbackPos, 0.5f);
        iTween.MoveTo(pause.gameObject, pausePos, 0.5f);
    }

    public void Pause()
    {
        mediaPlayer.Pause();
    }

    public void Launch()
    {
        if (LaunchBack != null)
        {
            LaunchBack.Invoke();
        }
    }

    public void Playback()
    {
        mediaPlayer.Rewind(false);
        mediaPlayer.Play();

    }
}