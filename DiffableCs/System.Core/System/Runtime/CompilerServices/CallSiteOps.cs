namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public static class CallSiteOps
{

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void AddRule(CallSite site, T rule) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T Bind(CallSiteBinder binder, CallSite site, object[] args) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static CallSite CreateMatchmaker(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetCachedRules(RuleCache cache) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static RuleCache GetRuleCache(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetRules(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void MoveRule(RuleCache cache, T rule, int i) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void UpdateRules(CallSite this, int matched) { }

}

