using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class MyHotfixTest : MonoBehaviour {


	void Start ()
	{
        MyTestClass myTestClass = new MyTestClass();

        Debug.Log(myTestClass.HelloHotfix());

	    LuaEnvManager.luaEnv.DoString(@"xlua.hotfix(CS.MyTestClass, 'HelloHotfix', function(self) return '热更新后' end)");

	    Debug.Log (myTestClass.HelloHotfix ());

    }
	

}
