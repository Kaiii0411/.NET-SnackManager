using SnackManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackManager.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 95;
        public static int TableHeight = 95;

        private TableDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("SwitchTable @idTable1 , @idTable2", new object[] { id1, id2});
        }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetTableList");
            foreach (DataRow item  in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public List<Table> GetListTable()
        {
            List<Table> tablelist = new List<Table>();
            string query = "SELECT * FROM TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT dbo.TableFood ( name ) VALUES ( N'{0}' )", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditTable(string name, int id)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{0}' WHERE id = {1} ", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByBillID(id);
            BillDAO.Instance.DeleteBillByTableID(id);
            string query = string.Format("DELETE TableFood WHERE id = {0} " , id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
