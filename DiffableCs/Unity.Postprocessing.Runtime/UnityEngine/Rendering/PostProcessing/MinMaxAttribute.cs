namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class MinMaxAttribute : Attribute
{
	public readonly float min; //Field offset: 0x10
	public readonly float max; //Field offset: 0x14

	public MinMaxAttribute(float min, float max) { }

}

