using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using WebEncuesta.Models;

namespace WebEncuesta
{
    public static class Helper
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }


        public static bool ExistUserInSession()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
        public static void DestroyUserSession()
        {
            FormsAuthentication.SignOut();
        }
        public static User GetUser()
        {
            if (HttpContext.Current.User != null && HttpContext.Current.User.Identity is FormsIdentity)
            {
                FormsAuthenticationTicket ticket = ((FormsIdentity)HttpContext.Current.User.Identity).Ticket;
                if (ticket != null)
                {
                    var serializer = new JavaScriptSerializer();
                    var userData = serializer.Deserialize<User>(ticket.UserData);
                    return userData;
                }
            }
            return null;
        }
        public static void AddUserToSession(User user)
        {
            bool persist = true;
            var cookie = FormsAuthentication.GetAuthCookie("usuario", persist);

            cookie.Name = FormsAuthentication.FormsCookieName;
            cookie.Expires = DateTime.Now.AddMonths(3);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var serializer = new JavaScriptSerializer();
            string userData = serializer.Serialize(user);

            var newTicket = new FormsAuthenticationTicket(ticket.Version, user.Username, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, userData);

            cookie.Value = FormsAuthentication.Encrypt(newTicket);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}