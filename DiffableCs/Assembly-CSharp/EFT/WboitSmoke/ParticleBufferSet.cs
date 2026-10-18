namespace EFT.WboitSmoke;

internal sealed class ParticleBufferSet : IDisposable
{
	private readonly IndirectDrawArgs _drawArgs; //Field offset: 0x10
	private ComputeBuffer _allInstances; //Field offset: 0x18
	private ComputeBuffer _visibleInstances; //Field offset: 0x20
	private ComputeBuffer _argsBuffer; //Field offset: 0x28
	private ComputeBuffer _prepassArgsBuffer; //Field offset: 0x30
	private bool _isDisposed; //Field offset: 0x38

	public ComputeBuffer AllInstances
	{
		 get { } //Length: 5
	}

	public ComputeBuffer ArgsBuffer
	{
		 get { } //Length: 5
	}

	public bool IsReady
	{
		 get { } //Length: 39
	}

	public ComputeBuffer PrepassArgsBuffer
	{
		 get { } //Length: 76
	}

	public ComputeBuffer VisibleInstances
	{
		 get { } //Length: 5
	}

	public ParticleBufferSet(int capacity) { }

	private void Create(int capacity) { }

	public override void Dispose() { }

	public ComputeBuffer get_AllInstances() { }

	public ComputeBuffer get_ArgsBuffer() { }

	public bool get_IsReady() { }

	public ComputeBuffer get_PrepassArgsBuffer() { }

	public ComputeBuffer get_VisibleInstances() { }

	private void ReleaseBuffer(ref ComputeBuffer buffer) { }

	public void ResetVisibleInstances() { }

	public void SetParticleCount(int particleCount) { }

	public void UploadRange(List particles, int startIndex, int count) { }

}

