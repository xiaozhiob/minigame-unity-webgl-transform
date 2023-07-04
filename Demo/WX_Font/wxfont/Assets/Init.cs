﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;
using WeChatWASM;
using System.Reflection;
using System;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public TMP_Text tmpText;
    void Start()
    {
        WeChatWASM.WX.InitSDK((ret) =>
        {
            // fallbackFont作为旧版本微信或者无法获得系统字体文件时的备选CDN URL
            var fallbackFont = "https://www.oooceanworld.com/testgame/testfont/36ee0558-77aa-4918-a524-1e472fcb2a12.ttf";
            WeChatWASM.WX.GetWXFont(fallbackFont, (font) =>
            {
                text.font = font;
                tmpText.font = TMP_FontAsset.CreateFontAsset(font);
            });
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
