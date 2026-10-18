namespace AnimationEventSystem;

public interface IAnimatorEventParameter
{

	public bool BoolParam
	{
		 get { } //Length: 0
	}

	public float FloatParam
	{
		 get { } //Length: 0
	}

	public int IntParam
	{
		 get { } //Length: 0
	}

	public EAnimationEventParamType ParamType
	{
		 get { } //Length: 0
	}

	public string StringParam
	{
		 get { } //Length: 0
	}

	public bool get_BoolParam() { }

	public float get_FloatParam() { }

	public int get_IntParam() { }

	public EAnimationEventParamType get_ParamType() { }

	public string get_StringParam() { }

}

