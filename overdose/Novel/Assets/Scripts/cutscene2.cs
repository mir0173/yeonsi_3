using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class cutscene2 : MonoBehaviour
{   

    public GameObject UI_Panel2;
    public GameObject ChooseBox;
    public TMP_Text textfield_text2;
    public TMP_Text textfield_name2;
    public TMP_Text choose1;
    public TMP_Text choose2;
    public GameObject obj;
    public int istalk;
    float speed = startcutscene.speed;
    
    void Start()
    {
        textfield_name2.text = " ";
        textfield_text2.text = " ";
        choose1.text = " ";
        choose2.text = " ";
        Color b = obj.GetComponent<Renderer>().material.color; 
        b.a = 0; 
        obj.GetComponent<Renderer>().material.color = b;
        Color c = UI_Panel2.GetComponent<Image>().material.color; 
        c.a = 0; 
        UI_Panel2.GetComponent<Image>().material.color = c;
        Color d = ChooseBox.GetComponent<Image>().material.color; 
        d.a = 0; 
        ChooseBox.GetComponent<Image>().material.color = d;
        StartCoroutine(Fade1(1.0f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade1(float duration)
    {
        var runtime1 = 0.0f;
 
        while (runtime1 < duration)
        {
            runtime1 += Time.deltaTime;

            Color c = obj.GetComponent<Renderer>().material.color; 
        	c.a = runtime1 * runtime1 / 1; 
        	obj.GetComponent<Renderer>().material.color = c;   
            yield return null;
        }
        yield return null;
        StartCoroutine(Talk_Start(1.5f));
        yield break;
    }

    IEnumerator Fade2(float duration)
    {
        var runtime4 = 0.0f;
 
        while (runtime4 < duration)
        {
            runtime4 += Time.deltaTime;

            Color c = obj.GetComponent<Renderer>().material.color; 
        	c.a = 1 - runtime4 * runtime4 / 4; 
        	obj.GetComponent<Renderer>().material.color = c;   
            yield return null;
        }
        yield return null;
        yield break;
    }

    IEnumerator Talk_Start(float duration)
    {
        bool ischoose = false;
        istalk = 0;
        var runtime2 = 0.0f;
        var runtime3 = 0.0f;
        while (runtime2 < duration)
        {
            runtime2 += Time.deltaTime;
            Color y = UI_Panel2.GetComponent<Image>().material.color; 
        	y.a = runtime2 / 4f; 
        	UI_Panel2.GetComponent<Image>().material.color = y;    
            yield return null;
        }
        StartCoroutine(typingtext.Typing2(textfield_name2, textfield_text2, istalk, 0.07f * speed));
        yield return null;
        while(true)
        {
            if((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && typingtext.talking == false && istalk < 9)
            {
                yield return new WaitForSeconds(0.5f);
                StartCoroutine(typingtext.Typing2(textfield_name2, textfield_text2, ++istalk, 0.07f * speed));
                yield return null;
            }
            if(typingtext.talking == false && istalk == 9)
            {
                break;
            }
            yield return null;
        }
        StartCoroutine(typingtext.Typing_C(choose1, "네!!!", 0.03f));
        StartCoroutine(typingtext.Typing_C(choose2, "알겠습니다!!!", 0.03f));
        yield return null;
        while(ischoose != true)
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
            if(point.x > 0.4 && point.x < 9 && point.y > -2.3 && point.y < -1.8)
            {
                choose1.color = new Color32(255, 255, 255, 255);
                choose2.color = new Color32(197, 197, 197, 255);
                if(Input.GetMouseButtonDown(0))
                {
                    ischoose = true;
                }
            }
            else if(point.x > 0.4 && point.x < 9 && point.y > -2.8 && point.y < -2.3)
            {
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
        ischoose = false;
        StartCoroutine(typingtext.Typing2(textfield_name2, textfield_text2, ++istalk, 0.07f * speed));
        StartCoroutine(typingtext.Typing_C(choose1, " ", 0f));
        StartCoroutine(typingtext.Typing_C(choose2, " ", 0f));
        while (runtime3 < duration)
        {
            runtime3 += Time.deltaTime;
            Color y = UI_Panel2.GetComponent<Image>().material.color; 
        	y.a = 0.375f - runtime3 / 4f; 
        	UI_Panel2.GetComponent<Image>().material.color = y;    
            yield return null;
        }
        yield return null;
        StartCoroutine(Fade2(2.0f));
        yield break;

    }
}
