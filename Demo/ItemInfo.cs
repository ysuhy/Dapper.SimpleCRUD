using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Demo
{
    [Table("zb_item")]
    public class ItemInfo
    {
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }
        public int Category { get; set; }
        public int Type { get; set; }

        public string Icon { get; set; }
        public int Order { get; set; }

        public string Description { get; set; }
        public int AddDate { get; set; }


    }
}
