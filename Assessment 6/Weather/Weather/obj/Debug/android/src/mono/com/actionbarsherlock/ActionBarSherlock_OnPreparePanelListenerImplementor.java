package mono.com.actionbarsherlock;


public class ActionBarSherlock_OnPreparePanelListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.ActionBarSherlock.OnPreparePanelListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreparePanel:(ILandroid/view/View;Lcom/actionbarsherlock/view/Menu;)Z:GetOnPreparePanel_ILandroid_view_View_Lcom_actionbarsherlock_view_Menu_Handler:Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPreparePanelListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPreparePanelListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBarSherlock_OnPreparePanelListenerImplementor.class, __md_methods);
	}


	public ActionBarSherlock_OnPreparePanelListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBarSherlock_OnPreparePanelListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.ActionBarSherlock/IOnPreparePanelListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onPreparePanel (int p0, android.view.View p1, com.actionbarsherlock.view.Menu p2)
	{
		return n_onPreparePanel (p0, p1, p2);
	}

	private native boolean n_onPreparePanel (int p0, android.view.View p1, com.actionbarsherlock.view.Menu p2);

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
