package mono.android.support.v4.app;


public class Watson_OnPrepareOptionsMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.app.Watson.OnPrepareOptionsMenuListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPrepareOptionsMenu:(Lcom/actionbarsherlock/view/Menu;)V:GetOnPrepareOptionsMenu_Lcom_actionbarsherlock_view_Menu_Handler:Android.Support.V4.App.Watson/IOnPrepareOptionsMenuListenerInvoker, ActionBarSherlock\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V4.App.Watson/IOnPrepareOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Watson_OnPrepareOptionsMenuListenerImplementor.class, __md_methods);
	}


	public Watson_OnPrepareOptionsMenuListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Watson_OnPrepareOptionsMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V4.App.Watson/IOnPrepareOptionsMenuListenerImplementor, ActionBarSherlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPrepareOptionsMenu (com.actionbarsherlock.view.Menu p0)
	{
		n_onPrepareOptionsMenu (p0);
	}

	private native void n_onPrepareOptionsMenu (com.actionbarsherlock.view.Menu p0);

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
