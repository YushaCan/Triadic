using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    private void Start()
    {
        GameOver.isGameOver = false;
    }
    private void Update()
    {
        if (GameOver.isGameOver)
        {
            Play();
        }
    }
    public void Play()
    {
        StartCoroutine(OtherScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Restart()
    {
        StartCoroutine(OtherScene(SceneManager.GetActiveScene().buildIndex));
    }
    public IEnumerator OtherScene(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
