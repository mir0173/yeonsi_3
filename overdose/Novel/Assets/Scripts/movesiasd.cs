using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;


public class movesiasd : MonoBehaviour
{

    float a, b, w, h;
    private CubismModel _model;
    // Start is called before the first frame update
    void Start()
    {
        _model = this.FindCubismModel();
    }

    void Update()
    {
        a = Input.mousePosition.x;
        w = Screen.width;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        
         _model.Parameters[0].BlendToValue(CubismParameterBlendMode.Override, ((a / w - 0.40f) / 0.22f));
        if(a / w < 0.53f && a / w> 0.17f)
        {
             _model.Parts[3].Opacity = Mathf.Abs(_model.Parameters[0].Value) / 20 + 0.95f;
             _model.Parts[2].Opacity = Mathf.Abs(_model.Parameters[0].Value) / 20 + 0.95f;
             _model.Parts[1].Opacity = Mathf.Abs(_model.Parameters[0].Value) / 20 + 0.95f;
        }


    }
}
