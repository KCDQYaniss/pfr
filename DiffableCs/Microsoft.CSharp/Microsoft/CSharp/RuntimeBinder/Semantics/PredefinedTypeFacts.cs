namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class PredefinedTypeFacts
{
	private sealed class PredefinedTypeInfo
	{
		public readonly string Name; //Field offset: 0x10
		public readonly FUNDTYPE FundType; //Field offset: 0x18
		public readonly Type AssociatedSystemType; //Field offset: 0x20

		internal PredefinedTypeInfo(PredefinedType type, Type associatedSystemType, string name, FUNDTYPE fundType) { }

		internal PredefinedTypeInfo(PredefinedType type, Type associatedSystemType, string name) { }

	}

	private static readonly PredefinedTypeInfo[] s_types; //Field offset: 0x0
	private static readonly Dictionary s_typesByName; //Field offset: 0x8

	private static PredefinedTypeFacts() { }

	private static Dictionary CreatePredefinedTypeFacts() { }

	internal static Type GetAssociatedSystemType(PredefinedType type) { }

	internal static FUNDTYPE GetFundType(PredefinedType type) { }

	internal static string GetNiceName(PredefinedType type) { }

	internal static bool IsNumericType(PredefinedType type) { }

	internal static bool IsSimpleType(PredefinedType type) { }

	public static PredefinedType TryGetPredefTypeIndex(string name) { }

}

