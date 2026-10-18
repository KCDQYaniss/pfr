namespace EFT.Hideout;

public class FreeSpaceCameraMover : ICameraMover, IDisposable
{
	private readonly FreeSpaceCameraMoveSettings _moveSettings; //Field offset: 0x10
	private Transform _cameraParent; //Field offset: 0x18
	private bool _edgePanSuppressed; //Field offset: 0x20

	public FreeSpaceCameraMover(FreeSpaceCameraMoveSettings moveSettings, Transform cameraParent, Transform virtualCamera) { }

	private Vector3 ClampTargetPosition(Vector3 newPosition) { }

	public override void Dispose() { }

	private float GetMoveSpeedAccordingMousePosition(float position) { }

	public override void Move(Vector3 direction) { }

	private void Move(Vector3 direction, float speed) { }

	public override void MoveAccordingMousePosition() { }

	private bool PointerInsideEdge(float mouseX, float mouseY, float widthMax, float heightMax) { }

	public override void Rotate() { }

	public override void SetPosition(object position) { }

	public override void SuppressEdgePan() { }

}

