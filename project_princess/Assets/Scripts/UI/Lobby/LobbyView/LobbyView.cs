using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyView : UIView
{
    public LobbyCalenderUI calenderUI;
    public LobbyUserInfoUI userInfoUI;
    public LobbyMenuUI menuUI;

    protected override void OnAwake()
    {
        base.OnAwake();
        calenderUI.SetScheduleCountText( 1, 192 );
        calenderUI.SetMonthText( 1 );
        calenderUI.SetDayOfWeekText( "Mon" );
        calenderUI.SetDateText( 1 );

        userInfoUI.SetNicknameText( "IRIS" );
        userInfoUI.SetAgeInfoImage( 1 );
        userInfoUI.SetBloodTypeInfoImage( 1 );
        userInfoUI.SetStarmapTypeInfoImage( 1 );
        userInfoUI.SetMoneyText( 1000 );
    }
}
