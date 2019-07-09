using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonSelectPopup : UIPopup
{
    public UIText descriptionText;
    public UIButton cancelButton;
    public UIText cancelButtonText;
    public UIButton confirmButton;
    public UIText confirmButtonText;

    protected override void OnAwake()
    {
        base.OnAwake();
        uiPopupType = GirlGlobeEnums.eUIPopupType.CommonSelectPopup;
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void ReleaseEvents()
    {
        cancelButton.onClick.RemoveAllListeners();
        confirmButton.onClick.RemoveAllListeners();
    }

    public void SetPopupText( string _descriptionText, string _cancelButtonText, string _confirmButtonText )
    {
        descriptionText.text = _descriptionText;
        cancelButtonText.text = _cancelButtonText;
        confirmButtonText.text = _confirmButtonText;
    }

    public void SetCancelButtonEvent( UnityEngine.Events.UnityAction action )
    {
        cancelButton.onClick.AddListener( action );
    }

    public void SetConfirmButtonEvent( UnityEngine.Events.UnityAction action )
    {
        confirmButton.onClick.AddListener( action );
    }
}
