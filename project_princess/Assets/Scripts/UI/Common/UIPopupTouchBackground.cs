using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIPopupTouchBackground : UIButton
{
    public override void OnPointerUp( PointerEventData _eventData )
    {
        base.OnPointerUp( _eventData );
        GameUIManager.instance.RemovePopup();
    }
}
