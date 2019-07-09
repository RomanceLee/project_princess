using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class YieldReturnManager
{
	//Dictionary 의 key 에 의 한 Boxing/UnBoxing 을 피하기 위해 비교 클래스 재정의 
	class IntComparer : IEqualityComparer< int >
    {
		bool IEqualityComparer< int >.Equals( int x, int y )
        {
			return x == y;
		}
		int IEqualityComparer< int >.GetHashCode( int obj )
        {
			return obj.GetHashCode();
		}
	}

	private static Dictionary< int, WaitForSeconds > m_pDicTimeYielder = new Dictionary< int, WaitForSeconds >( new IntComparer() );
	private static WaitForEndOfFrame m_pEndOfFrameYielder = new WaitForEndOfFrame();
	private static WaitForFixedUpdate m_pFixedUpdateYielder = new WaitForFixedUpdate();

	public static WaitForSeconds waitForSeconds( int miliSec )
	{
		WaitForSeconds pYielder = null;

		if( !m_pDicTimeYielder.TryGetValue( miliSec, out pYielder ) )
        {
			pYielder = new WaitForSeconds( miliSec * 0.001f );
			m_pDicTimeYielder.Add( miliSec, pYielder );
		}
		return pYielder;
	}

	public static WaitForEndOfFrame waitForEndOfFrame()
	{
		return m_pEndOfFrameYielder;
	}

	public static WaitForFixedUpdate waitForFixedUpdate()
	{
		return m_pFixedUpdateYielder;
	}
}
