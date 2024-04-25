﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Drink : DAL<DAL_Drink, Drink, int>
    {
        public override void Create(Drink newElement)
        {
            SqlCommand cmd = new SqlCommand("InsertDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = newElement.id;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newElement.name;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.NVarChar).Value = newElement.type;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Float).Value = newElement.price;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Delete(int deleteDrinkID)
        {
            SqlCommand cmd = new SqlCommand("DeleteDrink"); 
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = deleteDrinkID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("SelectAllDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }

        public override void Update(Drink updateElement, int oldDrinkID)
        {
            SqlCommand cmd = new SqlCommand("UpdateDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = updateElement.id;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateElement.name;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.NVarChar).Value = updateElement.type;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Float).Value = updateElement.price;
            cmd.Parameters.AddWithValue("@OldId", SqlDbType.Int).Value = oldDrinkID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
    }
}