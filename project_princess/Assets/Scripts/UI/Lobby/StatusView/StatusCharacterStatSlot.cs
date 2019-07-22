using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusCharacterStatSlot : UICommon
{
    public UIText statNameText;
    public Image statProgressImage;

    public void SetStatNameText( string text )
    {
        statNameText.text = text;
    }

    public void SetStatProgressImage( int currentValue, int maxValue )
    {
        statProgressImage.fillAmount = ( float )currentValue/( float )maxValue;
    }
}
