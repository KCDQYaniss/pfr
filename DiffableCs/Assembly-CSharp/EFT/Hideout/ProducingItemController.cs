namespace EFT.Hideout;

public sealed class ProducingItemController
{
	private sealed class ProducingProcess
	{
		[CompilerGenerated]
		private double <BaseProductionTime>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private double <Progress>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private double <EndTime>k__BackingField; //Field offset: 0x20
		private double _timeLeft; //Field offset: 0x28
		private bool _isInProgress; //Field offset: 0x30
		private double _speedCoefficient; //Field offset: 0x38

		public double BaseProductionTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public private double EndTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public bool IsInProgress
		{
			 get { } //Length: 5
			 set { } //Length: 127
		}

		public double Progress
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public double SpeedCoefficient
		{
			 get { } //Length: 6
			 set { } //Length: 130
		}

		public double TimeLeft
		{
			 get { } //Length: 179
		}

		public ProducingProcess(bool isInProgress, double baseProductionTime, double speedCoefficient) { }

		[CompilerGenerated]
		public double get_BaseProductionTime() { }

		[CompilerGenerated]
		public double get_EndTime() { }

		public bool get_IsInProgress() { }

		[CompilerGenerated]
		public double get_Progress() { }

		public double get_SpeedCoefficient() { }

		public double get_TimeLeft() { }

		[CompilerGenerated]
		public void set_BaseProductionTime(double value) { }

		[CompilerGenerated]
		private void set_EndTime(double value) { }

		public void set_IsInProgress(bool value) { }

		[CompilerGenerated]
		public void set_Progress(double value) { }

		public void set_SpeedCoefficient(double value) { }

		private void UpdateEndTime() { }

		public void UpdateProductionTimeAndProgressStatus() { }

	}

	private readonly ProducingProcess _producingProcess; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ErrorChecked>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <SchemeId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsCodeProducer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <AvailableForFinish>k__BackingField; //Field offset: 0x29

	public private bool AvailableForFinish
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool ErrorChecked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int EstimatedTimeInt
	{
		 get { } //Length: 20
	}

	public float EstimatedTimeLeft
	{
		 get { } //Length: 204
	}

	public private bool IsCodeProducer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public double Progress
	{
		 get { } //Length: 28
	}

	public string SchemeId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ProducingItemController(string schemeId, float baseProductionTime, float speedCoefficient) { }

	public static double CalculateProductionTime(double time, double reductionCoefficient = 1) { }

	[CompilerGenerated]
	public bool get_AvailableForFinish() { }

	[CompilerGenerated]
	public bool get_ErrorChecked() { }

	public int get_EstimatedTimeInt() { }

	public float get_EstimatedTimeLeft() { }

	[CompilerGenerated]
	public bool get_IsCodeProducer() { }

	public double get_Progress() { }

	[CompilerGenerated]
	public string get_SchemeId() { }

	public void Produce() { }

	public void ResetProgress() { }

	[CompilerGenerated]
	private void set_AvailableForFinish(bool value) { }

	[CompilerGenerated]
	public void set_ErrorChecked(bool value) { }

	[CompilerGenerated]
	private void set_IsCodeProducer(bool value) { }

	public void UpdateFromProductionData(ProductionData productionData) { }

	public void UpdateSpeedCoefficient(float speedCoefficient) { }

}

