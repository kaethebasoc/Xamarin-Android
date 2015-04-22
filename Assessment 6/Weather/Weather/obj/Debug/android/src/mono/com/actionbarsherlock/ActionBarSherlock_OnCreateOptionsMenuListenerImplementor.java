package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnCreateOptionsMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnCreateOptionsMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateOptionsMenu:(Lcom/actionbarsherlock/view/Menu;)Z:GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnCreateOptionsMenuListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnCreateOptionsMenuListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnCreateOptionsMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0);

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
