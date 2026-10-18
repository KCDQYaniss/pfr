namespace EFT.Vehicle;

public class BTRDoor : IDisposable
{
	public Quaternion CloseRotation; //Field offset: 0x10
	public Quaternion OpenRotation; //Field offset: 0x20
	public Transform HingeTransform; //Field offset: 0x30
	public HysteresisFilter Filter; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; //Field offset: 0x40

	public bool IsOpen
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BTRDoor() { }

	[CompilerGenerated]
	private void <Init>b__8_0(float x) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_IsOpen() { }

	public void Init() { }

	public void OnEnd(bool onEnabled, bool isOn) { }

	public void Set(bool isOn, bool initial) { }

	[CompilerGenerated]
	public void set_IsOpen(bool value) { }

}

