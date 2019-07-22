using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusCharacterStatUI : UICommon
{
    public List< StatusCharacterStatSlot > characterStatSlotList;

    public void SetCharacterStatSlotLists()
    {
        for( int i = 0; i < characterStatSlotList.Count; i++ )
        {
            characterStatSlotList[ i ].SetStatNameText( "stat_" + i.ToString() );
            characterStatSlotList[ i ].SetStatProgressImage( i, 10 );
        }
    }
}
