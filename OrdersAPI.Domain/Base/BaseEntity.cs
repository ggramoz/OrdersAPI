﻿using System.Collections.Generic;

namespace Domain.Base
{
    public abstract class BaseEntity
    {
        
    }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        public TKey Id { get; set; }
    }
}