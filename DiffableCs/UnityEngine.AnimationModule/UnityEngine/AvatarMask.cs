namespace UnityEngine;

[MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[NativeHeader("Modules/Animation/AvatarMask.h")]
[UsedByNativeCode]
public sealed class AvatarMask : Object
{

	public int transformCount
	{
		 get { } //Length: 78
	}

	public int get_transformCount() { }

	[NativeMethod("GetBodyPart")]
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	public bool GetTransformActive(int index) { }

	public string GetTransformPath(int index) { }

	private float GetTransformWeight(int index) { }

}

