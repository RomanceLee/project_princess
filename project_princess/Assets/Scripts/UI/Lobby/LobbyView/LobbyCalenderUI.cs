public class LobbyCalenderUI : UICommon
{
    public UIText scheduleCountText;
    public UIText monthText;
    public UIText dayofweekText;
    public UIText dateText;

    public void SetScheduleCountText( int currentCount, int maxCount )
    {
        scheduleCountText.text = currentCount.ToString() + "/" + maxCount.ToString();
    }

    public void SetMonthText( int month )
    {
        monthText.text = Utils.GetMonthNumberToMonthString( month );
    }

    public void SetDayOfWeekText( string dayofweek )
    {
        dayofweekText.text = dayofweek.ToString();
    }

    public void SetDateText( int date )
    {
        dateText.text = date.ToString();
    }
}
