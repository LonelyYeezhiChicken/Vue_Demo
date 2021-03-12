using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vue_demo.Models.bSql
{
    public class OrdersMain
    {
        public string orderNum { get; set; }
        public string Table { get; set; }
        public string MealNum { get; set; }
    }
    public class Order_bSQL
    {
        public List<OrdersMain> get_OrdersMain_list()
        {

            List<OrdersMain> _req = new List<OrdersMain>();
            _req.Add(new OrdersMain
            {
                orderNum = "DK01P01210311001",
                Table = "2",
                MealNum ="A01"
            });
            _req.Add(new OrdersMain
            {
                orderNum = "DK01P01210311002",
                Table = "2",
                MealNum = "A02"
            });

            return _req;
        }
    }
}