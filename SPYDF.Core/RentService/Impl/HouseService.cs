using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.RentService.Impl
{
    public class HouseService : IHouseService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(HouseInput model)
        {
            int result = 0;
            return result;
        }
        public List<HouseView> GetAll()
        {
            var result = new List<HouseView>();
            return result;
        }
        public List<HouseView> GetByPageIndex()
        {
            var result = new List<HouseView>();
            return result;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="listModel"></param>
        /// <returns></returns>
        public List<HouseView> Find(List<HouseInput> listModel)
        {
            var result = new List<HouseView>();
            return result;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(HouseInput model)
        {
            int result = 0;
            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(HouseInput model)
        {
            int result = 0;
            return result;
        }
    }
}
