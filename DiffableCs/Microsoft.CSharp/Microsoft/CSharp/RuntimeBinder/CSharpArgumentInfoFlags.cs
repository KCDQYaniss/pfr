namespace Microsoft.CSharp.RuntimeBinder;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Flags]
public enum CSharpArgumentInfoFlags
{
	None = 0,
	UseCompileTimeType = 1,
	Constant = 2,
	NamedArgument = 4,
	IsRef = 8,
	IsOut = 16,
	IsStaticType = 32,
}

