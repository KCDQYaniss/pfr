namespace EFT.UI;

public class InteractableElement : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public bool rawText; //Field offset: 0x10
		public string tooltip; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal string <SetEnabledTooltip>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public bool rawText; //Field offset: 0x10
		public string tooltip; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal string <SetDisabledTooltip>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Func tooltipGetter; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal string <SetEnabledTooltip>b__0() { }

	}

	[SerializeField]
	protected bool _unavailable; //Field offset: 0x70
	private CanvasGroup _canvasGroup; //Field offset: 0x78
	private HoverTooltipArea _tooltipArea; //Field offset: 0x80
	private Func _enabledTooltipGetter; //Field offset: 0x88
	private Func _disabledTooltipGetter; //Field offset: 0x90

	protected CanvasGroup CanvasGroup
	{
		 get { } //Length: 389
	}

	public override bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 173
	}

	private HoverTooltipArea TooltipArea
	{
		private get { } //Length: 405
	}

	public InteractableElement() { }

	protected CanvasGroup get_CanvasGroup() { }

	public override bool get_Interactable() { }

	private HoverTooltipArea get_TooltipArea() { }

	public override void set_Interactable(bool value) { }

	public void SetDisabledTooltip(string tooltip, bool rawText = false) { }

	public void SetDisabledTooltip(Func tooltipGetter) { }

	public void SetEnabledTooltip(string tooltip, bool rawText = false) { }

	public void SetEnabledTooltip(Func tooltipGetter, bool rawText = false) { }

	private void UpdateTooltips() { }

}

