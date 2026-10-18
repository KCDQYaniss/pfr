namespace EFT.UI.HealthTreatment;

public sealed class HydrationObserver : HealthFactorObserver
{

	public virtual EHealthFactorType FactorType
	{
		 get { } //Length: 6
	}

	protected virtual float HealPrice
	{
		 get { } //Length: 83
	}

	public HydrationObserver() { }

	public virtual void Dispose() { }

	public virtual EHealthFactorType get_FactorType() { }

	protected virtual float get_HealPrice() { }

	protected virtual float GetValueToHeal() { }

	private void HydrationChangeHandler(float delta) { }

	protected virtual void Init() { }

	public virtual void Store(HealthTreatmentData treatmentData, out float cost) { }

}

