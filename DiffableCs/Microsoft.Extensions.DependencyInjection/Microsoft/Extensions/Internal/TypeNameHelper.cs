namespace Microsoft.Extensions.Internal;

internal static class TypeNameHelper
{
	[IsReadOnly]
	private struct DisplayNameOptions
	{
		[CompilerGenerated]
		private readonly bool <FullName>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly bool <IncludeGenericParameters>k__BackingField; //Field offset: 0x1
		[CompilerGenerated]
		private readonly bool <IncludeGenericParameterNames>k__BackingField; //Field offset: 0x2
		[CompilerGenerated]
		private readonly char <NestedTypeDelimiter>k__BackingField; //Field offset: 0x4

		public bool FullName
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public bool IncludeGenericParameterNames
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public bool IncludeGenericParameters
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public char NestedTypeDelimiter
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter) { }

		[CompilerGenerated]
		public bool get_FullName() { }

		[CompilerGenerated]
		public bool get_IncludeGenericParameterNames() { }

		[CompilerGenerated]
		public bool get_IncludeGenericParameters() { }

		[CompilerGenerated]
		public char get_NestedTypeDelimiter() { }

	}

	private static readonly Dictionary _builtInTypeNames; //Field offset: 0x0

	private static TypeNameHelper() { }

	[NullableContext(2)]
	public static string GetTypeDisplayName(object item, bool fullName = true) { }

	[NullableContext(1)]
	public static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = +) { }

	private static void ProcessArrayType(StringBuilder builder, Type type, in DisplayNameOptions options) { }

	private static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, in DisplayNameOptions options) { }

	private static string ProcessType(ref StringBuilder builder, Type type, in DisplayNameOptions options) { }

}

