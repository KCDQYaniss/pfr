namespace Comfort.Serialization;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
public sealed class LoadMethodAttribute : Attribute
{

	public LoadMethodAttribute() { }

}

