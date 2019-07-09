using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationManager
{
    /// <summary>
    /// Text 오브젝트 알파 애니메이션 - 값 증가
    /// </summary>
	public static IEnumerator AppearTextAlphaAnimation( Text _textObject, float _startAlphaValue, float _targetAlphaValue, float _addAlphaValue, int _waitValue )
    {
        float alphaValue = _startAlphaValue;
        Color textColor = new Color( _textObject.color.r, _textObject.color.g, _textObject.color.b, alphaValue );

        while( _textObject.color.a < _targetAlphaValue )
        {
            alphaValue += _addAlphaValue;
            textColor.a = alphaValue;
            _textObject.color = textColor;
            yield return YieldReturnManager.waitForSeconds( _waitValue );
        }
    }

    /// <summary>
    /// Text 오브젝트 알파 애니메이션 - 값 감소
    /// </summary>
    public static IEnumerator DisappearTextAlphaAnimation( Text _textObject, float _startAlphaValue, float _targetAlphaValue, float _addAlphaValue, int _waitValue )
    {
        float alphaValue = _startAlphaValue;
        Color textColor = new Color( _textObject.color.r, _textObject.color.g, _textObject.color.b, alphaValue );

        while( _targetAlphaValue < _textObject.color.a )
        {
            alphaValue -= _addAlphaValue;
            textColor.a = alphaValue;
            _textObject.color = textColor;
            yield return YieldReturnManager.waitForSeconds( _waitValue );
        }
    }

    /// <summary>
    /// Image 오브젝트 알파 애니메이션 - 값 증가
    /// </summary>
	public static IEnumerator AppearImageAlphaAnimation( Image _imageObject, float _startAlphaValue, float _targetAlphaValue, float _addAlphaValue, int _waitValue )
    {
        float alphaValue = _startAlphaValue;
        Color imageColor = new Color( _imageObject.color.r, _imageObject.color.g, _imageObject.color.b, alphaValue );

        while( _imageObject.color.a < _targetAlphaValue )
        {
            alphaValue += _addAlphaValue;
            imageColor.a = alphaValue;
            _imageObject.color = imageColor;
            yield return YieldReturnManager.waitForSeconds( _waitValue );
        }
    }

    /// <summary>
    /// Image 오브젝트 알파 애니메이션 - 값 감소
    /// </summary>
    public static IEnumerator DisappearImageAlphaAnimation( Image _imageObject, float _startAlphaValue, float _targetAlphaValue, float _addAlphaValue, int _waitValue )
    {
        float alphaValue = _startAlphaValue;
        Color imageColor = new Color( _imageObject.color.r, _imageObject.color.g, _imageObject.color.b, alphaValue );

        while( _targetAlphaValue < _imageObject.color.a )
        {
            alphaValue -= _addAlphaValue;
            imageColor.a = alphaValue;
            _imageObject.color = imageColor;
            yield return YieldReturnManager.waitForSeconds( _waitValue );
        }
    }

    /// <summary>
    /// spriteName은 'mainlobby_achievement_' 형태로 입력.
    /// </summary>
    public static IEnumerator PlaySpriteAnimation( Image _imageObject, string _folderName, string _atlasName, string _spriteName, int _spriteCount, float _animationTime, bool _isLoop = true )
    {
        string resName;
        //밀리세컨드로 변환.
        int time = ( int )( _animationTime*1000 );
        
        if( _isLoop == true )
        {
            while( _isLoop )
            {
                for( int i = 0; i < _spriteCount; i++ )
                {
                    resName = "";
                    resName = Utils.CreateStringBuilderStr( new string[]{ _spriteName, i.ToString() } );
                    _imageObject.sprite = Utils.LoadUIImageResourceFromAtlas( _folderName, _atlasName, resName );
                    _imageObject.SetNativeSize();
                    yield return YieldReturnManager.waitForSeconds( time/_spriteCount );
                }
            }
        }
        else
        {
            for( int i = 0; i < _spriteCount; i++ )
            {
                resName = "";
                resName = Utils.CreateStringBuilderStr( new string[]{ _spriteName, i.ToString() } );
                _imageObject.sprite = Utils.LoadUIImageResourceFromAtlas( _folderName, _atlasName, resName );
                _imageObject.SetNativeSize();
                yield return YieldReturnManager.waitForSeconds( time/_spriteCount );
            }
        }
    }

    /// <summary>
    /// 우측 이동 애니메이션
    /// </summary>
    public static IEnumerator MoveRightAnimation( RectTransform _rectTransform, float _startPosX, float _targetPosX, float _addValue, bool _isLooping = false )
    {
        float targetPosX = _targetPosX;
        Vector2 moveVec = new Vector2( _startPosX, _rectTransform.anchoredPosition.y );

        if( _isLooping == true )
        {
            while( _isLooping )
            {
                if( _rectTransform.anchoredPosition.x < targetPosX )
                {
                    moveVec.x += _addValue*Time.deltaTime;
                }
                else
                {
                    moveVec.x = _startPosX;
                }

                _rectTransform.anchoredPosition = moveVec;
                yield return null;
            }
        }
        else
        {
            while( _rectTransform.anchoredPosition.x < targetPosX )
            {
                moveVec.x += _addValue*Time.deltaTime;
                _rectTransform.anchoredPosition = moveVec;
                yield return null;
            }
        }
    }

    /// <summary>
    /// 좌측 이동 애니메이션
    /// </summary>
    public static IEnumerator MoveLeftAnimation( RectTransform _rectTransform, float _startPosX, float _targetPosX, float _addValue, bool _isLooping = false )
    {
        float targetPosX = _targetPosX;
        Vector2 moveVec = new Vector2( _startPosX, _rectTransform.anchoredPosition.y );

        if( _isLooping == true )
        {
            while( _isLooping )
            {
                if( targetPosX < _rectTransform.anchoredPosition.x )
                {
                    moveVec.x -= _addValue*Time.deltaTime;
                }
                else
                {
                    moveVec.x = _startPosX;
                }

                _rectTransform.anchoredPosition = moveVec;
                yield return null;
            }
        }
        else
        {
            while( targetPosX < _rectTransform.anchoredPosition.x )
            {
                moveVec.x -= _addValue*Time.deltaTime;
                _rectTransform.anchoredPosition = moveVec;
                yield return null;
            }
        }
    }

    /// <summary>
    /// 위 이동 애니메이션
    /// </summary>
    public static IEnumerator MoveUpAnimation( RectTransform _rectTransform, float _startPosY, float _targetPosY, float _addValue )
    {
        float targetPosY = _targetPosY;
        Vector2 moveVec = new Vector2( _rectTransform.anchoredPosition.x, _startPosY );
        while( _rectTransform.anchoredPosition.y < targetPosY )
        {
            moveVec.y += _addValue * Time.deltaTime;
            _rectTransform.anchoredPosition = moveVec;
            yield return null;
        }
    }

    /// <summary>
    /// 아래 이동 애니메이션
    /// </summary>
    public static IEnumerator MoveDownAnimation( RectTransform _rectTransform, float _startPosY, float _targetPosY, float _addValue )
    {
        float targetPosY = _targetPosY;
        Vector2 moveVec = new Vector2( _rectTransform.anchoredPosition.x, _startPosY );
        while( targetPosY < _rectTransform.anchoredPosition.y )
        {
            moveVec.y -= _addValue * Time.deltaTime;
            _rectTransform.anchoredPosition = moveVec;
            yield return null;
        }
    }
}
