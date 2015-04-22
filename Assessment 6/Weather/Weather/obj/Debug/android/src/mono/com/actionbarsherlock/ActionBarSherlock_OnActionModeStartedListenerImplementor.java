package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnActionModeStartedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnActionModeStartedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionModeStarted:(Lcom/actionbarsherlock/view/ActionMode;)V:GetOnActionModeStarted_Lcom_actionbarsherlock_view_ActionMode_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnActionModeStartedListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnActionModeStartedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnActionModeStartedListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnActionModeStartedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnActionModeStartedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnActionModeStartedListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onActionModeStarted (com.actionbarsherlock.view.ActionMode p0)
	{
		n_onActionModeStarted (p0);
	}

	private native void n_onActionModeStarted (com.actionbarsherlock.view.ActionMode p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
