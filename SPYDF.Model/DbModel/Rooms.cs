//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPYDF.Model.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms
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
