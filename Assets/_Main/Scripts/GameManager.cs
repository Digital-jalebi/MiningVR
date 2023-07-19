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

        public void PlayVideo(string videoSceneName)
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
