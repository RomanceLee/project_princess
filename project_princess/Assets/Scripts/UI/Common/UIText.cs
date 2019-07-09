using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : Text
{
    protected override void Awake()
    {
        base.Awake();
        this.font = Resources.Load( "Fonts/NotoSansCJKkr-Medium" ) as Font;
    }
}
