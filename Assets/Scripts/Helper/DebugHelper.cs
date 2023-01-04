using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugHelper : MonoBehaviour {
	private static DebugHelper _instance;
    public bool activeLog = false;
    
    private static bool _isInit = false;
	void Awake()
	{
		DebugHelper._instance = this;
		DebugHelper._isInit = true;
	}

    public static void log(string text) {
        if (DebugHelper._isInit && DebugHelper._instance.activeLog) {
			Debug.Log("[Mahjong] ####### : " + text);
		}
    }
}