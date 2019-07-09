using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Utils
{
    /// <summary>
    /// 이미지 로딩 - 단일 리소스
    /// </summary>
    public static Sprite LoadUIImageResource( string folderName, string resourceName )
    {
        Sprite sprite = null;

        if( resourceName == string.Empty || folderName == string.Empty )
        {
            Debug.LogError( "resourceName or folderName is Empty" );
            return sprite;
        }
            
        string path = CreateStringBuilderStr( new string[]{ "Images/DinamicImage/", folderName, "/", resourceName } );
        sprite = Resources.Load< Sprite >( path );

        if( sprite == null )
        {
            Debug.LogError( "not exist image resource - " + resourceName );
            return sprite;
        }

        return sprite;
    }

    /// <summary>
    /// 이미지 로딩 - Atlas에서 로딩
    /// </summary>
    public static Sprite LoadUIImageResourceFromAtlas( string folderName, string atlasName, string resourceName )
    {
        SpriteAtlas atlas = null;
        Sprite sprite = null;

        if( atlasName == string.Empty || resourceName == string.Empty )
        {
            Debug.LogError( "atlasName or folderName is Empty" );
            return sprite;
        }
            
        string path = CreateStringBuilderStr( new string[]{ "Images/DinamicImage/", folderName, "/", atlasName } );
        atlas = Resources.Load< SpriteAtlas >( path );

        if( atlas == null )
        {
            Debug.LogError( "not exist atlas resource" );
            return null;
        }

        sprite = atlas.GetSprite( resourceName );

        if( sprite == null )
        {
            Debug.LogError( "not exist sprite resource" );
            return null;
        }

        return sprite;
    }

    /// <summary>
    /// 씬 로딩
    /// </summary>
    public static void LoadLevel( string _currentScene, string _nextScene )
    {
        ProjectManager.Instance.currentScene = _currentScene;
        ProjectManager.Instance.nextScene = _nextScene;

        //UnityEngine.SceneManagement.SceneManager.LoadScene( "Loading" );
        UnityEngine.SceneManagement.SceneManager.LoadScene( ProjectManager.Instance.nextScene );
    }

    #region string 형 변환

	public static int IntConvert( string _str )
    {
        int re = 0;
        
        if( _str.Equals( "" ) == false )
        {
            if( int.TryParse( _str, out re ) == false )
            {
                Debug.LogError( "IntConvert Fail > _str  = " + _str );
            }
        }
        
        return re;
    }

    public static float FloatConvert( string _str )
    {
        float re = 0;
        
        if( _str.Equals( "" ) == false )
        {
            if( float.TryParse( _str, out re ) == false )
            {
                Debug.LogError( "FloatConvert Fail > _str  = " + _str );
            }
        }
        
        return re;
    }

    public static bool BoolConvert( string _str )
    {
        bool re = false;
        
        if( _str.Equals( "" ) == false )
        {
            if( bool.TryParse( _str, out re ) == false )
            {
                Debug.LogError( "BoolConvert Fail > _str  = " + _str );
            }
        }
        
        return re;
    }

	public static byte ByteConvert ( string _str )
	{
		byte re = 0;
		if( _str.Equals( "" ) == false )
		{
			if( byte.TryParse( _str, out re ) == false )
			{
				Debug.LogError ( "ByteConvert Fail > _str =" + _str );
			}
		}
		return re;
	}

    public static sbyte SbyteConvert( string _str )
    {
        sbyte re = 0;
		if( _str.Equals( "" ) == false )
		{
			if( sbyte.TryParse (_str, out re) == false )
			{
				Debug.LogError( "ByteConvert Fail > _str =" + _str );
			}
		}
		return re;
    }

	public static ushort UshortConvert( string _str )
	{
		ushort re = 0;
		if( _str.Equals( "" ) == false )
		{
			if ( ushort.TryParse( _str, out re ) == false )
			{
				Debug.LogError( "UshortConvert Fail > _str =" + _str );
			}
		}
		return re;
	}

    public static short ShortConvert( string _str )
    {
        short re = 0;
		if( _str.Equals( "" ) == false )
		{
			if( short.TryParse( _str, out re ) == false )
			{
				Debug.LogError( "ShortConvert Fail > _str =" + _str );
			}
		}
		return re;
    }

	public static uint UIntConvert( string _str )
	{
		uint re = 0;
		if( _str.Equals( "" ) == false )
		{
			if( uint.TryParse( _str, out re ) == false )
			{
				Debug.LogError( "UIntConvert Fail > _str =" + _str );
			}
		}
		return re;
	}

    public static T ConvertEnumData< T >( string _value )
    {
        return ( T )Enum.Parse( typeof( T ), _value );
    }
	#endregion

    /// <summary>
	/// 인자 값으로 받은 스트링 Array 값을 StringBuilder 로 문장으로 만들어 리턴
	/// </summary>
	public static string CreateStringBuilderStr( string[] _strArray )
	{
		StringBuilder sb = new StringBuilder();

		for( int i = 0 ; i < _strArray.Length ; i++ )
		{
			sb.Append( _strArray[ i ] );
		}

		return sb.ToString ();
	}

    /// <summary>
    /// format을 이용하여 StringBuilder로 문장 만들기
    /// </summary>
    public static string CreateStringBuilderStrFormat( string _format, params object[] _args )
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat( _format, _args );
        return sb.ToString();
    }

    /// <summary>
    /// 남은 시간 스트링 형태로 변환
    /// </summary>
    public static string ConvertRemainTimeToString( int _remainTime )
    {
        StringBuilder stringBuilder = new StringBuilder();
        int hour = _remainTime/3600;
        int minute = ( _remainTime%3600 )/60;
        int second = ( _remainTime%3600 )%60;

        if( 0 < hour )
        {
            stringBuilder.Append( CreateStringBuilderStr( new string[]{ hour.ToString( "00" ), ":" } ) );
        }
        
        stringBuilder.Append( CreateStringBuilderStr( new string[]{ minute.ToString( "00" ), ":", second.ToString( "00" ) } ) );

        return stringBuilder.ToString();
    }
        
    /// <summary>
    /// 텍스트 리턴
    /// </summary>
    public static string GetLoadText( string _key )
    {
        string text = "";
        if( ProjectManager.Instance.staticDataManager.languageStringDic.TryGetValue( _key, out text ) == false )
        {
            Debug.LogError( "Not Exist Match Text - " + _key );
            return text;
        }

        return text;
    }
}
