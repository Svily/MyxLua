using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;


public class LuaEnvManager
{
    private static LuaEnv _luaEnv = null;

    public static LuaEnv luaEnv
    {
        get
        {
            if (_luaEnv == null)
            {
                _luaEnv = new LuaEnv();
            }

            return _luaEnv;
        }
    }

}
