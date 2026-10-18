namespace EFT.UI.Matchmaker;

public sealed class BannerPageToggle : Toggle, IDisposable
{
	[CompilerGenerated]
	private Action OnSelected; //Field offset: 0x128
	[SerializeField]
	private Image _image; //Field offset: 0x130
	[SerializeField]
	private Sprite _onSprite; //Field offset: 0x138
	[SerializeField]
	private Sprite _offSprite; //Field offset: 0x140

	public event Action OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public BannerPageToggle() { }

	[CompilerGenerated]
	public void add_OnSelected(Action value) { }

	public override void Dispose() { }

	public void Init(ToggleGroup toggleGroup) { }

	private void OnValueChangedHandler(bool value) { }

	[CompilerGenerated]
	public void remove_OnSelected(Action value) { }

	public void ResetForPool() { }

	public void SetSprite(bool active) { }

}

