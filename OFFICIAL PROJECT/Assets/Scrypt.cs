using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scrypt : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = DataPOCManager.Instance.num.ToString();
    }
    public void AddValue(int val)
    {
        DataPOCManager.Instance.num += val;
    }
    public void SceneChange(int val)
    {
        SceneManager.LoadScene(val);
    }
}
