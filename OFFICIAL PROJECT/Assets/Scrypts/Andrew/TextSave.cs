using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSave : MonoBehaviour
{
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        SaveSystem.SaveString(new SaveData(text));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(SaveSystem.LoadString().text);
        }
    }
}
