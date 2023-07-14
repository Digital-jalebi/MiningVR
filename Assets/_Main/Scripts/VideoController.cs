using System.IO;
using UnityEngine;
using UnityEngine.Video;

namespace RanchiMusuem
{
    public class VideoController : MonoBehaviour
    {
        [SerializeField] private Material videoMat;
        private VideoPlayer videoPlayer;

        private void Awake()
        {
            videoPlayer = GetComponent<VideoPlayer>();

            videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
        }

        private void VideoPlayer_prepareCompleted(VideoPlayer source)
        {
            videoMat.color = Color.white;
        }

        private void Start()
        {
            videoPlayer.url = Path.Combine(Application.streamingAssetsPath, "Video.mp4");
            videoMat.color = Color.black;
            //videoPlayer.Play();
        }

        public void OnClick_Home()
        {
            //videoPlayer.Stop();
            GameManager.Instance.StopVideo();
        }

        public void OnClick_Restart()
        {
            videoMat.color = Color.black;
            videoPlayer.Stop();
            videoPlayer.Play();
        }

        public void TogglePause(bool val)
        {
            if (val)
            {
                videoPlayer.Play();
            }
            else
            {
                videoPlayer.Pause();
            }
        }
    }
}
