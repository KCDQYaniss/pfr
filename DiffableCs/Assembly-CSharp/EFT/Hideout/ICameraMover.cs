namespace EFT.Hideout;

public interface ICameraMover : IDisposable
{

	public void Move(Vector3 direction) { }

	public void MoveAccordingMousePosition() { }

	public void Rotate() { }

	public void SetPosition(object position) { }

	public void SuppressEdgePan() { }

}

