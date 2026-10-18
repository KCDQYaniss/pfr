namespace EFT.Hideout;

public class RailCameraMover : ICameraMover, IDisposable
{
	private readonly RailCameraMoveSettings _moveSettings; //Field offset: 0x10
	private float _normalizedTime; //Field offset: 0x18
	private readonly float _absStep; //Field offset: 0x1C
	private bool _edgePanSuppressed; //Field offset: 0x20

	private string ClipName
	{
		private get { } //Length: 113
	}

	public RailCameraMover(RailCameraMoveSettings moveSettings) { }

	public override void Dispose() { }

	private string get_ClipName() { }

	public override void Move(Vector3 direction) { }

	public override void MoveAccordingMousePosition() { }

	private void MoveAside(Vector3 direction) { }

	public override void Rotate() { }

	private void SetAnimationTime(float normalizedTime) { }

	public override void SetPosition(object position) { }

	public override void SuppressEdgePan() { }

}

