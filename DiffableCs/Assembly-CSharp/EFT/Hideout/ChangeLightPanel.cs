namespace EFT.Hideout;

public sealed class ChangeLightPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public ELightingLevel level; //Field offset: 0x10
		public ComplementaryButton button; //Field offset: 0x18
		public ChangeLightPanel <>4__this; //Field offset: 0x20

		public <>c__DisplayClass17_0() { }

		internal void <Show>b__0(bool arg) { }

		internal string <Show>b__1() { }

	}

	private const string DISABLE_LIGHT_BUTTON = "hideout/Disable all light"; //Field offset: 0x0
	private const string CANDLES_BUTTON = "hideout/Enable candles"; //Field offset: 0x0
	private const string LIGHT_BULBS_BUTTON = "hideout/Enable light bulbs"; //Field offset: 0x0
	private const string GAS_LAMPS_BUTTON = "hideout/Enable gas lamps"; //Field offset: 0x0
	private const string CHRISTMAS_LIGHTS = "hideout/Enable christmas lights"; //Field offset: 0x0
	private const string HALLOWEEN_LIGHTS = "hideout/Enable halloween lights"; //Field offset: 0x0
	private const string LIGHT_NOT_UNLOCKED = "This light level has not been unlocked yet"; //Field offset: 0x0
	[SerializeField]
	private Dictionary _lightButtons; //Field offset: 0x70
	[SerializeField]
	private Dictionary _sounds; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnButtonSelected; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnLightningSelected; //Field offset: 0x88
	private HashSet _availableButtons; //Field offset: 0x90
	private ELightingLevel _selectedLevel; //Field offset: 0x98

	public event Action OnButtonSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnLightningSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public ChangeLightPanel() { }

	[CompilerGenerated]
	public void add_OnButtonSelected(Action value) { }

	[CompilerGenerated]
	public void add_OnLightningSelected(Action value) { }

	public void AddLightingLevel(ELightingLevel level, bool switchToNewLevel) { }

	public void ClearLightLevels() { }

	private string GetMessage(ELightingLevel level, ComplementaryButton button) { }

	public void Hide() { }

	private void LightLevelSelected(ELightingLevel level) { }

	[CompilerGenerated]
	public void remove_OnButtonSelected(Action value) { }

	[CompilerGenerated]
	public void remove_OnLightningSelected(Action value) { }

	public void SetCurrentLightingLevel(ELightingLevel level) { }

	public void Show() { }

}

