namespace EFT.Tools.AnimatorTools;

public static class AnimatorRebindUtility
{
	private struct AnimatorParamData
	{
		private enum EValueType
		{
			None = -1,
			Bool = 0,
			Int = 1,
			Float = 2,
			Trigger = 3,
			EValueTypeValuesCount = 4,
		}

		private sealed class SetterDelegate : MulticastDelegate
		{

			public SetterDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(Animator animator, AnimatorParamData paramData, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(Animator animator, AnimatorParamData paramData) { }

		}

		private static readonly SetterDelegate[] _SETTER_DELEGATES; //Field offset: 0x0
		private readonly int _hash; //Field offset: 0x0
		private readonly bool _bool; //Field offset: 0x4
		private readonly int _int; //Field offset: 0x8
		private readonly float _float; //Field offset: 0xC
		private readonly EValueType _valueType; //Field offset: 0x10

		private static AnimatorParamData() { }

		public AnimatorParamData(Animator animator, AnimatorControllerParameter parameter) { }

		private static void SetBool(Animator animator, AnimatorParamData paramData) { }

		private static void SetFloat(Animator animator, AnimatorParamData paramData) { }

		private static void SetInt(Animator animator, AnimatorParamData paramData) { }

		public void SetParam(Animator animator) { }

		private static void SetTrigger(Animator animator, AnimatorParamData paramData) { }

	}

	private static readonly List AnimatorStateInfos; //Field offset: 0x0
	private static readonly List AnimatorParamDatas; //Field offset: 0x8

	private static AnimatorRebindUtility() { }

	public static void RebindAnimatorWithStateRcovering(Animator animator) { }

}

