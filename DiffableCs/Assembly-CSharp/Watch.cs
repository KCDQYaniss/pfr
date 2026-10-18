//Type is in global namespace

public class Watch : MonoBehaviour
{
	[SerializeField]
	private Transform _hourHand; //Field offset: 0x20
	[SerializeField]
	private Transform _minuteHand; //Field offset: 0x28
	[SerializeField]
	private Transform _secondHand; //Field offset: 0x30
	[SerializeField]
	private AnimationCurve _curve; //Field offset: 0x38
	private float _acceleration; //Field offset: 0x40
	private DateTime _startingDateTime; //Field offset: 0x48
	private TimeSpan _timeDifference; //Field offset: 0x50

	private DateTime GetCurrentLocationTime
	{
		private get { } //Length: 239
	}

	public Watch() { }

	private DateTime get_GetCurrentLocationTime() { }

	public void Init(TimeSpan timeDifference) { }

	private void Update() { }

}

