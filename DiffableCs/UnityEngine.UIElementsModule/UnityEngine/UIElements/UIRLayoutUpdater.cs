namespace UnityEngine.UIElements;

internal class UIRLayoutUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private List changeEventsList; //Field offset: 0x20

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 84
	}

	private static UIRLayoutUpdater() { }

	public UIRLayoutUpdater() { }

	private void DispatchChangeEvents(List changeEvents, int currentLayoutPass) { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public virtual void Update() { }

	private void UpdateSubTree(VisualElement ve, bool isDisplayed, List changeEvents) { }

}

