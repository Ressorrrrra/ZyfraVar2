using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2
{
    public class Session
    {

        [Key] public Guid Id { get; set; }
        public string Owner { get; set; }
        public bool IsActive { get; set; }


    }
}
