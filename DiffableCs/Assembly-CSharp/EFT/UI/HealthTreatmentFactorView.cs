namespace EFT.UI;

public sealed class HealthTreatmentFactorView : HealthTreatmentView
{
	internal struct HealthFactorSettings
	{
		[SerializeField]
		public Color Color; //Field offset: 0x0
		[SerializeField]
		public Sprite Icon; //Field offset: 0x10

	}

	[SerializeField]
	private TextMeshProUGUI _valueToHealField; //Field offset: 0xB0
	[SerializeField]
	private Image _icon; //Field offset: 0xB8
	[SerializeField]
	private Dictionary _healthFactorsSettings; //Field offset: 0xC0
	private IHealthFactorObserver _healthObserver; //Field offset: 0xC8

	public HealthTreatmentFactorView() { }

	public void Show(IHealthFactorObserver observer) { }

	private void UpdateFactor() { }

}

