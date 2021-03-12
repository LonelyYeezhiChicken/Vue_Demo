using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Vue_demo.Models.bSql;

namespace Vue_demo.Models.bll
{
    public class Order_bll
    {
        public string get_OrderData()
        {
            string _req = "";
            try
            {
                List<OrdersMain> _listData = new List<OrdersMain>();
                Order_bSQL _os = new Order_bSQL();
                _listData = _os.get_OrdersMain_list();
                if (_listData != null)
                {
                    _req = JsonConvert.SerializeObject(_listData);
                }
            }
            catch (Exception ex)
            {
                Debug.Write("get_OrderData error = " + ex.Message);
            }

            return _req;
        }
    }
}