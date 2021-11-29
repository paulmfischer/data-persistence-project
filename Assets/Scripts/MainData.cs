using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainData : MonoBehaviour
{
    public static MainData Instance;

    public string UserName;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
