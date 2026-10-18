namespace EFT.Animations;

public sealed class ValProcessor
{
	private readonly Val _val; //Field offset: 0x10
	public float Intensity; //Field offset: 0x18
	private Spring _target; //Field offset: 0x20
	private int _component; //Field offset: 0x28
	private bool _isHeadBobbing; //Field offset: 0x2C

	private float HeadBobbing
	{
		private get { } //Length: 146
	}

	public ValProcessor(Val val) { }

	private float get_HeadBobbing() { }

	public void Initialize(Spring rootRotation, Spring handsPosition, Spring handsRotation, bool isHeadBobbing = false) { }

	public void Process(float value) { }

	public void ProcessRaw(float value) { }

	public void ProcessZero() { }

}

