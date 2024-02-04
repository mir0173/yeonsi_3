using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class typingtext : MonoBehaviour
{
    public static bool talking = false;
    public static string[] name = {"???", "???", "???", "???", "백하연", "백하연", "백하연", "백하연", " "};
    public static string[] talk = {"드디어 일어났구나", "많이 피곤했나보네", "어제 몇시에 잔거야?", "반 친구 이름도 기억 못하는거야?", "나 하연이잖아, 백.하.연!", "좀 있으면 쌤 오실 시간이니까 빨리 정신좀 차려봐!!", "오늘? 겨울 방학식 날이잖아", "앗, 쌤 오시는 소리 들린다", " "};
    void Start() 
    { 

    } 

    public static IEnumerator Typing(TMP_Text textfield_name, TMP_Text textfield_text, int a, float speed) 
    { 
        talking = true;
        for (int i = 0; i < talk[a].Length; i++) 
        { 
            textfield_name.text = name[a].Substring(0, name[a].Length); 
            textfield_text.text = talk[a].Substring(0, i + 1); 
            yield return new WaitForSeconds(speed);
        }
        yield return null;
        talking = false;
    } 

    public static IEnumerator Typing_C(TMP_Text textfield, string a, float speed) 
    { 
        for (int i = 0; i < a.Length; i++) 
        { 
            textfield.text = a.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed);
        }
        yield return null;
    }

    
}
