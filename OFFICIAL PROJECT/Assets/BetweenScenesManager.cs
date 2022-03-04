using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenScenesManager : MonoBehaviour
{
    public static BetweenScenesManager Instance;
    public Vector2 lastPos;
    public string enterFrom;
    public bool EnterSceneMatters;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
