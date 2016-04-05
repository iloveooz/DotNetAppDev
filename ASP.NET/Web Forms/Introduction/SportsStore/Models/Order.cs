﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
   /// <summary>
   /// Класс модели данных для хранения информации о заказе
   /// </summary>
   public class Order
   {
      public int OrderId { get; set; }

      [Required(ErrorMessage = "Please enter your name")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Please enter the first address line")]
      public string Line1 { get; set; }

      public string Line2 { get; set; }

      public string Line3 { get; set; }

      [Required(ErrorMessage = "Please enter a city name")]
      public string City { get; set; }

      [Required(ErrorMessage = "Please enter a state")]
      public string State { get; set; }

      public bool GiftWrap { get; set; }

      public bool Dispatched { get; set; }

      public virtual List<OrderLine> OrderLines { get; set; }
   }
}