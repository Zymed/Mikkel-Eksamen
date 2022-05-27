using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeAScene : MonoBehaviour
{
    [SerializeField] private Button button;
    private void Start()
    {
        button.onClick.AddListener(ChangeToMyScene);
    }

    public void ChangeToMyScene()
    {
        SceneManager.LoadScene(1);
    }
}
