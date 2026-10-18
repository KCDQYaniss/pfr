namespace Comfort.Serialization;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
public sealed class SaveMethodAttribute : Attribute
{

	public SaveMethodAttribute() { }

}

