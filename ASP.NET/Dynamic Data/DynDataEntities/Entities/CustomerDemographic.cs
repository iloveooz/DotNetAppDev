//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynDataEntities.Entities
{
   using System.Collections.Generic;

   public partial class CustomerDemographic
   {
      public CustomerDemographic()
      {
         this.Customers = new HashSet<Customer>();
      }

      public string CustomerTypeID { get; set; }
      public string CustomerDesc { get; set; }

      public virtual ICollection<Customer> Customers { get; set; }
   }
}
