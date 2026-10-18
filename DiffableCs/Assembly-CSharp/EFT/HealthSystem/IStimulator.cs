namespace EFT.HealthSystem;

public interface IStimulator : IHealthEffect, IInitializable, IDesirable, IStackableFromDifferentTemplates
{

	public IStimulatorBuff[] ActiveBuffs
	{
		 get { } //Length: 0
	}

	public IStimulatorBuff[] get_ActiveBuffs() { }

}

