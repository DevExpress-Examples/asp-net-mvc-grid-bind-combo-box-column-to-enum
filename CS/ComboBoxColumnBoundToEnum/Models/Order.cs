using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComboBoxColumnBoundToEnum.Models
{
    public class Order
    {
        public int ID { set; get; }
        public OrderHelper.OrderStatus Status { set; get; }
    }

    public class OrderHelper
    {
        public enum OrderStatus
        {
            Unprocessed = 1,
            Started,
            Sent,
            Finished
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            for (int i = 1; i <= Enum.GetNames(typeof(OrderStatus)).Length; i++)
            {
                orders.Add(new Order { ID = i, Status = (OrderStatus)i });
            }

            return orders;
        }
    }
}