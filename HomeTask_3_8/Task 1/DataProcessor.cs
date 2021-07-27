using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask_3_8
{
    public class DataProcessor
    {
        public static List<User> ParseUsers(string input)
        {
            var list = ParseFile(input);

            var users = new List<User>();

            for (int i = 0; i < list.Count; i++)
            {
                var user = list[i].Split(";");

                users.Add(new User());
                users[i].Id = Convert.ToInt32(user[0]);
                users[i].Name = user[1];
                users[i].Gender = user[2];
                users[i].Age = Convert.ToInt32(user[3]);
            }

            return users;
        }

        public static List<Order> ParseOrders(string input)
        {
            var list = ParseFile(input);

            var orders = new List<Order>();

            for (int i = 0; i < list.Count; i++)
            {
                var user = list[i].Split(";");

                orders.Add(new Order());
                orders[i].Id = Convert.ToInt32(user[0]);
                orders[i].UserId = Convert.ToInt32(user[1]);
                orders[i].OrderNumber = Convert.ToInt32(user[2]);
                orders[i].OrderDate = user[3];
                orders[i].Total = Convert.ToInt32(user[4]);
            }

            return orders;
        }

        public static List<string> ParseFile(string input)
        {
            var tmp = input.Split('\n');
            var list = new List<string>();

            for (int i = 1; i < tmp.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    list.Add(tmp[i]);
                }
            }

            return list;
        }

        public static void MatchUsersAndOrders(List<Order> orders, List<User> users)
        {
            var res = from user in users
                      from order in orders
                      where user.Id == order.Id
                      where user.Age > 18 && user.Age < 65
                      where CheckDate(order)
                      select new { ONum = order.OrderNumber, ODate = order.OrderDate, UName = user.Name, Total = order.Total };

            foreach (var a in res)
            {
                FileProcessor.Write($"order_number {a.ONum} order_date {a.ODate} user_name {a.UName} total {a.Total}\n", "result.txt", true);
            }
        }

        public static bool CheckDate(Order order)
        {
            var date = order.OrderDate;

            if (date.Substring(0, 4).Equals("2021") && date.Substring(5, 2).Equals("07") && Convert.ToInt32(date.Substring(8)) >= 19)
            {
                return true;
            }

            return false;
        }
    }
}