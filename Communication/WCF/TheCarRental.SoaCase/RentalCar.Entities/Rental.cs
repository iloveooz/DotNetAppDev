//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalCar.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string CarId { get; set; }
        public Nullable<int> PickUpLocation { get; set; }
        public Nullable<int> DropOffLocation { get; set; }
        public Nullable<System.DateTime> PickUpDateTime { get; set; }
        public Nullable<System.DateTime> DropOffDateTime { get; set; }
        public string PaymentStatus { get; set; }
        public string Comments { get; set; }
    }
}