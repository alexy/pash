using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.DurableInstancing;
using System.Runtime.Serialization;
using System.Transactions;
using System.Windows.Markup;
using System.Xaml;
using System.Xml.Linq;
using System.Activities.Debugger;
using System.Activities.Expressions;
using System.Activities.Hosting;
using System.Activities.Statements;
using System.Activities.Tracking;
using System.Activities.Validation;

namespace System.Activities
{
	public sealed class ActivityFunc<TResult> : ActivityDelegate
	{
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T> Argument { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateInArgument<T12> Argument12 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateInArgument<T12> Argument12 { get; set; }
		public DelegateInArgument<T13> Argument13 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateInArgument<T12> Argument12 { get; set; }
		public DelegateInArgument<T13> Argument13 { get; set; }
		public DelegateInArgument<T14> Argument14 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateInArgument<T12> Argument12 { get; set; }
		public DelegateInArgument<T13> Argument13 { get; set; }
		public DelegateInArgument<T14> Argument14 { get; set; }
		public DelegateInArgument<T15> Argument15 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}

	public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : ActivityDelegate
	{
		public DelegateInArgument<T1> Argument1 { get; set; }
		public DelegateInArgument<T2> Argument2 { get; set; }
		public DelegateInArgument<T3> Argument3 { get; set; }
		public DelegateInArgument<T4> Argument4 { get; set; }
		public DelegateInArgument<T5> Argument5 { get; set; }
		public DelegateInArgument<T6> Argument6 { get; set; }
		public DelegateInArgument<T7> Argument7 { get; set; }
		public DelegateInArgument<T8> Argument8 { get; set; }
		public DelegateInArgument<T9> Argument9 { get; set; }
		public DelegateInArgument<T10> Argument10 { get; set; }
		public DelegateInArgument<T11> Argument11 { get; set; }
		public DelegateInArgument<T12> Argument12 { get; set; }
		public DelegateInArgument<T13> Argument13 { get; set; }
		public DelegateInArgument<T14> Argument14 { get; set; }
		public DelegateInArgument<T15> Argument15 { get; set; }
		public DelegateInArgument<T16> Argument16 { get; set; }
		public DelegateOutArgument<TResult> Result { get; set; }
	}
}
