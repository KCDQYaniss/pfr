namespace EFT.Impostors;

internal interface IImpostorsCameraContext : IDisposable
{

	public Camera Camera
	{
		 get { } //Length: 0
	}

	public Camera get_Camera() { }

	public void OnPreCull() { }

}

