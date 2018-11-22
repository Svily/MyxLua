using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

[Hotfix()]
public class MyLogManager
{

    private static MyLogManager _myLogManager = null;

    public static MyLogManager Instance
    {
        get
        {
            if (_myLogManager == null)
            {
                _myLogManager = new MyLogManager();
            }

            return _myLogManager;
        }

        
    }

    public void Log()
    {
        string str = "热更新前:Hello XLua!";

        Debug.Log(str);
    }
}
