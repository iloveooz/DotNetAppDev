﻿using System;
using System.Runtime.InteropServices;

namespace DotnetServer
{
   [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
   [ComVisible(true)]
   public interface IMathEvents
   {
      [DispId(46200)]
      void CalculationCompleted();
   }

   [InterfaceType(ComInterfaceType.InterfaceIsDual)]
   [ComVisible(true)]
   public interface IWelcome
   {
      [DispId(60040)]
      string Greeting(string name);
   }

   [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
   [ComVisible(true)]
   public interface IMath
   {
      int Add(int val1, int val2);
      int Sub(int val1, int val2);
   }

   [ClassInterface(ClassInterfaceType.None)]
   [ProgId("Wrox.DotnetComponent")]
   [Guid("77839717-40DD-4876-8297-35B98A8402C7")]
   [ComSourceInterfaces(typeof(IMathEvents))]
   [ComVisible(true)]
   public class DotnetComponent : IWelcome, IMath
   {
      public int Add(int val1, int val2)
      {
         var result = val1 + val2;
         if (CalculationCompleted != null)
            CalculationCompleted();
         return result;
      }

      public int Sub(int val1, int val2)
      {
         var result = val1 - val2;
         if (CalculationCompleted != null)
            CalculationCompleted();
         return result;
      }

      public string Greeting(string name)
      {
         return string.Format("Hello {0}", name);
      }

      public event Action CalculationCompleted;
   }
}