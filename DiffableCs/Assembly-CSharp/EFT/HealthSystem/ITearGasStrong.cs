namespace EFT.HealthSystem;

public interface ITearGasStrong : ITearGas, IHealthEffect, IEffectTriggersUIPanel
{

	public bool TryTriggerCough() { }

}

