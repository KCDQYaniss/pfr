namespace EFT.UI.HealthTreatment;

public sealed class HealthObserver : HealthFactorObserver
{
	public readonly Dictionary ValuesToHeal; //Field offset: 0x40

	public virtual EHealthFactorType FactorType
	{
		 get { } //Length: 6
	}

	protected virtual float HealPrice
	{
		 get { } //Length: 83
	}

	public HealthObserver() { }

	public virtual void Dispose() { }

	public virtual EHealthFactorType get_FactorType() { }

	protected virtual float get_HealPrice() { }

	protected virtual float GetValueToHeal() { }

	private void HealthChangeHandler(EBodyPart bodyPart, float delta, DamageInfo damageInfo) { }

	protected virtual void Init() { }

	public virtual void Store(HealthTreatmentData treatmentData, out float cost) { }

}

