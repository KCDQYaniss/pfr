namespace EFT.UI;

public sealed class HealthTreatmentEffectView : HealthTreatmentView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public SimpleTooltip tooltip; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <Show>b__0(EffectDescription effect, EffectIcon view) { }

	}

	[SerializeField]
	private RectTransform _effectViewsContainer; //Field offset: 0xB0
	[SerializeField]
	private EffectIcon _effectIconTemplate; //Field offset: 0xB8
	private HealthEffectObserver _effectObserver; //Field offset: 0xC0
	private BindableList _bindableActiveEffects; //Field offset: 0xC8

	public HealthTreatmentEffectView() { }

	private void OnEffectChanged() { }

	public void Show(HealthEffectObserver effectObserver) { }

}

