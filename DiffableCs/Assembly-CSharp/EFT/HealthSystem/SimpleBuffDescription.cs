namespace EFT.HealthSystem;

public class SimpleBuffDescription
{
	public string Text; //Field offset: 0x10

	public override string NameDisplay
	{
		 get { } //Length: 5
	}

	public override int TimeLeft
	{
		 get { } //Length: 6
	}

	public override string TimeLeftApproximatelyDisplay
	{
		 get { } //Length: 20
	}

	public override string TimeLeftDisplay
	{
		 get { } //Length: 20
	}

	public SimpleBuffDescription(string effectName) { }

	public override string get_NameDisplay() { }

	public override int get_TimeLeft() { }

	public override string get_TimeLeftApproximatelyDisplay() { }

	public override string get_TimeLeftDisplay() { }

}

