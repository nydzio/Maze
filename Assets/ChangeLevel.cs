using Assets;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    static TimeCounter timeCounter;

    internal static TimeCounter TimeCounter { get => timeCounter; set => timeCounter = value; }

    // Start is called before the first frame update
    void Start()
    {
        TimeCounter = new TimeCounter
        {
            StartTime = Time.time
        };
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "scene1":
                TimeCounter.FirstLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("scene2");
                break;
            case "scene2":
                TimeCounter.SecondLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("scene3");
                break;
            case "scene3":
                TimeCounter.ThirdLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("scene4");
                break;
            case "scene4":
                TimeCounter.FourthLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("scene5");
                break;
            case "scene5":
                TimeCounter.FifthLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("scene6");
                break;
            case "scene6":
                TimeCounter.SixthLevelTime = Time.time - TimeCounter.StartTime;
                SceneManager.LoadScene("endScene");
                break;
        }
    }
}
