using SPYDF.Model.InputModel;
using SPYDF.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Core.RentService
{
    interface IHouseService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(HouseInput model);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        List<HouseView> GetAll();
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <returns></returns>
        List<HouseView> GetByPageIndex();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="listModel"></param>
        /// <returns></returns>
        List<HouseView> Find(List<HouseInput> listModel);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Update(HouseInput model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Delete(HouseInput model);

       

    }
}
