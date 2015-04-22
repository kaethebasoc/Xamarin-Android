package mono.android.support.v4.app;


public class Watson_OnCreateOptionsMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app.Watson.OnCreateOptionsMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateOptionsMenu:(Lcom/actionbarsherlock/view/Menu;Lcom/actionbarsherlock/view/MenuInflater;)V:GetOnCreateOptionsMenu_Lcom_actionbarsherlock_view_Menu_Lcom_actionbarsherlock_view_MenuInflater_Handler:Android.Support.V4.App.Watson/IOnCreateOptionsMenuListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App.Watson/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Watson_OnCreateOptionsMenuListenerImplementor.class, __md_methods);
	}


	public Watson_OnCreateOptionsMenuListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Watson_OnCreateOptionsMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App.Watson/IOnCreateOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0, com.actionbarsherlock.view.MenuInflater p1)
	{
		n_onCreateOptionsMenu (p0, p1);
	}

	private native void n_onCreateOptionsMenu (com.actionbarsherlock.view.Menu p0, com.actionbarsherlock.view.MenuInflater p1);

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
