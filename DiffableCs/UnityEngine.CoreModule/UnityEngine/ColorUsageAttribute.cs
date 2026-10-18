namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha; //Field offset: 0x18
	public readonly bool hdr; //Field offset: 0x19
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; //Field offset: 0x1C
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; //Field offset: 0x20
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; //Field offset: 0x24
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; //Field offset: 0x28

	public ColorUsageAttribute(bool showAlpha) { }

	public ColorUsageAttribute(bool showAlpha, bool hdr) { }

	[Obsolete("Brightness and exposure parameters are no longer used for anything. Use ColorUsageAttribute(bool showAlpha, bool hdr)")]
	public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

