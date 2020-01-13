using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class VideoPlayer : MonoBehaviour
{
    public MediaPlayer mediaPlayer;
    public string videoPath;

    // Start is called before the first frame update
    void Start()
    {
        StartVideo();
    }

    public void StartVideo()
    {
        Debug.LogError(Application.persistentDataPath);
        Debug.LogError("Full Path: " + Path.Combine(Application.persistentDataPath, videoPath));
        mediaPlayer.OpenVideoFromFile(MediaPlayer.FileLocation.AbsolutePathOrURL, Path.Combine(Application.persistentDataPath, videoPath), false);
        mediaPlayer.Control.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
