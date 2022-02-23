using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataPOCManager : MonoBehaviour
{
    public static DataPOCManager Instance;
    public int num;
    public Text text;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void numChange(int val)
    {
        this.num += val;
    }

    void Update()
    {
        //text.text = this.num.ToString();
    }


}
