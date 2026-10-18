namespace Coffee.UISoftMaskInternal;

[AttributeUsage(AttributeTargets::Field (256))]
[Conditional("UNITY_EDITOR")]
public sealed class PowerRangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x18
	public readonly float max; //Field offset: 0x1C
	public readonly float power; //Field offset: 0x20

	public PowerRangeAttribute(float min, float max, float power) { }

}

