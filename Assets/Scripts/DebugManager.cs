using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LogManager {

    private static LogManager _debugManager = null;

    public static LogManager Instance
    {
        get
        {
            if (_debugManager == null) {
                _debugManager = new LogManager ();
            }

            return _debugManager;
        }
    }

    public void Say(string str)
    {
        Debug.Log(str);
    }
}
