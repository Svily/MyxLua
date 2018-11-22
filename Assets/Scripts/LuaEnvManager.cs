using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaEnvManager
{
    //单例模式，只存在一个lua虚拟机
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
