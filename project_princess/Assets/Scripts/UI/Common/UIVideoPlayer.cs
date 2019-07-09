using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;


public class UIVideoPlayer : MonoBehaviour, IPointerClickHandler
{
	public Image baseImage = null;
	public RawImage videoImage = null;
	public VideoPlayer videoPlayer = null;

	public VideoClip videoClip = null;
	public AudioSource audioSource = null;
	public bool autoPlay = false;

	protected bool canSkip = true;
	protected bool canLoop = false;
	protected bool isPlaying = false;

	public bool CanSkip
    { 
        get
        { 
            return canSkip; 
        }
        set
        { 
            canSkip = value; 
        } 
    }

	public bool CanLoop
    { 
        get
        { 
            return canLoop; 
        } 
        set 
        { 
            canLoop = value; 

            if( videoPlayer != null )
            {
                videoPlayer.isLooping = value;
            } 
        }
    }

    protected void OnDestroy()
    {
        Stop();
    }

    public void SetVideoClip( string _fileName )
    {
        videoClip = Resources.Load< VideoClip >( "Video/" + _fileName + "_" + ProjectManager.Instance.language.ToString() );

        if( videoClip == null )
        {
            videoClip = Resources.Load< VideoClip >( "Video/" + _fileName );
        }

        //if( Resources.Load< VideoClip >( "Video/" + _fileName + "_" + ProjectManager.Instance.language.ToString() ) == null )
        //{
        //    videoClip = Resources.Load< VideoClip >( "Video/" + _fileName );
        //}
        //else
        //{
        //    videoClip = Resources.Load< VideoClip >( "Video/" + _fileName + "_" + ProjectManager.Instance.language.ToString() );
        //}
    }

    public void Play()
	{
		Application.runInBackground = true;

		GameObject prefab = Resources.Load( "Prefabs/VideoPlayer/VideoPlayer" ) as GameObject;

		GameObject go = Instantiate( prefab ) as GameObject;	 
		go.SetActive( true );
		go.transform.SetParent( this.transform );
		go.transform.localScale = Vector3.one;
		go.transform.localPosition = Vector3.zero;

		videoPlayer = go.GetComponent< VideoPlayer >();
		videoPlayer.playOnAwake = false;
		videoPlayer.source = VideoSource.VideoClip;
		videoPlayer.clip = videoClip;
		videoPlayer.isLooping = canLoop;
		audioSource.volume = 1f;
		videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
		videoPlayer.SetTargetAudioSource( 0, audioSource );
		videoPlayer.EnableAudioTrack( 0, true );

        InitializeEvents();

		float resolution = 1f;

        //if( videoClip.width > videoClip.height )
        //{
        //    resolution = ( float )GetComponent< RectTransform >().rect.height / videoClip.height;
        //}
        //else
        //{
        //    resolution = ( float )GetComponent< RectTransform >().rect.width / videoClip.width;
        //}

        if( ( float )GetComponent< RectTransform >().rect.width < 720 )
        {
            resolution = ( float )GetComponent< RectTransform >().rect.width / videoClip.width;
        }

        videoImage = videoPlayer.GetComponent< RawImage >();

		videoImage.rectTransform.sizeDelta = new Vector2( videoClip.width * resolution, videoClip.height * resolution );
		videoImage.color = Color.black;
        //videoImage.transform.SetSiblingIndex( 0 );
		videoPlayer.Prepare();

	}

    protected void InitializeEvents()
    {
        if( videoPlayer != null )
        {
			videoPlayer.prepareCompleted += Prepared;
			videoPlayer.loopPointReached += EndReached;	
		}
    }

    protected void ReleaseEvents()
    {
        if( videoPlayer != null )
        {
			videoPlayer.prepareCompleted -= Prepared;
			videoPlayer.loopPointReached -= EndReached;	
		}
    }

	public void Stop()
	{
		if( videoPlayer != null )
        {
            ReleaseEvents();
			isPlaying = false;
			StartCoroutine( CoLazyDestroy() );
		}
	}

	protected IEnumerator CoLazyDestroy()
	{
		videoImage.texture = null;
        videoPlayer.clip = null;
        videoClip = null;
		Destroy( videoPlayer.gameObject );
		videoPlayer = null;
		yield return YieldReturnManager.waitForSeconds( 100 );

  //      if( UIAction.COMMON_VIDEOPLAYER_END != null && UIAction.COMMON_VIDEOPLAYER_END.GetInvocationList().Length > 0 )
  //      {
		//    UIAction.COMMON_VIDEOPLAYER_END();
		//}
	}


	protected void Prepared( VideoPlayer _player )
	{
		if( videoPlayer.isPrepared == true )
        {
			baseImage.gameObject.SetActive( true );
			videoImage.texture = videoPlayer.texture;
			videoPlayer.Play();
			isPlaying = true;
            videoImage.color = Color.white;
			
   //         if( UIAction.COMMON_VIDEOPLAYER_START != null && UIAction.COMMON_VIDEOPLAYER_START.GetInvocationList().Length > 0 )
   //         {
			//	UIAction.COMMON_VIDEOPLAYER_START();
			//}
		}
	}


	public void EndReached( VideoPlayer _player )
	{
		if( videoPlayer.isLooping == false )
        {
            Stop();
        }
			
	}

	// 동영상 재생중 클릭 로직 추가
	public void OnPointerClick( PointerEventData eventData ) 
	{
		if( canSkip == true )
        {
			Stop();	
		}
	}

	void OnApplicationPause( bool pause )
	{
		if( videoPlayer != null )
        {
			if( pause == true )
            {
				if( isPlaying == true )
                {
					isPlaying = false;

					if( videoPlayer.isPlaying == true )
                    {
				        videoPlayer.Pause();
	                }
				}
			} 
			else
            {
				if( isPlaying == false )
                {
					isPlaying = true;

					if( videoPlayer.isPlaying == false )
                    {
						videoPlayer.Play();
					}
				}
			}
		}
	}
}
