/*
What is managed vs unmanaged code? 
 
 Managed Code is the code that runs under the control or supervision of CLR. When we write C# code, it is "managed" 
because its entire lifecycle is managed by CLR. We as developer does not have to worry about manually allocating or freeing 
the memory.

Unmanaged Code runs directly on the OS without the supervision of CLR. Languages like C++ produce unmanaged code.
Here, the developer has to take care of memory allocation and deallocation. If we forget to free memory, it leads to memory leak


The .NET CLR allows both managed and unmanaged code to coexist. This is done via P/Invoke or COM Interop. 
These are very useful when accessing legacy native libraries or access low level OS APIs.
 */




/*

 Follow-Ups
----------------------------------------------------
1.  What is the unsafe keyword in C#?
=>
   The unsafe keyword in C# allows us to write the code that uses raw pointers like C/C++. 
It is not managed by CLR. It must be explicitly enabled in project settings.

unsafe void Example()
{
	int x = 10;
	int *p = &x;		// raw pointer - unmanaged style
	*p = 20;		// direct memory manipulation
}

--------------------------------------------------------------------------------------------

2. What is COM Interop in .NET?
=>
	COM(Component Object Model) Interop allows managed .NET code to use COM components written in C++/VB6.
	The CLR generates a Runtime Callable Wrapper around COM object so that we can use it as a regular .NET object.

// Using a COM component (e.g., Microsoft Excel via COM)
var excelApp = new Microsoft.Office.Interop.Excel.Application();
excelApp.Visible = true;

---------------------------------------------------------------------------------------------

3. what is P/Invoke in .NET?
=>
	Platform Invocation services (P/Invoke) allows managed .NET code to call functions in unmanaged native DLLs(like Windows APIs)
Achieved using DllImport attribute
Commonly used for:

Windows API calls
Low-level OS operations
Accessing legacy native libraries

CODE Example:

using System.Runtime.InteropServices;

class NativeDemo{
	// Calling a native Windows API function from CLR-managed code
	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
	static void Main()
    	{
        	MessageBox(IntPtr.Zero, "Hello from CLR via P/Invoke!", "Demo", 0);
    	}
}




*/