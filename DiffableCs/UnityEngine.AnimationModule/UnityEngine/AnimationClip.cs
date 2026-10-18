namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion
{

	public bool empty
	{
		[NativeMethod("IsEmpty")]
		 get { } //Length: 78
	}

	[NativeProperty("SampleRate", False, TargetType::Function (0))]
	public float frameRate
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool hasGenericRootTransform
	{
		[NativeMethod("HasGenericRootTransform")]
		 get { } //Length: 78
	}

	public bool hasMotionCurves
	{
		[NativeMethod("HasMotionCurves")]
		 get { } //Length: 78
	}

	public bool hasRootCurves
	{
		[NativeMethod("HasRootCurves")]
		 get { } //Length: 78
	}

	internal bool hasRootMotion
	{
		[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
		internal get { } //Length: 78
	}

	public bool legacy
	{
		[NativeMethod("IsLegacy")]
		 get { } //Length: 78
		[NativeMethod("SetLegacy")]
		 set { } //Length: 93
	}

	[NativeProperty("Length", False, TargetType::Function (0))]
	public float length
	{
		 get { } //Length: 78
	}

	public AnimationClip() { }

	[NativeMethod("IsEmpty")]
	public bool get_empty() { }

	public float get_frameRate() { }

	[NativeMethod("HasGenericRootTransform")]
	public bool get_hasGenericRootTransform() { }

	[NativeMethod("HasMotionCurves")]
	public bool get_hasMotionCurves() { }

	[NativeMethod("HasRootCurves")]
	public bool get_hasRootCurves() { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	internal bool get_hasRootMotion() { }

	[NativeMethod("IsLegacy")]
	public bool get_legacy() { }

	public float get_length() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	public void set_frameRate(float value) { }

	[NativeMethod("SetLegacy")]
	public void set_legacy(bool value) { }

}

