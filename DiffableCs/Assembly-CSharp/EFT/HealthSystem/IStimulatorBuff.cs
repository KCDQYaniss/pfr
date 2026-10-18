namespace EFT.HealthSystem;

public interface IStimulatorBuff : IStimulatorDebuff
{

	public bool Active
	{
		 get { } //Length: 0
	}

	public EBodyPart BodyPart
	{
		 get { } //Length: 0
	}

	public string BuffName
	{
		 get { } //Length: 0
	}

	public Type BuffType
	{
		 get { } //Length: 0
	}

	public StimulatorBuffSettings Settings
	{
		 get { } //Length: 0
	}

	public float Value
	{
		 get { } //Length: 0
	}

	public float WholeTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_Active() { }

	public EBodyPart get_BodyPart() { }

	public string get_BuffName() { }

	public Type get_BuffType() { }

	public StimulatorBuffSettings get_Settings() { }

	public float get_Value() { }

	public float get_WholeTime() { }

	public void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skills) { }

	public void set_WholeTime(float value) { }

}

