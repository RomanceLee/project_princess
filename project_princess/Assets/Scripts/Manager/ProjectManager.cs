using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ProjectManager
{
    // 싱글톤 인스턴스를 저장
	private static volatile ProjectManager uniqueInstance;
	private static object _lock = new System.Object();

    public StaticDataManager staticDataManager;

    public string currentScene;
    public string nextScene;

    public GirlGlobeEnums.eLanguage language;

	// 생성자
	private ProjectManager()
	{
		ProjectSetting();
	}

    private void ProjectSetting()
    {
        //switch( Application.systemLanguage )
        //{
        //    case SystemLanguage.Korean:
        //        language = GirlGlobeEnums.eLanguage.KR;
        //        break;
        //    default :
        //        language = GirlGlobeEnums.eLanguage.EN;
        //        break;
        //}

        //TEST CODE
        //language = GirlGlobeEnums.eLanguage.EN;
    }

    // 외부에서 접근할 수 있도록 함.
	public static ProjectManager Instance
	{
		get
		{
			if( uniqueInstance == null )
			{
				// lock으로 지정된 블록안의 코드를 하나의 쓰레드만 접근하도록 한다.
				lock( _lock )
				{
					if( uniqueInstance == null )
					{
						uniqueInstance = new ProjectManager();
					}
				}
			}
			
			return uniqueInstance;
		}
	}
    // 공통 사용 Class 생성
	public void CreatePrimitiveClass()
	{
        staticDataManager = new StaticDataManager();
	}

    //게임 타이틀 화면으로 이동 시 초기화 수행
    public void Reload()
    {
        staticDataManager = null;

    	UnityEngine.SceneManagement.SceneManager.LoadScene( "SPLASH" );
    }
}
