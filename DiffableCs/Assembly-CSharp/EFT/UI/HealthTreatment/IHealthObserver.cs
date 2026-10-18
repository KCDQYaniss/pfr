namespace EFT.UI.HealthTreatment;

public interface IHealthObserver : IDisposable
{

	public bool Active
	{
		 get { } //Length: 0
	}

	public EHealthFactorType FactorType
	{
		 get { } //Length: 0
	}

	public float TreatmentCost
	{
		 get { } //Length: 0
	}

	public string TreatmentName
	{
		 get { } //Length: 0
	}

	public void ApplyTreatment() { }

	public bool get_Active() { }

	public EHealthFactorType get_FactorType() { }

	public float get_TreatmentCost() { }

	public string get_TreatmentName() { }

	public void Store(HealthTreatmentData treatmentData, out float cost) { }

	public Action Subscribe(Action handler) { }

	public void Unsubscribe(Action handler) { }

}

