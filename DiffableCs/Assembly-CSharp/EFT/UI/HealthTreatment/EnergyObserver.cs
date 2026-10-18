namespace EFT.UI.HealthTreatment;

public sealed class EnergyObserver : HealthFactorObserver
{

	public virtual EHealthFactorType FactorType
	{
		 get { } //Length: 6
	}

	protected virtual float HealPrice
	{
		 get { } //Length: 83
	}

	public EnergyObserver() { }

	public virtual void Dispose() { }

	private void EnergyChangeHandler(float delta) { }

	public virtual EHealthFactorType get_FactorType() { }

	protected virtual float get_HealPrice() { }

	protected virtual float GetValueToHeal() { }

	protected virtual void Init() { }

	public virtual void Store(HealthTreatmentData treatmentData, out float cost) { }

}

