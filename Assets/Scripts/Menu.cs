using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI userName;
    
    public void LoadGame()
    {
        MainData.Instance.UserName = userName.text;
        SceneManager.LoadScene("main");
    }
}
