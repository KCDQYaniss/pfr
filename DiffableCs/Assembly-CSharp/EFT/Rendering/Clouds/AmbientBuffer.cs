namespace EFT.Rendering.Clouds;

public class AmbientBuffer : IDisposable
{
	private readonly ComputeBuffer _buffer; //Field offset: 0x10
	private SphericalHarmonicsL2 _currentSH; //Field offset: 0x18

	public SphericalHarmonicsL2 CurrentSH
	{
		 get { } //Length: 70
	}

	public AmbientBuffer() { }

	public override void Dispose() { }

	public SphericalHarmonicsL2 get_CurrentSH() { }

	public static ComputeBuffer op_Implicit(AmbientBuffer ambientBuffer) { }

	public bool SetData(SphericalHarmonicsL2 sh) { }

}

