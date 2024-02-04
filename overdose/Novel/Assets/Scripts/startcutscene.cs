    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;

public class startcutscene : MonoBehaviour
{
    public TMP_Text textfield_text;
    public TMP_Text textfield_name;
    public TMP_Text choose1;
    public TMP_Text choose2;
    public static int istalk;
    public CanvasGroup Fade_img;
    float fadeDuration = 1.0f; 
    private Vector3 Position_Default = new Vector3(6.5f, 3.5f, 0f);
    private Vector3 Position_End = new Vector3(0f, 0f, 0f);
    private Vector3 Position_Default2 = new Vector3(0f, 0f, 0f);
    private Vector3 Position_End2 = new Vector3(0f, -3.5f, 0f);
    private Vector3 Position_Default3 = new Vector3(0f, -3.5f, 0f);
    private Vector3 Position_End3 = new Vector3(0f, 3.5f, 0f);
    private Vector3 Scale_Default = new Vector3(3f, 3f, 3f);
    private Vector3 Scale_End = new Vector3(2f, 2f, 2f);
    private Vector3 Scale_Default2 = new Vector3(6f, 6f, 6f);
    private Vector3 Scale_End2 = new Vector3(3.5f, 3.5f, 3.5f);
    private float m_RunTime = 2.0f;

    public GameObject UI_Panel;
    public GameObject ChooseBox;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public int choose_Enter = 0;

