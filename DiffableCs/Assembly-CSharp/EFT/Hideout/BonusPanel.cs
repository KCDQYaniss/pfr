namespace EFT.Hideout;

public sealed class BonusPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BonusPanel <>4__this; //Field offset: 0x10
		public HoverTrigger hoverTrigger; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__2() { }

		internal void <Show>b__3() { }

		internal void <Show>g__HoverEndHandler|1(PointerEventData eventData) { }

		internal void <Show>g__HoverStartHandler|0(PointerEventData eventData) { }

	}

	private const string INACTIVE_ENERGY_BONUS_TEXT = "hideout/bonus_is_inactive_due_to_energy"; //Field offset: 0x0
	private const string INACTIVE_PRODUCTION_BONUS_TEXT = "hideout/bonus_is_inactive_due_to_production_state"; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _effect; //Field offset: 0x80
	private Bonus _bonus; //Field offset: 0x88
	private string _hint; //Field offset: 0x90
	private SimpleTooltip _tooltip; //Field offset: 0x98

	public BonusPanel() { }

	public virtual void Close() { }

	public void Show(Bonus bonus, Sprite sprite) { }

	public void UpdateIcon(Texture2D resultValue) { }

	public void UpdateView(ELightStatus lightStatus, bool activeProduction, ELevelType levelType) { }

}

