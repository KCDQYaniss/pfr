namespace Microsoft.CSharp.RuntimeBinder.Syntax;

internal static class NameManager
{
	private static readonly Name[] s_predefinedNames; //Field offset: 0x0
	private static readonly NameTable s_names; //Field offset: 0x8

	private static NameManager() { }

	internal static Name Add(string key) { }

	internal static Name Add(string key, int length) { }

	private static NameTable GetKnownNames() { }

	internal static Name GetPredefinedName(PredefinedName id) { }

}

