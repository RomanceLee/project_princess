using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BGM enum값
/// </summary>
public enum eBGM
{
    MAIN = 0,
    SHOP,
    CHALLENGE,
    COLLECTION,
    GACHASHOP,
    JOURNEY_LABYRINTH,
    JOURNEY_KOREA,
	COUNT
}

/// <summary>
/// 효과음 enum값
/// </summary>
public enum eEffectSound
{
    BUTTON_COMMON = 0,
    BUTTON_CLOSE,
    POPUP_OPEN,
    CONTEST_LOSE,
    CONTEST_WIN,
    COUNT
}


// 사운드 데이터를 위한 구조체
public struct SoundStruct
{
    public AudioClip clip;
	public float volume;

	public SoundStruct( string _path, float _volume )
	{
        clip = Resources.Load( _path ) as AudioClip;
		volume = _volume;
	}

	public SoundStruct( AudioClip _clip, float _volume )
	{
		clip = _clip;
		volume = _volume;
	}
}

public class SoundManager : MonoBehaviour
{
	public static SoundManager Instance;

    private SoundStruct[] bgmList;
    private SoundStruct[] effectList;
    private AudioSource bgmAudio;
    private List< AudioSource > effectAudio;
    private bool isChangingBGM;
    private int audioIndex;

    protected void Awake()
	{
		if( Instance )
		{
			if( this != Instance )
			{
				Destroy( this.gameObject );
			}
		}
		else
		{
			Instance = this;

			DontDestroyOnLoad( gameObject );
			SetAudioSource();

            LoadBGM();
            LoadEffectSound();

            // IOS의 경우 Frame 설정( 모두 60프레임 기준 )
            Application.targetFrameRate = 60;

		    // 멀티터치 막기
		    Input.multiTouchEnabled = false;

		    // 화면 잠금 방지
		    Screen.sleepTimeout = SleepTimeout.NeverSleep;
			
		}
	}

    // 오디오 소스 컴퍼넌트 설정
	protected void SetAudioSource()
	{
		// BGM 소스 1 + Effect 소스 30
		int audioSourceCount = 31;

		// 오디오 소스 컴퍼넌트 생성
		for( int i = 0; i < audioSourceCount; i++ )
		{
			gameObject.AddComponent< AudioSource >();
		}

		AudioSource[] audioSources = GetComponents< AudioSource >();
		effectAudio = new List< AudioSource >();
		
		// 0번째 오디오 소스의 경우 배경음 전용으로 설정
		bgmAudio = audioSources[ 0 ];
		bgmAudio.playOnAwake = false;
		bgmAudio.loop = true;
		bgmAudio.volume = 1f;

		// 그외의 오디오 소스 30개는 효과음 전용으로 설정
		for( int i = 1; i < audioSources.Length; i++ )
		{
			audioSources[ i ].playOnAwake = false;
			audioSources[ i ].volume = 0.2f;
			effectAudio.Add( audioSources[ i ] );
		}
	}

	public void LoadBGM()
	{
		if( bgmList == null )
		{
			int[] soundCount =
		    {
			    ( int )eBGM.COUNT,
		    };

		    string[] path =
		    {
			    "Sound/BGM",
		    };
			LoadSound( ref bgmList, soundCount[ 0 ], path[ 0 ] );
		}	
	}

    public void LoadEffectSound()
	{
		if( effectList == null )
		{
			int[] soundCount =
		    {
			    ( int )eEffectSound.COUNT,
		    };

		    string[] path =
		    {
			    "Sound/EFFECT",
		    };
			LoadSound( ref effectList, soundCount[ 0 ], path[ 0 ] );
		}	
	}

