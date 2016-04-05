﻿/**
 * Информация об операционной системе
 */

using System;

namespace OsVersions
{
   class Program
   {
      static void Main()
      {
         OperatingSystem operatingSystem = Environment.OSVersion;
         Console.WriteLine("Platform: {0}", operatingSystem.Platform);
         Console.WriteLine("Service Pack: {0}", operatingSystem.ServicePack);
         Console.WriteLine("Version: {0}", operatingSystem.Version);
         Console.WriteLine("Version String: {0}", operatingSystem.VersionString);
         Console.WriteLine("CLR Version: {0}", Environment.Version);
      }
   }
}
