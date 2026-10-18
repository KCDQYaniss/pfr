namespace EFT;

public interface ISpawnDelayModel
{

	public bool CanBeRemoved
	{
		 get { } //Length: 0
	}

	public int Count
	{
		 get { } //Length: 0
	}

	public float CreatedTime
	{
		 get { } //Length: 0
	}

	public BotCreationData Data
	{
		 get { } //Length: 0
	}

	public float LastCheckTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ERemoveDelayReason RemoveReason
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_CanBeRemoved() { }

	public int get_Count() { }

	public float get_CreatedTime() { }

	public BotCreationData get_Data() { }

	public float get_LastCheckTime() { }

	public ERemoveDelayReason get_RemoveReason() { }

	public void OnDelayFinished() { }

	public void set_LastCheckTime(float value) { }

	public void set_RemoveReason(ERemoveDelayReason value) { }

	public string ZoneName() { }

}