    // Start is called before the first frame update
    void Start()
    { 
        textfield_name.text = " ";
        textfield_text.text = " ";
        choose1.text = " ";
        choose2.text = " ";
        Color b = obj.GetComponent<Renderer>().material.color; 
        b.a = 0; 
        obj.GetComponent<Renderer>().material.color = b;
        Color c = obj2.GetComponent<Renderer>().material.color; 
        c.a = 0; 
        obj2.GetComponent<Renderer>().material.color = c;
        Color d = obj3.GetComponent<Renderer>().material.color; 
        d.a = 0; 
        obj3.GetComponent<Renderer>().material.color = d;
        Color e = UI_Panel.GetComponent<Image>().material.color; 
        e.a = 0; 
        UI_Panel.GetComponent<Image>().material.color = e;
        Color f = ChooseBox.GetComponent<Image>().material.color; 
        f.a = 0; 
        ChooseBox.GetComponent<Image>().material.color = f;
        choose1.color = new Color(197, 197, 197);
        choose2.color = new Color(197, 197, 197);
        Fade_img.DOFade(0, fadeDuration)
        .OnStart(()=>{

        })
        .OnComplete(()=>{
            Fade_img.blocksRaycasts = false;
            StartCoroutine(Fade5(m_RunTime));
            
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Fade5(float duration)
    {
        var runtime6 = 0.0f;
 
        while (runtime6 < duration)
        {
            runtime6 += Time.deltaTime;

            Color c = obj.GetComponent<Renderer>().material.color; 
        	c.a = runtime6 / 2; 
        	obj.GetComponent<Renderer>().material.color = c;   
            yield return null;
        }
        yield return null;
        StartCoroutine(School(2.0f));
        yield break;
    }
    IEnumerator School(float duration)
    {
        var runTime = 0.0f;

        while (runTime < duration)
        {
            runTime += Time.deltaTime;

            obj.transform.position = Vector3.Lerp(Position_Default, Position_End, runTime / duration);
            obj.transform.localScale = Vector3.Lerp(Scale_Default, Scale_End, runTime / duration); 
            yield return null;        
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(Fade(2.0f));
        yield break;
    }

    IEnumerator Girls(float duration)
    {
        var runTime2 = 0.0f;

        while (runTime2 < duration)
        {
            runTime2 += Time.deltaTime;
            obj2.transform.position = Vector3.Lerp(Position_Default2, Position_End2, runTime2 / duration);
            obj2.transform.localScale = Vector3.Lerp(Scale_Default2, Scale_End2, runTime2 / duration); 
            yield return null;        
        }
        yield return null;
        StartCoroutine(Girls2(4.0f));
        yield break;
    }

    IEnumerator Girls2(float duration)
    {
        var runTime5 = 0.0f;

        while (runTime5 < duration)
        {
            runTime5 += Time.deltaTime;
            obj2.transform.position = Vector3.Lerp(Position_Default3, Position_End3, runTime5 / duration);
            yield return null;        
        }
        yield return null;
        StartCoroutine(Fade4(2.0f));
        yield break;
    }

    IEnumerator Fade(float duration)
    {
        var runtime3 = 0.0f;
 
        while (runtime3 < duration)
        {
            runtime3 += Time.deltaTime;

            Color c = obj.GetComponent<Renderer>().material.color; 
        	c.a = 1 - runtime3 / 2; 
        	obj.GetComponent<Renderer>().material.color = c;   
            yield return null;
        }
        yield return null;
        StartCoroutine(Fade3(2.0f));
        yield break;
    }

    IEnumerator Fade3(float duration)
    {
        var runtime4 = 0.0f;
 
        while (runtime4 < duration)
        {
            runtime4 += Time.deltaTime;
            Color c = obj2.GetComponent<Renderer>().material.color; 
        	c.a = runtime4 / 2; 
        	obj2.GetComponent<Renderer>().material.color = c; 
            yield return null;
        }
        yield return null;
        StartCoroutine(Girls(2.0f));
        yield break;
    }


    IEnumerator Fade4(float duration)
    {
        var runtime10 = 0.0f;

        while (runtime10 < duration)
        {
            runtime10 += Time.deltaTime;
            Color c = obj2.GetComponent<Renderer>().material.color; 
        	c.a = 1 - runtime10 / 2; 
        	obj2.GetComponent<Renderer>().material.color = c;    
            yield return null;
        }
        yield return null;
        StartCoroutine(Girl(2.0f));
        yield break;
    }

    IEnumerator Girl(float duration)
    {
        var runtime8 = 0.0f;

        while (runtime8 < duration)
        {
            runtime8 += Time.deltaTime;
            Color c = obj3.GetComponent<Renderer>().material.color; 
        	c.a = runtime8 / 2; 
        	obj3.GetComponent<Renderer>().material.color = c;    
            yield return null;
        }
        yield return null;
        StartCoroutine(Talk_Start(1.5f));
        yield break;
    }

    IEnumerator Talk_Start(float duration)
    {
        bool istalking = true;
        bool ischoose = false;
        istalk = 0;
        var runtime9 = 0.0f;
        while (runtime9 < duration)
        {
            runtime9 += Time.deltaTime;
            Color y = UI_Panel.GetComponent<Image>().material.color; 
        	y.a = runtime9 / 4f; 
        	UI_Panel.GetComponent<Image>().material.color = y;    
            yield return null;
        }
        StartCoroutine(typingtext.Typing(textfield_name, textfield_text, istalk, 0.1f));
        yield return null;
        while(istalking)
        {
            if(Input.GetMouseButtonDown(0) && typingtext.talking == false && istalk < 2)
            {
                yield return new WaitForSeconds(0.5f);
                StartCoroutine(typingtext.Typing(textfield_name, textfield_text, ++istalk, 0.1f));
                yield return null;
            }
            if(Input.GetMouseButtonDown(0) && typingtext.talking == false && istalk == 2)
            {
                istalking = false;
            }
            yield return null;
        }
        StartCoroutine(typingtext.Typing2(choose1, "누구세요?", 0.03f));
        StartCoroutine(typingtext.Typing2(choose2, "여기가 어딘가요?", 0.03f));
        yield return null;
        while(ischoose != true)
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
            if(point.x > 0.4 && point.x < 9 && point.y > -2.3 && point.y < -1.8)
            {
                choose_Enter = 1;
                choose1.color = new Color32(255, 255, 255, 255);
                choose2.color = new Color32(197, 197, 197, 255);
                if(Input.GetMouseButtonDown(0))
                {
                    ischoose = true;
                }
            }
            else if(point.x > 0.4 && point.x < 9 && point.y > -2.8 && point.y < -2.3)
            {
                choose_Enter = 2;
                choose2.color = new Color32(255, 255, 255, 255);
                choose1.color = new Color32(197, 197, 197, 255);
                if(Input.GetMouseButtonDown(0))
                {
                    ischoose = true;
                }
            }
            else
            {
                choose1.color = new Color32(197, 197, 197, 255);
                choose2.color = new Color32(197, 197, 197, 255);
            }
            yield return null;
        }
        StartCoroutine(typingtext.Typing2(choose1, " ", 0f));
        StartCoroutine(typingtext.Typing2(choose2, " ", 0f));
        StartCoroutine(typingtext.Typing(textfield_name, textfield_text, ++istalk, 0.1f));
        /*while (runtime12 < duration)
        {
            runtime12 += Time.deltaTime;
            Color c = UI_Panel.GetComponent<Image>().material.color; 
        	c.a = 0.375f - runtime12 / 4f; 
        	UI_Panel.GetComponent<Image>().material.color = c;    
            yield return null;
        }*/
    }
}
