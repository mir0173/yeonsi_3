using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class typingtext : MonoBehaviour
{
    public static bool talking = false;
    public static string[] name1 = {"???", "???", "???", "???", "백하연", "백하연", "백하연", "백하연", " "};
    public static string[] talk1 = {"드디어 일어났구나", "많이 피곤했나보네", "어제 몇시에 잔거야?", "반 친구 이름도 기억 못하는거야?", "나 하연이잖아,  백. 하. 연 !!", "좀 있으면 쌤 오실 시간이니까 빨리 정신좀 차려봐!!", "오늘?  여름 방학식 날이잖아", "앗,  쌤 오시는 소리 들린다", " "};
    
    public static string myname;
    public static string[] name2 = {"선생님", "반장", "학생들", "선생님", "선생님", "이름", "이시아", "친구들", "선생님", "학생들", " "};
    public static string[] talk2 = {"반장,  인사!", "차렷,  공수,  선생님께 인사!", "선생님 안녕하세요!!!", "방학식이라 다들 목소리가 우렁차구나", "방학식날인데 졸고 있는 친구가 있네?", "(시아야 정신좀 차려봐!!)", "네?! 저 부르셨어요?", "(쟤는 방학식 날인데 변한게 하나도 없네)", "한달동안 건강하고 말썽피우지 말고 지내야 한다", "네!!!", " "};
    
    void Awake() 
    { 

    } 

    public static IEnumerator Setname() 
    { 
        if(PlayerPrefs.HasKey("Key_Name"))
        {
            myname = PlayerPrefs.GetString("name");
        }
        else
        {
            myname = "디버깅";
        }
        yield return null;
        yield break;
    } 

    public static IEnumerator Typing(TMP_Text textfield_name, TMP_Text textfield_text, int a, float speed) 
    { 
        talking = true;
        for (int i = 0; i < talk1[a].Length; i++) 
        { 
            textfield_name.text = name1[a].Substring(0, name1[a].Length); 
            textfield_text.text = talk1[a].Substring(0, i + 1); 
            yield return new WaitForSeconds(speed);
        }
        yield return null;
        talking = false;
        yield break;
    } 

    public static IEnumerator Typing2(TMP_Text textfield_name, TMP_Text textfield_text, int a, float speed) 
    { 
        talking = true;
        for (int i = 0; i < talk2[a].Length; i++) 
        { 
            if(name2[a] == "이름")
            {
                textfield_name.text = myname.Substring(0, myname.Length); 
            }
            else
            {
                textfield_name.text = name2[a].Substring(0, name2[a].Length); 
            }
            textfield_text.text = talk2[a].Substring(0, i + 1); 
            yield return new WaitForSeconds(speed);
        }
        yield return null;
        talking = false;
        yield break;
    } 

    public static IEnumerator Typing_C(TMP_Text textfield, string a, float speed) 
    { 
        for (int i = 0; i < a.Length; i++) 
        { 
            textfield.text = a.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed);
        }
        yield return null;
        yield break;
    }

    
}
