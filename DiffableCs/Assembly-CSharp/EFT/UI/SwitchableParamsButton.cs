namespace EFT.UI;

public class SwitchableParamsButton : Button
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public SwitchableParamsButton <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <AddSubscription>b__0() { }

		internal void <AddSubscription>b__1() { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x108
	[SerializeField]
	private Sprite _onSprite; //Field offset: 0x110
	[SerializeField]
	private Sprite _offSprite; //Field offset: 0x118
	[SerializeField]
	private CustomTextMeshProUGUI _label; //Field offset: 0x120
	[SerializeField]
	private string _onText; //Field offset: 0x128
	[SerializeField]
	private string _offText; //Field offset: 0x130
	[SerializeField]
	private bool _toUpper; //Field offset: 0x138
	private bool _isActive; //Field offset: 0x139

	public SwitchableParamsButton() { }

	public void AddSubscription(Action callback) { }

	public void AddSubscription(Action callback, bool isOn) { }

	private void ChangeState(bool isOn) { }

}

