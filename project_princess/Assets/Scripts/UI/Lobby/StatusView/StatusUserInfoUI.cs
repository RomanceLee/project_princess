using UnityEngine.UI;

public class StatusUserInfoUI : UICommon
{
    public UIText nicknameText;
    public Image ageInfoImage;
    public Image bloodTypeInfoImage;
    public Image starmapTypeInfoImage;
    public UIText moneyText;

    public void SetNicknameText( string nickname )
    {
        nicknameText.text = nickname;
    }

    public void SetAgeInfoImage( int age )
    {
        ageInfoImage.sprite = Utils.GetAgeTypeToSprite( age );
    }

    public void SetBloodTypeInfoImage( int bloodType )
    {
        bloodTypeInfoImage.sprite = Utils.GetBloodTypeToSprite( bloodType );
    }

    public void SetStarmapTypeInfoImage( int starmapType )
    {
        starmapTypeInfoImage.sprite = Utils.GetStarMapTypeToSprite( starmapType );
    }

    public void SetMoneyText( int moneyCount )
    {
        moneyText.text = moneyCount.ToString( "#,##0" );
    }
}
