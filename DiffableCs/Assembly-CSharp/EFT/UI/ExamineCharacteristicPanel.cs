namespace EFT.UI;

public sealed class ExamineCharacteristicPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ItemController itemController; //Field offset: 0x10
		public ExamineCharacteristicPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private Slider _examineProgressSlider; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _examineLabel; //Field offset: 0x78
	private readonly Color32 _defaultColor; //Field offset: 0x80
	private readonly Color32 _progressColor; //Field offset: 0x84
	private Item _item; //Field offset: 0x88
	private bool _isBeingExamined; //Field offset: 0x90
	private DateTime _examinationStartTime; //Field offset: 0x98
	private float _examinationTime; //Field offset: 0xA0

	public ExamineCharacteristicPanel() { }

	private void OnExaminationHandler(ExamineItemEventArgs examineArgs) { }

	public void Show(Item item, ItemController itemController) { }

	private void Update() { }

}

