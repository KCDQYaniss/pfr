namespace EFT;

public sealed class AudioSequence : ScriptableObject
{
	internal struct SequenceSettings
	{
		public double StartTime; //Field offset: 0x0
		public double LoopLength; //Field offset: 0x8
		public double SkipTime; //Field offset: 0x10
		public double JumpTime; //Field offset: 0x18
		public double InitialLength; //Field offset: 0x20
		public double LoopStartTime; //Field offset: 0x28
		public float Delay; //Field offset: 0x30

		public SequenceSettings(double startTime = 0, double loopStartTime = 0, double initialLength = 0, double loopLength = 0, double skipTime = -1, double jumpTime = -1) { }

	}

	public AudioClip SequenceClip; //Field offset: 0x18
	public double OnTime; //Field offset: 0x20
	public double WorkingTime; //Field offset: 0x28
	public double OffTime; //Field offset: 0x30
	public double DisabledTime; //Field offset: 0x38
	public double OverlapTime; //Field offset: 0x40
	[HideInInspector]
	public AudioClip OnSource; //Field offset: 0x48
	[HideInInspector]
	public AudioClip WorkingSource; //Field offset: 0x50
	[HideInInspector]
	public AudioClip OffSource; //Field offset: 0x58
	[HideInInspector]
	public AudioClip DisabledSource; //Field offset: 0x60

	public AudioSequence() { }

	public SequenceSettings GetSequenceSettings(EAudioSequenceType sequenceType) { }

}

