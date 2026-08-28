using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;
    public static UIManager instance;

    [SerializeField]
    private GameObject restartBotton;

    [SerializeField]
    private Player player;

    void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 88f, -86f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }
    public void ShowHideRestartButton(bool flag)
    {
        restartBotton.SetActive(flag);
    }
}
