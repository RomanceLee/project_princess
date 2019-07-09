using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICategoryMenuButton : UIButton
{
	public bool isSelect;

    protected override void Awake()
    {
        base.Awake();
        isSelect = false;
    }
}
