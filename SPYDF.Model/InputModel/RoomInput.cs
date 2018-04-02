using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Model.InputModel
{
    public class RoomInput
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

    public class PageFind<T>
    {
        /// <summary>
        /// 大小
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 条件
        /// </summary>
        public T parm { get; set; }
    }

}
