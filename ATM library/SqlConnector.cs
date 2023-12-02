using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATM_library
{
    public static class SqlConnector
    {
        private static string connString = @"Data Source=Adi211013;Initial Catalog=ATM;Integrated Security=True";



        public static void Login(User u)
        {
            
            using (SqlConnection db = new SqlConnection(connString))
            {
                db.Open();
                var p = new DynamicParameters();

                p.Add("@Email", u.Email);
                p.Add("@Password", u.Password);

                
                var dr=db.ExecuteReader("dbo.UserLogin", p, commandType: System.Data.CommandType.StoredProcedure);

               while (dr.Read())
               {
                    u.id = dr.GetInt32(0);
                    u.FirstName = dr.GetString(1);
                    u.LastName = dr.GetString(2);
                    u.Balance = dr.GetDecimal(5);
                    
               }
                db.Close();
            }
        }
        public static void DepositMoney(User u,decimal b)
        {
            using (SqlConnection db=new SqlConnection(connString))
            {
                var after = u.Balance + b;
                db.Open();
                SqlCommand cmd = new SqlCommand("dbo.balanceOperiaton", db) { CommandType=CommandType.StoredProcedure};
                cmd.Parameters.AddWithValue("@Id",u.id);
                cmd.Parameters.AddWithValue("@Balance", after);
                cmd.ExecuteNonQuery();
                SaveToTransactionHistory(u, after,db);
                u.Balance = after;
                //u.Balance = p.Get<decimal>("@Result");
                db.Close();
            }
        }
        public static void WithdrawMoney(User u, decimal b)
        {
            using (SqlConnection db = new SqlConnection(connString))
            {
                var after = u.Balance - b;

                db.Open();
                SqlCommand cmd = new SqlCommand("dbo.balanceOperiaton", db) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Id", u.id);
                cmd.Parameters.AddWithValue("@Balance", after);
                cmd.ExecuteNonQuery();
                SaveToTransactionHistory(u, after, db);
                u.Balance = after;
                //u.Balance = p.Get<decimal>("@Result");
                db.Close();
            }
        }
        public static void SaveToTransactionHistory(User u,decimal after,SqlConnection db)
        {
             SqlCommand cmd = new SqlCommand("dbo.TransactionHistoryInsert", db) { CommandType=CommandType.StoredProcedure};
            cmd.Parameters.AddWithValue("@UserId", u.id);
            cmd.Parameters.AddWithValue("@BalanceBefore", u.Balance);
            cmd.Parameters.AddWithValue("@BalanceAfter", after);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public static void SignUp(User u)
        {
            using (SqlConnection db = new SqlConnection(connString))
            {
                db.Open();
                var p = new DynamicParameters();
                p.Add("@FirstName", u.FirstName);
                p.Add("@LastName", u.LastName);
                p.Add("@Email", u.Email);
                p.Add("@Password", u.Password);
                p.Add("@Balance", u.Balance);


                db.Execute("dbo.userInsertUser",p,commandType:System.Data.CommandType.StoredProcedure);
                db.Close();
            }
        }
        public static DataTable ShowHistory(User u) 
        {
            DataTable dt = new DataTable();
            using (SqlConnection db = new SqlConnection(connString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("dbo.getTransactionHistory", db) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@UserId", u.id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db.Close();
            }


            return dt;
        }

    }
}
