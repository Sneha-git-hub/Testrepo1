using System;

class SampleMSBuild
{
 static void Main()
 {
 #if DebugConfig
        Console.WriteLine("We are in the debug configuration");
 #endif
        Console.WriteLine("MSBuild is working fine");
 }
}
