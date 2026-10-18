namespace EFT.UI;

public sealed class UpdatableToggle : Toggle, IValueUpdatable
{
	private Action _onValueChanged; //Field offset: 0x128

	public UpdatableToggle() { }

	[CompilerGenerated]
	private void <Awake>b__1_0(bool arg) { }

	protected virtual void Awake() { }

	public override void Bind(Action valueChanged) { }

	public override bool CurrentValue() { }

	public override void UpdateValue(bool value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

}

