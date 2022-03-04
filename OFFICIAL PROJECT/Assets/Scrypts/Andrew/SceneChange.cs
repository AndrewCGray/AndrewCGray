using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int RoomID;
    public string EnterNextSceneFrom;
    public bool toggle;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        BetweenScenesManager.Instance.enterFrom = EnterNextSceneFrom;
        SceneManager.LoadScene(RoomID);
    }
}
