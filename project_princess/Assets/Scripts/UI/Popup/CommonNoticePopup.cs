using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonNoticePopup : UIPopup
{
    public UIText titleText;
    public UIText descriptionText;
    public UIButton confirmButton;
    public UIText confirmButtonText;

    protected override void OnAwake()
    {
        base.OnAwake();
        uiPopupType = GirlGlobeEnums.eUIPopupType.CommonNoticePopup;
    }

    protected override void OnDestroied()
    {
        base.OnDestroied();
    }

    protected override void ReleaseEvents()
    {
        confirmButton.onClick.RemoveAllListeners();
    }

    public void SetCommonNoticePopup( string _titleText, string _descriptionText, UnityEngine.Events.UnityAction _action )
    {
        titleText.text = _titleText;
        descriptionText.text = _descriptionText;
        confirmButton.onClick.AddListener( _action );
        confirmButtonText.text = Utils.GetLoadText( "common_confirm" );
    }
}
