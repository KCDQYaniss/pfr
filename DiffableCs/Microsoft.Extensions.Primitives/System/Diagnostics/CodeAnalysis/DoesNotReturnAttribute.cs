namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
internal sealed class DoesNotReturnAttribute : Attribute
{

	public DoesNotReturnAttribute() { }

}

