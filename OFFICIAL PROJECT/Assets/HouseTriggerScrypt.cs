using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseTriggerScrypt : MonoBehaviour
{
    public int triggerScene; //The Scene we want to transition to

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(triggerScene);
    }
}
