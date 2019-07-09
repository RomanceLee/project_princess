using UnityEngine;
using System.Collections;

namespace TouchEffectSystem 
{
	public class UITouchObject : MonoBehaviour
    {
		protected float m_fDuration;
		protected SignalCallBack m_pSignalCallBack;

		void OnEnable()
		{
			StopCoroutine( "CoActivate" );
			StartCoroutine( "CoActivate" );
		}

		public void Activate( float duration, SignalCallBack callBack )
		{
			m_fDuration = duration;
			m_pSignalCallBack = callBack;
		}

		protected IEnumerator CoActivate()
		{
			yield return new WaitForSeconds( m_fDuration );
			if( m_pSignalCallBack != null )
            {
				m_pSignalCallBack ( this );
			}
		}
	}
}
