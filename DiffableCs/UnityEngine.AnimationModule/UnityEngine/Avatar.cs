namespace UnityEngine;

[NativeHeader("Modules/Animation/Avatar.h")]
[UsedByNativeCode]
public class Avatar : Object
{

	public HumanDescription humanDescription
	{
		 get { } //Length: 114
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 78
	}

	public bool isValid
	{
		[NativeMethod("IsValid")]
		 get { } //Length: 78
	}

	private Avatar() { }

	public HumanDescription get_humanDescription() { }

	private void get_humanDescription_Injected(out HumanDescription ret) { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	[NativeMethod("IsValid")]
	public bool get_isValid() { }

}

