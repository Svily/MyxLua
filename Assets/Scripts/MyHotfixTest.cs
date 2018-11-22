using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

//热更新入口类
public class MyHotfixTest : MonoBehaviour {

	void Start ()
	{
        //热更新前log函数调用
	    MyLogManager.Instance.Log();
        //启动热更新
	    LuaEnvManager.luaEnv.DoString("require('StartHotfix')");
        //热更新后函数调用
	    MyLogManager.Instance.Log();
    }
	

}
