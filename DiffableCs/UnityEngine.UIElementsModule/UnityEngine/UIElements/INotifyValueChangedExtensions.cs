namespace UnityEngine.UIElements;

[Extension]
public static class INotifyValueChangedExtensions
{

	[Extension]
	public static bool RegisterValueChangedCallback(INotifyValueChanged control, EventCallback callback) { }

	[Extension]
	public static bool UnregisterValueChangedCallback(INotifyValueChanged control, EventCallback callback) { }

}

