using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
  public abstract  class EntityBase<TKey>
    {
        public TKey Id { get; set; }
       // public TKey IlanId { get; set; }
    }
}
