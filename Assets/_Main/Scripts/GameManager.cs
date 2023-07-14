using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RanchiMusuem
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private SceneSwitcher sceneSwitcher;
        [SerializeField] private string mainMenuSceneName;
        [SerializeField] private string videoSceneName;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        [ContextMenu("Test")]
        public void PlayTest()
        {
            PlayVideo();
        }

        public void PlayVideo()
        {
            sceneSwitcher.SwitchScene(videoSceneName);
        }

        [ContextMenu("Stop")]
        public void StopVideo()
        {
            sceneSwitcher.SwitchScene(mainMenuSceneName);
        }
    }
}
