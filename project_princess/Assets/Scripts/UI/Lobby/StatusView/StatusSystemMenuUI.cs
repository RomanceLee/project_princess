using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusSystemMenuUI : UICommon
{
    public UIButton saveButton;
    public UIButton loadButton;
    public UIButton settingButton;
    public UIButton lobbyButton;

    public UIText saveButtonText;
    public UIText loadButtonText;
    public UIText settingButtonText;
    public UIText lobbyButtonText;

    protected override void OnAwake()
    {
        base.OnAwake();

        saveButtonText.text = "시간을 기록";
        loadButtonText.text = "기록을 읽기";
        settingButtonText.text = "설정";
        lobbyButtonText.text = "초기화면";
    }

    protected override void OnDestroied()
    {
        base.OnDestroied();
    }

    protected override void InitializeEvents()
    {
        saveButton.onClick.AddListener( OnClickSaveButton );
        loadButton.onClick.AddListener( OnClickLoadButton );
        settingButton.onClick.AddListener( OnClickSettingButton );
        lobbyButton.onClick.AddListener( OnClickLobbyButton );
    }

    protected override void ReleaseEvents()
    {
        saveButton.onClick.RemoveListener( OnClickSaveButton );
        loadButton.onClick.RemoveListener( OnClickLoadButton );
        settingButton.onClick.RemoveListener( OnClickSettingButton );
        lobbyButton.onClick.RemoveListener( OnClickLobbyButton );
    }

    private void OnClickSaveButton()
    {
        Debug.Log( "OnClickSaveButton" );
    }

    private void OnClickLoadButton()
    {
        Debug.Log( "OnClickLoadButton" );
    }

    private void OnClickSettingButton()
    {
        Debug.Log( "OnClickSettingButton" );
    }

    private void OnClickLobbyButton()
    {
        Debug.Log( "OnClickLobbyButton" );
        GameUIManager.instance.AddView( GirlGlobeEnums.eUIViewType.LobbyView );
    }
}
