using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Play() {
        videoPlayer.Play();
    }

    private void Pause() {
        videoPlayer.Pause();
    }

    private void Stop() {
        videoPlayer.Stop();
    }

    public void PlayPause() {
        if (videoPlayer.isPlaying) {
            Pause();
        }
        else {
            Play();
        }
    }

    public void URLToVideo(string url) {
        Debug.Log("Now Playing: " + url);
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += prepareCompleted;
    }

    private void prepareCompleted(VideoPlayer source) {
        Play();
    }
}
