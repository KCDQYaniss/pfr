namespace AnimationEventSystem;

public sealed class AnimationEventParameter : ICloneable, IAnimatorEventParameter
{
	public bool BoolParam; //Field offset: 0x10
	public float FloatParam; //Field offset: 0x14
	public int IntParam; //Field offset: 0x18
	public string StringParam; //Field offset: 0x20
	public EAnimationEventParamType ParamType; //Field offset: 0x28

	private override bool AnimationEventSystem.IAnimatorEventParameter.BoolParam
	{
		private get { } //Length: 5
	}

	private override float AnimationEventSystem.IAnimatorEventParameter.FloatParam
	{
		private get { } //Length: 6
	}

	private override int AnimationEventSystem.IAnimatorEventParameter.IntParam
	{
		private get { } //Length: 4
	}

	private override EAnimationEventParamType AnimationEventSystem.IAnimatorEventParameter.ParamType
	{
		private get { } //Length: 4
	}

	private override string AnimationEventSystem.IAnimatorEventParameter.StringParam
	{
		private get { } //Length: 5
	}

	public AnimationEventParameter() { }

	private override bool AnimationEventSystem.IAnimatorEventParameter.get_BoolParam() { }

	private override float AnimationEventSystem.IAnimatorEventParameter.get_FloatParam() { }

	private override int AnimationEventSystem.IAnimatorEventParameter.get_IntParam() { }

	private override EAnimationEventParamType AnimationEventSystem.IAnimatorEventParameter.get_ParamType() { }

	private override string AnimationEventSystem.IAnimatorEventParameter.get_StringParam() { }

	public override object Clone() { }

	public void Deserialize(BinaryReader reader) { }

	public virtual bool Equals(object obj) { }

	protected bool Equals(AnimationEventParameter other) { }

	public virtual int GetHashCode() { }

	public object GetParameter() { }

	public string GetSelectedParameterFieldName() { }

	public void Serialize(BinaryWriter writer) { }

	public virtual string ToString() { }

}

