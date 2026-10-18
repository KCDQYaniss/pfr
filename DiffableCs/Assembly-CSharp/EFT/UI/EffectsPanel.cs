namespace EFT.UI;

public sealed class EffectsPanel : UIElement
{
	[CompilerGenerated]
	private struct <>c__DisplayClass11_0
	{
		public EffectsPanel <>4__this; //Field offset: 0x0
		public List resultList; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public SimpleTooltip tooltip; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__0(EffectDescription effect, EffectIcon view) { }

	}

	[SerializeField]
	private EffectIcon _effectIconTemplate; //Field offset: 0x70
	private EBodyPart _bodyPart; //Field offset: 0x78
	private IHealthController _healthController; //Field offset: 0x80
	private BindableList _bindableActiveEffects; //Field offset: 0x88
	private Dictionary _icons; //Field offset: 0x90
	private bool _updateRequired; //Field offset: 0x98
	private bool _isAnyMaybeFiltered; //Field offset: 0x99
	private IEnumerable _effectsFilterList; //Field offset: 0xA0

	public EffectsPanel() { }

	[CompilerGenerated]
	private void <UpdateEffects>g__AppendEffects|11_0(IEnumerable effects, ref <>c__DisplayClass11_0 unnamed_param_1) { }

	[CompilerGenerated]
	private bool <UpdateEffects>g__IsEffectAllowed|11_1(Type effect, ref <>c__DisplayClass11_0 unnamed_param_1) { }

	private void CleanUp() { }

	private void EffectRemovedHandler(IHealthEffect effect) { }

	private void EffectResiduedHandler(IHealthEffect effect) { }

	private void EffectStartedHandler(IHealthEffect effect) { }

	private void EffectUpdatedHandler(IHealthEffect effect) { }

	private static EffectDescription FindDescription(List resultList, Type type) { }

	public void SetEffectsFilter(IEnumerable effectsFilter) { }

	public void Show(IHealthController healthController, EBodyPart bodyPart, SimpleTooltip tooltip) { }

	private void StimulatorBuffEventHandler(IStimulatorBuff buff) { }

	private void Update() { }

	private void UpdateEffects() { }

}

