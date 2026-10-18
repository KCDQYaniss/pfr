namespace ChartAndGraph;

public abstract class AbstractChartData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string group; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <RemoveSliderForGroup>b__0(Slider x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string category; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <RemoveSliderForCategory>b__0(Slider x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string category; //Field offset: 0x10
		public string group; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal bool <RemoveSlider>b__0(Slider x) { }

	}

	internal class Slider
	{
		public string category; //Field offset: 0x10
		public string group; //Field offset: 0x18
		public double from; //Field offset: 0x20
		public double to; //Field offset: 0x28
		public float startTime; //Field offset: 0x30
		public float totalTime; //Field offset: 0x34
		public float timeScale; //Field offset: 0x38
		public AnimationCurve curve; //Field offset: 0x40

		public Slider() { }

		public bool UpdateSlider(AbstractChartData data) { }

	}

	protected List mSliders; //Field offset: 0x10

	protected AbstractChartData() { }

	private bool DoSlider(Slider s) { }

	protected void RemoveSlider(string category, string group) { }

	protected void RemoveSliderForCategory(string category) { }

	protected void RemoveSliderForGroup(string group) { }

	protected abstract void SetValueInternal(string column, string row, double value) { }

	protected void UpdateSliders() { }

}

