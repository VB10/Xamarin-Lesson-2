package mono.com.airbnb.lottie;


public class PerformanceTracker_FrameListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.airbnb.lottie.PerformanceTracker.FrameListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFrameRendered:(F)V:GetOnFrameRendered_FHandler:Com.Airbnb.Lottie.PerformanceTracker/IFrameListenerInvoker, Lottie\n" +
			"";
		mono.android.Runtime.register ("Com.Airbnb.Lottie.PerformanceTracker+IFrameListenerImplementor, Lottie, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null", PerformanceTracker_FrameListenerImplementor.class, __md_methods);
	}


	public PerformanceTracker_FrameListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PerformanceTracker_FrameListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Airbnb.Lottie.PerformanceTracker+IFrameListenerImplementor, Lottie, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFrameRendered (float p0)
	{
		n_onFrameRendered (p0);
	}

	private native void n_onFrameRendered (float p0);

	private java.util.ArrayList refList;
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
