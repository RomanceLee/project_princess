using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICountingValue
{
	/// <summary>
	/// 재화 숫자 카운팅 애니메이션. 
	/// textObject = 갱신할 Text오브젝트, 
	/// preValue = 이전 수치, 
	/// currentValue = 현재 수치,
	/// totSec = 애니메이션 시간.
	/// </summary>
	public IEnumerator PlayCountingWealthValue( object[] param )
	{
		UIText textObject = ( UIText )param[ 0 ];
		int preValue = ( int )param[ 1 ];
		int currentValue = ( int )param[ 2 ];
		float duration = ( float )param[ 3 ];

		int value = 0;

		float fTime = 0f;
		float fElapsedTime = 0;
		float fUnitTime = 1.0f / duration;


		while( true )
		{
			fElapsedTime += Time.deltaTime;
			fTime = fElapsedTime * fUnitTime;

			value = ( int )( Mathf.Lerp( preValue, currentValue, fTime ) );

			textObject.text = value.ToString( "n0" );

			if( fTime >= 1.0f )
		    {
				break; 
			}
		
			yield return null;
		}

		textObject.text = currentValue.ToString( "n0" );
	}

    /// <summary>
	/// 스코어 숫자 카운팅 애니메이션. 
	/// textObject = 갱신할 Text오브젝트, 
	/// preValue = 이전 수치, 
	/// currentValue = 현재 수치,
	/// totSec = 애니메이션 시간.
	/// </summary>
	public IEnumerator PlayCountingScoreValue( object[] param )
	{
		UIText textObject = ( UIText )param[ 0 ];
		int preValue = ( int )param[ 1 ];
		int currentValue = ( int )param[ 2 ];
		float duration = ( float )param[ 3 ];

		int value = 0;

		float fTime = 0f;
		float fElapsedTime = 0;
		float fUnitTime = 1.0f / duration;

		while( true )
		{
			fElapsedTime += Time.deltaTime;
			fTime = fElapsedTime * fUnitTime;

			value = ( int )( Mathf.Lerp( preValue, currentValue, fTime ) );

			textObject.text = value.ToString();

			if( fTime >= 1.0f )
		    {
				break; 
			}
		
			yield return null;
		}

		textObject.text = currentValue.ToString();
	}
}
