namespace EFT.Hideout;

public sealed class MannequinVisualSwitcher : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__8_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <PreparePantsDropdown>b__8_0(CustomizationSuite suite) { }

		internal string <PreparePosesDropdown>b__7_0(CustomizationHideoutMannequinPose pose) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MannequinVisualSwitcher <>4__this; //Field offset: 0x10
		public IReadOnlyList poses; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <PreparePosesDropdown>b__1(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public MannequinVisualSwitcher <>4__this; //Field offset: 0x10
		public IList suites; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <PreparePantsDropdown>b__1(int index) { }

	}

	[SerializeField]
	private TMP_Text _title; //Field offset: 0x70
	[SerializeField]
	private DropDownBox _pantsDropdown; //Field offset: 0x78
	[SerializeField]
	private DropDownBox _poseDropdown; //Field offset: 0x80
	private Action _onPantsChangedEvent; //Field offset: 0x88
	private Action _onPoseChangedEvent; //Field offset: 0x90
	private Item _mannequin; //Field offset: 0x98

	public MannequinVisualSwitcher() { }

	private void PreparePantsDropdown(IList suites, CustomizationSuite currentSuite) { }

	private void PreparePosesDropdown(IReadOnlyList poses, CustomizationHideoutMannequinPose currentPose) { }

	public void Show(Item mannequin, string titleText, Action onPantsChanged, Action onPoseChanged, List suites, CustomizationSuite currentSuite, List poses, CustomizationHideoutMannequinPose currentPose) { }

}

