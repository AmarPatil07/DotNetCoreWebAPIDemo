﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EHDEMO.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
