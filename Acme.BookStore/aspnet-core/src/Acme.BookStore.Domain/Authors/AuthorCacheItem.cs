using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;

namespace Acme.BookStore.Authors
{
  [CacheName("Authors")]
    public class AuthorCacheItem
    {
        public string Name { get; set; }

    }
}
