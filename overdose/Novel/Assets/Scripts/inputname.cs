using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class inputname : MonoBehaviour
{
    public InputField playerNameInput;
    static public string playerName = null;
 
    public CanvasGroup Fade_img;
    public GameObject Loading;
    float fadeDuration = 2; 

    void Start()
    {
        Fade_img.DOFade(0, fadeDuration)
        .OnStart(()=>{

        })
        .OnComplete(()=>{
            Fade_img.blocksRaycasts = false;
        });
    }
 
    private void Update()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        if (playerName.Length > 0 && Input.GetKeyDown(KeyCode.Return))
        {
            PlayerPrefs.SetString("name", playerName);
            Fade_img.DOFade(1, fadeDuration)
            .OnStart(()=>{
                Fade_img.blocksRaycasts = true;
            })
            .OnComplete(()=>{
                loading.LoadScene("cutScene1");
            });
        }
    }
 
}