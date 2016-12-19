using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class PluginImport : MonoBehaviour {
	//Lets make our calls from the Plugin
	[DllImport ("ASimplePlugin")]
	private static extern int PrintANumber();
	
	[DllImport ("ASimplePlugin")]
	private static extern IntPtr PrintHello();
	
	[DllImport ("ASimplePlugin")]
	private static extern int AddTwoIntegers(int i1,int i2);

	[DllImport ("ASimplePlugin")]
	private static extern float AddTwoFloats(float f1,float f2);

    [DllImport("ASimplePlugin")]
    private static extern void GetFloat(ref float a);

    private string text;

	void Start ()
    {
        float val = 0.0f;
        GetFloat(ref val);
        text += PrintANumber() + "\n";
      //  text += Marshal.PtrToStringAuto (PrintHello(), 5) + "\n";
        text += val + "\n";
        text += AddTwoIntegers(2,2) + "\n";
        text += AddTwoFloats(2.5F,4F) + "\n";
    }

    void OnGUI()
    {
        GUILayout.TextArea(text);
    }
}
