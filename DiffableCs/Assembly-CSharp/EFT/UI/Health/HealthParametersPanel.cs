namespace EFT.UI.Health;

public class HealthParametersPanel : UIElement
{
	private const float UPDATE_INTERVAL = 1; //Field offset: 0x0
	[SerializeField]
	private BuffableHealthParameterPanel _overallHealth; //Field offset: 0x70
	[SerializeField]
	private HealthParameterPanel _poisoning; //Field offset: 0x78
	[SerializeField]
	private HealthParameterPanel _radiation; //Field offset: 0x80
	[SerializeField]
	private HealthParameterPanel _bloodPressure; //Field offset: 0x88
	[SerializeField]
	private BuffableHealthParameterPanel _energy; //Field offset: 0x90
	[SerializeField]
	private BuffableHealthParameterPanel _hydration; //Field offset: 0x98
	[SerializeField]
	private BuffableHealthParameterPanel _temperature; //Field offset: 0xA0
	[SerializeField]
	private HealthParameterPanel _weight; //Field offset: 0xA8
	private IBaseHealthController _baseHealth; //Field offset: 0xB0
	[CanBeNull]
	private IHealthController _health; //Field offset: 0xB8
	private Inventory _inventory; //Field offset: 0xC0
	private SkillManager _skills; //Field offset: 0xC8
	private DateTime _lastUpdateTime; //Field offset: 0xD0

	public HealthParametersPanel() { }

	[CompilerGenerated]
	private void <Show>b__14_2() { }

	[CompilerGenerated]
	private void <Show>b__14_3() { }

	[CompilerGenerated]
	private void <Show>g__HealthEffectChangeHandler|14_1(IHealthEffect effect) { }

	[CompilerGenerated]
	private void <Show>g__WeightUpdateHandler|14_0() { }

	private float GetEnergyRate() { }

	private float GetHydrationRate() { }

	public void Show(IBaseHealthController baseHealthController, Inventory inventory, SkillManager skills) { }

	public void ShowSecondaryParameters(bool value) { }

	private void Update() { }

	private void UpdateMainHealthAndStats() { }

}

