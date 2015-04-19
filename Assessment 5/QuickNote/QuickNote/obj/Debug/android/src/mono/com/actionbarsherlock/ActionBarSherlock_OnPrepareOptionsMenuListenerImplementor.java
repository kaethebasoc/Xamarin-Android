package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnPrepareOptionsMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPrepareOptionsMenu:(Lcom/actionbarsherlock/view/Menu;)Z:GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPrepareOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnPrepareOptionsMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPrepareOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onPrepareOptionsMenu (com.actionbarsherlock.view.Menu p0)
	{
		return n_onPrepareOptionsMenu (p0);
	}

	private native boolean n_onPrepareOptionsMenu (com.actionbarsherlock.view.Menu p0);

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
