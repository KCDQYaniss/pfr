namespace EFT.Weather;

internal sealed class WindCalculator : IDisposable
{
	private static readonly int _windCalculatedId; //Field offset: 0x0
	private static readonly int _windBuffersLength; //Field offset: 0x4
	private static readonly int _windParamsBufferId; //Field offset: 0x8
	private static readonly int _windBufferId; //Field offset: 0xC
	private static readonly int _windRWBufferId; //Field offset: 0x10
	private static readonly int _windRestBufferId; //Field offset: 0x14
	private static readonly int _windRestRWBufferId; //Field offset: 0x18
	private static readonly int _windMagnitudeId; //Field offset: 0x1C
	private static readonly int _impostorsWindId; //Field offset: 0x20
	private static readonly int _windTimeScaledVectorId; //Field offset: 0x24
	private static readonly int _prevWindTimeScaledVectorId; //Field offset: 0x28
	private CommandBuffer _commandBuffer; //Field offset: 0x10
	private ComputeBuffer _windParamsBuffer; //Field offset: 0x18
	private ComputeBuffer _windBuffer; //Field offset: 0x20
	private ComputeBuffer _windRWBuffer; //Field offset: 0x28
	private ComputeBuffer _windRestBuffer; //Field offset: 0x30
	private ComputeBuffer _windRestRWBuffer; //Field offset: 0x38
	private bool _isAdded; //Field offset: 0x40
	private Camera _camera; //Field offset: 0x48
	private float _impostorsWind; //Field offset: 0x50
	private float _windIdleSway; //Field offset: 0x54
	private float _windMagnitude; //Field offset: 0x58
	private Vector4 _windFactor; //Field offset: 0x5C
	private Vector4 _windTimeScaledVector; //Field offset: 0x6C
	private Vector4 _prevWindTimeScaledVector; //Field offset: 0x7C

	private static CameraEvent CalculationEvent
	{
		private get { } //Length: 6
	}

	private static WindCalculator() { }

	public WindCalculator() { }

	private void AddToCamera() { }

	internal static WindCalculator Create(ComputeShader windShader, WindParamsSet[] windParams, float windIdleSway = 0.3) { }

	public override void Dispose() { }

	private static CameraEvent get_CalculationEvent() { }

	private void Init(ComputeShader windShader, WindParamsSet[] paramsSet) { }

	private void OnCameraChanged() { }

	private void OnPreCull(Camera cam) { }

	private void RemoveFromCamera() { }

	private void SetupCalculation() { }

	private void SetupFoliage() { }

	private void SetupImpostors() { }

	internal void SetWind(Vector2 wind) { }

}

