﻿/**
 * Принципал учетной записи Windows и его заявки
 */

using System;
using System.Security.Claims;
using System.Security.Principal;

namespace WindowsPrincipal
{
   class Program
   {
      static void Main()
      {
         AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

         var principal = ClaimsPrincipal.Current as System.Security.Principal.WindowsPrincipal;
         if (principal != null)
         {
            // Параметры принципала
            var identity = principal.Identity as WindowsIdentity;
            Console.WriteLine("IdentityType: {0}", identity);
            if (identity != null)
            {
               Console.WriteLine("Name: {0}", identity.Name);
               Console.WriteLine("'Users?': {0}", principal.IsInRole(WindowsBuiltInRole.User));
               Console.WriteLine("'Administrators'? {0}", principal.IsInRole(WindowsBuiltInRole.Administrator));
               Console.WriteLine("Authenticated: {0}", identity.IsAuthenticated);
               Console.WriteLine("AuthType: {0}", identity.AuthenticationType);
               Console.WriteLine("Anonymous? {0}", identity.IsAnonymous);
               Console.WriteLine("Token: {0}", identity.Token);

               // Заявки
               Console.WriteLine();
               Console.WriteLine("Claims");
               foreach (var claim in principal.Claims)
               {
                  Console.WriteLine("Subject: {0}", claim.Subject);
                  Console.WriteLine("Issuer: {0}", claim.Issuer);
                  Console.WriteLine("Type: {0}", claim.Type);
                  Console.WriteLine("Value Type: {0}", claim.ValueType);
                  Console.WriteLine("Value: {0}", claim.Value);
                  foreach (var claimProp in claim.Properties)
                  {
                     Console.WriteLine("\tProperty: {0} {1}", claimProp.Key, claimProp.Value);
                  }
                  Console.WriteLine();
               }
            }
         }
      }
   }
}
