using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
	public static GameUIManager instance;
    
    private Stack< UIPopup > uIPopups;

    public Canvas viewCanvas;
    public Canvas popupCanvas;
    public GameObject uiTouchBlock;

    [HideInInspector]
    public Stack< GirlGlobeEnums.eUIViewType > uIViewTypes;
    [HideInInspector]
    public Stack< GirlGlobeEnums.eUIPopupType > uIPopupTypes;
    [HideInInspector]
    public bool isEnableAndroidBackButton;
    [HideInInspector]
    public UIView currentView;
    [HideInInspector]
    public UIPopup currentPopup;
    [HideInInspector]
    public Dictionary< GirlGlobeEnums.eUIViewType, object[] > viewParmDic;
    [HideInInspector]
    public Dictionary< GirlGlobeEnums.eUIPopupType, object[] > popupParmDic;
    [HideInInspector]
    public Dictionary< string, object[] > objectParmDic;

    private Transform parentTransform;

    protected void Awake()
    {
        if( instance == null )
        {
            instance = this;
            DontDestroyOnLoad( instance.gameObject );
        }

        uIViewTypes = new Stack< GirlGlobeEnums.eUIViewType >();
        uIPopupTypes = new Stack< GirlGlobeEnums.eUIPopupType >();
        uIPopups = new Stack< UIPopup >();
        uiTouchBlock.SetActive( false );

        isEnableAndroidBackButton = true;

        viewParmDic = new Dictionary< GirlGlobeEnums.eUIViewType, object[] >();
        popupParmDic = new Dictionary< GirlGlobeEnums.eUIPopupType, object[] >();
        objectParmDic = new Dictionary< string, object[] >();

        AddView( GirlGlobeEnums.eUIViewType.LobbyView );
    }

    /// <summary>
    /// 뷰 생성. - 새로운 뷰 생성 시 기존 뷰 제거.
    /// </summary>
    public void AddView( GirlGlobeEnums.eUIViewType _uiPanelType, object[] _param = null )
    {
        if( currentView != null )
        {
            Destroy( currentView.gameObject );
            currentView = null;
        }

        currentView = Resources.Load< UIView >( Utils.CreateStringBuilderStr( new string[]{ "Prefabs/Panel/View/", _uiPanelType.ToString() } ) );
        parentTransform = viewCanvas.transform;
        currentView = Instantiate( currentView, parentTransform ).GetComponent< UIView >();
        

        if( _param != null )
        {
            currentView.SetData( _param );
        }

        if( uIViewTypes.Contains( _uiPanelType ) == false )
        {
            uIViewTypes.Push( _uiPanelType );
        }
    }

    /// <summary>
    /// 현재 보여지는 뷰 제거. - 뷰 제거 후 이전 뷰 생성.
    /// </summary>
    public void RemoveView()
    {
        if( uIViewTypes.Count <= 0 )
        {
            return;
        }
        else
        {
            GirlGlobeEnums.eUIViewType uiViewType = uIViewTypes.Peek();
        }
        
        Destroy( currentView.gameObject );
        currentView = null;
        uIViewTypes.Pop();
        AddView( uIViewTypes.Peek() );
    }

    /// <summary>
    /// 팝업 생성.
    /// </summary>
    public UIPopup AddPopup( GirlGlobeEnums.eUIPopupType _uiPopupType, object[] _param = null )
    {
        currentPopup = Resources.Load< UIPopup >( Utils.CreateStringBuilderStr( new string[]{ "Prefabs/Panel/Popup/", _uiPopupType.ToString() } ) );
        parentTransform = popupCanvas.transform;
        currentPopup = Instantiate( currentPopup, parentTransform ).GetComponent< UIPopup >();

        if( _param != null )
        {
            currentPopup.SetData( _param );
        }

        uIPopupTypes.Push( _uiPopupType );
        uIPopups.Push( currentPopup );

        return currentPopup;
    }

    /// <summary>
    /// 팝업 제거.
    /// </summary>
    public void RemovePopup()
    {
        Destroy( currentPopup.gameObject );
        uIPopupTypes.Pop();
        uIPopups.Pop();
        currentPopup = null;

        if( 0 < uIPopups.Count )
        {
            currentPopup = uIPopups.Peek();
        }
    }

    /// <summary>
    /// 화면상 모든 팝업 제거.
    /// </summary>
    public void RemoveAllPopup()
    {
        while( 0 < uIPopups.Count )
        {
            Destroy( currentPopup.gameObject );
            uIPopupTypes.Pop();
            uIPopups.Pop();
            currentPopup = null;

            if( 0 < uIPopups.Count )
            {
                currentPopup = uIPopups.Peek();
            }    
        }
    }

    public void BackButtonAction()
    {
        if( currentPopup != null )
        {
            RemovePopup();
            return;
        }

        instance.RemoveView();
    }

    //UI 터치 블록 활성화/비활성화.
    public void SetActiveUITouchBlock( bool _isActive )
    {
        uiTouchBlock.gameObject.SetActive( _isActive );
    }

    public void CreatePrototypeDescriptionPopup()
    {
        CommonNoticePopup commonNoticePopup = AddPopup( GirlGlobeEnums.eUIPopupType.CommonNoticePopup ) as CommonNoticePopup;
        commonNoticePopup.SetCommonNoticePopup( Utils.GetLoadText( "common_notice" ), Utils.GetLoadText( "text_key_dev_desc" ), RemovePopup );
    }

    private void Update()
    {
        if( Input.GetKeyUp( KeyCode.Escape ) == true )
        {
            if( isEnableAndroidBackButton == true )
            {
                BackButtonAction();
            }
        }
    }
}
