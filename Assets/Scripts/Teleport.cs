using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    public string nextScene;
    public GameObject moveLocation;
    public GameObject switchScenes;

    private Player player;
    private bool isSwithScene;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        isSwithScene = !nextScene.Equals("");

        switchScenes.SetActive(isSwithScene);
        moveLocation.SetActive(!isSwithScene);
    }

    public void TeleportPlayer()
    {
        player.transform.position = transform.position;
        if (isSwithScene) SwitchScene();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    private void SwitchScene()
    {
        Fadeout fadeout = FindObjectOfType<Fadeout>();

        fadeout.FadeOut();
    }

    
}
