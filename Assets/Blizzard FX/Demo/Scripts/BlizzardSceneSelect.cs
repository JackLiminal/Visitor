using UnityEngine;
using UnityEngine.SceneManagement;

public class BlizzardSceneSelect : MonoBehaviour
{
    public void LoadBlizzardDemo01()
    {
        SceneManager.LoadScene("blizzard_demo01");
    }
    public void LoadBlizzardDemo02()
    {
        SceneManager.LoadScene("blizzard_demo02");
    }
    public void LoadBlizzardDemo03()
    {
        SceneManager.LoadScene("blizzard_demo03");
    }
}