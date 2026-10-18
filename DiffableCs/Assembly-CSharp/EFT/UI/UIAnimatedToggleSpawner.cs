namespace EFT.UI;

public sealed class UIAnimatedToggleSpawner : UISpawner
{
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xA8
	[SerializeField]
	private ToggleGroup _toggleGroup; //Field offset: 0xB0
	[SerializeField]
	private bool _unavailable; //Field offset: 0xB8
	[SerializeField]
	private int _siblingIndex; //Field offset: 0xBC
	private UISpawnableToggle _spawnableToggle; //Field offset: 0xC0

	internal bool IsToggled
	{
		internal get { } //Length: 45
		internal set { } //Length: 102
	}

	public UISpawnableToggle SpawnableToggle
	{
		 get { } //Length: 376
	}

	public UIAnimatedToggleSpawner() { }

	internal bool get_IsToggled() { }

	public UISpawnableToggle get_SpawnableToggle() { }

	internal void set_IsToggled(bool value) { }

	public void SetActive(bool active) { }

	protected virtual void SetEllipsis(bool useEllipsis) { }

	internal virtual void SetHeaderText(string caption, int size) { }

	protected virtual AnimatedToggle SpawnObject() { }

	public void ToggleSilently(bool show) { }

}

