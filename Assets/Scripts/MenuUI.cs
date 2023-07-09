using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using TMPro;

public class MenuUI : MonoBehaviour
{
    [SerializeField] TMP_Text enterName;

    public void StartNew()
    {
        GameData.Instance.playerName = enterName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        GameData.Instance.SaveName();
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
