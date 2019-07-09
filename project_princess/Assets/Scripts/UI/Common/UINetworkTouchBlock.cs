using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UINetworkTouchBlock : MonoBehaviour
{
    public GameObject ga_touchBlock;
    public GameObject ga_indicator;
    public GameObject ga_indicatorBG;
    public GameObject ga_errorPopup;
    public GameObject ga_errorPopupButton;

	public Text la_errorDesc;
	public Text la_button;
	public UIButton popupButton;

    Coroutine co_indicatorTimer;

    void ClosePopup()
    {
		popupButton.onClick.RemoveAllListeners();
        ga_touchBlock.SetActive( false );
        ga_indicatorBG.SetActive( false );
        ga_errorPopup.SetActive( false );
    }

	public void PopupOKClick( bool _isReload, bool _isMoveToSplash = false )
    {
   //     if( ProjectManager.Instance.currentScene == "Title_Bridge" )
   //     {
   //         ProjectManager.Instance.networkManager.Init();
			//ProjectManager.Instance.titlemanager.CheckSelectedServerState ();
   //         ClosePopup();
   //     }
   //     else
   //     {
   //     	if( isReload )
   //         	ProjectManager.Instance.Reload();
   //         else
			//	ClosePopup();
   //     }
    }

    public void PopupOKRelease()
    {
        //Utils.ButtonPress( ga_errorPopupButton.transform, 0.1f, false );
    }

    public void PopupOKPress()
    {
        //Utils.ButtonPress( ga_errorPopupButton.transform, 0.1f, true );
    }

	/// <summary>
	/// 에러 팝업 띄우기(isReload값에 따른 타이틀 이동여부 결정)
	/// </summary>
    public void ShowPopup( string _errCode, string _str, bool _isReload )
    {
//		string desc = ProjectManager.Instance.datamanager.GetLoadText( "network_popup_error" );
//		desc = desc + "\n\n( eCode : " + _errCode + " )";

		//bool isMoveToSplash = false; 
		//GetPopupState (_errCode, ref isReload, ref isMoveToSplash);

		//popupButton.onClick.RemoveAllListeners();
		//popupButton.onClick.AddListener( delegate { PopupOKClick( isReload ); } );

		//la_errorDesc.text = _str;

		//string buttonText = ProjectManager.Instance.datamanager.GetLoadText( "okButton" );
		//if (!string.IsNullOrEmpty (buttonText)) {
		//	la_button.text = buttonText;
		//}

  //      ga_indicator.SetActive( false );
  //      ga_touchBlock.SetActive( true );
  //      ga_indicatorBG.SetActive( true );
  //      ga_errorPopup.SetActive( true );

  //      //**devchoi - 최종적으로 네트워크 에러팝업이 뜬 경우 기본 백키를 비활성 시킴
  //      if (ProjectManager.Instance.heroSelectManager != null)
  //          ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = true;

  //      if (ProjectManager.Instance.titlemanager != null)
  //          ProjectManager.Instance.titlemanager.activeNetTouchBlock = true;
       
  //      if (UINavigationManager.Instance != null)
  //          UINavigationManager.Instance.activeNetTouchBlock = true;
    }


	/// <summary>
	/// 에 러 코 드 에 따 른 타 이 틀 복 귀 여 부 를 판 단 하 기 위 해 만 듦
	/// </summary>
	public void ShowPopupEx ( string _errCode )
    {
		//bool isReload = true;
		//bool isMoveToSplash = false;

		//GetPopupState (_errCode, ref isReload, ref isMoveToSplash);

		//popupButton.onClick.RemoveAllListeners();
		//popupButton.onClick.AddListener( delegate { PopupOKClick( isReload,isMoveToSplash ); } );

		//string errText = GetErrorCodeString (_errCode);

		//la_errorDesc.text = errText;

		//string buttonText = ProjectManager.Instance.datamanager.GetLoadText( "okButton" );
		//if (!string.IsNullOrEmpty (buttonText)) {
		//	la_button.text = buttonText;
		//}

		//ga_indicator.SetActive( false );
		//ga_touchBlock.SetActive( true );
		//ga_indicatorBG.SetActive( true );
		//ga_errorPopup.SetActive( true );

		////**devchoi - 최종적으로 네트워크 에러팝업이 뜬 경우 기본 백키를 비활성 시킴
		//if (ProjectManager.Instance.heroSelectManager != null)
		//	ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = true;

		//if (ProjectManager.Instance.titlemanager != null)
		//	ProjectManager.Instance.titlemanager.activeNetTouchBlock = true;
			
		//if (UINavigationManager.Instance != null)
		//	UINavigationManager.Instance.activeNetTouchBlock = true;
	}


	public void ShowPopup( string _errCode, bool _isReload, bool _isMoveToSplash = false)
		{
//		string desc = ProjectManager.Instance.datamanager.GetLoadText( "network_popup_error" );
//		desc = desc + "\n\n( eCode : " + _errCode + " )";

		//GetPopupState (_errCode, ref isReload, ref isMoveToSplash);

		//popupButton.onClick.RemoveAllListeners();
		//popupButton.onClick.AddListener( delegate { PopupOKClick( isReload,isMoveToSplash ); } );

		//string errText = GetErrorCodeString (_errCode);

		//la_errorDesc.text = errText;


		//string buttonText = ProjectManager.Instance.datamanager.GetLoadText( "okButton" );
		//if (!string.IsNullOrEmpty (buttonText)) {
		//	la_button.text = buttonText;
		//}
		
  //      ga_indicator.SetActive( false );
  //      ga_touchBlock.SetActive( true );
  //      ga_indicatorBG.SetActive( true );
  //      ga_errorPopup.SetActive( true );

  //       //**devchoi - 최종적으로 네트워크 에러팝업이 뜬 경우 기본 백키를 비활성 시킴
  //      if (ProjectManager.Instance.heroSelectManager != null)
  //          ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = true;

  //      if (ProjectManager.Instance.titlemanager != null)
  //          ProjectManager.Instance.titlemanager.activeNetTouchBlock = true;
       
  //      if (UINavigationManager.Instance != null)
  //          UINavigationManager.Instance.activeNetTouchBlock = true;
    }

    IEnumerator IE_CheckIndicator()
    {
        float checkTime = 0;

        while( true )
        {
            checkTime += Time.deltaTime;

            if( checkTime > 1f )
            {
                ga_indicator.SetActive( true );
                ga_indicatorBG.SetActive( true );
                break;
            }

            yield return null;
        }
    }

    public void TouchBlockOff()
    {
        if( co_indicatorTimer != null )
        {
            StopCoroutine( co_indicatorTimer );
            co_indicatorTimer = null;
        }


        // 네트워크 통신으로 통신 막힐때 안드로이드 백버튼 기능 재개
        //if (ProjectManager.Instance.heroSelectManager != null)
        //    ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = false;

        //if (ProjectManager.Instance.titlemanager != null)
        //    ProjectManager.Instance.titlemanager.activeNetTouchBlock = false;
        
        //if (UINavigationManager.Instance != null)
        //    UINavigationManager.Instance.activeNetTouchBlock = false;

        ga_touchBlock.SetActive( false );
        ga_indicator.SetActive( false );
        ga_indicatorBG.SetActive( false );
    }

    public void TouchBlockOn()
    {
        if( co_indicatorTimer != null )
        {
            StopCoroutine( co_indicatorTimer );
        }
		
        ga_touchBlock.SetActive( true );

        // 네트워크 통신으로 통신 막힐때 안드로이드 백버튼 먹히지 않음
        //if (ProjectManager.Instance.heroSelectManager != null)
        //    ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = true;

        //if (ProjectManager.Instance.titlemanager != null)
        //    ProjectManager.Instance.titlemanager.activeNetTouchBlock = true;
       
        //if (UINavigationManager.Instance != null)
        //    UINavigationManager.Instance.activeNetTouchBlock = true;

        co_indicatorTimer = StartCoroutine( IE_CheckIndicator() );
    }

    public void TouchBlockOnWithIndicator()
    {
        ga_touchBlock.SetActive( true );
        ga_indicator.SetActive( true );
        ga_indicatorBG.SetActive( true );

        // 네트워크 통신으로 통신 막힐때 안드로이드 백버튼 먹히지 않음
        //if (ProjectManager.Instance.heroSelectManager != null)
        //    ProjectManager.Instance.heroSelectManager.activeNetTouchBlock = true;

        //if (ProjectManager.Instance.titlemanager != null)
        //    ProjectManager.Instance.titlemanager.activeNetTouchBlock = true;
       
        //if (UINavigationManager.Instance != null)
        //    UINavigationManager.Instance.activeNetTouchBlock = true;
    }



	/// <summary>
	/// 에 러 코 드 텍 스 트 처 리 
	/// </summary>
	protected string GetErrorCodeString( string _errCode )
	{
		string errText = "";

		//switch (_errCode) {
		//case "0":
		//	errText = ProjectManager.Instance.datamanager.GetLoadText ("network_popup_error");
		//	break;
		//case "405":
		//	errText = UIConstants.HTEXT_ERROR_405;
		//	break;
		//case "4444":
		//	errText = ProjectManager.Instance.datamanager.GetLoadText ("warning_False_Account");
		//	break;
		//case "TimedOut":
		//	errText = UIConstants.HTEXT_ERROR_TIMEOUT;
		//	break;
		//case "Error":
		//	break;
		//default:
		//	{
		//		string stringKey = Utils.CreateStringBuilderStrFormat( "warning_{0}", _errCode );
		//		errText = ProjectManager.Instance.datamanager.GetLoadText( stringKey );
		//	}
		//	break;
		//}

		//// 에 러 텍 스 트 가 없 을 경 우 
		//if (string.IsNullOrEmpty (errText)) {
		//	errText = UIConstants.HTEXT_ERROR_TIMEOUT;
		//}
		//// 아 직 정 상 적 인 텍 스 트 입 력 이 안 되 었 을 경 우 
		//else if (errText.Equals ("1111")) {
		//	errText = ProjectManager.Instance.datamanager.GetLoadText ("network_popup_error");
		//	errText = errText + "\n\n( eCode : " + _errCode + " )";
		//} 

		return errText;
	}


	/// <summary>
	/// 에 러 코 드 에 따 른 팝 업 이 동 처 리 
	/// </summary>
	protected void GetPopupState( string _errCode, ref bool _isReload , ref bool _isMoveToSplash )
	{
		_isReload = false;
		_isMoveToSplash = false;

		switch (_errCode) {

		//case "405":			// NEED_VERSION_UPDATE: 405,              // API 버전 업데이트 필요
		case "406":			// NEED_CDN_UPDATE: 406,                   // CDN 업데이트 필요
//		case "500":			// INTERNAL_SERVER_ERROR: 500,             // 서버 에러
//		case "1000":		// LOGIN_NO_USER: 1000,                    // 존재하지 않는 player-id
//		case "1001":		// SEARCH_NO_USER: 1001,                   // 존재하지 않는 device-uuid
//		case "2000":		// NO_PLAYER_INFO: 2000,                   // 플레이어 정보가 존재하지 않음
//		case "4444":		// BLOCK_USER: 4444,                       // 차단된 유저
//		case "9999":		// LOCKING_API: 9999,                         // 유저단위 api 락(서버에서 api 처리가 완료되지 않은 상태에서 추가 api 호출 시)
			_isReload = true;
			_isMoveToSplash = true;
			break;
			
		// 재화 등 부족 
		case "2008":			// NOT_ENOUGH_GOLD: 2008,                  // 골드 부족
		case "2010":			// NOT_ENOUGH_DIAMOND: 2010,               // 다이아몬드 부족
		case "2021":			// NOT_ENOUGH_STAMINA: 2021,               // 스태미너 부족	
		case "2136":			// NOT_ENOUGH_MILEAGE: 2136,               // 마일리지 부족
		case "3025":			// NOT_ENOUGH_TIER: 3025,                  // 티어 미달 
		case "3026":			// NOT_ENOUGH_TEAM_LEVEL: 3026,            // 팀레벨 미달
		case "3037":			// NOT_ENOUGH_SUMMON_PIECE: 3037,              // 조각 부족
		case "3044":			// NOT_ENOUGH_CHAMPION_PIECE: 3044,            // 챔피언 조각 부족
		case "3048":			// NOT_ENOUGH_MATERIAL: 3048,                  // 재료 아이템 부족
		case "3051":			// NOT_ENOUGH_CHAMPION_SKILL_POINT: 3051,      // 챔피언 스킬 포인트 부족
		case "3052":			// NOT_ENOUGH_CHAMPION_USED_SKILL_POINT: 3052, // 사용한 스킬포인트가 부족
		case "3106":			// NOT_ENOUGH_SWEEPTICKET: 3106, // 소탕권 부족
		case "3112":			// NOT_ENOUGH_SINGLE_DUNGEON_TIER: 3112,       // 티어 부족으로 던전 이용 불가
			_isReload = false;
			_isMoveToSplash = false;
			break;
			// 이미 뭔가 이상한 경우 
//		case "1002":			// ALREADY_EXITS_NICK_NAME: 1002,          // 이미 사용중인 닉네임 (Deprecated)
//		case "1007":			// ALREADY_JOIN_DEVICE_ID: 1007,           // 이미 가입된 device-uuid
//		case "2031":			// ALREADY_RESET_CHAMPION_SKILL: 2031,          // 스킬이 이미 초기화된 상태 (챔피언 스킬 초기화시)
//		case "3034":			// ALREADY_OPEN_ARENA_BOX: 3004,           // 이미 오픈중인 아레나 박스가 있다.
//		case "3061":			// ALREADY_ALL_CLEAR_INVADE_STAGE: 3061,           // 이미 돌격대 스테이지 모두 클리어 했는데도 전투 요청
//		case "3062":			// ALREADY_EXPIRE_INVADE: 3062,                    // 이미 만료된 돌격대
//		case "3028":			// ALREADY_SALE_DONE: 3028,                // 판매 기간이 지남
//		case "3010":			// ALREADY_MAX_RUNE_LEVEL: 3010,           // 이미 최대 레벨에 도달한 룬
//		case "3013":			// ALREADY_MAX_RUNE_GRADE: 3013,           // 이미 최고 등급에 도달한 룬(진화 시도시)
//		case "3036":			// ALREADY_MAX_SUMMON_LEVEL: 3036,         // 이미 소환수의 레벨이 최대
//		case "3043":			// ALREADY_MAX_CHAMPION_LEVEL: 3043,           // 챔피언이 이미 최고 레벨 도달
//		case "3045":			// ALREADY_MAX_CHAMPION_EQUIP_LEVEL: 3045,     // 이미 챔피언 장비가 최대 레벨 도달
//		case "3050":			// ALREADY_MAX_CHAMPION_SKILL_LEVEL: 3050,     // 이미 챔피언의 스킬 레벨이 만땅이다
//		case "2173":			// ALREADY_MAX_RUNE_SLOT_BUY_COUNT: 2173,          // 이미 최대치 만큼 룬 슬롯을 구매 함
//		case "3003":			// ALREADY_ACTIVATED_ARENA_BOX: 3003,      // 이미 활성화된 박스를 활성화 시도
//		case "3056":			// ALREADY_ACTIVATED_CHAMPION_SKILL: 3056,            // 이미 장착한 스킬
//		case "3063":			// ALREADY_ACTIVATED_RUNE: 3063,                   // 이미 챔피언에게 착용된 룬
//		case "3033":			// ALREADY_ACTIVATED_SUMMON: 3033,                 // 중복된 소환수 타입 전달
//			
//		case "2069":			//WRONG_STAGE_DATA: 2069,                 // 플레이 할 수 없는 스테이지 정보 전달 (싱글 던전 플레이 시작)
//		case "2114":			//WRONG_SUMMON_TYPE: 2114,                // 잘못된 소환수 타입 전달 (샵)
//		case "2134":			//WRONG_QUEST_TYPE: 2134,                 // 잘못된 퀘스트 타입 전달 (퀘스트 클리어)
//		case "2146":			//WRONG_SHOP_ARENA_DATA: 2146,            // 샵 - 상자 정보가 잘못됨(데이터 문제)
//		case "3001":			//WRONG_TUTORIAL_PHASE: 3001,             // 잘못된 튜토리얼 단계(진행할수 없는 단계인데 api 호출이 온 경우)
//		case "3007":			//WRONG_RUNE_TYPE: 3007,           // 잘못된 룬 타입으로 생성 시도
//		case "3009":			//WRONG_MATERIAL_RUNE_ID: 3009,      // 레벨업시 대상 룬이 재료 룬에 포함되어 있음
//		case "3018":			//WRONG_PARTY_LIST: 3018,            // 잘못된 파티리스트 정보 전달
//		case "3019":			//WRONG_PARTY_NO: 3019,       // 잘못된 파티 넘버 전달
//		case "3029":			//WRONG_PAYLOAD: 3029,                    // 잘못된 페이로드
//		case "3041":			//WRONG_REWARD_BOX: 3041,            // 전투 진행시 획득한 박스 정보가 잘못 전달되었다.
//		case "3047":			//WRONG_CHAMPION_EQUIP_TYPE: 3047,       // 잘못된 챔피언 장비 타입 전달
//		case "3049":			//WRONG_CHAMPION_SKILL_TYPE: 3049,       // 잘못된 챔피언 스킬 타입 전달
//		case "3065":			//WRONG_INVADE_STATE: 3065,                       // 잘못된 돌격대 상태 (돌격대 침공 상태가 아닌 상태에서 전투 시작 요청 이라던지..)
//		case "3064":			//WRONG_INVADE_BATTLE_INFO: 3064,                 // 돌격대 전투 정보가 잘못되었다. 정상적인 진행이 되지 않은 상태에서 전투 종료 요청.
//		case "2065":			//WRONG_BATTLE_INFO: 2065,                 // 잘못된 스테이지 정보 전달 (싱글 던전 플레이 종료)
//
//		case "3005":			//NOT_FOUND_RUNE_INFO: 3005,       // 룬 정보가 존재 하지 않는다. ( 보유하지 않은 룬 )
//		case "3020":			//NOT_FOUND_QUEST_INFO: 3020,      // 퀘스트 정보를 찾을 수 없다.
//		case "3035":			//NOT_FOUND_SUMMON_INFO: 3035,     // 소환수 정보 조회 실패
//		case "3038":			//NOT_FOUND_SUMMON_LIST: 3038,            // 소환수 목록 조회 실패
//		case "3040":			//NOT_FOUND_STAGE_INFO: 3040,      // 스테이지 정보 조회 결과 없음
//		case "3042":			//NOT_FOUND_CHAMPION_INFO: 3042,       // 챔피언 정보 조회 결과 없음
//		case "3046":			//NOT_FOUND_CHAMPION_EQUIP_DATA: 3046,        // 챔피언 장비 데이터가 없다(데이터 에러)
//		case "3058":			//NOT_FOUND_CHAMPION_SKILL_DATA: 3058,            // 스킬 데이터가 없다
//		case "3060":			//NOT_FOUND_INVADE_INFO: 3060,             // 돌격대 정보 조회 실패
//		case "3066":			//NOT_FOUND_MATERIAL: 3066,               // 재료 부족
//
//		case "3077":			//NOT_FOUND_INVITATION: 3077,               // 초대장을 찾을수 없을 때
//		case "3078":			//NOT_FOUND_PVPINFO: 3078,               // PVP 정보를 찾을수 없을 때
//
//
//		case "2111":			//NOT_POST: 2111,                         // 잘못된 우편 정보
//		case "3006":			//NOT_GET_RUNE_PRE_INFORMATION: 3006,     // 룬 생성을 위한 사전 정보 조회에 실패 (서버 내부 에러)
//		case "3012":			//NOT_MAX_RUNE_LEVEL: 3012,               // 최대 레벨이 아닌 룬으로 진화 시도
//		case "3014":			//NOT_SAME_RUNE_COLOR: 3014,              // 동일한 룬의 색상이 아니다(진화 시도시)
//		case "3015":			//NOT_SAME_RUNE_SHAPE: 3015,              // 동일한 룬의 모양이 아니다(진화 시도시)
//		case "3016":			//NOT_SAME_RUNE_GRADE: 3016,              // 동일한 룬의 등급이 아니다(진화 시도시)
//		case "3022":			//NOT_SELLING_ITEM: 3022,                 // 판매하지 않는 항목의 아이템(소환수)를 구매 시도
//		case "3031":			//NOT_OWN_CHAMPION_TYPE: 3031,            // 보유하지 않은 챔피언 타입 전달
//		case "3032":			//NOT_OWN_SUMMON_TYPE: 3032,              // 보유하지 않은 소환수 타입 전달
//		case "3053":			//NOT_LEARNED_CHAMPION_PRE_SKILL: 3053,           // 선행 스킬을 배우지 않음
//		case "3054":			//NOT_LEARNED_CHAMPION_PRE_SKILL_LEVEL: 3054,     //  선행 스킬의 레벨이 충분치 않음
//		case "3055":			//NOT_LEARNED_CHAMPION_SKILL: 3055,               // 배우지 않은 스킬
//		case "3059":			//NOT_ACTIVATED_CHAMPION_SKILL: 3059,                      // 장착되지 않은 스킬
//		case "2052":			//NOT_ACTIVATED_RUNE: 2052,               // 장착되어있지 않은 룬을 장착 해제 시도
//		case "2030":			//NOT_ACTIVATED_SUMMON: 2030,                // 활성화되지 않은 소환수 (파티)
//		case "3057":			//NOT_EMPTY_CHAMPION_SKILL_SLOT: 3057,             // 스킬 빈슬롯이 없다
//
//		case "3002":			//FAILED_CREATE_NEW_ARENA_BOX_UID: 3002,        // 아레나 박스 uid 생성 실패(서버 내부 에러)
//		case "3023":			//FAILED_CREATE_NEW_SUMMON_ORDER_ID: 3023,    // 소환수 주문id 생성 실패 ( 내부 에러 )
//		case "3034":			//FAILED_CREATE_NEW_MAIL_ID: 3034,        // 신규 메일 id 생성 실패 ( 내부 에러 )
//		case "3039":			//FAILED_GET_ITEM_SERVICE: 3039,               // 잘못된 아이템 타입 전달
//		case "3067":			//FAILED_GET_MAIL_COUNT: 3067,            // 우편물 갯수를 가져오는데 실패.
//
//		case "3017":			//CANT_RECEIVE_MAIL_LACK_OF_RUNE_SLOT: 3017,      // 룬 슬롯 부족으로 우편(룬)을 받을 수 없는 경우
//		case "3021":			//CANT_CLEAR_QUEST: 3021,                 // 클리어 할 수 없는 퀘스트
//		case "2150":			//CANT_USE_WORD: 2150,                    // 사용 할 수 없는 닉네임(욕설/비속어)
//		case "2152":			//CANT_USE_WORD_KANJI: 2152,              // 사용 할 수 없는 닉네임(한자)
//
//		case "2139":			//SHOP_PURCHASE_LIMIT_TODAY_FREE: 2139,   // 샵 - 무료 상자를 이미 오픈 함
//		case "2140":			//SHOP_PURCHASE_TODAY_ANYMORE: 2140,      // 샵 - 더 이상 구매 할 수 없다. (소환수)
//
//		case "3000":			//RISEMARA_ERROR: 3000,                   // 리세마라 에러(내부 에러.. 데이터 문제)
//		case "3024":			//USE_ONLY_DIAMOND: 3024,                 // 데이터 에러
//		case "3027":			//BUY_LIMIT_OVER: 3027,                   // 구매 제한
//		case "3030":			//COLLECT_LIMIT_MIN_VAULT: 3030,          // 금고에 수집할만큼 충분한 골드가 쌓이지 않았다.
//		case "31011":			//DOUBLE_LOGIN_ERROR: 31011,              // 중복 로그인
//
//
//			// 클라이언트와의 협의가 필요하기때문에 기존 부여된 에러 번호는 변경 x
//
//			//new error codes..
//			// 맥스 치 초과에 대한 에러.
		case "3100":			//FULL_DIAMOND: 3100,                     // 더 이상 다이아몬드를 획득 할 수 없을 경우.
		case "3101":			//FULL_GOLD: 3101,                        // 더 이상 골드를 획득 할 수 없을 경우.
		case "3102":			//FULL_STAMINA: 3102,                     // 더 이상 행동력을 획득 할 수 없을 경우.
		case "3103":			//FULL_MILEAGE: 3103,                     // 더 이상 마일리지를 획득 할 수 없을 경우.
		case "3104":			//FULL_SWEEPTICKET: 3104,                 // 더 이상 소탕권을 획득 할 수 없을 경우.
		case "3105":			//CAN_NOT_USE_SWEEPTICKET: 3105,          // 소탕권을 사용 할수 없다.
		case "3107":			//SHORTFALL_BILLING: 3107,                // 과금액 부족으로 구매할수 없는 아이템
		case "3108":			//SHORTFALL_NOT_LOGGED_IN: 3108,          // 미로그인 날짜 부족으로 인해 구매 할 수 없는 아이템(복귀 유저 아이템)
		case "3109":			//LACK_OF_RUNE_SLOT: 3109,                // rune-slot 부족
			_isReload = false;
			_isMoveToSplash = false;
			break;

//
//		case "3110":			//FAILED_BUY_ITEM_NOT_MATCH_CODE: 3110,   // 비정상 영수증 정보
//		case "3111":			//FAILED_BUY_ITEM_WRONG_RECEIPT: 3111,    // 비정상 영수증 정보
//
//		case "9013":			//API_SERVER_BUSY: 9013,                  // 모든 api-db가 한계에 도달
//		case "9014":			//PVP_SERVER_BUSY: 9014,                  // 모든 pvp-db가 한계에 도달- 잠시 후 다시 시도
//		case "9015":			//PVP_REWARD_NOT_AVAILABLE: 9015,         // 기존 pvp 전투가 종료 된 상태가 아니다.
//		case "9016":			//PVP_HAS_REWARD: 9016,                   // 받을 보상이 존재한다(pvp 매칭 시도시)
//		case "9017":			//PVP_NO_REWARDBOX: 9017,                 // 상자가 존재하지 않는다(상자 열기, 활성화)
//		case "9018":			//PVP_NOT_SELECTED_SERVER: 9018,          // pvp 서버를 선택하지 못하였다. (매칭시) - 매칭 재시도
//		case "9019":			//PVP_SERVER_IS_TESTING: 9019,            // PVP 서버 점검중
//		case "9020":			//PVP_CHEATER: 9020,                      // 치터 유저
//
//
//		case "13104":			//BRIDGE_E0102: 13104,                    // E0102 400 입력 값 형식 오류로 인해 처리가 계속 수 없다.
//		case "13105":			//BRIDGE_E0001: 13105,                    // E0001 401 OAuth 인증 오류로 인해 처리가 계속 수 없다.
//		case "13106":			//BRIDGE_E0002: 13106,                    // E0002 401 oauth_body_hash가 부정이기 때문에 처리가 계속 수 없다.
//		case "13107":			//BRIDGE_E0201: 13107,                    // E0201 403 개 API에 대한 실행 권한이 없습니다.
//		case "10002":			//BRIDGE_E0103: 10002,                    // E0103 404 마스터 데이터 결합 데이터 부정 의해 자원이 존재하지 않는다.
//		case "13109":			//BRIDGE_E0104: 13109,                    // E0104 404 처리 대상이 잠겨있는 상한치에 도달했습니다 만료 등 처리 조건을 만족하지 않기 때문에 처리가 계속 수 없다.
//		case "10301":			//BRIDGE_E0301: 10301,                    // E0301 404 CESA 연령별 과금 제한의 한계에 도달하고 있기 때문에 리소스를 추가 할 수 없다.
//		case "10012":			//BRIDGE_E0998: 10012,                    // E0998 404 알 수없는 이유로 자원이 존재하지 않는다.
//		case "13110":			//BRIDGE_E2001: 13110,                    // E2001 404 데이터 중복 오류로 인해 자원의 추가 할 수 없다.
//		case "13111":			//BRIDGE_E0101: 13111,                    // E0101 405 요청 메소드 부정 오류로 인해 처리가 계속 수 없다.
//		case "10500":			//BRIDGE_E0999: 10500,                    // E0999 500 시스템 오류로 인해 처리가 계속 수 없다.
//		case "13113":			//BRIDGE_E2002: 13113,                    // E2002 400 inviteCode 가 전달되고 있지만 잘못된 것이다.
//		case "13114":			//BRIDGE_E2101: 13114,                    // E2101 403 사용자가 정지 상태이기 때문에 처리가 계속 수 없다.
//		case "13115":			//BRIDGE_E1001: 13115,                    // E1001 404 검색 대상 자원이 존재하지 않는다.
//		case "13002":			//BRIDGE_E3002: 13002,                    // E3002 404 데이터 중복 오류로 인해 자원의 갱신 할 수 없다.
//		case "13116":			//BRIDGE_E3003: 13116,                    // E3003 404 업데이트 할 수없는 데이터를위한 리소스 업데이트 할 수 없다
//		case "13117":			//BRIDGE_E3001: 13117,                    // E3001 404 업데이트 대상 조건을 만족하는 데이터가 존재하지 않기 때문에 자원의 갱신 할 수 없다.
//		case "10102":			//BRIDGE_E3101: 10102,                    // E3101 403 인도 된 제품 ID와 서버에 설정되어있는 제품 ID가 일치하지 않기 때문에 자원의 갱신 할 수 없다.
//		case "13103":			//BRIDGE_E3103: 13103,                    // E3103 404 [v6] 인도 된 bridgeTransId 이미 영수증이 커밋되는
//		case "13118":			//BRIDGE_E3104: 13118,                    // E3104 404 미리 지정한 checkProductId 구매 데이터에서 제품 ID가 다르기 때문에 처리가 계속 수 없다.
//		case "13119":			//BRIDGE_E3106: 13119,                    // E3106 404 대상 receiptTransactionId 영수증에 존재하지 않는다.
//		case "13120":			//BRIDGE_E3107: 13120,                    // E3107 404 구독 영수증이기 때문에 계속할 수 없다.
//		case "13121":			//BRIDGE_E3200: 13121,                    // E3200 404 Apple에서 상태 코드 21000 (보낸 JSON 정보가 App Store에서 읽어 들일 수 없었던)에 대한 처리를 계속할 수없는
//		case "13122":			//BRIDGE_E3202: 13122,                    // E3202 404 Apple에서 상태 코드 21002 (receipt-data 속성의 데이터가 부정 또는 누락)에 대한 처리를 계속할 수없는
//		case "13124":			//BRIDGE_E3204: 13124,                    // E3204 404 Apple에서 상태 코드 21004 (공유 암호가 잘못)에 대한 처리를 계속할 수없는
//		case "13125":			//BRIDGE_E3205: 13125,                    // E3205 404 Apple에서 상태 코드 21005 (Apple 측의 영수증 서버가 현재 사용할 수없는)에 대한 처리를 계속할 수없는
//		case "13126":			//BRIDGE_E3105: 13126,                    // E3105 403 구독 구매 데이터이기 때문에 처리가 계속 수 없다.
//		case "13127":			//BRIDGE_E3102: 13127,                    // E3102 403 구매 데이터와 서명이 일치하지 않기 때문에 자원의 갱신 할 수 없다.
//
//		case "10504":			//BRIDGE_TIME_OUT: 10504,                 // 브릿지 타임아웃
//		case "13999":			//BRIDGE_SERVICE_UNAVAILABLE: 13999,      // 브릿지 점검중
//		case "10501":			//STORE_BILLING_CHECK_MODE: 10501,        // 과금점검모드
//		case "19000":			//BRIDGE_ERROR: 19000,                    // 브릿지 에러(핸들링하지 않는 기본 에러 코드)
//		case "20000":			//SERVER_CHECK: 20000,                    // 서버 점검중
//		case "30000":			//REDIS_DISCONNECT: 30000,
//		case "50000":			//NINJA_DECRYPT_ERROR: 50000,             // 닌자 복호화 에러
//		case "50001":			//NINJA_ENCRYPT_ERROR: 50001,             // 닌자 암호화 에러
//		case "50002":			//PARAM_DECRYPT_ERROR: 50002,             // 파라미터 복호화 에러
//		case "50003":			//PARAM_ENCRYPT_ERROR: 50003,             // 파라미터 암호화 에러
//			break;
		}
	}
}
