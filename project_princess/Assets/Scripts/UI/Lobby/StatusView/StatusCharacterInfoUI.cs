using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusCharacterInfoUI : UICommon
{
    public UIText birthText;
    public UIText heightText;
    public UIText weightText;
    public UIText chestSizeText;
    public UIText weistSizeText;
    public UIText hipSizeText;
    public UIText fatherBirthText;
    public UIText fatherJobText;

    public void SetBirthText( string text )
    {
        birthText.text = text;
    }

    public void SetHeightText( string text )
    {
        heightText.text = text;
    }

    public void SetWeightText( string text )
    {
        weightText.text = text;
    }

    public void SetChestSizeText( string text )
    {
        chestSizeText.text = text;
    }

    public void SetWeistSizeText( string text )
    {
        weistSizeText.text = text;
    }

    public void SetHipSizeText( string text )
    {
        hipSizeText.text = text;
    }

    public void SetFatherBirthText( string text )
    {
        fatherBirthText.text = text;
    }

    public void SetFatherJobText( string text )
    {
        fatherJobText.text = text;
    }
}
