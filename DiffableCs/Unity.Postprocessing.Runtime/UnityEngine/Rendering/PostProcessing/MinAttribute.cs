namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class MinAttribute : Attribute
{
	public readonly float min; //Field offset: 0x10

	public MinAttribute(float min) { }

}

