namespace System.Reflection;

[Extension]
public static class RuntimeReflectionExtensions
{

	[Extension]
	public static MethodInfo GetRuntimeBaseDefinition(MethodInfo method) { }

	[Extension]
	public static IEnumerable GetRuntimeMethods(Type type) { }

	[Extension]
	public static IEnumerable GetRuntimeProperties(Type type) { }

}

