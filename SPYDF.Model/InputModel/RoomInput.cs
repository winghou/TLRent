using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.InputModel
{
   public  class RoomInput
    {
        public int RoomID { get; set; }
        public int HouseId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int RoomType { get; set; }
        public int Acreage { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IsAir { get; set; }
        public Nullable<int> IsHeater { get; set; }
        public Nullable<int> IsBay { get; set; }
        public Nullable<int> IsBalcony { get; set; }
        public Nullable<int> LiveNum { get; set; }
    }
}
