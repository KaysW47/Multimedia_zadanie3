using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    GameObject[] allTargets;
    public GameObject winPanel;
    public TMP_Text timerText;
    public TMP_Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.timeSinceLevelLoad;
        timerText.SetText(time.ToString("0.0"));

        allTargets = GameObject.FindGameObjectsWithTag("Target");
        if (allTargets.Length < 1)
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
            timeText.SetText(time.ToString("0.0"));
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
