namespace UnityEngine.Timeline;

public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
{
	internal enum BlendCurveMode
	{
		Auto = 0,
		Manual = 1,
	}

	internal enum ClipExtrapolation
	{
		None = 0,
		Hold = 1,
		Loop = 2,
		PingPong = 3,
		Continue = 4,
	}

	private static class TimelineClipUpgrade
	{

		public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) { }

	}

	private enum Versions
	{
		Initial = 0,
		ClipInFromGlobalToLocal = 1,
	}

	private const int k_LatestVersion = 1; //Field offset: 0x0
	public static readonly ClipCaps kDefaultClipCaps; //Field offset: 0x0
	public static readonly float kDefaultClipDurationInSeconds; //Field offset: 0x4
	public static readonly double kTimeScaleMin; //Field offset: 0x8
	public static readonly double kTimeScaleMax; //Field offset: 0x10
	internal static readonly string kDefaultCurvesName; //Field offset: 0x18
	internal static readonly double kMinDuration; //Field offset: 0x20
	internal static readonly double kMaxTimeValue; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x10
	[SerializeField]
	private double m_Start; //Field offset: 0x18
	[SerializeField]
	private double m_ClipIn; //Field offset: 0x20
	[SerializeField]
	private Object m_Asset; //Field offset: 0x28
	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	private double m_Duration; //Field offset: 0x30
	[SerializeField]
	private double m_TimeScale; //Field offset: 0x38
	[SerializeField]
	private TrackAsset m_ParentTrack; //Field offset: 0x40
	[SerializeField]
	private double m_EaseInDuration; //Field offset: 0x48
	[SerializeField]
	private double m_EaseOutDuration; //Field offset: 0x50
	[SerializeField]
	private double m_BlendInDuration; //Field offset: 0x58
	[SerializeField]
	private double m_BlendOutDuration; //Field offset: 0x60
	[SerializeField]
	private AnimationCurve m_MixInCurve; //Field offset: 0x68
	[SerializeField]
	private AnimationCurve m_MixOutCurve; //Field offset: 0x70
	[SerializeField]
	private BlendCurveMode m_BlendInCurveMode; //Field offset: 0x78
	[SerializeField]
	private BlendCurveMode m_BlendOutCurveMode; //Field offset: 0x7C
	[SerializeField]
	private List m_ExposedParameterNames; //Field offset: 0x80
	[SerializeField]
	private AnimationClip m_AnimationCurves; //Field offset: 0x88
	[SerializeField]
	private bool m_Recordable; //Field offset: 0x90
	[SerializeField]
	private ClipExtrapolation m_PostExtrapolationMode; //Field offset: 0x94
	[SerializeField]
	private ClipExtrapolation m_PreExtrapolationMode; //Field offset: 0x98
	[SerializeField]
	private double m_PostExtrapolationTime; //Field offset: 0xA0
	[SerializeField]
	private double m_PreExtrapolationTime; //Field offset: 0xA8
	[SerializeField]
	private string m_DisplayName; //Field offset: 0xB0

	public AnimationClip animationClip
	{
		 get { } //Length: 453
	}

	public override Object asset
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public BlendCurveMode blendInCurveMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public double blendInDuration
	{
		 get { } //Length: 40
		 set { } //Length: 145
	}

	public BlendCurveMode blendOutCurveMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public double blendOutDuration
	{
		 get { } //Length: 40
		 set { } //Length: 145
	}

	public double clipAssetDuration
	{
		 get { } //Length: 102
	}

	public ClipCaps clipCaps
	{
		 get { } //Length: 148
	}

	public double clipIn
	{
		 get { } //Length: 40
		 set { } //Length: 276
	}

	public internal override AnimationClip curves
	{
		 get { } //Length: 8
		internal set { } //Length: 82
	}

	public string displayName
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public override double duration
	{
		 get { } //Length: 6
		 set { } //Length: 225
	}

	public double easeInDuration
	{
		 get { } //Length: 246
		 set { } //Length: 317
	}

	public double easeOutDuration
	{
		 get { } //Length: 246
		 set { } //Length: 317
	}

	public double easeOutTime
	{
		 get { } //Length: 49
	}

	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", True)]
	public double eastOutTime
	{
		 get { } //Length: 49
	}

	public double end
	{
		 get { } //Length: 11
	}

	[Obsolete("exposedParameter is deprecated and will be removed in a future release", True)]
	public List exposedParameters
	{
		 get { } //Length: 207
	}

	public double extrapolatedDuration
	{
		 get { } //Length: 256
	}

	public double extrapolatedStart
	{
		 get { } //Length: 23
	}

	public bool hasBlendIn
	{
		 get { } //Length: 49
	}

	public bool hasBlendOut
	{
		 get { } //Length: 49
	}

	public override bool hasCurves
	{
		 get { } //Length: 304
	}

	public bool hasPostExtrapolation
	{
		 get { } //Length: 31
	}

	public bool hasPreExtrapolation
	{
		 get { } //Length: 31
	}

	public AnimationCurve mixInCurve
	{
		 get { } //Length: 267
		 set { } //Length: 82
	}

	public double mixInDuration
	{
		 get { } //Length: 287
	}

	public float mixInPercentage
	{
		 get { } //Length: 31
	}

	public AnimationCurve mixOutCurve
	{
		 get { } //Length: 267
		 set { } //Length: 82
	}

	public double mixOutDuration
	{
		 get { } //Length: 92
	}

	public float mixOutPercentage
	{
		 get { } //Length: 96
	}

	public double mixOutTime
	{
		 get { } //Length: 111
	}

	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", False)]
	public TrackAsset parentTrack
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public internal ClipExtrapolation postExtrapolationMode
	{
		 get { } //Length: 40
		internal set { } //Length: 59
	}

	public internal ClipExtrapolation preExtrapolationMode
	{
		 get { } //Length: 40
		internal set { } //Length: 59
	}

	public internal bool recordable
	{
		 get { } //Length: 8
		internal set { } //Length: 7
	}

	public double start
	{
		 get { } //Length: 6
		 set { } //Length: 404
	}

	public double timeScale
	{
		 get { } //Length: 270
		 set { } //Length: 276
	}

	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", True)]
	public Object underlyingAsset
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	private override Object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		private get { } //Length: 5
	}

	private override string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		private get { } //Length: 84
	}

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		private get { } //Length: 5
	}

	private static TimelineClip() { }

	internal TimelineClip(TrackAsset parent) { }

	private static double CalculateEasingRatio(double easeIn, double easeOut) { }

	public void ConformEaseValues() { }

	public override void CreateCurves(string curvesClipName) { }

	public float EvaluateMixIn(double time) { }

	public float EvaluateMixOut(double time) { }

	internal double FromLocalTimeUnbound(double time) { }

	public AnimationClip get_animationClip() { }

	public override Object get_asset() { }

	public BlendCurveMode get_blendInCurveMode() { }

	public double get_blendInDuration() { }

	public BlendCurveMode get_blendOutCurveMode() { }

	public double get_blendOutDuration() { }

	public double get_clipAssetDuration() { }

	public ClipCaps get_clipCaps() { }

	public double get_clipIn() { }

	public override AnimationClip get_curves() { }

	public string get_displayName() { }

	public override double get_duration() { }

	public double get_easeInDuration() { }

	public double get_easeOutDuration() { }

	public double get_easeOutTime() { }

	public double get_eastOutTime() { }

	public double get_end() { }

	public List get_exposedParameters() { }

	public double get_extrapolatedDuration() { }

	public double get_extrapolatedStart() { }

	public bool get_hasBlendIn() { }

	public bool get_hasBlendOut() { }

	public override bool get_hasCurves() { }

	public bool get_hasPostExtrapolation() { }

	public bool get_hasPreExtrapolation() { }

	public AnimationCurve get_mixInCurve() { }

	public double get_mixInDuration() { }

	public float get_mixInPercentage() { }

	public AnimationCurve get_mixOutCurve() { }

	public double get_mixOutDuration() { }

	public float get_mixOutPercentage() { }

	public double get_mixOutTime() { }

	public TrackAsset get_parentTrack() { }

	public ClipExtrapolation get_postExtrapolationMode() { }

	public ClipExtrapolation get_preExtrapolationMode() { }

	public bool get_recordable() { }

	public double get_start() { }

	public double get_timeScale() { }

	public Object get_underlyingAsset() { }

	private static AnimationCurve GetDefaultMixInCurve() { }

	private static AnimationCurve GetDefaultMixOutCurve() { }

	private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration) { }

	public TrackAsset GetParentTrack() { }

	internal int Hash() { }

	public bool IsExtrapolatedTime(double sequenceTime) { }

	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	private static double SanitizeTimeValue(double value, double defaultValue) { }

	public void set_asset(Object value) { }

	public void set_blendInCurveMode(BlendCurveMode value) { }

	public void set_blendInDuration(double value) { }

	public void set_blendOutCurveMode(BlendCurveMode value) { }

	public void set_blendOutDuration(double value) { }

	public void set_clipIn(double value) { }

	internal void set_curves(AnimationClip value) { }

	public void set_displayName(string value) { }

	public void set_duration(double value) { }

	public void set_easeInDuration(double value) { }

	public void set_easeOutDuration(double value) { }

	public void set_mixInCurve(AnimationCurve value) { }

	public void set_mixOutCurve(AnimationCurve value) { }

	public void set_parentTrack(TrackAsset value) { }

	internal void set_postExtrapolationMode(ClipExtrapolation value) { }

	internal void set_preExtrapolationMode(ClipExtrapolation value) { }

	internal void set_recordable(bool value) { }

	public void set_start(double value) { }

	public void set_timeScale(double value) { }

	public void set_underlyingAsset(Object value) { }

	internal void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	internal void SetPostExtrapolationTime(double time) { }

	internal void SetPreExtrapolationTime(double time) { }

	public double ToLocalTime(double time) { }

	public double ToLocalTimeUnbound(double time) { }

	public virtual string ToString() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private override Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	private override string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	private void UpdateDirty(double oldValue, double newValue) { }

	private void UpgradeToLatestVersion() { }

}

