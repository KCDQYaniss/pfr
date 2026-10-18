namespace EFT.UI.Prestige;

[UsedImplicitly]
public class PrestigeConditionCounterView : ConditionProgressView
{
	private readonly BindableEvent _onCounterChanged; //Field offset: 0xC8

	public bool Complete
	{
		 get { } //Length: 8
	}

	protected virtual bool HideValueObjectsWhenEmpty
	{
		 get { } //Length: 3
	}

	public IBindableEvent OnCounterChanged
	{
		 get { } //Length: 8
	}

	public PrestigeConditionCounterView() { }

	public bool get_Complete() { }

	protected virtual bool get_HideValueObjectsWhenEmpty() { }

	public IBindableEvent get_OnCounterChanged() { }

	protected virtual void OnStateUpdated() { }

	public void Show(PrestigeLevel prestige, ConditionProgressChecker progress, Color colorReady, Color colorNotReady) { }

}

