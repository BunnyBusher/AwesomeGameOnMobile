using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    private int ActualScene;
    public UnityEvent OnGameStart;

    private void Start()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        ActualScene = activeScene.buildIndex;
    }



    [ContextMenu("Start Menu")]
    public void StartMenu()
    {
        SceneManager.LoadScene(0);
       
        
    }

    [ContextMenu("In Game")]
    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
        OnGameStart?.Invoke();




    }

    [ContextMenu("EndGame Menu")]
    public void EndGameMenu()
    {
        SceneManager.LoadScene(2);
    
    }



}
