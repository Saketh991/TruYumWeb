using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TruYumWeb.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public MenuItems MenuItem { get; set; }

        public int MenuItemId { get; set; }
    }
}