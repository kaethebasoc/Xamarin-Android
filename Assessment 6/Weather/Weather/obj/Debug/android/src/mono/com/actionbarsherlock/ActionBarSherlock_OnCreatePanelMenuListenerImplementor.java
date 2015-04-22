package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnCreatePanelMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnCreatePanelMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreatePanelMenu:(ILcom/actionbarsherlock/view/Menu;)Z:GetOnCreatePanelMenu_ILcom_actionbarsherlock_view_Menu_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreatePanelMenuListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreatePanelMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnCreatePanelMenuListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnCreatePanelMenuListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnCreatePanelMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnCreatePanelMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onCreatePanelMenu (int p0, com.actionbarsherlock.view.Menu p1)
	{
		return n_onCreatePanelMenu (p0, p1);
	}

	private native boolean n_onCreatePanelMenu (int p0, com.actionbarsherlock.view.Menu p1);

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
