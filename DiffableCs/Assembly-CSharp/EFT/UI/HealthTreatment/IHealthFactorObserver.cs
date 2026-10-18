namespace EFT.UI.HealthTreatment;

public interface IHealthFactorObserver : IHealthObserver, IDisposable
{

	public float ValueToHeal
	{
		 get { } //Length: 0
	}

	public IHealthFactorObserver Clone(Profile profile, OfflineHealthController healthController, TraderInfo traderInfo) { }

	public float get_ValueToHeal() { }

}

