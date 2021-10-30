using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           LoadNextLevel(); 
        }
    }
    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel("Dev Scene"));
    }

    IEnumerator LoadLevel(string levelIndex)
    {
        transition.SetTrigger("Start");                     //Play animation

        yield return new WaitForSeconds(transitionTime);    //Wait

        SceneManager.LoadScene(levelIndex);                 //Load Scene
    }
}
