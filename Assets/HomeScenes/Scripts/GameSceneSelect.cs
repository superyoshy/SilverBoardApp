using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameSceneSelect : MonoBehaviour
{
    public GameObject BattlePanel;
    public GameObject CharaSelectPanel;

    // ホームボタンを押した時に実行
    public void Onclickhome()
    {
        BattlePanel.SetActive(false);
        CharaSelectPanel.SetActive(false);
    }

    // バトルボタンを押した時に実行
    public void Onclickbattle()
    {
        BattlePanel.SetActive(true);
        CharaSelectPanel.SetActive(false);
    }

    // キャラ選択ボタンを押した時に実行
    public void Onclickcharaselect()
    {
        BattlePanel.SetActive(false);
        CharaSelectPanel.SetActive(true);
    }

    public void Onclickbattlestart()
    {
        SceneManager.LoadScene("Battle");
    }
}
