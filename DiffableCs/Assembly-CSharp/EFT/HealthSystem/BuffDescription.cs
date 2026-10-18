namespace EFT.HealthSystem;

public sealed class BuffDescription : SimpleBuffDescription
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public IStimulatorBuff buff; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal float <.ctor>b__0() { }

	}

	private static readonly Dictionary TimePoints; //Field offset: 0x0
	private readonly Func _wholeTime; //Field offset: 0x18
	private readonly float _duration; //Field offset: 0x20

	public virtual string NameDisplay
	{
		 get { } //Length: 117
	}

	public virtual int TimeLeft
	{
		 get { } //Length: 100
	}

	public virtual string TimeLeftApproximatelyDisplay
	{
		 get { } //Length: 835
	}

	public virtual string TimeLeftDisplay
	{
		 get { } //Length: 257
	}

	private static BuffDescription() { }

	public BuffDescription(string effectName, Func wholeTime, float duration) { }

	public BuffDescription(IStimulatorBuff buff) { }

	public virtual string get_NameDisplay() { }

	public virtual int get_TimeLeft() { }

	public virtual string get_TimeLeftApproximatelyDisplay() { }

	public virtual string get_TimeLeftDisplay() { }

	public virtual string ToString() { }

}

