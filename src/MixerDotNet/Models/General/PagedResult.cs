using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixerDotNet.Models.General
{
    public class PagedResult<TEntity>
    {
        public IReadOnlyCollection<TEntity> Items { get; set; }

        public bool HasNextPage { get; set; }
        public bool HasPrevPage { get; set; }

        public PagedResult<TEntity> GetNextPage() => throw new NotImplementedException();
        public PagedResult<TEntity> GetPrevPage() => throw new NotImplementedException();
    }
}
