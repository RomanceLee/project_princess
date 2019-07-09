using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 버튼 공통 기능 작성
/// </summary>
public class UIButton : Button 
{
	[ HideInInspector ]
	public bool enableSound = true; //사운드 사용여부

    //[ HideInInspector ]
	//public eEffectSound soundEffect = eEffectSound.COUNT; //이펙트 사운드 enum

	[ HideInInspector ]
	public bool enableScaling = false; //자동확대/축소 사용여부

	private Vector3 normalScale; //정상사이즈
	private Vector3 pressScale; //press입력시 사이즈


	protected UnityAction< PointerEventData > onPointDownAction = null;
	protected UnityAction< PointerEventData > onPointUpAction = null;


	protected override void Awake()
	{
		base.Awake();
		normalScale = transform.localScale;
		pressScale = transform.localScale * 0.95f;

	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		OnDestroied();
	}

	//Destroy시 호출되는 함수
	protected virtual void OnDestroied()
    {
    }

	public void AddListenerOnPointerDown( UnityAction< PointerEventData > _action )
	{
		onPointDownAction = _action;
	}


	public void AddListenerOnPointerUp( UnityAction< PointerEventData > _action )
	{
		onPointUpAction = _action;
	}


	public void RemoveListenerOnPointerDown()
	{
		onPointDownAction = null;
	}

	public void RemoveListenerOnPointerUp()
	{
		onPointUpAction = null;
	}

	//TouchDown이벤트
	public override void OnPointerDown( PointerEventData _eventData )
	{
		base.OnPointerDown( _eventData );
		if( interactable && enableScaling )
        {
			transform.localScale = pressScale;
		}
		if( onPointDownAction != null )
        {
			onPointDownAction( _eventData );
		}
	}

	//TouchUp이벤트
	public override void OnPointerUp( PointerEventData _eventData )
	{
		base.OnPointerUp( _eventData );
		if( interactable && enableScaling )
        {
			transform.localScale = normalScale;
		}
		if( onPointUpAction != null )
        {
			onPointUpAction( _eventData );
		}
	}

	//Touch이벤트
	public override void OnPointerClick( PointerEventData _eventData )
	{
        if( interactable && enableSound )
        {
            //if( soundEffect != eEffectSound.COUNT )
            //{
            //    SoundManager.Instance.PlayEffect( soundEffect );
            //}
        }
        base.OnPointerClick( _eventData );
	}
}
