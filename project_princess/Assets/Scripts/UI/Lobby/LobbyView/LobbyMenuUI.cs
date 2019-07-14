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

    private UnityAction scheduleChartAction;
    private UnityAction shoppingAction;
    private UnityAction talkAction;
    private UnityAction actionAction;
    private UnityAction changeWearAction;
    private UnityAction statusAction;

    protected override void OnAwake()
    {
        base.OnAwake();

        scheduleChartButtonText.text = "일정표";
        scheduleChartButtonText.text = "일정표";
        scheduleChartButtonText.text = "일정표";
        scheduleChartButtonText.text = "일정표";
        scheduleChartButtonText.text = "일정표";
        scheduleChartButtonText.text = "일정표";
    }

    protected override void OnDestroied()
    {
        base.OnDestroied();
    }

    protected override void InitializeEvents()
    {
        scheduleChartButton.onClick.AddListener( scheduleChartAction );
        shoppingButton.onClick.AddListener( shoppingAction );
        talkButton.onClick.AddListener( talkAction );
        actionButton.onClick.AddListener( actionAction );
        changeWearButton.onClick.AddListener( changeWearAction );
        statusButton.onClick.AddListener( statusAction );
    }

    protected override void ReleaseEvents()
    {
        scheduleChartButton.onClick.RemoveListener( scheduleChartAction );
        shoppingButton.onClick.RemoveListener( shoppingAction );
        talkButton.onClick.RemoveListener( talkAction );
        actionButton.onClick.RemoveListener( actionAction );
        changeWearButton.onClick.RemoveListener( changeWearAction );
        statusButton.onClick.RemoveListener( statusAction );
    }

    public void SetScheduleChartAction( UnityAction action )
    {
        scheduleChartAction = action;
    }

    public void SetShoppingAction( UnityAction action )
    {
        shoppingAction = action;
    }

    public void SetTalkAction( UnityAction action )
    {
        talkAction = action;
    }

    public void SetActionAction( UnityAction action )
    {
        actionAction = action;
    }

    public void SetChangeWearAction( UnityAction action )
    {
        changeWearAction = action;
    }

    public void SetStatusAction( UnityAction action )
    {
        statusAction = action;
    }
}
