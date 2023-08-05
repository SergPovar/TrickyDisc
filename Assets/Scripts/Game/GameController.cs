using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameController: MonoBehaviour
    {
        [SerializeField]
        private float _sceneChangeDelay;
        [UsedImplicitly]
        public void OnPlayerDied() 
        {
            StartCoroutine(ShowGameOver());
        }
        private IEnumerator ShowGameOver()
        {
            yield return new WaitForSeconds(_sceneChangeDelay);
            SceneManager.LoadSceneAsync(GlobalConstants.GAME_OVER_SCENE);
        }
        private void Awake()
        {
            //максимальное значение кадров в секунду
            Application.targetFrameRate = 60;
        }
    }
}