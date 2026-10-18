//Type is in global namespace

[Extension]
public static class ComponentExtensions
{

	[Extension]
	public static void CopyComponentValues(Component target, T source) { }

	[Extension]
	public static bool IsEnabledUniversal(Component component) { }

	[Extension]
	public static bool SetEnabledUniversal(Component component, bool isEnabled) { }

	[Extension]
	public static void SetEnabledUniversal(List components, bool isEnabled) { }

}

