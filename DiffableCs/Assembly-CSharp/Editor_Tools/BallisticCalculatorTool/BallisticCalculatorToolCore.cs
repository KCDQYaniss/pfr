namespace Editor_Tools.BallisticCalculatorTool;

public sealed class BallisticCalculatorToolCore
{
	internal struct AmmoData
	{
		public float StartVelocity; //Field offset: 0x0
		public float BulletMassGram; //Field offset: 0x4
		public float BulletDiameterMilimeters; //Field offset: 0x8
		public float BallisticCoefficientG1; //Field offset: 0xC

		public AmmoData(float startVelocity, float bulletMassGram, float bulletDiameterMilimeters, float ballisticCoefficientG1) { }

	}

	internal struct BallisticData
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Velocity; //Field offset: 0xC

		public BallisticData(Vector3 position, Vector3 velocity) { }

	}

	internal struct MeasurementData
	{
		public float Distance; //Field offset: 0x0
		public float Velocity; //Field offset: 0x4
		public float Drop; //Field offset: 0x8

		public MeasurementData(float distance, float velocity, float drop) { }

	}

	private static BallisticCalculatorToolCore instance; //Field offset: 0x0
	[CompilerGenerated]
	private List <currentBallisticData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List <currentMeasurementData>k__BackingField; //Field offset: 0x18

	public private List currentBallisticData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private List currentMeasurementData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private BallisticCalculatorToolCore() { }

	public void Calculate(int shootingHeight, int shootingRangeLimit, int measurementStep, AmmoData ammo) { }

	[CompilerGenerated]
	public List get_currentBallisticData() { }

	[CompilerGenerated]
	public List get_currentMeasurementData() { }

	private List GetBallisticData(int shootingHeight, int shootingRangeLimit, AmmoData ammo) { }

	public static BallisticCalculatorToolCore getInstance() { }

	[CompilerGenerated]
	private void set_currentBallisticData(List value) { }

	[CompilerGenerated]
	private void set_currentMeasurementData(List value) { }

	private List TakeMeasurement(List trajectory, int step, int height) { }

}

