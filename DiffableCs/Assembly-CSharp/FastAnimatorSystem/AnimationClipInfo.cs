namespace FastAnimatorSystem;

public sealed class AnimationClipInfo : AbstractMotion
{
	public readonly bool IsLooping; //Field offset: 0x20
	public readonly int ClipInstanceId; //Field offset: 0x24

	public virtual bool IsLooped
	{
		 get { } //Length: 5
	}

	private AnimationClipInfo(float duration, string name, bool isLooping, int clipInstanceId) { }

	public static AnimationClipInfo Create(AnimationClip animClip) { }

	public static AnimationClipInfo Create(float duration, string name, bool isLooping, int instanceId) { }

	public virtual bool get_IsLooped() { }

	public virtual string ToString() { }

}

