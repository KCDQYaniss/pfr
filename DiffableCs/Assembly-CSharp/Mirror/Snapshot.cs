namespace Mirror;

public interface Snapshot
{

	public double localTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public double remoteTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public double get_localTime() { }

	public double get_remoteTime() { }

	public void set_localTime(double value) { }

	public void set_remoteTime(double value) { }

}

