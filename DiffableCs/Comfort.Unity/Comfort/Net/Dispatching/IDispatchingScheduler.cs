namespace Comfort.Net.Dispatching;

public interface IDispatchingScheduler
{

	public Action PingAction
	{
		 set { } //Length: 0
	}

	public Action ReceiveAction
	{
		 set { } //Length: 0
	}

	public void Execute(Action action) { }

	public void ExecuteOnSchedule(Action action) { }

	public ulong GetFrameIndex() { }

	public void ScheduleExecution(Action action) { }

	public void set_PingAction(Action value) { }

	public void set_ReceiveAction(Action value) { }

	public void TryReceive() { }

}

