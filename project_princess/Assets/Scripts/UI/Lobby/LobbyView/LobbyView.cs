using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyView : UIView
{
    public LobbyCalenderUI calenderUI;
    public LobbyUserInfoUI userInfoUI;
    public LobbyMenuUI menuUI;

    protected override void OnStart()
    {
        base.OnStart();
        calenderUI.SetScheduleCountText( 1, 192 );
        calenderUI.SetMonthText( 1 );
        calenderUI.SetDayOfWeekText( "Mon" );
        calenderUI.SetDateText( 1 );

        userInfoUI.SetNicknameText( "IRIS" );
        userInfoUI.SetAgeInfoImage( 1 );
        userInfoUI.SetBloodTypeInfoImage( 1 );
        userInfoUI.SetStarmapTypeInfoImage( 1 );

        menuUI.SetScheduleChartAction( OnClickScheduleChartButton );
        menuUI.SetShoppingAction( OnClickShoppingButton );
        menuUI.SetTalkAction( OnClickTalkButton );
        menuUI.SetActionAction( OnClickActionButton );
        menuUI.SetChangeWearAction( OnClickChangeWearButton );
        menuUI.SetStatusAction( OnClickStatusButton );
    }

    private void OnClickScheduleChartButton()
    {
        Debug.Log( "OnClickScheduleChartButton" );
    }

    private void OnClickShoppingButton()
    {
        Debug.Log( "OnClickShoppingButton" );
    }

    private void OnClickTalkButton()
    {
        Debug.Log( "OnClickTalkButton" );
    }

    private void OnClickActionButton()
    {
        Debug.Log( "OnClickActionButton" );
    }

    private void OnClickChangeWearButton()
    {
        Debug.Log( "OnClickChangeWearButton" );
    }

    private void OnClickStatusButton()
    {
        Debug.Log( "OnClickStatusButton" );
    }
}
