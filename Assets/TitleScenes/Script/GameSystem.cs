using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    // スタートボタンを押したら実行
    public void StartGame()
    {
        SceneManager.LoadScene("Home");
    }
}
