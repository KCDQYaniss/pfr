namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimationState.h")]
[UsedByNativeCode]
public sealed class AnimationState : TrackedReference
{

	public AnimationClip clip
	{
		 get { } //Length: 78
	}

	public bool enabled
	{
		 get { } //Length: 78
	}

	public int layer
	{
		 set { } //Length: 91
	}

	public float length
	{
		 get { } //Length: 78
	}

	public string name
	{
		 get { } //Length: 78
	}

	public float normalizedTime
	{
		 set { } //Length: 94
	}

	public float speed
	{
		 set { } //Length: 94
	}

	public float time
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public WrapMode wrapMode
	{
		 set { } //Length: 91
	}

	public AnimationState() { }

	public AnimationClip get_clip() { }

	public bool get_enabled() { }

	public float get_length() { }

	public string get_name() { }

	public float get_time() { }

	public void set_layer(int value) { }

	public void set_normalizedTime(float value) { }

	public void set_speed(float value) { }

	public void set_time(float value) { }

	public void set_wrapMode(WrapMode value) { }

}

