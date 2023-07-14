using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RanchiMusuem
{
    public class SceneSwitcher : MonoBehaviour
    {
        [SerializeField] private OVRScreenFade screenFader;
        [SerializeField] private float waitAfterLoadTime;

        public void SwitchScene(string sceneName)
        {
            StartCoroutine(LoadYourAsyncScene(sceneName));
        }

        IEnumerator LoadYourAsyncScene(string name)
        {
            yield return screenFader.Fade(0,1);
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(name);
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
            yield return new WaitForSeconds(waitAfterLoadTime);
            yield return screenFader.Fade(1, 0);
        }
    }
}