     // BGM 플레이
	public void PlayBGM( eBGM _bgm )
	{
        Debug.Log( "PlayBGM" );
        bool isLoop = true;

		// 플레이 중인 BGM이 있다면
		if( bgmAudio.clip != null )
		{
			// 플레이 중인 BGM과 같지 않으면
			if( bgmAudio.clip != bgmList[ ( int )_bgm ].clip )
			{
                if( isChangingBGM == true )
                {
                    bgmAudio.Stop();
                    StopCoroutine( "ChangeBGM" );
                }

				// BGM체인지
                bgmAudio.loop = isLoop;
				StartCoroutine( "ChangeBGM", _bgm );
			}
		}
		// 플레이 중인 BGM이 없다면 무조건 플레이
		else
		{
            bgmAudio.loop = isLoop;
			bgmAudio.clip = bgmList[ ( int )_bgm ].clip;
			bgmAudio.volume = bgmList[ ( int )_bgm ].volume;
			bgmAudio.Play();
		}
	}

    public void UnPauseBGM()
    {
        bgmAudio.UnPause();
    }

    public void PauseBGM()
    {
        bgmAudio.Pause();
    }

    public void StopBGM()
	{
        Debug.Log( "StopBGM" );
		bgmAudio.Stop();
		bgmAudio.clip = null;
	}

    public int PlayEffect( eEffectSound _soundEffect )
    {
        int index = audioIndex;
        SetEffect( _soundEffect, effectList[ ( int )_soundEffect ].volume, false );
        return index;
    }

    private void LoadSound( ref SoundStruct[] _soundArray, int _count, string _path )
	{
		int soundCount = _count;
		_soundArray = new SoundStruct[ soundCount ];

		Object[] soundList = Resources.LoadAll( _path );

        if( soundList.Length <= 0 )
        {
            return;
        }

		for( int i = 0; i < soundCount; i++ )
		{
			// 앞에 3글자는 인덱스로 씀
			string indexStr = soundList[ i ].name.Substring( 0, 3 );
			int index = Utils.IntConvert( indexStr );
			_soundArray[ index ] = new SoundStruct( soundList[ i ] as AudioClip, 1f );
		}
	}

    // BGM 체인지
	// 소리가 점점 줄어들었다가 0.5초 후에 BGM을 체인지 하고 서서히 소리를 키운다.
	private IEnumerator ChangeBGM( eBGM _bgm )
	{
        isChangingBGM = true;

		while( bgmAudio.volume > 0 )
		{
			bgmAudio.volume -= 0.05f;
			yield return null;
		}

        bgmAudio.volume = 0;

		yield return new WaitForSeconds( 0.1f );

		bgmAudio.clip = bgmList[ ( int )_bgm ].clip;
		bgmAudio.Play();
		
		while( bgmAudio.volume < bgmList[ ( int )_bgm ].volume )
		{
			bgmAudio.volume += 0.05f;
			yield return null;
		}

    	bgmAudio.volume = bgmList[ ( int )_bgm ].volume;

        isChangingBGM = false;
	}

	/// <summary>
	/// BGM Off 시, fade out 처 리 
	/// </summary>
	private IEnumerator CoFadeOutBGM( float fDuration )
	{
		float fTime = 0f;
		float fTimeCoeff = 1f / fDuration;
		float fElapsedTime = 0f;
		float fVolume = bgmAudio.volume;

		while( bgmAudio.volume > 0 )
		{
			fElapsedTime += Time.deltaTime;

			fTime = fElapsedTime * fTimeCoeff;

			if( fTime >= 1.0f )
            {
				break;
			}
			bgmAudio.volume = Mathf.Lerp( fVolume, 0, fTime );

			yield return null;
		}

		bgmAudio.volume = 0;
	}

    private void SetEffect( eEffectSound _soundEffect, float _volume, bool _loop )
    {
        effectAudio[ audioIndex ].Stop();
        effectAudio[ audioIndex ].clip = effectList[ ( int )_soundEffect ].clip;
		effectAudio[ audioIndex ].volume = _volume;
        effectAudio[ audioIndex ].loop = _loop;
        effectAudio[ audioIndex ].Play();
        audioIndex = ( audioIndex + 1 ) % effectAudio.Count;
    }
}
