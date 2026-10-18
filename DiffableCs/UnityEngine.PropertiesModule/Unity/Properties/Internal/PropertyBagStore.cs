namespace Unity.Properties.Internal;

internal static class PropertyBagStore
{
	public struct TypedStore`1
	{
		public static IPropertyBag PropertyBag; //Field offset: 0x0

	}

	private static readonly ConcurrentDictionary s_PropertyBags; //Field offset: 0x0
	private static readonly List s_RegisteredTypes; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action NewTypeRegistered; //Field offset: 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; //Field offset: 0x18

	private static PropertyBagStore() { }

	internal static void AddPropertyBag(IPropertyBag propertyBag) { }

	internal static IPropertyBag GetPropertyBag() { }

	internal static IPropertyBag GetPropertyBag(Type type) { }

}

