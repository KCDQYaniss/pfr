namespace UnityEngine.UIElements;

internal class UxmlObjectFactoryRegistry
{
	private static Dictionary s_Factories; //Field offset: 0x0

	internal static Dictionary factories
	{
		internal get { } //Length: 277
	}

	internal static Dictionary get_factories() { }

	private static void RegisterEngineFactories() { }

	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	private static void RegisterUserFactories() { }

	internal static bool TryGetFactories(string fullTypeName, out List factoryList) { }

}

