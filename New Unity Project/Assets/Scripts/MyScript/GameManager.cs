using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Canvas UI;
    public int Score=0;
    public GameObject endPortal;
    // Start is called before the first frame update
    void Start()
    {
        endPortal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UI.GetComponentInChildren<TextMeshProUGUI>().text = "Evidence gathered "+Score+"/5";
        if (Score > 4)
            endPortal.SetActive(true);
    }

    void Awake()
    {
       


        DontDestroyOnLoad(this.gameObject);
    }
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void UpdateScore()
    {
        
    }
}
