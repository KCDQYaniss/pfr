namespace EFT.HealthSystem;

public interface IHealthEffect
{

	public bool Active
	{
		 get { } //Length: 0
	}

	public EBodyPart BodyPart
	{
		 get { } //Length: 0
	}

	public bool Critical
	{
		 get { } //Length: 0
	}

	public float CurrentStrength
	{
		 get { } //Length: 0
	}

	public float CurStateTimeLeft
	{
		 get { } //Length: 0
	}

	public EffectDescription[] DisplayableVariations
	{
		 get { } //Length: 0
	}

	public bool Existing
	{
		 get { } //Length: 0
	}

	public float OverallDuration
	{
		 get { } //Length: 0
	}

	public bool Residual
	{
		 get { } //Length: 0
	}

	public EEffectState State
	{
		 get { } //Length: 0
	}

	public float Strength
	{
		 get { } //Length: 0
	}

	public float TimeLeft
	{
		 get { } //Length: 0
	}

	public Type Type
	{
		 get { } //Length: 0
	}

	public bool WasPaused
	{
		 get { } //Length: 0
	}

	public float WholeTime
	{
		 get { } //Length: 0
	}

	public float WorkStateTime
	{
		 get { } //Length: 0
	}

	public void AddWholeTime(float deltaTime) { }

	public bool get_Active() { }

	public EBodyPart get_BodyPart() { }

	public bool get_Critical() { }

	public float get_CurrentStrength() { }

	public float get_CurStateTimeLeft() { }

	public EffectDescription[] get_DisplayableVariations() { }

	public bool get_Existing() { }

	public float get_OverallDuration() { }

	public bool get_Residual() { }

	public EEffectState get_State() { }

	public float get_Strength() { }

	public float get_TimeLeft() { }

	public Type get_Type() { }

	public bool get_WasPaused() { }

	public float get_WholeTime() { }

	public float get_WorkStateTime() { }

	public void Propagate() { }

}

