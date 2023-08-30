
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public static LevelControl levelControl;
    private void Awake() {
        levelControl = this;
    }

    public void RestartGame(){
       SceneManager.LoadScene(0);
    }

    public void LevelRestart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    
}
