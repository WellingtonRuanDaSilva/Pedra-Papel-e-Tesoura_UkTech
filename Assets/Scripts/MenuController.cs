using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private Animator initializationAnimation;

    public void PlayGame()
    {
        StartCoroutine(ChangeScene("GamePlay"));
    }

    IEnumerator ChangeScene(string name)
    {
        yield return new WaitForSeconds(0.3f);
        initializationAnimation.Play("Transition");
        yield return new WaitForSeconds(2.1f);
        SceneManager.LoadScene(name);
    }
}
