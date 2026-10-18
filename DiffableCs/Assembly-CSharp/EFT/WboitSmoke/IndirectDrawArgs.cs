namespace EFT.WboitSmoke;

internal sealed class IndirectDrawArgs
{
	private readonly uint[] _drawArgs; //Field offset: 0x10

	public IndirectDrawArgs() { }

	public void ResetDrawArgs(ComputeBuffer drawArgsBuffer) { }

	public void SetDrawArgs(ComputeBuffer prepassArgsBuffer, int value) { }

}

