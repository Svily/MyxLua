using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using XLua.LuaDLL;

public class TestxLua : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
       LuaEnv luaEnv = new LuaEnv();


	    luaEnv.DoString(@"lua.hotfix()");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
