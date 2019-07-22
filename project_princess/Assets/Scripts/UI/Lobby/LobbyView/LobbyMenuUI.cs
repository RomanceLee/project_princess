using UnityEngine;
using UnityEngine.Events;

public class LobbyMenuUI : UICommon
{
    public UIButton scheduleChartButton;
    public UIButton shoppingButton;
    public UIButton talkButton;
    public UIButton actionButton;
    public UIButton changeWearButton;
    public UIButton statusButton;

    public UIText scheduleChartButtonText;
    public UIText shoppingButtonText;
    public UIText talkButtonText;
    public UIText actionButtonText;
    public UIText changeWearButtonText;
    public UIText statusButtonText;

    protected override void OnAwake()
    {
        base.OnAwake();

        scheduleChartButtonText.text = "일정표";
        shoppingButtonText.text = "쇼핑";
        talkButtonText.text = "대화";
        actionButtonText.text = "실행";
        changeWearButtonText.text = "갈아입기";
        statusButtonText.text = "상태보기";
    }

    protected override void OnDestroied()
    {
        base.OnDestroied();
    }

    protected override void InitializeEvents()
    {
        scheduleChartButton.onClick.AddListener( OnClickScheduleChartButton );
        shoppingButton.onClick.AddListener( OnClickShoppingButton );
        talkButton.onClick.AddListener( OnClickTalkButton );
        actionButton.onClick.AddListener( OnClickActionButton );
        changeWearButton.onClick.AddListener( OnClickChangeWearButton );
        statusButton.onClick.AddListener( OnClickStatusButton );
    }

    protected override void ReleaseEvents()
    {
        scheduleChartButton.onClick.RemoveListener( OnClickScheduleChartButton );
        shoppingButton.onClick.RemoveListener( OnClickShoppingButton );
        talkButton.onClick.RemoveListener( OnClickTalkButton );
        actionButton.onClick.RemoveListener( OnClickActionButton );
        changeWearButton.onClick.RemoveListener( OnClickChangeWearButton );
        statusButton.onClick.RemoveListener( OnClickStatusButton );
    }

    public void OnClickScheduleChartButton()
    {
        Debug.Log( "OnClickScheduleChartButton" );
    }

    public void OnClickShoppingButton()
    {
        Debug.Log( "OnClickShoppingButton" );
    }

    public void OnClickTalkButton()
    {
        Debug.Log( "OnClickTalkButton" );
    }

    public void OnClickActionButton()
    {
        Debug.Log( "OnClickActionButton" );
    }

    public void OnClickChangeWearButton()
    {
        Debug.Log( "OnClickChangeWearButton" );
    }

    public void OnClickStatusButton()
    {
        Debug.Log( "OnClickStatusButton" );
        GameUIManager.instance.AddView( GirlGlobeEnums.eUIViewType.StatusView );
    }
}
