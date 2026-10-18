namespace Sirenix.Serialization;

public class AnimationCurveFormatter : MinimalBaseFormatter
{
	private static readonly Serializer KeyframeSerializer; //Field offset: 0x0
	private static readonly Serializer WrapModeSerializer; //Field offset: 0x8

	private static AnimationCurveFormatter() { }

	public AnimationCurveFormatter() { }

	protected virtual AnimationCurve GetUninitializedObject() { }

	protected virtual void Read(ref AnimationCurve value, IDataReader reader) { }

	protected virtual void Write(ref AnimationCurve value, IDataWriter writer) { }

}

