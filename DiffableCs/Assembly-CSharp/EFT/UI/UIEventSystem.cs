namespace EFT.UI;

public class UIEventSystem : MonoBehaviour
{
	[Flags]
	internal enum EInputEnabler
	{
		Notes = 1,
		Console = 2,
	}

	private static UIEventSystem _instance; //Field offset: 0x0
	private EventSystem _eventSystem; //Field offset: 0x20
	private StandaloneInputModule _standaloneInputModule; //Field offset: 0x28
	private EInputEnabler _temporaryEnabler; //Field offset: 0x30
	private bool _isEnabled; //Field offset: 0x34

	private EventSystem EventSystem
	{
		private get { } //Length: 356
	}

	public static UIEventSystem Instance
	{
		 get { } //Length: 525
	}

	private StandaloneInputModule StandaloneInputModule
	{
		private get { } //Length: 356
	}

	public UIEventSystem() { }

	private void Awake() { }

	public void Disable() { }

	public void Enable() { }

	private EventSystem get_EventSystem() { }

	public static UIEventSystem get_Instance() { }

	private StandaloneInputModule get_StandaloneInputModule() { }

	public void SetTemporaryStatus(EInputEnabler enabler, bool enable) { }

	private void UpdateActiveness() { }

}

