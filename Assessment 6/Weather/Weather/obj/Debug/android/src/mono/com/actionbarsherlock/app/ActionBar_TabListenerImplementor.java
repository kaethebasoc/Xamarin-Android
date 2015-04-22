package mono.com.actionbarsherlock.app;


public class ActionBar_TabListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.actionbarsherlock.app.ActionBar.TabListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTabReselected:(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V:GetOnTabReselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:Xamarin.ActionbarSherlockBinding.App.ActionBar/ITabListenerInvoker, ActionBarSherlock\n" +
			"n_onTabSelected:(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V:GetOnTabSelected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:Xamarin.ActionbarSherlockBinding.App.ActionBar/ITabListenerInvoker, ActionBarSherlock\n" +
			"n_onTabUnselected:(Lcom/actionbarsherlock/app/ActionBar$Tab;Landroid/support/v4/app/FragmentTransaction;)V:GetOnTabUnselected_Lcom_actionbarsherlock_app_ActionBar_Tab_Landroid_support_v4_app_FragmentTransaction_Handler:Xamarin.ActionbarSherlockBinding.App.ActionBar/ITabListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Xamarin.ActionbarSherlockBinding.App.ActionBar/ITabListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActionBar_TabListenerImplementor.class, __md_methods);
	}


	public ActionBar_TabListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActionBar_TabListenerImplementor.class)
			mono.android.TypeManager.Activate ("Xamarin.ActionbarSherlockBinding.App.ActionBar/ITabListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTabReselected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1)
	{
		n_onTabReselected (p0, p1);
	}

	private native void n_onTabReselected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1);


	public void onTabSelected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1)
	{
		n_onTabSelected (p0, p1);
	}

	private native void n_onTabSelected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1);


	public void onTabUnselected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1)
	{
		n_onTabUnselected (p0, p1);
	}

	private native void n_onTabUnselected (com.actionbarsherlock.app.ActionBar.Tab p0, android.support.v4.app.FragmentTransaction p1);

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
