using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
public class startgame : MonoBehaviour
{
    public CanvasGroup Fade_img;

    public CanvasGroup Start_img;
    
    public GameObject Loading;

    public GameObject start_img;
    float fadeDuration = 2; 
    bool key = false;
    bool key2 = false;


    void Start()
    {
        Fade_img.DOFade(0, fadeDuration)
        .OnStart(()=>{

        })
        .OnComplete(()=>{
            Fade_img.blocksRaycasts = false;
        });
        Invoke("Startgame", 3);
    }

    void Startgame()
    {
        Start_img.DOFade(1, fadeDuration / 2)
        .OnStart(()=>{

        })
        .OnComplete(()=>{
            key = true;  
        });

    }

    void Update()
    {   if(EventSystem.current.IsPointerOverGameObject() == true)
        {
            start_img.transform.DOScale(new Vector3(100, 100, 0.4166667f), 0.5f);
            if (Input.GetMouseButtonDown(0) && key == true)
            {
                key2 = true;
                Fade_img.DOFade(1, fadeDuration)
                .OnStart(()=>{
                    Start_img.DOFade(0, fadeDuration)
                    .OnStart(()=>{

                    })
                    .OnComplete(()=>{
                   
                    });
                    Fade_img.blocksRaycasts = true;
                })
                .OnComplete(()=>{
                    DOTween.KillAll();
                    loading.LoadScene("Inputname");
                });
            }
        }
        else if(key2 == false)
        {
            start_img.transform.DOScale(new Vector3(75, 75, 0.4166667f), 0.5f);
        }
    }
}

