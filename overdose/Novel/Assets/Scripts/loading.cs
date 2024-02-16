using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  
using DG.Tweening;
public class loading : MonoBehaviour
{

    public CanvasGroup Fade_img;
    public GameObject Loading;
    float fadeDuration = 1f; 
    public static string nextScene;
    private float a;

    public Image progressBar;

    private void Start()
    {
        Fade_img.DOFade(0, fadeDuration)
        .OnStart(()=>{

        })
        .OnComplete(()=>{
            Fade_img.blocksRaycasts = false;
        });
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("loading");
    }


    IEnumerator LoadScene()
    {
        progressBar.fillAmount = 0.0f;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;
        while(!op.isDone)
        {
            yield return null;
            timer += Time.unscaledDeltaTime;
            if(op.progress < 0.9f)
            {
                progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount,op.progress,timer);
                if(progressBar.fillAmount >= op.progress)
                {
                    timer=0f;
                }
            }
            else
            {
                progressBar.fillAmount=Mathf.Lerp(progressBar.fillAmount,1f,timer);
                if(progressBar.fillAmount == 1.0f)
                {
                    yield return new WaitForSeconds(1.5f);
                    Fade_img.DOFade(1, fadeDuration)
                    .OnStart(()=>{
                        Fade_img.blocksRaycasts = true;
                    })
                    .OnComplete(()=>{

                     });
                    yield return new WaitForSeconds(1f);
                    op.allowSceneActivation = true;
                    break;
                }
            }

        }
    }
}