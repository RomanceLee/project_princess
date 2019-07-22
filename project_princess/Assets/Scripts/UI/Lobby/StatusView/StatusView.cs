using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusView : UIView
{
    public StatusUserInfoUI userInfoUI;
    public StatusSystemMenuUI systemMenuUI;
    public StatusCharacterInfoUI characterInfoUI;
    public StatusCharacterStatUI characterStatUI;

    protected override void OnAwake()
    {
        base.OnAwake();
        userInfoUI.SetNicknameText( "IRIS" );
        userInfoUI.SetAgeInfoImage( 1 );
        userInfoUI.SetBloodTypeInfoImage( 1 );
        userInfoUI.SetStarmapTypeInfoImage( 1 );
        userInfoUI.SetMoneyText( 1000 );

        characterInfoUI.SetBirthText( "10월4일생" );
        characterInfoUI.SetHeightText( "신장 : 166cm" );
        characterInfoUI.SetWeightText( "체중 : 50kg" );
        characterInfoUI.SetChestSizeText( "가슴 : 70cm" );
        characterInfoUI.SetWeistSizeText( "허리 : 50cm" );
        characterInfoUI.SetHipSizeText( "엉덩이 : 80cm" );
        characterInfoUI.SetFatherBirthText( "아빠생일 : 4월29일" );
        characterInfoUI.SetFatherJobText( "아빠직업 : 백수" );

        //TODO
        characterStatUI.SetCharacterStatSlotLists();
    }
}
